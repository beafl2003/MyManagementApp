using MyManagementApp.Data.Repositories;
using MyManagementApp.Domain;
using MyManagementApp.Domain.Core;
using MyManagementApp.Domain.Enums;
using System;
using System.Data;

namespace MyManagementApp.Application.Services
{
    public class CustomerAppService
    {

        #region fields
        private readonly CustomerRepository _customerRepository;
        #endregion

        #region constructor
        public CustomerAppService()
        {
            _customerRepository = new CustomerRepository();
        }
        #endregion


        #region methods


        public DataTable LoadFromDatabase()
        {
            return _customerRepository.LoadFromDatabase();
        }

        public Result NewCustomer(string customerCode, string customerName, CustomerStatusEnum customerStatus)
        {
            var customer = new Customer()
            {
                Id = Guid.NewGuid(),
                CustomerCode = customerCode,
                CustomerName = customerName,
                Active = customerStatus == CustomerStatusEnum.Active
            };

            var r = customer.IsValid();
            if (!r.Success)
                return r;

            _customerRepository.InsertDatabase(customer);

            return Result.Factory.True();
        }

        public Result UpdateCustomer(string customerCode, string customerName, CustomerStatusEnum customerStatus, Guid id)
        {



            // Read
            var customer = _customerRepository.GetCustomerById(id);

            if (customer == null)
                return Result.Factory.False("Customer not found");

            // Alter
            customer.CustomerCode = customerCode;
            customer.CustomerName = customerName;
            customer.Active = customerStatus == CustomerStatusEnum.Active;



            var r = customer.IsValid();
            if (!r.Success)
                return r;


            // Persist
            _customerRepository.UpdateDatabase(customer);


            return Result.Factory.True();
        }

        public Result DeleteCustomer(Guid id)
        {
            var customer = _customerRepository.GetCustomerById(id);

            if (customer == null)
                return Result.Factory.False("Customer not found");

            _customerRepository.DeleteDatabase(customer);


            return Result.Factory.True();
        }


        #endregion
    }
}
