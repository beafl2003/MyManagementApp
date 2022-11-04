using MyManagementApp.Domain;
using System;
using System.Data;

namespace MyManagementApp.Data.Repositories
{
    public class CustomerRepository
    {
        public Customer GetCustomerById(Guid id)
        {

            var dbConnection = ConnectionProvider.GetConnection();
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


            if (table.Rows.Count == 0)
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

            // Clean RAM 
            dbConnection.Dispose();
            dbConnection = null;

            return customer;

        }
        public bool InsertDatabase(Customer customer)
        {
            var dbConnection = ConnectionProvider.GetConnection();
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
        public bool UpdateDatabase(Customer customer)
        {
            var dbConnection = ConnectionProvider.GetConnection();
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
        public bool DeleteDatabase(Customer customer)
        {
            var dbConnection = ConnectionProvider.GetConnection();
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
        public DataTable LoadFromDatabase()
        {
            var dbConnection = ConnectionProvider.GetConnection();
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

    }
}
