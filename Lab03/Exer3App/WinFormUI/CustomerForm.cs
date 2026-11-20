using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WinFormUI
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            _customerService = new CustomerService();
        }

        private readonly CustomerService _customerService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            var customers = _customerService.GetAllCustomers();
            dataGridView1.DataSource = customers;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Name = txtName.Text,
                Email = txtEmail.Text
            };
            _customerService.AddCustomer(customer);
            MessageBox.Show("Customer added successfully!");
            LoadCustomers();
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCustomerId.Text, out int customerId))
            {
                MessageBox.Show("Customer ID must be a valid number!");
                return;
            }
            var customer = _customerService.GetCustomer(customerId);
            if (customer != null)
            {
                txtName.Text = customer.Name;
                txtEmail.Text = customer.Email;
            }
            else
            {
                MessageBox.Show("Customer not found!");
            }
        }
    }
}
