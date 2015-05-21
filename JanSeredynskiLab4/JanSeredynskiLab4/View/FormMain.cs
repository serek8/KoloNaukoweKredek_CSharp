using JanSeredynskiLab4.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanSeredynskiLab4
{
    public partial class FormMain : Form
    {
        Model.DataClasses1DataContext dataContext;
        //DataClassesNorthwind 
        public FormMain()
        {
            InitializeComponent();
            dataContext = new Model.DataClasses1DataContext();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            var query = Model.Customer.GetAll();
            dataGridViewContent.DataSource = query;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Customer client = (from customer 
                                in dataContext.Customers
                                select customer).First();

            client.City = "Wrocławw";
            dataContext.SubmitChanges();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(); // Tworzymy nowy wiersz=obiekt
            customer.CustomerID = textBoxCustomerID.Text;
            //customer.ContactName = "Janusz";
            //customer.ContactTitle = "komórka";
            //customer.Country = "Polska";
            customer.CompanyName = textBoxCustomerCompany.Text;

            dataContext.Customers.InsertOnSubmit(customer);

            dataContext.SubmitChanges(); // Zapisujemy zmiany
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var client = (from customer in dataContext.Customers
                          select customer).Where(x => x.CustomerID == textBoxCustomerID.Text).First(); ;
            dataContext.Customers.DeleteOnSubmit(client);

            dataContext.SubmitChanges(); // Zapisujemy zmiany UZYWAJ ZAWSZE !!
        }

        private void buttonShowOrders_Click(object sender, EventArgs e)
        {
            var query = (from customer in dataContext.Customers
                         join order in dataContext.Orders
                         on customer.CustomerID equals order.CustomerID
                         select new { Klient = customer.CustomerID, order.ShipName });
            dataContext.SubmitChanges(); // Zapisujemy zmiany UZYWAJ ZAWSZE !!
            dataGridViewContent.DataSource = query;
        }
    }
}
