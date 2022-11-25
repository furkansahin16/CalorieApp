using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Entities.Dtos.MealType;
using Entities.Dtos.ProductTypes;
using Entities.VMs.MealTypeVMs;
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
    public partial class frmAdminMealType : Form
    {
        IMealTypeService _mealTypeService;
        List<MealTypeVm> _mealTypeVms;
        public frmAdminMealType()
        {
            InitializeComponent();
            _mealTypeService = InstanceFactory.GetInstance<IMealTypeService>();
            _mealTypeVms= new List<MealTypeVm>();
        }

        private void frmAdminMealType_Load(object sender, EventArgs e)
        {
            FillListView();
        }

        private void FillListView()
        {
            _mealTypeVms = _mealTypeService.GetAll();
            lstMealType.DataSource = _mealTypeVms;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Seçili öğün türünü silmek istediğinize emin misiniz?", "Güncelleme", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)) == DialogResult.Yes)
                {
                    MealTypeVm productTypeVm = (MealTypeVm)lstMealType.SelectedItem;
                    _mealTypeService.Delete(productTypeVm.Id);
                    FillListView(); 
                }
            }
            catch(Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                MessageBox.Show("Bu öğün kullanıcı tarafında kullanılmıştır. Öğünün silinmesi raporlama işlemlerinde problem yaratabilir. Kullanılan ürünlerde silme işlemi yapılamaz.");
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
                if ((MessageBox.Show("Seçili öğün türünü güncellemek istediğinize emin misiniz?","Güncelleme",MessageBoxButtons.YesNo, MessageBoxIcon.Warning))==DialogResult.Yes)
                {
                    MealTypeVm productTypeVm = (MealTypeVm)lstMealType.SelectedItem;
                    MealTypeUpdateDto mealTypeUpdateDto = new MealTypeUpdateDto()
                    {
                        Id = productTypeVm.Id,
                        MealTypeName = txtMealName.Text
                    };
                    _mealTypeService.Update(mealTypeUpdateDto);
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
            if(txtMealName.Text=="")
                MessageBox.Show("Öğün türü eklemek için öğün adı alanı doldurulmalıdır");
            MealTypeCreateDto mealTypeCreateDto = new MealTypeCreateDto()
            {
                MealTypeName=txtMealName.Text,
            };

            try
            {
                _mealTypeService.Add(mealTypeCreateDto);
                FillListView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lstMealType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMealName.Text = ((MealTypeVm)lstMealType.SelectedItem).MealTypeName;
        }
    }
}
