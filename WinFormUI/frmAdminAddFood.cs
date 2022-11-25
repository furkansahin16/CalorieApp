using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Entities.Dtos.Product;
using Entities.VMs.ProductTypeVMs;
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
    public partial class frmAdminAddFood : Form
    {
        IProductTypeService _productTypeService;
        IProductService _productService;
        public frmAdminAddFood()
        {
            InitializeComponent();
            _productTypeService = InstanceFactory.GetInstance<IProductTypeService>();
            _productService = InstanceFactory.GetInstance<IProductService>();
            FillCategories();
        }

        private void FillCategories()
        {
            List<ProductTypeVm> categories = _productTypeService.GetAll();   
            cmbCategory.DataSource=categories;
            
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            Image image;
            OpenFileDialog openFileDialog = new()
            {
                InitialDirectory = "C://Destkop",
                Filter = "Image files (*.jpg, *.png) | *.jpg; *.png",
                Title = "Resim dosyası yükleyin"
            };

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                pbProductImage.Image = image;
                pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            if (imageIn != null)
            {
                using (var ms = new MemoryStream())
                {
                    imageIn.Save(ms, imageIn.RawFormat);
                    return ms.ToArray();
                }
            }
            return null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFoodName.Text.Trim() == "")  
            {
                MessageBox.Show("Yemek eklemek için yemek adı girişi zorunludur");
                return;
            }
            try
            {
                ProductCreateDTO newProduct = new()
                {
                    ProductName = txtFoodName.Text,
                    ProductType = ((ProductTypeVm)cmbCategory.SelectedItem).ProductTypeName,
                    UnitCalorie = (double)nmdUnitCalorie.Value,
                    Image = ImageToByteArray(pbProductImage.Image)
                };
                _productService.Add(newProduct);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}
