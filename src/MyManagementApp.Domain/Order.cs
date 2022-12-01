using MyManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManagementApp.Domain.Core
{

    public class Order
    {
        public int OrderNumber { get; set; }
        public Guid CustomerID { get; set; }
        public OrderStatusEnum OrderStatus { get; set; }

        // public string CustomerCode { get; set; }
        // public string CustomerName { get; set; }
        // Customerstatus - use as validation for the order

        public List<decimal> Items { get; set; }

        #region validations

        public Result IsValid()
        {
            var messages = new List<string>();


            if (CustomerID == Guid.Empty)
                messages.Add("CustomerId is empty");

            if (!Enum.IsDefined(typeof(OrderStatusEnum), OrderStatus))
                messages.Add("Please select a status for your order");




            return Result.Factory.New(messages);


        }

        #endregion
    }
        // ex
     public static class OrderTest
    {
        private static void TestarTotalOrder()
        {
            var order = new Order();

            // precisa do total 
            var total = order.Total();
         
            // print total
        }


        private static void TestarTotalOrder2()
        {
            var order = new Order();

            // precisa do total 
            var total = order.Total();


            // print total
        }

    }

    public static class OrderExtension
    {
        public  static decimal Total(this Order order)
        {
            var total = decimal.Zero;
            foreach (var item in order.Items)
            {
                total = total + item;
            }
            return total;
        }
    }
}
