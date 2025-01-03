﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEgitimKampi601.Entities;
using MongoDB.Bson.Serialization.Serializers;
using Npgsql;

namespace CSharpEgitimKampi601
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        //PostgreSql veritabanı bağlantısı
        string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;Password=3438";
        
        void GetAllCustomers()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Customers";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        private void BtnCustomerList_Click(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            string customerName=txtCustomerName.Text;
            string customerSurname = txtCustomerSurname.Text;
            string customerCity = txtCustomerCity.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into Customers (CustomerName, CustomerSurname, CustomerCity) values (@customerName, @customerSurname, @customerCity)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerName", customerName);
            command.Parameters.AddWithValue("@customerSurname", customerSurname);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.ExecuteNonQuery();
            MessageBox.Show("Ekleme işlemi başarılı.");
            connection.Close();
            GetAllCustomers();
            
        }

        private void BtnCustomerDelete_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Delete From Customers where CustomerId=@customerId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerId", id);
            command.ExecuteNonQuery ();
            MessageBox.Show("Silme işlemi başarılı.");
            connection.Close();
            GetAllCustomers();
        }

        private void BtnCustomerUpdate_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerSurname = txtCustomerSurname.Text;
            string customerCity = txtCustomerCity.Text;
            int id = int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Update Customers Set CustomerName=@customerName, CustomerSurname=@customerSurname, CustomerCity=@customerCity Where CustomerId=@customerId";
            var command = new NpgsqlCommand (query, connection);
            command.Parameters.AddWithValue("customerName", customerName);
            command.Parameters.AddWithValue("CustomerSurname", customerSurname);
            command.Parameters.AddWithValue("CustomerCity", customerCity);
            command.Parameters.AddWithValue("CustomerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Güncelleme işlemi başarılı.");
            connection.Close();
            GetAllCustomers();

        }
    }
}