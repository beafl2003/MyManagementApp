using System;

namespace MyManagementApp.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Price { get; set; }
        //public ProductStatusEnum Status { get; set; }
        public bool Active { get; set; }
    }
}

