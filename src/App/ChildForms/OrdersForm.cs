using C1.Win.C1TrueDBGrid;
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
using TestandoComponentes;
using MyManagmentApp;
using TestandoComponentes.ChildForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Threading;
using MyManagementApp.Domain;
using C1.Win.C1Input;

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
        public bool _refreshOrders;
        private Guid _currentCustomerId;
        private Guid _currentOrderItemId;
        private Order _order;

        private readonly OrdersAppService _orderAppService;
        private readonly OrderItemsAppService _orderItemsAppService;
      

        public OrdersForm()
        {
            InitializeComponent();
            ConfigureGrid();

            this.cbxOrderStatus.DataSource = Enum.GetValues(typeof(OrderStatusEnum));
            this.cbxOrderItemStatus.DataSource = Enum.GetValues(typeof(OrderItemStatusEnum));
            this.OrderItemsGrid.RowColChange += OrderItemsGrid_RowColChange;
            this.Shown += OrdersForm_Shown;

 

            btnAdd.Click += BtnAdd_Click;

            _orderAppService = new OrdersAppService();
            _orderItemsAppService = new OrderItemsAppService();


        }


        private void OrderItemsGrid_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            var currentRow = OrderItemsGrid.Row;
            if (e.LastRow == currentRow)
                return;
            var table = (DataTable)OrderItemsGrid.DataSource;
            var row = table.Rows[currentRow];
            FillFields(row);


            var orderItemsTable = _orderItemsAppService.LoadFromDatabase(_currentOrderNum);
            OrderItemsTheGrid.SetDataBinding(orderItemsTable, null, false);

            // orders Grid

        }
        private void OrderItems_RowColChange(object sender, RowColChangeEventArgs e)
        {

            var currentRow = OrderItemsTheGrid.Row;
            if (e.LastRow == currentRow)
                return;
            var table = (DataTable)OrderItemsTheGrid.DataSource;
            var row = table.Rows[currentRow];
            FillItemFields(row);
        }

        private void OrdersForm_Shown(object sender, EventArgs e)
        {
            //LoadData();
            //EnabledDisabledBtn();
            _currentOrderNum = 0;
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            //LoadData();
            //EnabledDisabledBtn();
        }

        public void LoadData()
        {

            ConfigureGrid();

            var ordersTable = _orderAppService.LoadFromDatabase();
            OrderItemsGrid.SetDataBinding(ordersTable, null, false);

            var currentRow = OrderItemsGrid.Row;
            var table = (DataTable)OrderItemsGrid.DataSource;
            var row = table.Rows[currentRow];

            _currentOrderNum = row.Field<int>("OrderNumber");

            var rows = ordersTable.Rows.Count;

            if (rows == 0)

            {
                ClearActions();
            };


            var orderItemsTable = _orderItemsAppService.LoadFromDatabase(_currentOrderNum);
            OrderItemsTheGrid.SetDataBinding(orderItemsTable, null, false);

            var Itemrows = orderItemsTable.Rows.Count;

            if (Itemrows == 0)

            {
                ClearActions();
            }
        }


        public void LoadOnlyItems()
        {

            var orderItemsTable = _orderItemsAppService.LoadFromDatabase(_currentOrderNum);
            OrderItemsTheGrid.SetDataBinding(orderItemsTable, null, false);

            var Itemrows = orderItemsTable.Rows.Count;

            if (Itemrows == 0)

            {
                ClearActions();
            }

        }

        // fill control


        private void ClearActions()
        {

            tbxOrderID.Clear();
            tbxCustomer.Clear();
            tbxCustomerDescription.Clear();
            cbxOrderItemStatus.SelectedItem = OrderStatusEnum.Open;
            tbxLine.Clear();
            tbxItem.Clear();
            tbxItemDescription.Clear();
            tbxBrand.Clear();
            tbxQty.Clear();
            tbxUnitPrice.Clear();
            cbxOrderItemStatus.SelectedItem = OrderItemStatusEnum.Ordered;
            tbxTotalPrice.Clear();


        }


        private void FillItemFields(DataRow row)
        {
            _filling = true;

            //if (_currentOrderNum == 0)
            //{
            //    return;
            //}

            _currentOrderNum = row.Field<int>("OrderNumber");

            var orderLine = row.Field<Int64>("line").ToString();
            var OrderItemProductCode = row.Field<string>("productcode");
            var OrderItemProduct = row.Field<string>("product");
            var OrderItemBrand = row.Field<string>("brand");
            var OrderItemQtyOrdered = row.Field<decimal>("Qtyordered").ToString("0.00");
            var OrderItemUnitPrice = row.Field<decimal>("unitprice").ToString("C");
            var OrderItemTotalPrice = row.Field<decimal>("TotalPrice").ToString("C");
            //

            tbxLine.Text = orderLine;
            tbxItem.Text = OrderItemProductCode;
            tbxItemDescription.Text = OrderItemProduct;
            tbxBrand.Text = OrderItemBrand;
            tbxQty.Text = OrderItemQtyOrdered;
            tbxUnitPrice.Text = OrderItemUnitPrice;
            tbxTotalPrice.Text = OrderItemTotalPrice;



            _filling = false;
        }

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

        #endregion


        #region order tools
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClearActions();
            _newItem = true;
            //if (MessageBox.Show("Please choose the customer for the new order: ", "New Order", MessageBoxButtons.OK) == DialogResult.OK)
            //{
            //    ShowCustomerPick();
            //    LoadData();
            //}

            ShowCustomerPick();
            LoadData();

            tbxLine.Clear();
            tbxItem.Clear();
            tbxItemDescription.Clear();
            tbxBrand.Clear();
            tbxQty.Clear();
            tbxUnitPrice.Clear();
            cbxOrderItemStatus.SelectedItem = OrderItemStatusEnum.Ordered;
            tbxTotalPrice.Clear();

            _newItem = false;

            OrderItemsGrid.MoveLast();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var r = _orderAppService.DeleteOrder(_currentOrderNum);

            if (!r.Success)
            {
                this.NotifyError(r);
                return;
            }
            else
            {
                LoadData();



            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            var customerId = _currentCustomerId;
            // Here I'm using this specific Guid, cause it will be defined in another selection form.
            // So temporaily, it's this fixed value

            if (_newItem)
            {
                var r = _orderAppService.NewOrder(customerId);

                if (!r.Success)
                {
                    this.NotifyError(r);
                    return;
                }
                else
                {
                    LoadData();
                }
            }
            else
            {

                var r = _orderAppService.UpdateOrder(int.Parse(tbxOrderID.Text), (OrderStatusEnum)Enum.Parse(typeof(OrderStatusEnum), cbxOrderStatus.SelectedItem.ToString()));

                if (!r.Success)
                {
                    this.NotifyError(r);
                    return;

                }
                else
                {
                    LoadData();
                }


                // int orderNumber, Guid customerID, OrderStatusEnum orderStatus

            }


        }



        public void ShowCustomerPick()
        {
            CustomerPick customerpickDialog = new CustomerPick();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (customerpickDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                this._currentCustomerId = customerpickDialog._currentId;
            }


        }

        public void ShowItemsPick()

        {
            ItemPick itempickDialog = new ItemPick();
            if (itempickDialog.ShowDialog(this) == DialogResult.OK)
            {
                this._currentOrderItemId = itempickDialog._currentitemId;
                var r = _orderItemsAppService.InsertItem(_currentOrderNum, _currentOrderItemId);
                if (!r.Success)
                {
                    this.NotifyError(r);

                }
                else
                {
                    LoadOnlyItems();





                }
            }
        }

        public void ShowOrdersPick()
        {

            OrdersPick ordersPickDialog = new OrdersPick();


            if (ordersPickDialog.ShowDialog(this) == DialogResult.OK)
            {
                this._currentOrderNum = ordersPickDialog._currentOrderNum;
                _order = _orderAppService.GetOrderByNumber(this._currentOrderNum);
                if (_order == null)
                {
                    MessageBox.Show("Could not find the selected order. Please try again.");
                    return;
                }
                LoadOnlyItems();
            }

            if (_order == null)
            {
                return;
            }

            var OrderNumber = _order.OrderNumber.ToString();
            var statusOrder = _order.OrderStatus;
            var CustomerCode = _order.CustomerCode.ToString();
            var CustomerName = _order.CustomerName.ToString();

            tbxOrderID.Text = OrderNumber;
            tbxCustomer.Text = CustomerCode;
            tbxCustomerDescription.Text = CustomerName;
            cbxOrderStatus.SelectedItem = statusOrder;
            ordersPickDialog.Close();

        }

        private void tbxOrderID_KeyDown(object sender, KeyEventArgs e)
        {

           // ShowOrdersPick();
            // LoadData();
        }


        #endregion

        private void tbxOrderID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                var a = "";
                var ordervalue = tbxOrderID.Text.Trim();
               if(ordervalue == null)
                    ShowOrdersPick();
               else if (ordervalue.Equals(a))
                    ShowOrdersPick();
           

              var ordervalueint = 0;
              int.TryParse(tbxOrderID.Text, out ordervalueint);

                if (ordervalueint == 0)
                {
                    MessageBox.Show("Could not find the informed order, please choose from our OrderPick options.");
                    ShowOrdersPick();
                    LoadOnlyItems();
                }
                else
                {
                    _currentOrderNum = ordervalueint;
                    _order = _orderAppService.GetOrderByNumber(ordervalueint);

                    if (_order == null)
                    {
                        MessageBox.Show("Could not find the informed order, please choose from our OrderPick options.");
                        ShowOrdersPick();
                    }
                    else 
                    {
                        LoadOnlyItems();
                    }

                    var OrderNumber = _order.OrderNumber.ToString();
                    var statusOrder = _order.OrderStatus;
                    var CustomerCode = _order.CustomerCode.ToString();
                    var CustomerName = _order.CustomerName.ToString();

                    tbxOrderID.Text = OrderNumber;
                    tbxCustomer.Text = CustomerCode;
                    tbxCustomerDescription.Text = CustomerName;
                    cbxOrderStatus.SelectedItem = statusOrder;
                }
                //int milliseconds = 2000;
                //Thread.Sleep(milliseconds);
            }

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            _newItem = true;
            ClearActions();
            if (_currentOrderNum == 0)
            { 
                return;
            }

            ShowItemsPick();
            _newItem= false;    

        }

        private void ConfigureGrid()
        {
            OrderItemsTheGrid.AlternatingRows = true;
            OrderItemsTheGrid.OddRowStyle.BackColor = Color.WhiteSmoke;
            OrderItemsTheGrid.EvenRowStyle.BackColor = Color.White;
            foreach (C1DisplayColumn item in OrderItemsTheGrid.Splits[0].DisplayColumns)
            {
                    // Block Item Editing 
             item.Locked = true;

              if (item.DataColumn.DataField.ToLower() == "customerid".ToLower())
              {
                  item.Visible = false;
              }
              if (item.DataColumn.DataField.ToLower() == "customername".ToLower())
              {
                  item.Visible = false;
              }
                }
            }

        }
    }


    #region Extension Tests
    public static class MyExtension
    {
        public static string ToDoubleString2(int valorInteiro)
        {
            // 100
            // "100"
            // 100.0
            // "100.00"
            return double.Parse(valorInteiro.ToString()).ToString();

        }
        public static string ToDoubleString(int valorInteiro)
        {
            // 100
            // "100"
            // 100.0
            // "100.00"
            return double.Parse(valorInteiro.ToString()).ToString();
        }


    }



    #endregion
