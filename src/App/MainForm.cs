using MyManagementApp.ChildForms;
using MyManagementApp.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyManagmentApp
{
    public partial class MainForm : Form
    {

 

        public MainForm()
        {

            InitializeComponent();

            this.tsiProducts.Click += new System.EventHandler(this.tsiProducts_Click);
            this.tsiCustomers.Click += new System.EventHandler(this.tsiCustomers_Click);
            this.tsiOrders.Click += new System.EventHandler(this.tsiOrders_Click);
            this.tsiSearchCustomers.Click += new EventHandler(this.tsiSearchCustomers_Click);

            

            var listDeUsuarios = new List<User>
            {
                new User { Username = "beafl2003", Fullname="Anna Beatriz Azevedo Fidelis"},
                new User { Username = "fl0k3rdev", Fullname = "Gustavo Henrique Coleti Ranci"},
            };

          
    }




        private void tsiProducts_Click(object sender, EventArgs e)
        {
            // chamada de form filho
            var prodForm = new MyManagementApp.ChildForms.ProductsForm();
            prodForm.MdiParent = this;
            prodForm.StartPosition = FormStartPosition.CenterScreen;


            prodForm.Show();


        }

        private void tsiCustomers_Click(object sender, EventArgs e)
        {
            var customerForm = new MyManagementApp.ChildForms.CustomersForm();
            customerForm.MdiParent = this;
            customerForm.StartPosition = FormStartPosition.CenterScreen;

            customerForm.Show();
        }


        private void tsiOrders_Click(object sender, EventArgs e)
        {


            var ordersForm = new MyManagementApp.ChildForms.OrdersForm();
            ordersForm.MdiParent = this;
            ordersForm.StartPosition = FormStartPosition.CenterScreen;

            ordersForm.Show();



        }

        public void tsiSearchCustomers_Click(object sender, EventArgs e)
        {
            var customersSearch = new CustomerPick();
            customersSearch.MdiParent = this;
            customersSearch.StartPosition = FormStartPosition.CenterScreen;

            customersSearch.Show();

             
        }

        public void ClickOnTsiSearchCustomers()
        {
            {
                this.tsiSearchCustomers.Click += new EventHandler(this.tsiSearchCustomers_Click);
            }

        }

       
    }
}
