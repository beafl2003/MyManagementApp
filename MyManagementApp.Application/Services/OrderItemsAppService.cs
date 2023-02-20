using MyManagementApp.Data.Repositories;
using MyManagementApp.Domain;
using MyManagementApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManagementApp.Application.Services
{
    public class OrderItemsAppService
    {
        #region Fields
        private readonly OrderItemsRepository _orderItemsRepository;
        #endregion

        #region constructor
        public OrderItemsAppService()
        {
            _orderItemsRepository = new OrderItemsRepository();
        }
        #endregion

        #region Methods
         
        public DataTable LoadFromDatabase(int orderNumber)
        {
            return _orderItemsRepository.LoadFromDatabase(orderNumber);

        }

        public DataTable GetOrderItemsByCustomerCode(int customerCode)
        {
            return _orderItemsRepository.GetOrderItemsByCustomerCode(customerCode);
        }

        //public DataTable 
        public OrderItems GetOrderItem(int orderNumber, int orderitemsq)
        {
            return _orderItemsRepository.GetOrderItemByNumber(orderNumber, orderitemsq);
        }

        public Result InsertItem(int OrderNumber, Guid ProductId)
        {

            var orderitem = new OrderItems()
            {
                OrderNumber = OrderNumber,
                ProductId = ProductId,
                ItemStatus = Domain.Enums.OrderItemStatusEnum.Ordered
            };

            var r = orderitem.IsValid();
            if (!r.Success)
                return r;
            _orderItemsRepository.InsertItem(orderitem);

            return Result.Factory.True();
            #endregion

        }


    }
}
