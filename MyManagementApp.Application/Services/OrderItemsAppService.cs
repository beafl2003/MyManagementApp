using MyManagementApp.Data.Repositories;
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

        public DataTable LoadFromDatabase()
        {
            return _orderItemsRepository.LoadFromDatabase();

    }
    #endregion
}


}
