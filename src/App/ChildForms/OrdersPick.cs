using MyManagementApp.Application.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestandoComponentes.ChildForms
{
    public partial class OrdersPick : Form
    {


        public int _currentOrderNum;

        private readonly OrdersAppService _orderAppService;

        public OrdersPick()
        {
            InitializeComponent();
            this.Shown += OrdersPick_Shown;
            _orderAppService = new OrdersAppService();
        }

        private void OrdersPick_Shown(object sender, EventArgs e)
        {
            LoadData();
            ConfigureGrid();
        }

        private void LoadData()
        {
            var ordersTable = _orderAppService.LoadFromDatabase();
            OrdersGrid.SetDataBinding(ordersTable, null, false);
            ConfigureGrid();

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
    }
}
