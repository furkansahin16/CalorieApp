using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Entities.Dtos.ProductTypes;
using Entities.VMs.ProductTypeVMs;

namespace WinFormUI
{
    public partial class frmAdminCategory : Form
    {
        IProductTypeService _productTypeService;
        List<ProductTypeVm> _productTypeVm;
        public frmAdminCategory()
        {
            InitializeComponent();
            _productTypeService = InstanceFactory.GetInstance<IProductTypeService>();
        }

        private void frmAdminCategory_Load(object sender, EventArgs e)
        {
            FillListView();
        }

        private void FillListView()
        {
            _productTypeVm = _productTypeService.GetAll();
            lstCategory.DataSource = _productTypeVm;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Seçili yemek türünü silmek istediğinize emin misiniz?", "Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                {
                    ProductTypeVm productTypeVm = (ProductTypeVm)lstCategory.SelectedItem;
                    _productTypeService.Delete(productTypeVm.Id);
                    FillListView();
                }
            }
            catch(Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                MessageBox.Show("Bu kategoriye ait ürünler bulunmaktadır. Kategoriyi tamamen silmek raporlama ve kullanıcı tarafında problemler yaratabilir. Bu sebeple ürüne sahip kategorilerde silme işlemi yapılamamaktadır.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Seçili yemek türünü güncellemek istediğinize emin misiniz?", "Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                {
                    ProductTypeVm productTypeVm = (ProductTypeVm)lstCategory.SelectedItem;
                    ProductTypeUpdateDto productTypeUpdateDto = new ProductTypeUpdateDto()
                    {
                        Id = productTypeVm.Id,
                        ProductTypeName = txtMealName.Text
                    };
                    _productTypeService.Update(productTypeUpdateDto);
                    FillListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtMealName.Text == "")
                MessageBox.Show("Yemek türü eklemek için yemek türü alanı doldurulmalıdır");
            ProductTypeCreateDto productTypeCreateDto = new ProductTypeCreateDto()
            {
                ProductTypeName = txtMealName.Text
            };
            try
            {
                _productTypeService.Add(productTypeCreateDto);
                FillListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMealName.Text = ((ProductTypeVm)lstCategory.SelectedItem).ProductTypeName;
        }
    }
}
