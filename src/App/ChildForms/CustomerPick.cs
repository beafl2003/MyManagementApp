﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MyManagementApp.Application.Services;

namespace MyManagementApp.ChildForms
{
    public partial class CustomerPick : Form
    {

        #region Presentation
        private Guid _currentId;
        private readonly CustomerAppService _customerAppService;

        
        public CustomerPick()
        {
            InitializeComponent();

            this.Shown += CustomerPick_Shown;
            //this.CustomerGrid.RowColChange += CustomerGrid_RowColChange;

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
                    item.Width = 300;
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


            //
        }


    }

    #endregion
}


