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
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public OrderStatusEnum OrderStatus { get; set; }
    }
}
