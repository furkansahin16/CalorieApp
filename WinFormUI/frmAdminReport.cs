using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolver.Autofac;
using Entities.Concrete;
using Entities.VMs;
using Entities.VMs.MealTypeVMs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class frmAdminReport : Form
    {
        IProductService _productService;
        IMealDetailService _mealDetailService;
        IMealService _mealService;
        IMealTypeService _mealTypeService;
        public frmAdminReport()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _mealDetailService = InstanceFactory.GetInstance<IMealDetailService>();
            _mealTypeService = InstanceFactory.GetInstance<IMealTypeService>();
            _mealService = InstanceFactory.GetInstance<IMealService>();
            FillMeals();
            FillListView(_mealDetailService.GetTopTenProduct(), lvTotal);
        }

        private void FillMeals()
        {
            cmbMealType.DataSource = _mealTypeService.GetAll();
        }

        private void cmbMealType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvTotalByMeal.Items.Clear();
            List<ReportVm> meals = _mealDetailService.GetTopTenProduct(x => x.Meal.MealType.TypeName == ((MealTypeVm)cmbMealType.SelectedItem).MealTypeName);
            FillListView(meals, lvTotalByMeal);
        }

        private void FillListView(List<ReportVm> meals,ListView listView)
        {
            listView.Items.Clear();
            foreach (var product in meals)
            {
                string[] newProduct = { product.Key, product.Toplam.ToString() };
                var row = new ListViewItem(newProduct);
                listView.Items.Add(row);
            }
        }
    }
}
