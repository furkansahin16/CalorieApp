using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Business.HelperClasses;
using Entities.VMs.MealDetailVMs;
using Entities.VMs.MealVMs;

namespace WinFormUI
{
    public partial class frmReport : Form
    {
        IMealService _mealService;
        IMealDetailService _mealDetailService;
        List<MealVm> dailyMeals;
        DateTime date;
        public frmReport()
        {
            InitializeComponent();
            _mealService = InstanceFactory.GetInstance<IMealService>();
            _mealDetailService = InstanceFactory.GetInstance<IMealDetailService>();
            date = dtpDay.Value;
            GetMeals();
        }

        private void GetMeals()
        {
            dailyMeals = _mealService.GetAllByExpression(x =>
                x.CreatedDate.Value.Day == date.Day
                && x.CreatedDate.Value.Month == date.Month
                && x.CreatedDate.Value.Year == date.Year
                && x.UserName == CurrentUser.UserName);
            lstMealType.DataSource = dailyMeals;
            lblCalorieValue.Text = CalculateTotalCalorieForMeals(dailyMeals).ToString();
            if (lblCalorieValue.Text == "0") lblMealCalorieValue.Text = "0"; 
            if (dailyMeals.Count == 0) dgvMealView.Rows.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMealView.SelectedRows.Count == 0)
            {
                throw new Exception("Düzenlemek istediğiniz yemeği seçiniz");
            }
            try
            {
                int id = Convert.ToInt32(dgvMealView.SelectedRows[0].Cells[5].Value);
                MealDetailVm mealDetail = _mealDetailService.GetById(id);
                frmUpdateMeal _frm = new(mealDetail);
                _frm.ShowDialog();
                GetMeals();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            try
            {
                date = dtpDay.Value;
                GetMeals();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstMealType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MealVm meal = (MealVm)lstMealType.SelectedItem;
            FillDataGridView(meal);
            lblMealCalorieValue.Text = CalculateTotalCalorieForMeal(meal).ToString();
        }

        private void FillDataGridView(MealVm meal)
        {
            dgvMealView.Rows.Clear();
            if(meal!=null)
            {
                List<MealDetailVm> mealDetails = meal.MealDetailVm;
                foreach (var food in mealDetails)
                {
                    dgvMealView.Rows.Add(food.ProductType, food.Product, food.Image, food.Gram, food.Gram * food.UnitCalorie, food.Id);
                }
            }
        }

        private double CalculateTotalCalorieForMeals(List<MealVm> meals)
        {
            double? totalCal = 0;
            foreach (var meal in meals)
            {
                foreach (var food in meal.MealDetailVm)
                {
                    totalCal += food.UnitCalorie * food.Gram;
                }
            }
            return totalCal == null ? 0 : Math.Round(totalCal.Value);
        }

        private double CalculateTotalCalorieForMeal(MealVm meal)
        {
            double? totalCal = 0;
            foreach (var product in meal.MealDetailVm)
            {
                totalCal += product.Gram * product.UnitCalorie;
            }
            return totalCal == null ? 0 : Math.Round(totalCal.Value);
        }

        private void btnDeleteMeal_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstMealType.SelectedItem == null) throw new Exception("Silmek istediğiniz öğünü seçiniz");
                MealVm deletedMeal = lstMealType.SelectedItem as MealVm;
                if (deletedMeal.MealDetailVm.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Öğün içerisindeki tüm yemekler silinecektir. Onaylıyor musunuz","Silme Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dr== DialogResult.No) return;
                }
                _mealService.Delete(deletedMeal.Id);
                int index = lstMealType.SelectedIndex;
                GetMeals();
                if (lstMealType.Items.Count +1 < index)
                {
                    lstMealType.SelectedIndex = index;
                }
                MealVm meal = (MealVm)lstMealType.SelectedItem;
                FillDataGridView(meal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = dgvMealView.SelectedRows.Count;
                if (temp == 0) throw new Exception("Lütfen silmek istediğiniz yemeği seçiniz");
                int id = Convert.ToInt32(dgvMealView.SelectedRows[0].Cells[5].Value);
                _mealDetailService.Delete(id);
                int index = lstMealType.SelectedIndex;
                GetMeals();
                lstMealType.SelectedIndex = index;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMealView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Rectangle rectPos1 = e.CellBounds;
                e.Graphics.FillRectangle(Brushes.White, rectPos1);
                Graphics graphics = e.Graphics; // this.dataGridView1.CreateGraphics();
                Point[] points =
                {
                new Point(rectPos1.Left , rectPos1.Bottom - 1),
                new Point(rectPos1.Right - 1, rectPos1.Bottom - 1),
                new Point(rectPos1.Right - 1, rectPos1.Top)
            };
                graphics.DrawLines(Pens.Gray, points);
                e.PaintContent(rectPos1);
                e.Handled = true;
            }
        }
    }
}
