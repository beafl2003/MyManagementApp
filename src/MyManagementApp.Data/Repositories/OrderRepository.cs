using MyManagementApp.Data;
using MyManagementApp.Domain.Core;
using MyManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManagementApp.Data.Repositories { }

public class OrderRepository
{
    public Order GetOrderByNumber(int OrderNumber)
    {
        var dbConnection = ConnectionProvider.GetConnection();
        dbConnection.Open();

        var sql = $@"
                SELECT * FROM Orders
                INNER JOIN Customers ON 
	                     Customers.id = Orders.Customerid 
	                AND  Customers.id = Orders.Customerid
	                WHERE
	                OrderNumber = @OrderNumber;";

        var command = new SqlCommand(sql, dbConnection);
        command.Parameters.Add(new SqlParameter("@OrderNumber", OrderNumber));

        var adapter = new SqlDataAdapter(command);
        // dataTable
        var table = new DataTable();
        adapter.Fill(table);


        if (table.Rows.Count == 0)
            return default;

        // datarow
        var row = table.Rows[0];

        var Order = new Order()
        {
            OrderNumber = row.Field<int>("OrderNumber"),
            CustomerID = row.Field<Guid>("Customerid"),
            OrderStatus = row.Field<OrderStatusEnum>("OrderStatus"),
            //CustomerCode = row.Field<string>("Customers.code"),
            //CustomerName = row.Field<string>("Customers.name")

        };

        if (dbConnection.State == ConnectionState.Open)
            dbConnection.Close();

        // Clean RAM 
        dbConnection.Dispose();
        dbConnection = null;

        return Order;

    }

    public bool InsertDatabase(Order order)
    {
        var dbConnection = ConnectionProvider.GetConnection();
        dbConnection.Open();

        var sql = $@"INSERT INTO Orders(CustomerID, OrderStatus)
                    VALUES(@id, @OrderStatus)
                    SELECT SCOPE_IDENTITY();";

        var command = new System.Data.SqlClient.SqlCommand(sql, dbConnection);
        command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", order.CustomerID));
        command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OrderStatus", order.OrderStatus.ToDataValue()));

        // command.ExecuteNonQuery() = linhas afetadas
        // command.ExecuteReader() = ponteiro

        var returnValue = command.ExecuteScalar();
        var rowsAffected = 0;
        // try convert
        if (int.TryParse(returnValue.ToString(), out int orderNumber))
        {
            order.OrderNumber = orderNumber;
            rowsAffected = 1;
        }

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

    public bool UpdateFromdatabase(Order order) 
    {
        var dbConnection = ConnectionProvider.GetConnection();
        dbConnection.Open();

        var sql = $@"UPDATE Orders SET
                OrderNumber = @OrderNumber,
                Customerid = @Customerid
                OrderStatus = @OrderStatus
                WHERE OrderNumber = @OrderNumber;";

        // command
        var command = new SqlCommand(sql, dbConnection);
        command.Parameters.Add(new SqlParameter("@OrderNumber", order.OrderNumber));
        command.Parameters.Add(new SqlParameter("@Customerid", order.CustomerID));
        command.Parameters.Add(new SqlParameter("@OrderStatus", order.OrderStatus));

        var rowsAffected = command.ExecuteNonQuery();

        if (dbConnection.State == ConnectionState.Open)
            dbConnection.Close();


        // liberação memória RAM da app..
        dbConnection.Dispose();


        if (rowsAffected > 0)
            return true;
        else
            return false;


    }

    public bool DeleteFromDataBase(Order order)
    {

        var dbConnection = ConnectionProvider.GetConnection();
        dbConnection.Open();

        var sql = $@"
                    DELETE FROM Orders 
                    WHERE OrderNumber = @OrderNumber";

        var command = new SqlCommand(sql, dbConnection);
        command.Parameters.Add(new SqlParameter("@OrderNumber", order.OrderNumber));
        var rowsAffected = command.ExecuteNonQuery();


        if (dbConnection.State == ConnectionState.Open)
            dbConnection.Close();


        // liberação memória RAM da app..
        dbConnection.Dispose();


        if (rowsAffected > 0)
            return true;
        else
            return false;

    }

    public DataTable LoadFromDatabase()
    {
        var dbConnection = ConnectionProvider.GetConnection();
        dbConnection.Open();


        var sql = $@"SELECT * FROM Orders
                INNER JOIN Customers ON

                         Customers.id = Orders.Customerid

                    AND Customers.id = Orders.Customerid";

        var command = new SqlCommand(sql, dbConnection);


        // adapter
        var adapter = new SqlDataAdapter(command);
        // dataTable
        var table = new DataTable();
        adapter.Fill(table);


        if (dbConnection.State == ConnectionState.Open)
            dbConnection.Close();


        // liberação memória RAM da app..
        dbConnection.Dispose();
        dbConnection = null;


        return table;


    }



}



