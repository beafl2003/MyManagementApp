using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MyManagementApp.Application.Services;
using TestandoComponentes.Extensions;
using MyManagementApp.ChildForms;
using MyManagementApp.Domain.Core;

namespace MyManagementApp.ChildForms
{
    public partial class CustomerPick : Form
    {

        #region Presentation
        public Guid _currentId;
        private readonly CustomerAppService _customerAppService;
        private readonly OrdersAppService _orderAppService;
        private readonly OrderRepository _orderRepository;
        public bool _newOrder;
        public DataTable _orders;


        public CustomerPick()
        {
            InitializeComponent();

            this.Shown += CustomerPick_Shown;
            this.CustomerGrid.RowColChange += CustomerGrid_RowColChange;


            _orderAppService = new OrdersAppService();
            _customerAppService = new CustomerAppService();


        }





        private void CustomerPick_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {



            var customersTable2 = _customerAppService.LoadFromDatabase();
            CustomerGrid.SetDataBinding(customersTable2, null, false);
            ConfigureGrid();


        }

        // grid
        private void CustomerGrid_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            var currentRow = CustomerGrid.Row;
            if (e.LastRow == currentRow)
                return;
            var table = (DataTable)CustomerGrid.DataSource;
            var row = table.Rows[currentRow];
            FillFields(row);
        }

        private void ConfigureGrid()
        {


            // zebra design
            CustomerGrid.AlternatingRows = true;
            CustomerGrid.OddRowStyle.BackColor = Color.WhiteSmoke;
            CustomerGrid.EvenRowStyle.BackColor = Color.White;

            foreach (C1.Win.C1TrueDBGrid.C1DisplayColumn item in CustomerGrid.Splits[0].DisplayColumns)
            {

                // Block Item Editing 
                item.Locked = true;

                if (item.DataColumn.DataField.ToLower() == "id".ToLower())
                {
                    item.Visible = false;
                }
                if (item.DataColumn.DataField.ToLower() == "code".ToLower())
                {
                    item.DataColumn.Caption = "Code";
                }
                if (item.DataColumn.DataField.ToLower() == "name".ToLower())
                {
                    item.DataColumn.Caption = "Name";
                    item.Width = 410;
                }
                if (item.DataColumn.DataField.ToLower() == "active".ToLower())
                {
                    item.DataColumn.Caption = "Active";
                }

            }
        }


        //fill control
        private void FillFields(DataRow row)
        {


            _currentId = row.Field<Guid>("id");
            var customerCode = row.Field<string>("code");
            var customerName = row.Field<string>("name");
            tbxcustomerID.Text = customerCode;
            tbxcustomerName.Text = customerName;




        }

        private void CustomerGrid_Enter(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            // aqui coloco a ação gerada pelo enter

            var customerId = this._currentId;
            if (_newOrder = true)
            {
                var r = _orderAppService.NewOrder(customerId);
                if (!r.Success)
                {
                    this.NotifyError(r);

                }
                else
                {
                    this.Close();



                }
            }
            else
            {
                _orders = _orderAppService.GetOrdersByCustomer(customerId);
                return;
            }
        }

        private void CustomerGrid_DoubleClick(object sender, EventArgs e)
        {
            var customerId = this._currentId;
            var r = _orderAppService.NewOrder(customerId);
            if (!r.Success)
            {
                this.NotifyError(r);

            }
            else
            {
                this.Close();
                //OrdersForm.CustomerPicked = true;



            }


        }

        #endregion

        private void CustomerGrid_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                //Do something
                //e.Handled = true;
                if (_newOrder == true)
                {
                    var customerId = this._currentId;
                    var r = _orderAppService.NewOrder(customerId);
                    if (!r.Success)
                    {
                        this.NotifyError(r);

                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();



                    }
                }
                else
                {
                    var customerId = this._currentId;
                    if (customerId == null)
                    {
                        this.NotifyError();
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    //_orders = _orderAppService.GetOrdersByCustomer(customerId);

                }

            }

        }
    }
}





