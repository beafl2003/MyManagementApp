using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using MyManagementApp.Domain.Enums;
using MyManagementApp.Domain;
using MyManagementApp.Domain.Core;
using MyManagementApp.Application.Services;
using System.Linq;
using TestandoComponentes.Extensions;

namespace MyManagementApp.ChildForms

{
    public partial class ProductsForm : Form
    {

        #region config
        //private readonly string _server = @"ANNA-BEATRIZ\SQLEXPRESS";
        #endregion

        #region Presentation
        private bool _editing;
        private bool _newItem;
        private bool _loading;
        private bool _filling;
        private Guid _currentId;
        private readonly ProductAppService _productAppService;

        public ProductsForm()
        {
            InitializeComponent();

            this.cbxProdStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            this.Shown += ProductsForm_Shown;
            this.btnProdSave.Click += btnProdSave_Click;
            this.btnAdd.Click += btnProdAdd_Click;
            this.btnDelete.Click += btnProdDelete_Click;
            this.btnCancel.Click += BtnCancel_Click;

            this.ProductGridNew.RowColChange += ProductGridNew_RowColChange;

            tbxProductID.TextChanged += TbxProductID_TextChanged;
            tbxProdDescription.TextChanged += TbxProdDescription_TextChanged;
            cbxProdStatus.TextChanged += CbxProdStatus_TextChanged;
            tbxProdBrand.TextChanged += TbxProdBrand_TextChanged;
            txtProdPrice.TextChanged += TxtProdPrice_TextChanged;

            _productAppService = new ProductAppService();
        }




        // Tools 
        private void ProductsForm_Shown(object sender, EventArgs e)
        {
            LoadData();
            EnabledDisabledBtn();
        }


        private void btnProdAdd_Click(object sender, EventArgs e)
        {
            _newItem = true;

            ClearActions();

            // form buttons status
            _editing = true;
            EnabledDisabledBtn();

        }
        private void btnProdSave_Click(object sender, EventArgs e)
        {


            if (_newItem)
            {
                var r = _productAppService.NewProduct(tbxProductID.Text, tbxProdDescription.Text, tbxProdBrand.Text, txtProdPrice.Text, (ProductStatusEnum)Enum.Parse(typeof(ProductStatusEnum),
                      cbxProdStatus.SelectedItem.ToString()));

                if (!r.Success)
                {
                    this.NotifyError(r);
                    return;
                }
            }
            else
            {
                var id = _currentId;
                var r = _productAppService.UpdateProduct(tbxProductID.Text, tbxProdDescription.Text, tbxProdBrand.Text, txtProdPrice.Text, (ProductStatusEnum)Enum.Parse(typeof(ProductStatusEnum),
                      cbxProdStatus.SelectedItem.ToString()), id);

                if (!r.Success)
                {
                    this.NotifyError(r);
                    return;
                }
            }


            LoadData();

            // Form Status
            _newItem = false;
            _editing = false;
            EnabledDisabledBtn();



        }

        private void btnProdDelete_Click(object sender, EventArgs e)
        {
            var id = _currentId;
            var r = _productAppService.DeleteProduct(id);
            if (!r.Success)
            {
                this.NotifyError(r);
                return;
            }

            LoadData();
            ClearActions();

            //Form Status

            _newItem = false;
            _editing = false;
            EnabledDisabledBtn();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            LoadData();

            // Form Status

            _newItem = false;
            _editing = false;
            EnabledDisabledBtn();
        }

        private void EnabledDisabledBtn()
        {
            if (_editing)
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Enabled = false;
            }
        }

        // grid

        private void ProductGridNew_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            var currentRow = ProductGridNew.Row;
            if (e.LastRow == currentRow)
                return;
            var table = (DataTable)ProductGridNew.DataSource;
            var row = table.Rows[currentRow];
            FillFields(row);
        }

        private void ConfigureGrid()
        {

            // Zebra Design
            ProductGridNew.AlternatingRows = true;
            ProductGridNew.OddRowStyle.BackColor = Color.WhiteSmoke;
            ProductGridNew.EvenRowStyle.BackColor = Color.White;

            foreach (C1.Win.C1TrueDBGrid.C1DisplayColumn item in ProductGridNew.Splits[0].DisplayColumns)
            {

                // Block itens editing
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
                    item.Width = 300;
                }
                if (item.DataColumn.DataField.ToLower() == "brand".ToLower())
                {
                    item.DataColumn.Caption = "Brand";
                }
                if (item.DataColumn.DataField.ToLower() == "price".ToLower())
                {
                    item.DataColumn.Caption = "Price";
                }
                if (item.DataColumn.DataField.ToLower() == "active".ToLower())
                {
                    item.DataColumn.Caption = "Active";
                }

            }

        }

        private void ClearActions()
        {
            tbxProductID.Clear();
            tbxProdDescription.Clear();
            txtProdPrice.Clear();
            tbxProdBrand.Clear();
            cbxProdStatus.SelectedItem = ProductStatusEnum.Active;

            tbxProductID.Focus();
        }

        // fill control

        private void FillFields(DataRow row)
        {
            _filling = true;
            _currentId = row.Field<Guid>("id");

            var productCode = row.Field<string>("code");
            var productName = row.Field<string>("name");
            var brand = row.Field<string>("brand");
            var price = row.Field<string>("price");
            var active = row.Field<bool>("active");

            tbxProductID.Text = productCode;
            tbxProdDescription.Text = productName;
            tbxProdBrand.Text = brand;
            txtProdPrice.Text = price;
            cbxProdStatus.SelectedItem = active ? ProductStatusEnum.Active : ProductStatusEnum.Inactive;

            _filling = false;
        }

        // load
        private void LoadData()
        {
            _loading = true;
            var productsTable = _productAppService.LoadFromDatabase();
            ProductGridNew.SetDataBinding(productsTable, null, false);
            ConfigureGrid();

            _loading = false;
        }

        // Control Events


        private void TbxProductID_TextChanged(object sender, EventArgs e)
        {
            if (_filling)
                return;
            _editing = true;
            EnabledDisabledBtn();
        }

        private void TbxProdDescription_TextChanged(object sender, EventArgs e)
        {
            if (_filling)
                return;
            _editing = true;
            EnabledDisabledBtn();
        }


        private void CbxProdStatus_TextChanged(object sender, EventArgs e)
        {
            if (_filling)
                return;
            _editing = true;
            EnabledDisabledBtn();
        }

        private void TbxProdBrand_TextChanged(object sender, EventArgs e)
        {
            if (_filling)
                return;
            _editing = true;
            EnabledDisabledBtn();
        }

        private void TxtProdPrice_TextChanged(object sender, EventArgs e)
        {
            if (_filling)
                return;
            _editing = true;
            EnabledDisabledBtn();
        }
        #endregion    
    }
    
}

      
