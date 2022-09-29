using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Enums.CustomerStatusEnum;
using MyCustomers;

namespace MyManagementApp.ChildForms
{
    public partial class CustomersForm : Form
    {

        #region config
        private readonly  string _server = @"ANNA-BEATRIZ\SQLEXPRESS";
        #endregion

        #region presentation
        private bool _edinting;
        private bool _newItem;
        private bool _loading;
        private bool _filling;
        private Guid _currentId;


        public CustomersForm()
        {
            InitializeComponent();


            this.cbxCustomerStatus.DataSource = Enum.GetValues(typeof(CustomerStatusEnum));
            this.Shown += CustomersForm_Shown;
            this.btnCustomerSave.Click += btnCustomerSave_Click;
            this.btnAdd.Click += btnCustomerAdd_Click;
            this.btnDelete.Click += btnCustomerDelete_Click;
            this.btnCancel.Click += BtnCancel_Click;

            this.CustomerGridNew.RowColChange += CustomerGridNew_RowColChange;

            // tbxcustomerID
            // tbxcustomerName
            // cbxCustomerStatus

            tbxcustomerID.TextChanged += TbxcustomerID_TextChanged;
            tbxcustomerName.TextChanged += TbxcustomerName_TextChanged;
            cbxCustomerStatus.TextChanged += CbxCustomerStatus_TextChanged;

        }


        // tools
        private void CustomersForm_Shown(object sender, EventArgs e)
        {
            LoadData();
            EnabledDisabledBtn();
        }
        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
         
            tbxcustomerID.Clear();
            tbxcustomerName.Clear();
            cbxCustomerStatus.SelectedItem = CustomerStatusEnum.Active;
            tbxcustomerID.Focus();

            // form status
            _edinting = true;
            _newItem = true;
            EnabledDisabledBtn();
        }
        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            if (tbxcustomerID.Text.Length > 0 && tbxcustomerName.Text.Length >0 && cbxCustomerStatus.SelectedItem != null)
            {
                if (_newItem)
                {
                    NewCustomer(tbxcustomerID.Text, tbxcustomerName.Text, (CustomerStatusEnum)Enum.Parse(typeof(CustomerStatusEnum),
                        cbxCustomerStatus.SelectedItem.ToString()));
                }
                else
                {
                    var id = _currentId;

                    UpdateCustomer(tbxcustomerID.Text, tbxcustomerName.Text, (CustomerStatusEnum)Enum.Parse(typeof(CustomerStatusEnum),
                     cbxCustomerStatus.SelectedItem.ToString()), id);
                }
            
            }
            else
            {
                string message = "Some information probably is missing. Verify and try again";
                string caption = "Warning";
                DialogResult result;
                result = MessageBox.Show(message, caption);
            }
     
            LoadData();

