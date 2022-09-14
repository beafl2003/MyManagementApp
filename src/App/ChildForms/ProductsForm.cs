using System;
using System.Windows.Forms;
using AppCore.Enums.ProductStatusEnum;
using System.Collections.Generic;
using MyProducts;

namespace MyManagementApp.ChildForms

{
    public partial class ProductsForm : Form
    {

        #region Presentation

        public ProductsForm()
        {
            InitializeComponent();

            this.cbxProdStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            this.Shown += ProductsForm_Shown;
            this.btnProdSave.Click += btnProdSave_Click;

        }

        private void ProductsForm_Shown(object sender, EventArgs e)
        {
            // LoadData();
        }


        private void btnProdSave_Click(object sender, EventArgs e)
        {

            // validations
            if (tbxProductID.Text.Length > 0 && tbxProdDescription.Text.Length > 0 && cbxProdStatus.SelectedItem != null && tbxProdBrand.Text.Length > 0 && txtProdPrice.Text.Length > 0)
            {
                SaveProduct(tbxProductID.Text, tbxProdDescription.Text, tbxProdBrand.Text, txtProdPrice.Text, (ProductStatusEnum)Enum.Parse(typeof(ProductStatusEnum),
                  cbxProdStatus.SelectedItem.ToString()));
            }
            else
            {
                string message = "Some information probably is missing. Verify and try again";
                string caption = "Warning";
                DialogResult result;
                result = MessageBox.Show(message, caption);
            }


        }


        #endregion

        #region application layer

        private List<Product> _productsList = new List<Product>();
        private void SaveProduct(string productCode, string productName, string brand, string price, ProductStatusEnum status)
        {


            var product = new Product()
            {

                ProductCode = productCode,
                ProductName = productName,
                Brand = brand,
                Price = price,
                Status = status
            };
            //  _productsList.Add(product);

        }

        #endregion
    }
}