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
    public partial class ItemPick : Form
    {
        private readonly OrdersAppService _orderAppService;
        private readonly ProductAppService _productsAppService;
        public ItemPick()
        {
            InitializeComponent();

            this.Shown += ItemPick_Shown;
            _orderAppService = new OrdersAppService();
            _productsAppService = new ProductAppService();
        }

        private void ItemPick_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var productstable = _productsAppService.LoadFromDatabase();
            ItemsGrid.SetDataBinding(productstable, null, false);
        }
    }
}
