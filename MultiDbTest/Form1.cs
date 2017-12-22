using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiDbTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSelectDb.Items.Add("Customer Database");
            cboSelectDb.Items.Add("Product Database");
        }

        // Displays data from selected database
        private void btnShowData_Click(object sender, EventArgs e)
        {
            if(cboSelectDb.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a database");
            }
            else if (cboSelectDb.SelectedIndex == 0)
            {
                lstData.Items.Clear();
                lstConString.Items.Clear();

                List<Customer> customersList = GetAllCustomers();

                foreach (Customer c in customersList)
                {
                    lstData.Items.Add(c.CustomerName + "\n");
                }

                // Gets connection string to display
                lstConString.Items.Add(GetConnectionStringByName("CustomerDb"));
            }
            else
            {
                lstData.Items.Clear();
                lstConString.Items.Clear();

                List<Product> productsList = GetAllProducts();

                foreach (Product p in productsList)
                {
                    lstData.Items.Add(p.ProductName + "\n");
                }

                // Gets connection string to display
                lstConString.Items.Add(GetConnectionStringByName("ProductDb"));
            }
        }

        // Returns all customers from the Customers DB
        private List<Customer> GetAllCustomers()
        {
            CustomerDb db = new CustomerDb();
            List<Customer> customerList = db.Customers.ToList();
            return customerList;

        }

        // Returns all customers from the Products DB
        private List<Product> GetAllProducts()
        {
            ProductDb db = new ProductDb();
            List<Product> productList = db.Products.ToList();
            return productList;

        }

        // Retrieves a connection string by name.
        // Returns null if the name is not found.
        private string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }
    }
}
