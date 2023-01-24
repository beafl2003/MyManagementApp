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
        public Guid _currentitemId;
        private readonly OrdersAppService _orderAppService;
        private readonly ProductAppService _productsAppService;
        public readonly int _currentOrderid;
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
            ConfigureGrid();
        }

        private void ConfigureGrid()
        {
            // zebra design
            ItemsGrid.AlternatingRows = true;
            ItemsGrid.OddRowStyle.BackColor = Color.WhiteSmoke;
            ItemsGrid.EvenRowStyle.BackColor = Color.White;

            foreach (C1.Win.C1TrueDBGrid.C1DisplayColumn item in ItemsGrid.Splits[0].DisplayColumns)
            {

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
                    item.DataColumn.Caption = "Description";
                    item.Width = 320;
                }
                if (item.DataColumn.DataField.ToLower() == "brand".ToLower())
                {
                    item.DataColumn.Caption = "Brand";
                }
                if (item.DataColumn.DataField.ToLower() == "price".ToLower())
                {
                    item.DataColumn.Caption = "Price";

                    if (item.DataColumn.DataField.ToLower() == "active".ToLower())
                    {
                        item.DataColumn.Caption = "Active";
                    }

                }
            }
        }

        private void ItemsGrid_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            var currentRow = ItemsGrid.Row;
            if (e.LastRow == currentRow)
                return;
            var table = (DataTable)ItemsGrid.DataSource;
            var row = table.Rows[currentRow];
            FillFields(row);
        }

        private void FillFields(DataRow row)
        {
            _currentitemId = row.Field<Guid>("id");
            var productCode = row.Field<string>("code");
            var productName = row.Field<string>("name");

            tbxProductCode.Text = productCode;
            tbxProductName.Text = productName;
        }

        private void ItemsGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var currentid = this._currentitemId;
                if (currentid == Guid.Empty)
                    MessageBox.Show("Could not pick this item, please try again.");
                else
                    this.Close();
                   
            }
        }
    }
}
