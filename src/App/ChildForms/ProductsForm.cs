using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AppCore.Enums.ProductStatusEnum;
using System.Collections.Generic;
using MyProducts;

namespace MyManagementApp.ChildForms

{
    public partial class ProductsForm : Form
    {

        #region config
        private readonly string _server = @"ANNA-BEATRIZ\SQLEXPRESS";
        #endregion

        #region Presentation
        private bool _newItem;
        private Guid _currentId; 

        public ProductsForm()
        {
            InitializeComponent();

            this.cbxProdStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            this.Shown += ProductsForm_Shown;
            this.btnProdSave.Click += btnProdSave_Click;
            this.btnAdd.Click += btnProdAdd_Click;
            this.btnDelete.Click += btnProdDelete_Click;

            this.ProductGridNew.RowColChange += ProductGridNew_RowColChange;

        }

        private void ProductsForm_Shown(object sender, EventArgs e)
        {
            LoadData();
        }


        private void btnProdAdd_Click(object sender, EventArgs e)
        { 
            _newItem = true;

            tbxProductID.Clear();
            tbxProdDescription.Clear();
            txtProdPrice.Clear();
            tbxProdBrand.Clear();
            cbxProdStatus.SelectedItem = ProductStatusEnum.Active;

            tbxProductID.Focus();
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

            _newItem = false;
            LoadData();


        }

        private void btnProdDelete_Click(object sender, EventArgs e)
        {
            var id = _currentId;
            DeleteProduct(id);
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
        // fill control

        private void FillFields (DataRow row)
        {
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
        }

        // load
        private void LoadData()
        {
           
            _productsTable = LoadFromDatabase();
            ProductGridNew.SetDataBinding(_productsTable, null, false);
        }



        #endregion

        #region application layer
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
                Status = ProductStatusEnum.Active

            };

            InsertDatabase(product);
        }

        private void UpdateProduct(string productCode, string productName, string brand, string price, ProductStatusEnum productStatus, Guid id)
        {

            // ler
            var product = GetProductById(id);

            if (product == null)
                throw new Exception("Product not found");

            // alterar
            product.ProductCode = productCode;
            product.ProductName = productName;
            product.Brand = brand;
            product.Price = price;
            product.Active = productStatus == ProductStatusEnum.Active;
            // persistir

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

            // liberação memória RAM da app..
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
