using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Entities.Dtos.Product;
using Entities.VMs.ProductVMs;
using System.Drawing.Imaging;

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
            pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private Image ByteArrayToImage(byte[] byteArr)
        {
            if (byteArr == null) return null;
            MemoryStream ms = new MemoryStream(byteArr, 0, byteArr.Length);
            ms.Write(byteArr, 0, byteArr.Length);
            Image img = Image.FromStream(ms, true);
            ms.Close();
            return img;
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

        private byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn != null)
            {
                using (var ms = new MemoryStream())
                {
                    Bitmap bmp = new(imageIn);
                    bmp.Save(ms, imageIn.RawFormat);
                    return ms.ToArray();
                }
            }
            return null;
        }


    }
}
