using MyManagementApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManagementApp.Application.Services
{
    public class OrdersAppService
    {
        #region fields
        private readonly OrderRepository _orderRepository;
        #endregion

        #region constructor
        public OrdersAppService()
        {
            _orderRepository = new OrderRepository();
        }
        #endregion


        #region methods


        public DataTable LoadFromDatabase()
        {
            return _orderRepository.LoadFromDatabase();
        }


        // new order
        public Result NewOrder(Guid customerId)
        {
            var order = new Order()
            {
                CustomerID = customerId,
                OrderStatus = Domain.Enums.OrderStatusEnum.Open
            };

            var r = order.IsValid();
            if (!r.Success)
                return r;

            _orderRepository.InsertDatabase(order);

            return Result.Factory.True();
        }


        // update order
        // delete order

        #endregion
    }
}
