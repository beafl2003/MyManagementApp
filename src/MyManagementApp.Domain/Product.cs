using System;
using MyManagementApp.Domain.Core;
using System.Collections.Generic;

namespace MyManagementApp.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Price { get; set; }
        public bool Active { get; set; }

        public Result IsValid()
        {
            var messages = new List<string>();

            //return Id != Guid.Empty
            //    && !string.IsNullOrEmpty(CustomerCode)
            //    && CustomerCode.Length >= 2
            //    && CustomerCode.Length <= 10
            //    && !string.IsNullOrEmpty(CustomerName)
            //    && CustomerName.Length >= 2
            //    && CustomerName.Length <= 100;


            if (Id == Guid.Empty)
                messages.Add("Id is empty");

            if (string.IsNullOrEmpty(ProductCode))
                messages.Add("ProductCode is empty");

            if (ProductCode.Length < 2)
                messages.Add("ProductCode is lower than 2 caracteres");

            if (ProductCode.Length > 10)
                messages.Add("ProductCode is greater than 10 caracteres");

            if (string.IsNullOrEmpty(ProductCode))
                messages.Add("ProductCode is empty");

            if (ProductCode.Length < 2)
                messages.Add("ProductCode is lower than 2 caracteres");

            if (ProductCode.Length > 100)
                messages.Add("ProductCode is greater than 100 caracteres");


            return Result.Factory.New(messages);
        }
    }
}

