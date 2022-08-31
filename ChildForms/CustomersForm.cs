﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Enums.CustomerStatusEnum;

namespace MyManagementApp.ChildForms
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();

           cbxCustomerStatus.DataSource = Enum.GetValues(typeof(CustomerStatusEnum));

        }
    }
}
