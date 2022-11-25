using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Entities.VMs.ProductTypeVMs;
using Entities.VMs.ProductVMs;

namespace WinFormUI
{
    public partial class frmAdminFood : Form
    {
        IProductService _productService;
        IProductTypeService _productTypeService;
        List<ProductVm> _products;
        ProductVm _activeProduct;

        public frmAdminFood()
        {
            InitializeComponent();

            dgvMealView.AutoSize = true;

            _productService = InstanceFactory.GetInstance<IProductService>();
            _productTypeService = InstanceFactory.GetInstance<IProductTypeService>();

            FillCategoryList();
            FillProducts();
        }

        private void FillProducts(ProductTypeVm category = null)
        {
            dgvMealView.Rows.Clear();
            if (category == null)
                _products = _productService.GetAll();
            else
                _products = _productService.GetAllByExpression(x => x.ProductType.ProductTypeName == category.ProductTypeName);

            foreach (var product in _products)
            {
                dgvMealView.Rows.Add(product.isActive, product.ProductTypeName, product.ProductName, product.UnitCalorie, product.Image, product.Id);
            }
        }

        private void FillCategoryList()
        {
            cmbCategory.DataSource = _productTypeService.GetAll();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAdminAddFood frm = new();
            frm.ShowDialog();
            FillProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMealView.CurrentRow == null)
            {
                MessageBox.Show("Ürün seçiniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            frmAdminUpdateFood frm = new(_activeProduct);
            frm.ShowDialog();
            FillProducts();
        }

        private void tsmMealType_Click(object sender, EventArgs e)
        {
            frmAdminMealType frm = new();
            frm.ShowDialog();
        }

        private void tsmCategory_Click(object sender, EventArgs e)
        {
            frmAdminCategory frm = new();
            frm.ShowDialog();
            FillCategoryList();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ProductTypeVm category = (ProductTypeVm)cmbCategory.SelectedItem;
            FillProducts(category);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbCategory.SelectedItem = null;
            FillProducts();
        }

        private void dgvMealView_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMealView.SelectedRows == null)
            {
                return;
            }
            int index = Convert.ToInt32(dgvMealView.CurrentRow.Cells[5].Value);
            _activeProduct = _productService.GetById(index);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvMealView.CurrentRow == null) return;
            _productService.Delete(Convert.ToInt32(dgvMealView.CurrentRow.Cells[5].Value));
            FillProducts();
        }

        private void pnlData_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void dgvMealView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 4)
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
