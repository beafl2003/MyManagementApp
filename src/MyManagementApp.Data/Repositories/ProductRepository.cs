using MyManagementApp.Data;
using MyManagementApp.Domain;
using System;
using System.Data;

namespace MyManagementApp.Data.Repositories
{
    public class ProductRepository
    {
        public Product GetProductById(Guid id)
        {
            var dbConnection = ConnectionProvider.GetConnection();
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

        public bool UpdateDatabase(Product product)
        {
            var dbConnection = ConnectionProvider.GetConnection();
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


        public bool InsertDatabase(Product product)
        {
            var dbConnection = ConnectionProvider.GetConnection();
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
        public bool DeleteDatabase(Product product)
        {
            var dbConnection = ConnectionProvider.GetConnection();
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
        public DataTable LoadFromDatabase()
        {
            var connectionString = @"Server=ANNA-BEATRIZ\SQLEXPRESS;Database=MyManagementAppDb;User Id=sa;Password=dp";
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
    }
}
