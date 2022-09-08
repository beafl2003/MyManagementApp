using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Enums.CustomerStatusEnum;
using MyCustomers;

namespace MyManagementApp.ChildForms
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();

            cbxCustomerStatus.DataSource = Enum.GetValues(typeof(CustomerStatusEnum));

            btnCustomerSave.Click += btnCustomerSave_Click;

            CustomerGridNew.DataSource = _customersList;

        }

        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            SaveCustomer(tbxcustomerID.Text, tbxcustomerName.Text, (CustomerStatusEnum)Enum.Parse(typeof(CustomerStatusEnum),
                cbxCustomerStatus.SelectedItem.ToString()));

            CustomerGridNew.SetDataBinding(_customersList, null, false);
        }


        // application layer 

        private List<Customer> _customersList = new List<Customer>();
        private void SaveCustomer(string customerID, string customerName, CustomerStatusEnum customerStatus)
        {
            var CustomerID = _customersList.Count + 1;

            var customer = new Customer()
            {
                CustomerID = customerID,
                CustomerName = customerName,
                CustomerStatus = customerStatus

            };
            _customersList.Add(customer);
        }


    }

}
