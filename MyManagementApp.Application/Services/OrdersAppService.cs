﻿using MyManagementApp.Domain.Core;
using MyManagementApp.Domain.Enums;
using System;
using System.Data;
using MyManagementApp.Data.Repositories;

namespace MyManagementApp.Application.Services
{
    public class OrdersAppService
    {
        #region fields
        private readonly OrderRepository _orderRepository;
        private readonly OrderItemsRepository _orderItemsRepository;
        #endregion

        #region constructor
        public OrdersAppService()
        {
            _orderRepository = new OrderRepository();
            _orderItemsRepository = new OrderItemsRepository();
        }
    
        #endregion


        #region methods

        // Load from database
        public DataTable LoadFromDatabase()
        {
            return _orderRepository.LoadFromDatabase();
        }

        public Order GetOrderByNumber(int orderNumber)
        {
            return _orderRepository.GetOrderByNumber(orderNumber);

        }

        public DataTable GetOrdersByCustomer(Guid customerid)
        {
            return _orderRepository.GetOrdersByCustomer(customerid);
        }

        public DataTable GetOrdersByCustomerCode(int customercode)
        {
            return _orderRepository.GetOrdersByCustomerCode(customercode);
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

        // UpdateOrder(int orderNumber, Guid customerID, OrderStatusEnum orderStatus)
        public Result UpdateOrder(int orderNumber, OrderStatusEnum orderStatus)
        {
            // Read
            var order = _orderRepository.GetOrderByNumber(orderNumber);

            if (order == null)
                return Result.Factory.False("Order not found");

            // Update order

            order.OrderNumber = orderNumber;
            order.OrderStatus = orderStatus;

            var r = order.IsValid();
            if (!r.Success)
                return r;

            _orderRepository.UpdateFromdatabase(order);

            return Result.Factory.True();

        }


        // delete order

        public Result DeleteOrder(int orderNumber)
        {
            //Read
            var order = _orderRepository.GetOrderByNumber(orderNumber);

            var orderitems = _orderItemsRepository.GetOrderItemsByOrder(orderNumber);

            if (order == null)
                return Result.Factory.False("Order not found");
            else if (orderitems == null)
            {
                _orderRepository.DeleteFromDataBase(order);
            }
            else
            {
                _orderItemsRepository.DeleteAllItemsFromOrder(order);
                _orderRepository.DeleteFromDataBase(order);
            }

               


            return Result.Factory.True();

        }

       

        #endregion
    }
}
