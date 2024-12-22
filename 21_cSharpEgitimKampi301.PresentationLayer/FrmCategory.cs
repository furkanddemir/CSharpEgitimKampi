using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cSharpEgitimKampi301.BusinessLayer.Abstract;
using cSharpEgitimKampi301.BusinessLayer.Concrete;
using cSharpEgitimKampi301.DataAccessLayer.EntitiyFramework;
using cSharpEgitimKampi301.EntitiyLayer.Concrete;

namespace cSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName=txtCategoryName.Text;
            category.CategoryStatus=true;
            _categoryService.TInsert(category);
            MessageBox.Show("Ekleme başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtCategoryId.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Silme başarılı");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtCategoryId.Text);
            var values=_categoryService.TGetById(id);
            dataGridView1 .DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category category=new Category();
            int updatedId=int.Parse(txtCategoryId.Text);
            var updatedValue=_categoryService.TGetById(updatedId);
            updatedValue.CategoryName=txtCategoryName.Text;
            updatedValue.CategoryStatus=true;
            _categoryService.TUpdate(updatedValue);
            MessageBox.Show("Güncelleme başarılı");
        }
    }
}
