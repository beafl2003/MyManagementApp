using MyManagementApp.Domain.Core;
using MyManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManagementApp.Domain
{
    public class OrderItems
    {
        public int OrderNumber { get; set; }
        public int Line { get; set; }
        public Guid ProductId { get; set; }
        public Guid CustomerID { get; set; }
        public int AddressID { get; set; }
        public decimal QtyOrdered { get; set; }
        public decimal TotalPrice { get; set;}
        public OrderItemStatusEnum ItemStatus { get; set; }


        #region validations

        public Result IsValid()
        {
            var messages = new List<string>();


            if (OrderNumber == null)
                messages.Add("Order Number is empty");


            return Result.Factory.New(messages);


        }

        #endregion
    }


}
