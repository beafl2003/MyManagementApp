using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
