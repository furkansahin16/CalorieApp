using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Business.HelperClasses;
using Entities.Dtos.Meal;
using Entities.Dtos.MealDetails;
using Entities.VMs.MealTypeVMs;
using Entities.VMs.MealVMs;
using Entities.VMs.ProductTypeVMs;
using Entities.VMs.ProductVMs;

namespace WinFormUI
{
    public partial class frmAddMeal : Form
    {
        IMealService _mealService;
        IMealDetailService _mealDetailService;
        IProductService _productService;
        IProductTypeService _productTypeService;
        IMealTypeService _mealTypeService;
        public frmAddMeal()
        {
            InitializeComponent();
            _mealTypeService = InstanceFactory.GetInstance<IMealTypeService>();
            _mealService = InstanceFactory.GetInstance<IMealService>();
            _mealDetailService = InstanceFactory.GetInstance<IMealDetailService>();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _productTypeService = InstanceFactory.GetInstance<IProductTypeService>();

            lstMeal.SelectedValue = null;

            FillMealComboBox();
            FillCategoryComboBox();
            FillFoodComboBox((ProductTypeVm)cmbMealCategory.SelectedItem);

            FillListMeal();

        }

        private void FillFoodComboBox(ProductTypeVm category = null)
        {
            if (category == null)
            {
                cmbFood.DataSource = _productService.GetAll();
            }
            else
            {
                cmbFood.DataSource = _productService.GetAllByExpression(x => x.ProductType.ProductTypeName == category.ProductTypeName);
            }
        }

        private void FillCategoryComboBox()
        {
            cmbMealCategory.DataSource = _productTypeService.GetAll();
        }

        private void FillMealComboBox()
        {
            cmbMealType.DataSource = _mealTypeService.GetAll();
        }

        private void FillListMeal()
        {
            try
            {
                List<MealVm> meals = _mealService.GetAllByExpression(m =>
                m.CreatedDate.Value.Day == DateTime.Now.Day
                && m.CreatedDate.Value.Month == DateTime.Now.Month
                && m.CreatedDate.Value.Year == DateTime.Now.Year
                && m.User.UserName == CurrentUser.UserName);

                lstMeal.DataSource = meals;
            }
            catch (Exception ex)
            {

            }
        }

        private void lstMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            MealVm meal = (MealVm)lstMeal.SelectedItem;
            FillDataGridView(meal.Id);
        }

        private void FillDataGridView(int mealId)
        {
            MealVm meal = _mealService.Get(mealId);
            dgvDailyReport.Rows.Clear();
            foreach (var food in meal.MealDetailVm)
            {
                dgvDailyReport.Rows.Add(food.ProductType, food.Product, food.Image, food.Gram, food.Gram * food.UnitCalorie, food.Id);
            }
        }

        private void btnAddMealType_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in lstMeal.Items)
                {
                    string currentMealType = ((MealTypeVm)cmbMealType.SelectedItem).MealTypeName;
                    if (currentMealType != "AraÖğün" && ((MealVm)item).MealType == currentMealType) throw new Exception("Aynı öğün iki kere eklenemez");
                }
                MealCreateDTO newMeal = new()
                {
                    UserName = CurrentUser.UserName,
                    MealTypeName = cmbMealType.SelectedItem.ToString()
                };
                _mealService.Add(newMeal);
                FillListMeal();
                lstMeal.SelectedIndex = lstMeal.Items.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void cmbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductVm product = (ProductVm)cmbFood.SelectedItem;
            pbProduct.Image = ByteArrayToImage(product.Image);
            pbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private Image ByteArrayToImage(byte[] byteArr)
        {
            if (byteArr == null) return null;
            using (MemoryStream ms = new MemoryStream(byteArr))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMeal.SelectedItems == null)
            {
                MessageBox.Show("Lütfen ekleme yapmak istediğiniz öğünü seçiniz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if(cmbFood.Items.Count == 0)
            {
                MessageBox.Show("Lütfen ekleme yapmak istediğiniz yemeği seçiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                ProductVm product = _productService.GetAllByExpression(x => x.ProductName == cmbFood.SelectedItem.ToString()).First();

                MealVm meal = (MealVm)lstMeal.SelectedItem;

                if (meal == null) throw new Exception("Önce öğün ekleyiniz");

                MealDetailCreateDto newMealDetail = new()
                {
                    ProductId = product.Id,
                    MealID = meal.Id,
                    Gram = (double)nmdPortion.Value
                };

                _mealDetailService.Add(newMealDetail);
                meal = (MealVm)lstMeal.SelectedItem;

                FillDataGridView(meal.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDailyReport.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz yemeği seçiniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            try
            {
                _mealDetailService.Delete(Convert.ToInt32(dgvDailyReport.SelectedRows[0].Cells[5].Value));
                FillDataGridView(((MealVm)lstMeal.SelectedItem).Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDailyReport_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void nmdPortion_ValueChanged(object sender, EventArgs e)
        {
            decimal unitCalorie = 0;
            if (cmbFood.SelectedItem != null)
            {
                unitCalorie = (decimal)((ProductVm)cmbFood.SelectedItem).UnitCalorie;
            }
            lblCalorieCal.Text = Math.Round((nmdPortion.Value * unitCalorie), 2).ToString() + " Kalori";
        }

        private void cmbMealCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductTypeVm category = (ProductTypeVm)cmbMealCategory.SelectedItem;
            FillFoodComboBox(category);
        }

        private void dgvDailyReport_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
