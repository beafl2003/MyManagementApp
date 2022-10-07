using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AppCore.Enums.ProductStatusEnum;
using System.Collections.Generic;
using MyProducts;
using System.Drawing;

namespace MyManagementApp.ChildForms

{
    public partial class ProductsForm : Form
    {

        #region config
        private readonly string _server = @"ANNA-BEATRIZ\SQLEXPRESS";
        #endregion

        #region Presentation
        private bool _editing;
        private bool _newItem;
        private bool _loading;
        private bool _filling;
        private Guid _currentId; 

        public ProductsForm()
        {
            InitializeComponent();

            this.cbxProdStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            this.Shown += ProductsForm_Shown;
            this.btnProdSave.Click += btnProdSave_Click;
            this.btnAdd.Click += btnProdAdd_Click;
            this.btnDelete.Click += btnProdDelete_Click;
            this.btnCancel.Click += BtnCancel_Click;

            this.ProductGridNew.RowColChange += ProductGridNew_RowColChange;

            tbxProductID.TextChanged += TbxProductID_TextChanged;
            tbxProdDescription.TextChanged += TbxProdDescription_TextChanged;
            cbxProdStatus.TextChanged += CbxProdStatus_TextChanged;
            tbxProdBrand.TextChanged += TbxProdBrand_TextChanged;
            txtProdPrice.TextChanged += TxtProdPrice_TextChanged;


        }

   


        // Tools 
        private void ProductsForm_Shown(object sender, EventArgs e)
        {
            LoadData();
            EnabledDisabledBtn();
        }


        private void btnProdAdd_Click(object sender, EventArgs e)
        { 
            _newItem = true;

            ClearActions();

            // form buttons status
            _editing = true;
            EnabledDisabledBtn();

        }
        private void btnProdSave_Click(object sender, EventArgs e)
        {

            // validations
            if (tbxProductID.Text.Length > 0 && tbxProdDescription.Text.Length > 0 && cbxProdStatus.SelectedItem != null && tbxProdBrand.Text.Length > 0 && txtProdPrice.Text.Length > 0)
            {
                if (_newItem)
                {
                    NewProduct(tbxProductID.Text, tbxProdDescription.Text, tbxProdBrand.Text, txtProdPrice.Text, (ProductStatusEnum)Enum.Parse(typeof(ProductStatusEnum),
                cbxProdStatus.SelectedItem.ToString()));
                }
                else
                {
                    var id = _currentId;
                    UpdateProduct(tbxProductID.Text, tbxProdDescription.Text, tbxProdBrand.Text, txtProdPrice.Text, (ProductStatusEnum)Enum.Parse(typeof(ProductStatusEnum),
                cbxProdStatus.SelectedItem.ToString()), id);
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

            // Form Status
            _newItem = false;
            _editing = false;
            EnabledDisabledBtn();
            


        }

        private void btnProdDelete_Click(object sender, EventArgs e)
        {
            var id = _currentId;
            DeleteProduct(id);

            LoadData();
            ClearActions();

            //Form Status

            _newItem = false;
            _editing = false;
            EnabledDisabledBtn();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            LoadData();

            // Form Status

            _newItem = false;
            _editing = false;
            EnabledDisabledBtn();
        }

        private void EnabledDisabledBtn()
        {
            if (_editing)
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

        private void ProductGridNew_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            var currentRow = ProductGridNew.Row;
            if (e.LastRow == currentRow)
                return;
            var table = (DataTable)ProductGridNew.DataSource;
            var row = table.Rows[currentRow];
            FillFields(row);
        }

        private void ConfigureGrid()
        {

            // Zebra Design
            ProductGridNew.AlternatingRows = true;
            ProductGridNew.OddRowStyle.BackColor = Color.WhiteSmoke;
            ProductGridNew.EvenRowStyle.BackColor = Color.White;

            foreach (C1.Win.C1TrueDBGrid.C1DisplayColumn item in ProductGridNew.Splits[0].DisplayColumns)
            {

                // Block itens editing
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
                    item.DataColumn.Caption = "Description";
                    item.Width = 300;
                }
                if (item.DataColumn.DataField.ToLower() == "brand".ToLower())
                {
                    item.DataColumn.Caption = "Brand";
                }
                if (item.DataColumn.DataField.ToLower() == "price".ToLower())
                {
                    item.DataColumn.Caption = "Price";
                }
                if (item.DataColumn.DataField.ToLower() == "active".ToLower())
                {
                    item.DataColumn.Caption = "Active";
                }

            }

        }

        private void ClearActions()
        {
            tbxProductID.Clear();
            tbxProdDescription.Clear();
            txtProdPrice.Clear();
            tbxProdBrand.Clear();
            cbxProdStatus.SelectedItem = ProductStatusEnum.Active;

            tbxProductID.Focus();
        }

        // fill control

        private void FillFields (DataRow row)
        {
            _filling = true;
            _currentId = row.Field<Guid>("id");

            var productCode = row.Field<string>("code");
            var productName = row.Field<string>("name");
            var brand = row.Field<string>("brand");
            var price = row.Field<string>("price");
            var active = row.Field<bool>("active");

            tbxProductID.Text = productCode;
            tbxProdDescription.Text = productName;
            tbxProdBrand.Text = brand;
            txtProdPrice.Text = price;
            cbxProdStatus.SelectedItem = active ? ProductStatusEnum.Active : ProductStatusEnum.Inactive;

            _filling = false;
        }

        // load
        private void LoadData()
        {
            _loading = true;
            _productsTable = LoadFromDatabase();
            ProductGridNew.SetDataBinding(_productsTable, null, false);
            ConfigureGrid();

            _loading = false;
        }

        // Control Events


        private void TbxProductID_TextChanged(object sender, EventArgs e)
        {
            if (_filling)
                return;
            _editing = true;
            EnabledDisabledBtn();
        }

        private void TbxProdDescription_TextChanged(object sender, EventArgs e)
        {
            if (_filling)
                return;
            _editing = true;
            EnabledDisabledBtn();
        }


        private void CbxProdStatus_TextChanged(object sender, EventArgs e)
        {
            if (_filling)
                return;
            _editing = true;
            EnabledDisabledBtn();
        }

        private void TbxProdBrand_TextChanged(object sender, EventArgs e)
        {
            if (_filling)
                return;
            _editing = true;
            EnabledDisabledBtn();
        }

        private void TxtProdPrice_TextChanged(object sender, EventArgs e)
        {
            if (_filling)
                return;
            _editing = true;
            EnabledDisabledBtn();
        }

        #endregion

        #region application layer (BLL)
        private DataTable _productsTable;
        private List<Product> _productsList = new List<Product>();


        private void NewProduct (string productCode, string productName, string brand, string price, ProductStatusEnum productStatus)
        {

            var product = new Product()
            {
                Id = Guid.NewGuid(),
                ProductCode = productCode,
                ProductName = productName,
                Brand = brand,
                Price = price,
                Active = productStatus == ProductStatusEnum.Active

            };

            InsertDatabase(product);
        }

        private void UpdateProduct(string productCode, string productName, string brand, string price, ProductStatusEnum productStatus, Guid id)
        {

            // Read
            var product = GetProductById(id);

            if (product == null)
                throw new Exception("Product not found");

            // Alter
            product.ProductCode = productCode;
            product.ProductName = productName;
            product.Brand = brand;
            product.Price = price;
            product.Active = productStatus == ProductStatusEnum.Active;

            // Persist

            UpdateDatabase(product);

        }

        private void DeleteProduct(Guid id)
        {
            var product = GetProductById(id);
            if (product == null)
                throw new Exception("Product not found");

            DeleteDatabase(product);
            
        }


        #endregion

        #region data access layer (DAL)

        private Product GetProductById(Guid id)
        {
            var dbConnection = GetConnection();
            dbConnection.Open();

            var sql = $@"
            SELECT * FROM Products
            WHERE id = @id;";
            var command = new System.Data.SqlClient.SqlCommand(sql, dbConnection);
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", id));

            var adapter = new System.Data.SqlClient.SqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table);


            if (table.Rows.Count == 0)
                return default;

            var row = table.Rows[0];


            var product = new Product()
            {
                Id = row.Field<Guid>("id"),
                ProductCode = row.Field<string>("code"),
                ProductName = row.Field<string>("name"),
                Brand = row.Field<string>("brand"),
                Price = row.Field<string>("price"),
                Active = row.Field<bool>("active"),
            };


            if (dbConnection.State == ConnectionState.Open)
                dbConnection.Close();

            // Clean RAM.
            dbConnection.Dispose();
            dbConnection = null;

            return product;

        }

