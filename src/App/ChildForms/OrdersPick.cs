﻿using MyManagementApp.Application.Services;
using MyManagementApp.Domain;
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

namespace TestandoComponentes.ChildForms
{
    public partial class OrdersPick : Form
    {


        public int _currentOrderNum;
        public Order _currentOrder;
        public int _currentCustomerCode;
        public Guid _currentCustomerGUID;
        private readonly OrdersAppService _orderAppService;
        private bool _filling;
        private string  _searchType;
        const string SearchAllOrders = "SearchAllOrders";
        const string SearchByCustomer = "SearchByCustomer";
        const string SearchByCustomerCode = "SearchByCustomerCode";


        public OrdersPick(string searchType, int customerCode = 0, Guid customerGUID = default)
        {
            InitializeComponent();

            this.Shown += OrdersPick_Shown;
            this.OrdersGrid.RowColChange += OrdersGrid_RowColChange;
            _orderAppService = new OrdersAppService();
            _searchType = searchType;
            _currentCustomerCode = customerCode;
            _currentCustomerGUID = customerGUID;

        }




        private void OrdersPick_Shown(object sender, EventArgs e)
        {
            LoadData();
            ConfigureGrid();

        }

        private void LoadData()
        {

            if (_searchType == SearchAllOrders)
            {
                var orderspickTable = _orderAppService.LoadFromDatabase();
                OrdersGrid.SetDataBinding(orderspickTable, null, false);
                ConfigureGrid();

                var rows = orderspickTable.Rows.Count;

                if (rows == 0)

                {
                    ClearActions();
                };

            }
            if (_searchType == SearchByCustomerCode)
            {
                var orderspickTable = _orderAppService.GetOrdersByCustomerCode(_currentCustomerCode);
                OrdersGrid.SetDataBinding(orderspickTable, null, false);
                ConfigureGrid();

                var rows = orderspickTable.Rows.Count;

                if (rows == 0)

                {
                    ClearActions();
                };
            }

            if (_searchType == SearchByCustomer)
            {
                var orderspickTable = _orderAppService.GetOrdersByCustomer(_currentCustomerGUID);
                OrdersGrid.SetDataBinding(orderspickTable, null, false);
                ConfigureGrid();

                var rows = orderspickTable.Rows.Count;

                if (rows == 0)

                {
                    ClearActions();
                };


            }
        }

        // grid

        private void OrdersGrid_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            var currentRow = OrdersGrid.Row;
            if (e.LastRow == currentRow)
                return;
            var table = (DataTable)OrdersGrid.DataSource;
            var row = table.Rows[currentRow];
            FillFields(row);
        }

        private void ClearActions()
        {
            tbxOrdernum.Clear();
            tbxcustomerID.Clear();
            tbxcustomerName.Clear();
        }




        private void FillFields(DataRow row)
        {
            _filling = true;

            _currentOrderNum = row.Field<int>("OrderNumber");

            var OrderNumber = row.Field<int>("OrderNumber").ToString();
            //var statusOrder = row.Field<string>("OrderStatus").ToOrderStatusEnum();
            var CustomerCode = row.Field<string>("code");
            var CustomerName = row.Field<string>("name");

            tbxOrdernum.Text = OrderNumber;
            tbxcustomerID.Text = CustomerCode;
            tbxcustomerName.Text = CustomerName;

            _filling = false;
        }

        private void ConfigureGrid()
        {


            // zebra design
            OrdersGrid.AlternatingRows = true;
            OrdersGrid.OddRowStyle.BackColor = Color.WhiteSmoke;
            OrdersGrid.EvenRowStyle.BackColor = Color.White;
            foreach (C1.Win.C1TrueDBGrid.C1DisplayColumn item in OrdersGrid.Splits[0].DisplayColumns)
            {

                // Block Item Editing 
                item.Locked = true;

                if (item.DataColumn.DataField.ToLower() == "ordernumber".ToLower())
                {
                    item.DataColumn.Caption = "Order";
                }
                if (item.DataColumn.DataField.ToLower() == "customerid".ToLower())
                {
                    item.Visible = false;
                }
                if (item.DataColumn.DataField.ToLower() == "orderstatus".ToLower())
                {
                    item.DataColumn.Caption = "Status";
                }
                if (item.DataColumn.DataField.ToLower() == "id".ToLower())
                {
                    item.Visible = false;
                }
                if (item.DataColumn.DataField.ToLower() == "code".ToLower())
                {
                    item.DataColumn.Caption = "Customer Code";
                }
                if (item.DataColumn.DataField.ToLower() == "name".ToLower())
                {
                    item.DataColumn.Caption = "Customer Name";
                }
                if (item.DataColumn.DataField.ToLower() == "active".ToLower())
                {
                    item.DataColumn.Caption = "Customer Status";
                }

            }
        }

        private void OrdersGrid_Enter(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {

                var orderId = this._currentOrderNum;
                        
        }

       private void OrdersGrid_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    var orderId = this._currentOrderNum;
            //    DialogResult = DialogResult.OK;
            //    this.Close();

            //}
        }

        private void OrdersPick_Load(object sender, EventArgs e)
        {

        }

        private void c1Button1_Click(object sender, EventArgs e)
        {
            var orderId = this._currentOrderNum;
            DialogResult = DialogResult.OK;
            this.Close();
        }


    } 

}
