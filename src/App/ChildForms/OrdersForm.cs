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

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadData();
            //EnabledDisabledBtn();
        }

        public void LoadData()
        {

            var ordersTable = _orderAppService.LoadFromDatabase();
            OrderItemsGrid.SetDataBinding(ordersTable, null, false);


            var rows = ordersTable.Rows.Count;

            if (rows == 0)
            
            {
                ClearActions();
            };

        }




        // fill control


        private void ClearActions()
        {

            tbxOrderID.Clear();
            tbxCustomer.Clear();
            tbxCustomerDescription.Clear();
            cbxOrderItemStatus.SelectedItem = OrderStatusEnum.Open;
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




        #region order tools
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _newItem = true;

            ShowMyDialogBox();
            LoadData();

            // seleção do cliente (janela de diálogo - modal)

            _newItem = false;
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

                var r = _orderAppService.UpdateOrder(int.Parse(tbxOrderID.Text), (OrderStatusEnum)Enum.Parse(typeof(OrderStatusEnum),cbxOrderStatus.SelectedItem.ToString()));

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



        public void ShowMyDialogBox()
        {
            CustomerPick customerpickDialog = new CustomerPick();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (customerpickDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                this._currentCustomerId = customerpickDialog._currentId;
            }

            customerpickDialog.Dispose();
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