        private bool UpdateDatabase(Product product)
        {
            var dbConnection = GetConnection();
            dbConnection.Open();

            var sql = $@"
                UPDATE 
                    Products
                        SET code = @code, name = @name ,  brand = @brand, active = @active, price = @price
	            WHERE id = @id;";

            var command = new System.Data.SqlClient.SqlCommand(sql, dbConnection);
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", product.Id));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@code", product.ProductCode));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", product.ProductName));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@brand", product.Brand));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@price", product.Price));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@active", product.Active));

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


        private bool InsertDatabase(Product product)
        {
            var dbConnection = GetConnection();
            dbConnection.Open();

            var sql = $@"
                INSERT INTO Products (id, code, [name], brand, price, active) Values (@id, @code, @name, @brand, @price, @active);";
            var command = new System.Data.SqlClient.SqlCommand(sql, dbConnection);
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", product.Id));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@code", product.ProductCode));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", product.ProductName));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@brand", product.Brand));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@price", product.Price));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@active", product.Active));

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
        private bool DeleteDatabase(Product product)
        {
            var dbConnection = GetConnection();
            dbConnection.Open();

            var sql = $@"
                DELETE Products 
	                WHERE id = @id;";

            var command = new System.Data.SqlClient.SqlCommand(sql, dbConnection);
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", product.Id));
            // command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@code", product.ProductCode));
            // command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", product.ProductName));
            // command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@brand", product.Brand));
            // command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@price", product.Price));
            // command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@active", product.Active));

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


            var sql = "SELECT * FROM Products";
            var command = new System.Data.SqlClient.SqlCommand(sql, dbConnection);


            // adpater
            var adpter = new System.Data.SqlClient.SqlDataAdapter(command);
            // dataTable
            var table = new DataTable();
            adpter.Fill(table);


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
    }
    }

    #endregion
