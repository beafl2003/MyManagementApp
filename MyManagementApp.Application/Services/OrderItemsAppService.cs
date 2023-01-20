using MyManagementApp.Data.Repositories;
using MyManagementApp.Domain;
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

        public OrderItems GetOrderItem(int orderNumber, int orderitemsq)
        {
            return _orderItemsRepository.GetOrderItemByNumber(orderNumber, orderitemsq);
        }

        #endregion

    }


}
