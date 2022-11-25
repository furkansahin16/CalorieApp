using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Entities.Dtos.Product;
using Entities.VMs.ProductVMs;
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
    public partial class frmAdminUpdateFood : Form
    {
        IProductService _productService;
        ProductVm _product;

        public frmAdminUpdateFood(ProductVm product)
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            this._product = product;
            InitializeProductData();
        }

        private void InitializeProductData()
        {
            txtCategory.Text = _product.ProductTypeName;
            txtProductName.Text = _product.ProductName;
            nmdUnitCalorie.Value = (decimal)_product.UnitCalorie;
            checkBox1.Checked = _product.isActive;
            pbProductImage.Image = ByteArrayToImage(_product.Image);
        }

        private Image ByteArrayToImage(byte[] byteArr)
        {
            using (MemoryStream ms = new MemoryStream(byteArr))
            {
                return Image.FromStream(ms);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductUpdateDTO productUpdateDTO = new()
            {
                Id = _product.Id,
                ProductName = _product.ProductName,
                ProductType = _product.ProductTypeName,
                Image = ImageToByteArray(pbProductImage.Image),
                UnitCalorie = (double)nmdUnitCalorie.Value,
                isActive = checkBox1.Checked,
            };
            _productService.Update(productUpdateDTO);
            this.Close();
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

            if (openFileDialog.ShowDialog() == DialogResult.OK)
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

       
    }
}
