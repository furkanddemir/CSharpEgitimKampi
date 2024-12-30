using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;

namespace CSharpEgitimKampi601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CustomerOperations customerOperations = new CustomerOperations();
        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerSurname = txtCustomerSurname.Text,
                CustomerBalance =decimal.Parse (txtCustomerBalance.Text),
                CustomerCity = txtCustomerCity.Text,
                CustomerShoppingCount =int.Parse (txtCustomerShoppingCount.Text),
            };

            customerOperations.AddCustomer(customer);
            MessageBox.Show("Müşteri ekleme işlemi başarılı!", "Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnCustomerList_Click(object sender, EventArgs e)
        {
            List<Customer> customers = customerOperations.GetAllCustomer();
            dataGridView1.DataSource = customers;
        }

        private void BtnCustomerDelete_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerId.Text;
            customerOperations.DeleteCustomer(customerId);
            MessageBox.Show("Müşteri Başarıyla silindi.");
        }

        private void BtnCustomerUpdate_Click(object sender, EventArgs e)
        {
            string id= txtCustomerId.Text;
            var updateCustomer = new Customer()
            {
                CustomerId = id,
                CustomerName = txtCustomerName.Text,
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomerCity = txtCustomerCity.Text,
                CustomerShoppingCount = int.Parse(txtCustomerShoppingCount.Text),
                CustomerSurname = txtCustomerSurname.Text,
            };
            customerOperations.UpdateCustomer(updateCustomer);
            MessageBox.Show("Müşteri Başarıyla güncellendi.");
        }

        private void BtnGetByCustomerId_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            Customer customers= customerOperations.GetCustomerById(id);
            dataGridView1.DataSource = new List<Customer> { customers };
        }
    }
}
