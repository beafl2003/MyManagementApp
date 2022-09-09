﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Enums.CustomerStatusEnum;



namespace MyCustomers
{
    public class Customer
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public CustomerStatusEnum CustomerStatus { get; set; }
    }
}
