using System;
using System.Windows.Forms;
using AppCore.Enums.ProductStatusEnum;
using System.Collections.Generic;
using MyProducts;

namespace MyManagementApp.ChildForms

{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();

            cbxProdStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
        }

        private void tbxProductID_Leave(object sender, EventArgs e)
        {
            if (tbxProductID.Text.Length > 0)
            {
                string prodID = tbxProductID.Text;
            }


        }

        private void tbxProdDescription_Leave(object sender, EventArgs e)
        {
            if (tbxProdDescription.Text.Length > 0)
            {
                string prodDescript = tbxProdDescription.Text;
            }


        }

        private void btnProdSave_Click(object sender, EventArgs e)
        {
            var productsList = new List<Product>()
            {
                new Product() { ProductID = tbxProductID.Text, ProductName = tbxProdDescription.Text}
            };
        }
    }
}

