﻿using C1.Win.C1TrueDBGrid;
using MyManagementApp.Application.Services;
using MyManagementApp.Domain.Core;
using MyManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestandoComponentes.Extensions;

namespace MyManagementApp.ChildForms
{
    public partial class OrdersForm : Form
    {
        #region Config
        #endregion

        #region Presentation
        private bool _editing;
        private bool _newItem;
        private bool _loading;
        private bool _filling;
        private int _currentOrderNum;

        private readonly OrdersAppService _orderAppService;

        public OrdersForm()
        {
            InitializeComponent();

            this.cbxOrderStatus.DataSource = Enum.GetValues(typeof(OrderStatusEnum));
            this.cbxOrderItemStatus.DataSource = Enum.GetValues(typeof(OrderItemStatusEnum));

            this.OrderItemsGrid.RowColChange += OrderItemsGrid_RowColChange;
            this.Shown += OrdersForm_Shown;


            btnAdd.Click += BtnAdd_Click;

            _orderAppService = new OrdersAppService();

        }


        private void OrderItemsGrid_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            var currentRow = OrderItemsGrid.Row;
            if (e.LastRow == currentRow)
                return;
            var table = (DataTable)OrderItemsGrid.DataSource;
            var row = table.Rows[currentRow];
            FillFields(row);
        }

        private void OrdersForm_Shown(object sender, EventArgs e)
        {
            LoadData();
            //EnabledDisabledBtn();
        }

        private void LoadData()
        {

            var customersTable = _orderAppService.LoadFromDatabase();
            OrderItemsGrid.SetDataBinding(customersTable, null, false);


        }

        // fill control
        private void FillFields(DataRow row)
        {
            _filling = true;

            _currentOrderNum = row.Field<int>("OrderNumber");

            var OrderNumber = row.Field<int>("OrderNumber").ToString();
            var statusOrder = row.Field<string>("OrderStatus").ToOrderStatusEnum();
            var CustomerCode = row.Field<string>("code");
            var CustomerName = row.Field<string>("name");

            tbxOrderID.Text = OrderNumber;
            tbxCustomer.Text = CustomerCode;
            tbxCustomerDescription.Text = CustomerName;
            cbxOrderStatus.SelectedItem = statusOrder;

            _filling = false;
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }


        #region order tools
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // direto

            // seleção do cliente (janela de diálogo - modal)
            // com base no retorno a gente monta o objeto order


            var customerId = Guid.Parse("0B949210-2822-48CB-8F1E-36B1825A67AF");

            var r = _orderAppService.NewOrder(customerId);
            if (!r.Success)
            {
                this.NotifyError(r);
                return;
            }


            _newItem = false;
            _editing = false;
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var customerId = Guid.Parse("0B949210-2822-48CB-8F1E-36B1825A67AF");
            if (_newItem)
            {
                var r = _orderAppService.NewOrder(customerId);

                if (!r.Success)
                {
                    this.NotifyError(r);
                    return;
                }
            }
            else
            {
                var customerID = _currentOrderNum;
                //var r = _orderAppService.UpdateOrder(tbxOrderID,)

                // int orderNumber, Guid customerID, OrderStatusEnum orderStatus

            }
        }


        #endregion

        #region Extension Tests
        public static class MyExtension
        {
            public static string ToDoubleString2( int valorInteiro)
            {
                // 100
                // "100"
                // 100.0
                // "100.00"
                return double.Parse(valorInteiro.ToString()).ToString();

            }
            public static string ToDoubleString (int valorInteiro)
            {
                // 100
                // "100"
                // 100.0
                // "100.00"
                return double.Parse(valorInteiro.ToString()).ToString();
            }
            

        }

    }

    #endregion
}

#endregion