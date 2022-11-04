using MyManagementApp.Domain.Core;
using System;
using System.Collections.Generic;

namespace MyManagementApp.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        //public CustomerStatusEnum CustomerStatus { get; set; }
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
                messages.Add( "Id is empty");
            
            if (string.IsNullOrEmpty(CustomerCode))
                messages.Add("CustomerCode is empty");
            
            if (CustomerCode.Length < 2)
                messages.Add("CustomerCode is lower than 2 caracteres");
            
            if (CustomerCode.Length > 10)
                messages.Add("CustomerCode is greater than 10 caracteres");
  
            if (string.IsNullOrEmpty(CustomerName))
                messages.Add("CustomerCode is empty");
            
            if (CustomerName.Length < 2)
                messages.Add("CustomerName is lower than 2 caracteres");

            if (CustomerName.Length > 100)
                messages.Add("CustomerName is greater than 100 caracteres");
  

            return Result.Factory.New(messages);

        }
    }
}
