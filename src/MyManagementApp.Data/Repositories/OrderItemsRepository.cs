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
                    Products.brand, Products.price AS 'unitprice', orderitems.Qtyordered, 
                    (Products.price  * orderitems.Qtyordered) AS 'TotalPrice',
                    orderitems.ItemStatus
                    FROM orderitems 
                    
                    INNER JOIN customers ON orderitems.customerid = customers.id
                    INNER JOIN orders ON orderitems.OrderNumber = orders.OrderNumber
                    INNER JOIN products ON orderitems.Productid = Products.id
                    INNER JOIN address ON orderitems.AddressID = Address.AddressID
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
                    
                    INNER JOIN customers ON orderitems.customerid = customers.id
                    INNER JOIN orders ON orderitems.OrderNumber = orders.OrderNumber
                    INNER JOIN products ON orderitems.Productid = Products.id
                    INNER JOIN address ON orderitems.AddressID = Address.AddressID
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

        public bool InsertItem(OrderItems item) 
        
        {
            var dbConnection = ConnectionProvider.GetConnection();
            dbConnection.Open();

            string StatusOfTheItem = item.ItemStatus.ToDataValue();
            var sql = $@" INSERT INTO orderitems
                    (ordernumber, productid, customerid, addressid, qtyordered, totalprice, itemstatus)
                    VALUES
                    (@OrderNumber, @ProductId, @CustomerID, @AddressID,@QtyOrdered, @TotalPrice, @ItemStatus)";

            var command = new System.Data.SqlClient.SqlCommand(sql, dbConnection);
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OrderNumber", item.OrderNumber));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductId", item.ProductId));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CustomerID", item.CustomerID));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AddressID", item.AddressID));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@QtyOrdered", item.QtyOrdered));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TotalPrice", item.TotalPrice));
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ItemStatus", StatusOfTheItem));

            var returnValue = command.ExecuteScalar();
            var rowsAffected = 0;
            // try convert
            if (int.TryParse(returnValue.ToString(), out int orderNumber))
            {
                item.OrderNumber = orderNumber;
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
