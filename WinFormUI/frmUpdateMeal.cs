using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Entities.Dtos.MealDetails;
using Entities.VMs.MealDetailVMs;
using Entities.VMs.ProductTypeVMs;

namespace WinFormUI
{
    public partial class frmUpdateMeal : Form
    {
        IMealDetailService _mealDetailService;
        IProductService _productService;
        IProductTypeService _productTypeService;
        MealDetailVm _mealDetail;
        public frmUpdateMeal(MealDetailVm mealDetail)
        {
            InitializeComponent();

            this._mealDetail = mealDetail;

            _mealDetailService = InstanceFactory.GetInstance<IMealDetailService>();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _productTypeService = InstanceFactory.GetInstance<IProductTypeService>();

            FillCategoryComboBox();
            FillProductComboBox();

            FillFoodDatas(_mealDetail);
        }

        private void FillProductComboBox(ProductTypeVm category = null)
        {
            if (category == null)
            {
                cmbProduct.DataSource = _productService.GetAll();
            }
            else
            {
                cmbProduct.DataSource = _productService.GetAllByExpression(x => x.ProductType.ProductTypeName == category.ProductTypeName);
            }
        }

        private void FillCategoryComboBox()
        {
            cmbCategory.DataSource = _productTypeService.GetAll();
        }

        private void FillFoodDatas(MealDetailVm mealDetail)
        {
            cmbCategory.SelectedIndex = cmbCategory.FindStringExact(mealDetail.ProductType);
            cmbProduct.SelectedIndex = cmbProduct.FindStringExact(mealDetail.Product);
            nmdGram.Value = (decimal)mealDetail.Gram;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MealDetailUpdateDto updatedMealDetail = new()
                {
                    Id = _mealDetail.Id,
                    MealType = cmbCategory.SelectedValue.ToString(),
                    ProductName = cmbProduct.SelectedValue.ToString(),
                    Gram = (double)nmdGram.Value

                };
                _mealDetailService.Update(updatedMealDetail);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FillFoodDatas(_mealDetail);
        }

        private void cmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            ProductTypeVm category = (ProductTypeVm)cmbCategory.SelectedItem;
            FillProductComboBox(category);
        }


    }
}
