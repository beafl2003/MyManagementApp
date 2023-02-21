using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyManagementApp.Domain.Core;
using MyManagementApp.Domain;
using MyManagementApp.Domain.Enums;

namespace MyManagementApp.Data.Repositories
{
    public class OrderItemsRepository
    {

        public DataTable LoadFromDatabase(int OrderNumber)
        {
            var dbConnection = ConnectionProvider.GetConnection();
            dbConnection.Open();


            var sql = $@"SELECT 
                    ROW_NUMBER() OVER (ORDER BY orderitems.line) AS 'line',
                    orderitems.line AS 'sq',
                    orders.OrderNumber, customers.name AS 'customername',
                    address.address, address.StateOrProvinceCode AS 'state',
                    address.city, address.countrycode AS 'country',
                    products.code AS 'productcode', products.name AS 'product',
                    Products.brand, Products.price AS 'unitprice', ISNULL(orderitems.Qtyordered, 00) AS 'Qtyordered', 
                    ISNULL((Products.price  * orderitems.Qtyordered),00) AS 'TotalPrice',
                    orderitems.ItemStatus
                    FROM orderitems 
                    
                    LEFT JOIN customers ON orderitems.customerid = customers.id
                    LEFT JOIN orders ON orderitems.OrderNumber = orders.OrderNumber
                    LEFT JOIN products ON orderitems.Productid = Products.id
                    LEFT JOIN address ON orderitems.AddressID = Address.AddressID
                    WHERE orderitems.OrderNumber = @OrderNumber";

            var command = new SqlCommand(sql, dbConnection);
            command.Parameters.Add(new SqlParameter("@OrderNumber", OrderNumber));

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

        public DataTable GetOrderItemsByCustomerCode(int customerCode)
        {
            var dbConnection = ConnectionProvider.GetConnection();
            dbConnection.Open();


            var sql = $@"SELECT 
                    ROW_NUMBER() OVER (ORDER BY orderitems.line) AS 'line',
                    orderitems.line AS 'sq',
                    orders.OrderNumber, customers.name AS 'customername',
                    address.address, address.StateOrProvinceCode AS 'state',
                    address.city, address.countrycode AS 'country',
                    products.code AS 'productcode', products.name AS 'product',
                    Products.brand, Products.price AS 'unitprice', ISNULL(orderitems.Qtyordered, 00) AS 'Qtyordered', 
                    ISNULL((Products.price  * orderitems.Qtyordered),00) AS 'TotalPrice',
                    orderitems.ItemStatus
                    FROM orderitems 
                    
                    LEFT JOIN customers ON orderitems.customerid = customers.id
                    LEFT JOIN orders ON orderitems.OrderNumber = orders.OrderNumber
                    LEFT JOIN products ON orderitems.Productid = Products.id
                    LEFT JOIN address ON orderitems.AddressID = Address.AddressID
                    WHERE Customers.code = @CustomerCode";

            var command = new SqlCommand(sql, dbConnection);
            command.Parameters.Add(new SqlParameter("@CustomerCode", customerCode));

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

        public OrderItems GetOrderItemByNumber(int OrderNumber, int orderitemsq)
        {
            var dbConnection = ConnectionProvider.GetConnection();
            dbConnection.Open();

            var sql = $@"SELECT 
                    ROW_NUMBER() OVER (ORDER BY orderitems.line) AS 'line',
                    orderitems.Productid,
					orderitems.CustomerID, 
                    orderitems.AddressID,
                    orderitems.line AS 'sq',
                    orders.OrderNumber, customers.name AS 'customername',
                    address.address, address.StateOrProvinceCode AS 'state',
                    address.city, address.countrycode AS 'country',
                    products.code AS 'productcode', products.name AS 'product',
                    Products.brand, Products.price AS 'unitprice', orderitems.Qtyordered, 
                    (Products.price  * orderitems.Qtyordered) AS 'TotalPrice',
                    orderitems.ItemStatus
                    FROM orderitems 
                    
                    LEFT JOIN customers ON orderitems.customerid = customers.id
                    LEFT JOIN orders ON orderitems.OrderNumber = orders.OrderNumber
                    LEFT JOIN products ON orderitems.Productid = Products.id
                    LEFT JOIN address ON orderitems.AddressID = Address.AddressID
                    WHERE orderitems.OrderNumber = @OrderNumber AND orderitems.line = @sq";

            var command = new SqlCommand(sql, dbConnection);
            command.Parameters.Add(new SqlParameter("@OrderNumber", OrderNumber));
            command.Parameters.Add(new SqlParameter("@sq", orderitemsq));
            var adapter = new SqlDataAdapter(command);
            // dataTable
            var table = new DataTable();
            adapter.Fill(table);


            if (table.Rows.Count == 0)
                return default;

            // datarow
            var row = table.Rows[0];

            var orderItemStatus = row.Field<string>("ItemStatus");

            var OrderItem = new OrderItems()
            {
                OrderNumber = row.Field<int>("OrderNumber"),
                Line = row.Field<int>("sq"),
                ProductId = row.Field<Guid>("Productid"),
                CustomerID = row.Field<Guid>("CustomerID"),
                AddressID = row.Field<int>("AddressID"),
                QtyOrdered = row.Field<decimal>("Qtyordered"),
                TotalPrice = row.Field<decimal>("TotalPrice"),
                ItemStatus = (OrderItemStatusEnum)orderItemStatus.ToOrderItemStatusEnum()

            };
            if (dbConnection.State == ConnectionState.Open)
                dbConnection.Close();

            // Clean RAM 
            dbConnection.Dispose();
            dbConnection = null;

            return OrderItem;
        }
        public DataTable GetOrderItemsByOrder(int OrderNumber)
        {
            var dbConnection = ConnectionProvider.GetConnection();
            dbConnection.Open();

            var sql = $@"SELECT 
                    ROW_NUMBER() OVER (ORDER BY orderitems.line) AS 'line',
                    orderitems.Productid,
					orderitems.CustomerID, 
                    orderitems.AddressID,
                    orderitems.line AS 'sq',
                    orders.OrderNumber, customers.name AS 'customername',
                    address.address, address.StateOrProvinceCode AS 'state',
                    address.city, address.countrycode AS 'country',
                    products.code AS 'productcode', products.name AS 'product',
                    Products.brand, Products.price AS 'unitprice', orderitems.Qtyordered, 
                    (Products.price  * orderitems.Qtyordered) AS 'TotalPrice',
                    orderitems.ItemStatus
                    FROM orderitems 
                    
                    LEFT JOIN customers ON orderitems.customerid = customers.id
                    LEFT JOIN orders ON orderitems.OrderNumber = orders.OrderNumber
                    LEFT JOIN products ON orderitems.Productid = Products.id
                    LEFT JOIN address ON orderitems.AddressID = Address.AddressID
                    WHERE orderitems.OrderNumber = @OrderNumber";

            var command = new SqlCommand(sql, dbConnection);
            command.Parameters.Add(new SqlParameter("@OrderNumber", OrderNumber));
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

        public bool DeleteAllItemsFromOrder(Order order)
        {

            var dbConnection = ConnectionProvider.GetConnection();
            dbConnection.Open();

            var sql = $@"
                    DELETE FROM orderitems 
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

        public bool InsertItem(OrderItems orderitem) 
        
        {
            var dbConnection = ConnectionProvider.GetConnection();
            dbConnection.Open();

            var sql = $@"  INSERT INTO orderitems (ordernumber, customerid, productid, ItemStatus)
                VALUES (@OrderNumber, (SELECT customerid FROM orders WHERE ordernumber = @OrderNumber), @productid, 'Ordered') 
                SELECT SCOPE_IDENTITY()";

            var command = new System.Data.SqlClient.SqlCommand(sql, dbConnection);
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OrderNumber", orderitem.OrderNumber));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductId", orderitem.ProductId));


            var returnValue = command.ExecuteScalar();
            var rowsAffected = 0;
            // try convert
            if (int.TryParse(returnValue.ToString(), out int orderitemNumber))
            {
                orderitem.Line = orderitemNumber;
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
    }
}
