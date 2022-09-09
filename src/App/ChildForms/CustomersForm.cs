using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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

        #region presentation
        public CustomersForm()
        {
            InitializeComponent();


            this.cbxCustomerStatus.DataSource = Enum.GetValues(typeof(CustomerStatusEnum));
            this.Shown += CustomersForm_Shown;
            this.btnCustomerSave.Click += btnCustomerSave_Click;

        }

        private void CustomersForm_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCustomerSave_Click(object sender, EventArgs e)
        {

            SaveCustomer(tbxcustomerID.Text, tbxcustomerName.Text, (CustomerStatusEnum)Enum.Parse(typeof(CustomerStatusEnum),
                cbxCustomerStatus.SelectedItem.ToString()));

            // DataTable == List<Customer>
            LoadData();
        }

        private void LoadData()
        {
            // CustomerGridNew.SetDataBinding(_customersList, null, false);
            _customersTable = LoadFromDatabase();
            CustomerGridNew.SetDataBinding(_customersTable, null, false);
        }
        #endregion

        #region application layer
        private DataTable _customersTable;
        private List<Customer> _customersList = new List<Customer>();
        private void SaveCustomer(string customerCode, string customerName, CustomerStatusEnum customerStatus)
        {
            //var customerCode = (_customersList.Count + 1).ToString();
            var customer = new Customer()
            {
                CustomerCode = customerCode,
                CustomerName = customerName,
                CustomerStatus = customerStatus

            };
            //_customersList.Add(customer);




            InsertDatabase(customer);
        }
        #endregion

        #region data access layer

        private bool UpdateDatabase(Customer customer)
        {
            return true;
        }
        private bool DeleteDatabase(Customer customer)
        {
            return true;
        }
        private bool InsertDatabase(Customer customer)
        {
            var connectionString = @"Server=ANNA-BEATRIZ\SQLEXPRESS;Database=MyManagementAppDb;User Id=sa;Password=dp";
            var dbConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            dbConnection.Open();


            var sql = $"INSERT INTO Customers (id, code, [name], active) Values (NEWID(), '{customer.CustomerCode}', '{customer.CustomerName}', 1);";
            var command = new System.Data.SqlClient.SqlCommand(sql, dbConnection);

            var rowsAffected = command.ExecuteNonQuery();

            if (dbConnection.State == ConnectionState.Open)
                dbConnection.Close();


            // liberação memória RAM da app..
            dbConnection.Dispose();
            dbConnection = null;


            if (rowsAffected > 0)
                return true;
            else
                return false;
        }

        private DataTable LoadFromDatabase() 
        {
            var connectionString = @"Server=ANNA-BEATRIZ\SQLEXPRESS;Database=MyManagementAppDb;User Id=sa;Password=dp";
            //DbConnection dbConnection2 = new System.Data.Odbc.OdbcConnection();
            var dbConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            dbConnection.Open();



            var sql = "select id, code, name from Customers";
            var command = new System.Data.SqlClient.SqlCommand(sql, dbConnection);




            // adpater
            var adpter = new System.Data.SqlClient.SqlDataAdapter(command);
            // dataTable
            var table = new DataTable();
            adpter.Fill(table);


            //// dataSet
            //// conjunto de tabelas + seus relacionamentos + ...
            //var dataSet = new DataSet();
            //adpter.Fill(dataSet, "Products");
            //// adpterCustomers.Fill(dataSet, "Customers");



            //// 1 - reader
            //var dataReader = command.ExecuteReader();
            //while (dataReader.Read())
            //{
            //    var id = dataReader["id"];
            //    var code = dataReader.GetString(1);
            //    var description = dataReader["description"];
            //}



            if (dbConnection.State == ConnectionState.Open)
                dbConnection.Close();


            // liberação memória RAM da app..
            dbConnection.Dispose();
            dbConnection = null;


            return table;

        }


        // configuração
        // DB >> SQL server 

        // 
        // DSN >> config.ini
        // ConnectionString 

        // DbConnections("ConnectionString") >> 

        // leitura

        // (commands)DataReader, (commands)DataAdapter()

        // escrita
        // commands = "";
        #endregion
    }

}
