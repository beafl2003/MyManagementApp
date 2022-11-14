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

namespace MyManagementApp.ChildForms
{
    public partial class OrdersForm : Form
    {
        #region Config
        #endregion

        #region Presentation
        public OrdersForm()
        {
            InitializeComponent();
            this.cbxOrderStatus.DataSource = Enum.GetValues(typeof(OrderStatusEnum));

        }

        #endregion
    }
}
