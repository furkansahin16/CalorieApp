using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Business.HelperClasses;
using Entities.VMs.MealDetailVMs;
using Entities.VMs.MealVMs;
using System.Diagnostics;

namespace WinFormUI
{
    public partial class frmMainPage : Form
    {
        IMealService _mealManager;

        public frmMainPage()
        {
            InitializeComponent();
            _mealManager = InstanceFactory.GetInstance<IMealService>();
            FillLastMeal();
            FillDailyReport();
        }

        private void FillDailyReport()
        {
            lblDailyReportDay.Text = "Tarih : " + DateTime.Now.ToString("D");

            List<MealVm> dailyMeals = _mealManager.GetAllByExpression(x => x.CreatedDate.Value.Day == DateTime.Now.Day
            && x.CreatedDate.Value.Month == DateTime.Now.Month
            && x.CreatedDate.Value.Year == DateTime.Now.Year
            && x.UserName == CurrentUser.UserName);

            lblDailyReportMealCount.Text = "Öğün Sayısı : " + dailyMeals.Count.ToString();

            lblDailyReportFoodCount.Text = "Yemek Sayısı : " + CountFoodFromMealList(dailyMeals).ToString();

            lblDailyReportTotalCalorie.Text = "Toplam Kalori : " + CalculateTotalCalorieForMeals(dailyMeals).ToString();

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
            return totalCal == null ? 0 : Math.Round(totalCal.Value, 2);
        }

        private int CountFoodFromMealList(List<MealVm> dailyMeals)
        {
            int count = 0;
            foreach (var meal in dailyMeals)
            {
                count += meal.MealDetailVm.Count;
            }
            return count;
        }

        private void FillLastMeal()
        {
            try
            {
                MealVm lastMeal = _mealManager.GetLastMealByUserName(CurrentUser.UserName);
                lblLastMealName.Text = "Öğün : " + lastMeal.MealType;
                lblLastMealDate.Text = "Tarih : " + lastMeal.Date.Value.ToString("D");
                FillListView(lastMeal.MealDetailVm);
            }
            catch (Exception ex)
            {

            }
        }

        private void FillListView(List<MealDetailVm> mealDetails)
        {
            foreach (var food in mealDetails)
            {
                string[] mealDetail = {
                    food.ProductType,
                    food.Product,
                    food.Gram.ToString(),
                    Math.Round((decimal)(food.Gram * food.UnitCalorie),2).ToString() };
                var newRow = new ListViewItem(mealDetail);
                lswLastFoods.Items.Add(newRow);
            }
        }
        private void llbWebPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OpenWebPage();
            }
            catch (Exception)
            {
                MessageBox.Show("Site bağlantı hatası.");
            }
        }
        private void OpenWebPage()
        {
            llbWebPage.LinkVisited = true;
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = @"http://localhost:3000", UseShellExecute = true });
        }
    }
}