            // form status
            _newItem = false;
            _edinting = false;
            EnabledDisabledBtn();
        }
        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            var id = _currentId;
            DeleteCustomer(id);
          
            LoadData();

            // form status
            _newItem = false;
            _edinting = false;
            EnabledDisabledBtn();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            LoadData();

            // form status
            _newItem = false;
            _edinting = false;
            EnabledDisabledBtn();
        }
        private void EnabledDisabledBtn()
        {
            if(_edinting)
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Enabled = false;
            }
        }


        // grid
        private void CustomerGridNew_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            var currentRow = CustomerGridNew.Row;
            if (e.LastRow == currentRow)
                return;
            var table = (DataTable)CustomerGridNew.DataSource;
            var row = table.Rows[currentRow];
            FillFields(row);
        }
        private void ConfigureGrid()
        {
            // colunas
            //foreach (C1.Win.C1TrueDBGrid.C1DataColumn item in CustomerGridNew.Columns)
            //{
            //    if (item.DataField == "Id")
            //    {
            //        item.Caption = "";
            //        item.vi
            //    }
            //}

            // zebrado
            CustomerGridNew.AlternatingRows = true;
            CustomerGridNew.OddRowStyle.BackColor = Color.WhiteSmoke;
            CustomerGridNew.EvenRowStyle.BackColor = Color.White;

            foreach (C1.Win.C1TrueDBGrid.C1DisplayColumn item in CustomerGridNew.Splits[0].DisplayColumns)
            {

                // bloquear todos
                item.Locked = true;

                if (item.DataColumn.DataField.ToLower() == "id".ToLower())
                {
                    item.Visible = false;
                }
                if (item.DataColumn.DataField.ToLower() == "code".ToLower())
                {
                    item.DataColumn.Caption = "Code";
                }
                if (item.DataColumn.DataField.ToLower() == "name".ToLower())
                {
                    item.DataColumn.Caption = "Name";
                    item.Width = 300;
                }
                if (item.DataColumn.DataField.ToLower() == "active".ToLower())
                {
                    item.DataColumn.Caption = "Active";
                }

            }
        }


        // fill control
        private void FillFields(DataRow row)
        {
            _filling = true;

            _currentId = row.Field<Guid>("id");

            var customerCode = row.Field<string>("code");
            var customerName = row.Field<string>("name");
            var active = row.Field<bool>("active");


            tbxcustomerID.Text = customerCode;
            tbxcustomerName.Text = customerName;
            cbxCustomerStatus.SelectedItem = active ? CustomerStatusEnum.Active : CustomerStatusEnum.Inactive;


            _filling = false;
        }


        // load
        private void LoadData()
        {
            _loading = true;

            // CustomerGridNew.SetDataBinding(_customersList, null, false);
            _customersTable = LoadFromDatabase();
            CustomerGridNew.SetDataBinding(_customersTable, null, false);
            ConfigureGrid();

            _loading = false;
        }


        // control events
        private void CbxCustomerStatus_TextChanged(object sender, EventArgs e)
        {
            if (_filling)
                return;

            _edinting = true;
            EnabledDisabledBtn();
        }

        private void TbxcustomerName_TextChanged(object sender, EventArgs e)
        {
            if (_filling)
                return;

            _edinting = true;
            EnabledDisabledBtn();
        }

        private void TbxcustomerID_TextChanged(object sender, EventArgs e)
        {
            if (_filling)
                return;

            _edinting = true;
            EnabledDisabledBtn();
        }

        #endregion

        #region application layer (BLL)
        private DataTable _customersTable;
        private List<Customer> _customersList = new List<Customer>();


        private void NewCustomer(string customerCode, string customerName, CustomerStatusEnum customerStatus)
        {

            var customer = new Customer()
            {
                Id = Guid.NewGuid(),
                CustomerCode = customerCode,
                CustomerName = customerName,
                Active = customerStatus == CustomerStatusEnum.Active

            };
            //_customersList.Add(customer);

            InsertDatabase(customer);
        }

        private void UpdateCustomer(string customerCode, string customerName, CustomerStatusEnum customerStatus, Guid id)
        {
            //var customerCode = (_customersList.Count + 1).ToString();


            // ler
            var customer = GetCustomerById(id);

            if (customer == null)
                throw new Exception(" Customer not found");

            // alterar
            customer.CustomerCode = customerCode;
            customer.CustomerName = customerName;
            customer.Active = customerStatus == CustomerStatusEnum.Active;
           
            // persistir
            //_customersList.Add(customer);
            UpdateDatabase(customer);
        }

        private void DeleteCustomer(Guid id)
        {
            var customer = GetCustomerById(id);

            if (customer == null)
                throw new Exception("Customer not found");

            DeleteDatabase(customer);
        }
        #endregion

        #region data access layer (DAL)

        private Customer GetCustomerById(Guid id)
        {

            var dbConnection = GetConnection();
            dbConnection.Open();

            var sql = $@"
            SELECT * FROM Customers
	            WHERE id = @id;";
            var command = new System.Data.SqlClient.SqlCommand(sql, dbConnection);
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", id));


            var adpter = new System.Data.SqlClient.SqlDataAdapter(command);
            // dataTable
            var table = new DataTable();
            adpter.Fill(table);


            if(table.Rows.Count == 0)
                return default;

            // datarow
            var row = table.Rows[0];

         

            var customer = new Customer()
            {
                Id = row.Field<Guid>("id"),
                CustomerCode = row.Field<string>("code"),
                CustomerName = row.Field<string>("name"),
                Active = row.Field<bool>("active"),
            };


            if (dbConnection.State == ConnectionState.Open)
                dbConnection.Close();

            // liberação memória RAM da app..
            dbConnection.Dispose();
            dbConnection = null;

            return customer;

        }
        private bool InsertDatabase(Customer customer)
        {
            var dbConnection = GetConnection();
            dbConnection.Open();

            var sql = $@"
                INSERT INTO Customers (id, code, [name], active) Values (@id, @code, @name, @active);";
            var command = new System.Data.SqlClient.SqlCommand(sql, dbConnection);

            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", customer.Id));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@code", customer.CustomerCode));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", customer.CustomerName));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@active", customer.Active));

            // command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@createdDate", DateTime.Now));

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
        private bool UpdateDatabase(Customer customer)
        {
            var dbConnection = GetConnection();
            dbConnection.Open();

            var sql = $@"
                UPDATE 
                    Customers
                        SET code = @code, name = @name , active = @active
	            WHERE id = @id;";

            var command = new System.Data.SqlClient.SqlCommand(sql, dbConnection);
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", customer.Id));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@code", customer.CustomerCode));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", customer.CustomerName));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@active", customer.Active));
            // command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@createdDate", DateTime.Now));

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
        private bool DeleteDatabase(Customer customer)
        {
            var dbConnection = GetConnection();
            dbConnection.Open();

            var sql = $@"
                DELETE Customers 
	                WHERE id = @id;";

            var command = new System.Data.SqlClient.SqlCommand(sql, dbConnection);
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", customer.Id));
            // command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@code", customer.CustomerCode));
            // command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", customer.CustomerName));
            // command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@active", customer.Active));

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


            var sql = "SELECT * FROM Customers";
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

        private SqlConnection GetConnection()
        {
            var connectionString = $@"Server={_server};Database=MyManagementAppDb;User Id=sa;Password=dp";
            var dbConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            return dbConnection;
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
