using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MyManagementApp.Application.Services;
using MyManagementApp.Data.Repositories;
using MyManagementApp.Domain;
using MyManagementApp.Domain.Core;
using MyManagementApp.Domain.Enums;
using TestandoComponentes.Extensions;

namespace MyManagementApp.ChildForms
{
    public partial class CustomersForm : Form
    {

        #region presentation
        private bool _editing;
        private bool _newItem;
        private bool _loading;
        private bool _filling;
        private Guid _currentId;
        private readonly CustomerAppService _customerAppService;


        public CustomersForm()
        {
            InitializeComponent();


            this.cbxCustomerStatus.DataSource = Enum.GetValues(typeof(CustomerStatusEnum));
            this.Shown += CustomersForm_Shown;
            this.btnCustomerSave.Click += btnCustomerSave_Click;
            this.btnAdd.Click += btnCustomerAdd_Click;
            this.btnDelete.Click += btnCustomerDelete_Click;
            this.btnCancel.Click += BtnCancel_Click;

            this.CustomerGridNew.RowColChange += CustomerGridNew_RowColChange;

            // tbxcustomerID
            // tbxcustomerName
            // cbxCustomerStatus

            tbxcustomerID.TextChanged += TbxcustomerID_TextChanged;
            tbxcustomerName.TextChanged += TbxcustomerName_TextChanged;
            cbxCustomerStatus.TextChanged += CbxCustomerStatus_TextChanged;


            _customerAppService = new CustomerAppService();
        }


        // tools
        private void CustomersForm_Shown(object sender, EventArgs e)
        {
            LoadData();
            EnabledDisabledBtn();
        }
        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {

            ClearActions();

            // form status
            _editing = true;
            _newItem = true;
            EnabledDisabledBtn();
        }
        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            if (_newItem)
            {
                var r = _customerAppService.NewCustomer(tbxcustomerID.Text, tbxcustomerName.Text, (CustomerStatusEnum)Enum.Parse(typeof(CustomerStatusEnum),
                    cbxCustomerStatus.SelectedItem.ToString()));

                if(!r.Success)
                {
                    this.NotifyError(r);
                    return;
                }                 
            }
            else
            {
                var id = _currentId;
                var r = _customerAppService.UpdateCustomer(tbxcustomerID.Text, tbxcustomerName.Text, (CustomerStatusEnum)Enum.Parse(typeof(CustomerStatusEnum),
                    cbxCustomerStatus.SelectedItem.ToString()), id);

                if (!r.Success)
                {
                    this.NotifyError(r);
                    return;
                }
            }
            
     
            LoadData();

            // form status
            _newItem = false;
            _editing = false;
            EnabledDisabledBtn();
        }
        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            var id = _currentId;
            var r = _customerAppService.DeleteCustomer(id);
            if (!r.Success)
            {
                this.NotifyError(r);
                return;
            }


            LoadData();

            ClearActions();

            // form status
            _newItem = false;
            _editing = false;
            EnabledDisabledBtn();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            LoadData();

            // form status
            _newItem = false;
            _editing = false;
            EnabledDisabledBtn();
        }
        private void EnabledDisabledBtn()
        {
            if(_editing)
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
        private void CustomerGridNew_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            var currentRow = CustomerGridNew.Row;
            if (e.LastRow == currentRow)
                return;
            var table = (DataTable)CustomerGridNew.DataSource;
            var row = table.Rows[currentRow];
            FillFields(row);
        }
        private void ConfigureGrid()
        {
           

            // zebra design
            CustomerGridNew.AlternatingRows = true;
            CustomerGridNew.OddRowStyle.BackColor = Color.WhiteSmoke;
            CustomerGridNew.EvenRowStyle.BackColor = Color.White;

            foreach (C1.Win.C1TrueDBGrid.C1DisplayColumn item in CustomerGridNew.Splits[0].DisplayColumns)
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
                    item.Width = 300;
                }
                if (item.DataColumn.DataField.ToLower() == "active".ToLower())
                {
                    item.DataColumn.Caption = "Active";
                }

            }
        }
        private void ClearActions()
        {
            tbxcustomerID.Clear();
            tbxcustomerName.Clear();
            cbxCustomerStatus.SelectedItem = CustomerStatusEnum.Active;
            tbxcustomerID.Focus();
        }

        // fill control
        private void FillFields(DataRow row)
        {
            _filling = true;

            _currentId = row.Field<Guid>("id");

            var customerCode = row.Field<string>("code");
            var customerName = row.Field<string>("name");
            var active = row.Field<bool>("active");


            tbxcustomerID.Text = customerCode;
            tbxcustomerName.Text = customerName;
            cbxCustomerStatus.SelectedItem = active ? CustomerStatusEnum.Active : CustomerStatusEnum.Inactive;


            _filling = false;
        }

        // load
        private void LoadData()
        {
            _loading = true;

       
            var customersTable = _customerAppService.LoadFromDatabase();
            CustomerGridNew.SetDataBinding(customersTable, null, false);
            ConfigureGrid();

            _loading = false;
        }


        // control events
        private void CbxCustomerStatus_TextChanged(object sender, EventArgs e)
        {
            if (_filling)
                return;

            _editing = true;
            EnabledDisabledBtn();
        }

        private void TbxcustomerName_TextChanged(object sender, EventArgs e)
        {
            if (_filling)
                return;

            _editing = true;
            EnabledDisabledBtn();
        }

        private void TbxcustomerID_TextChanged(object sender, EventArgs e)
        {
            if (_filling)
                return;

            _editing = true;
            EnabledDisabledBtn();
        }

        #endregion
    }

}
