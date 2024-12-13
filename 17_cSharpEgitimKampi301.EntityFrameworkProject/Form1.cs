using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpEgitimKampi301.EntityFrameworkProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        EgitimKampiEntityFrameworkTravelDbEntities db = new EgitimKampiEntityFrameworkTravelDbEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            EgitimKampiEntityFrameworkTravelDbEntities db = new EgitimKampiEntityFrameworkTravelDbEntities();
            var values=db.Guide.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();  
            guide.GuideName=txtName.Text;
            guide.GuiderSurname = txtSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges(); //Değişiklikleri veri tabanına kaydeder.
            MessageBox.Show("Rehber başarıyla eklendi.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtID.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuiderSurname= txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla güncellendi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtID.Text);
            var values = db.Guide.Where(x =>x.GuideId==id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
