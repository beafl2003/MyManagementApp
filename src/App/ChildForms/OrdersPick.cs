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


        }


        private void ConfigureGrid()
        {


            // zebra design
            OrdersGrid.AlternatingRows = true;
            OrdersGrid.OddRowStyle.BackColor = Color.WhiteSmoke;
            OrdersGrid.EvenRowStyle.BackColor = Color.White;
        }
    }
}
