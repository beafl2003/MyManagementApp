
namespace MyManagementApp.ChildForms
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.lbProdStatus = new System.Windows.Forms.Label();
            this.cbxProdStatus = new System.Windows.Forms.ComboBox();
            this.lbProdDescription = new System.Windows.Forms.Label();
            this.lbProdID = new System.Windows.Forms.Label();
            this.tbxProdPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tbxProductID = new System.Windows.Forms.TextBox();
            this.tbxProdDescription = new System.Windows.Forms.TextBox();
            this.tbxProdBrand = new System.Windows.Forms.TextBox();
            this.lbProdBrand = new System.Windows.Forms.Label();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.lbProdPrice = new System.Windows.Forms.Label();
            this.btnProdSave = new System.Windows.Forms.Button();
            this.ProductGrid = new System.Windows.Forms.DataGridView();
            this.ProductGridNew = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.ProductPanel.SuspendLayout();
            this.tbxProdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridNew)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.lbProdStatus);
            this.ProductPanel.Controls.Add(this.cbxProdStatus);
            this.ProductPanel.Controls.Add(this.lbProdDescription);
            this.ProductPanel.Controls.Add(this.lbProdID);
            this.ProductPanel.Controls.Add(this.tbxProdPanel);
            this.ProductPanel.Location = new System.Drawing.Point(25, 12);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(738, 64);
            this.ProductPanel.TabIndex = 4;
            // 
            // lbProdStatus
            // 
            this.lbProdStatus.Location = new System.Drawing.Point(602, 9);
            this.lbProdStatus.Name = "lbProdStatus";
            this.lbProdStatus.Size = new System.Drawing.Size(100, 17);
            this.lbProdStatus.TabIndex = 7;
            this.lbProdStatus.Text = "Status";
            // 
            // cbxProdStatus
            // 
            this.cbxProdStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cbxProdStatus.FormattingEnabled = true;
            this.cbxProdStatus.Location = new System.Drawing.Point(605, 30);
            this.cbxProdStatus.Name = "cbxProdStatus";
            this.cbxProdStatus.Size = new System.Drawing.Size(121, 24);
            this.cbxProdStatus.TabIndex = 5;
            // 
            // lbProdDescription
            // 
            this.lbProdDescription.Location = new System.Drawing.Point(128, 9);
            this.lbProdDescription.Name = "lbProdDescription";
            this.lbProdDescription.Size = new System.Drawing.Size(100, 17);
            this.lbProdDescription.TabIndex = 4;
            this.lbProdDescription.Text = "Description";
            // 
            // lbProdID
            // 
            this.lbProdID.AutoSize = true;
            this.lbProdID.Location = new System.Drawing.Point(5, 9);
            this.lbProdID.Name = "lbProdID";
            this.lbProdID.Size = new System.Drawing.Size(74, 17);
            this.lbProdID.TabIndex = 6;
            this.lbProdID.Text = "Product ID";
            // 
            // tbxProdPanel
            // 
            this.tbxProdPanel.ColumnCount = 2;
            this.tbxProdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.71713F));
            this.tbxProdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.28288F));
            this.tbxProdPanel.Controls.Add(this.tbxProductID, 0, 0);
            this.tbxProdPanel.Controls.Add(this.tbxProdDescription, 1, 0);
            this.tbxProdPanel.Location = new System.Drawing.Point(5, 29);
            this.tbxProdPanel.Name = "tbxProdPanel";
            this.tbxProdPanel.RowCount = 1;
            this.tbxProdPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbxProdPanel.Size = new System.Drawing.Size(594, 32);
            this.tbxProdPanel.TabIndex = 5;
            // 
            // tbxProductID
            // 
            this.tbxProductID.AccessibleDescription = "";
            this.tbxProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxProductID.BackColor = System.Drawing.SystemColors.Info;
            this.tbxProductID.Location = new System.Drawing.Point(3, 3);
            this.tbxProductID.Name = "tbxProductID";
            this.tbxProductID.Size = new System.Drawing.Size(117, 22);
            this.tbxProductID.TabIndex = 0;
            this.tbxProductID.Tag = "";
            this.tbxProductID.Leave += new System.EventHandler(this.tbxProductID_Leave);
            // 
            // tbxProdDescription
            // 
            this.tbxProdDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxProdDescription.BackColor = System.Drawing.SystemColors.Info;
            this.tbxProdDescription.Location = new System.Drawing.Point(126, 3);
            this.tbxProdDescription.Name = "tbxProdDescription";
            this.tbxProdDescription.Size = new System.Drawing.Size(465, 22);
            this.tbxProdDescription.TabIndex = 1;
            this.tbxProdDescription.Leave += new System.EventHandler(this.tbxProductID_Leave);
            // 
            // tbxProdBrand
            // 
            this.tbxProdBrand.AccessibleDescription = "";
            this.tbxProdBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxProdBrand.BackColor = System.Drawing.SystemColors.Window;
            this.tbxProdBrand.Location = new System.Drawing.Point(33, 105);
            this.tbxProdBrand.Name = "tbxProdBrand";
            this.tbxProdBrand.Size = new System.Drawing.Size(173, 22);
            this.tbxProdBrand.TabIndex = 5;
            this.tbxProdBrand.Tag = "";
            // 
            // lbProdBrand
            // 
            this.lbProdBrand.AutoSize = true;
            this.lbProdBrand.Location = new System.Drawing.Point(30, 85);
            this.lbProdBrand.Name = "lbProdBrand";
            this.lbProdBrand.Size = new System.Drawing.Size(46, 17);
            this.lbProdBrand.TabIndex = 8;
            this.lbProdBrand.Text = "Brand";
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Location = new System.Drawing.Point(221, 105);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(133, 22);
            this.txtProdPrice.TabIndex = 9;
            // 
            // lbProdPrice
            // 
            this.lbProdPrice.AutoSize = true;
            this.lbProdPrice.Location = new System.Drawing.Point(218, 85);
            this.lbProdPrice.Name = "lbProdPrice";
            this.lbProdPrice.Size = new System.Drawing.Size(40, 17);
            this.lbProdPrice.TabIndex = 10;
            this.lbProdPrice.Text = "Price";
            // 
            // btnProdSave
            // 
            this.btnProdSave.Location = new System.Drawing.Point(676, 105);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(75, 23);
            this.btnProdSave.TabIndex = 11;
            this.btnProdSave.Text = "Save";
            this.btnProdSave.UseVisualStyleBackColor = true;
            // 
            // ProductGrid
            // 
            this.ProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGrid.Location = new System.Drawing.Point(12, 133);
            this.ProductGrid.Name = "ProductGrid";
            this.ProductGrid.RowHeadersWidth = 51;
            this.ProductGrid.RowTemplate.Height = 24;
            this.ProductGrid.Size = new System.Drawing.Size(776, 150);
            this.ProductGrid.TabIndex = 12;
            // 
            // ProductGridNew
            // 
            this.ProductGridNew.GroupByCaption = "Drag a column header here to group by that column";
            this.ProductGridNew.Location = new System.Drawing.Point(12, 289);
            this.ProductGridNew.Name = "ProductGridNew";
            this.ProductGridNew.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.ProductGridNew.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.ProductGridNew.PreviewInfo.ZoomFactor = 75D;
            this.ProductGridNew.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.ProductGridNew.PrintInfo.MeasurementPrinterName = null;
            this.ProductGridNew.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.ProductGridNew.PropBag = resources.GetString("ProductGridNew.PropBag");
            this.ProductGridNew.Size = new System.Drawing.Size(776, 150);
            this.ProductGridNew.TabIndex = 13;
            this.ProductGridNew.UseCompatibleTextRendering = false;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductGridNew);
            this.Controls.Add(this.ProductGrid);
            this.Controls.Add(this.btnProdSave);
            this.Controls.Add(this.lbProdPrice);
            this.Controls.Add(this.txtProdPrice);
            this.Controls.Add(this.lbProdBrand);
            this.Controls.Add(this.tbxProdBrand);
            this.Controls.Add(this.ProductPanel);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.ProductPanel.ResumeLayout(false);
            this.ProductPanel.PerformLayout();
            this.tbxProdPanel.ResumeLayout(false);
            this.tbxProdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ProductPanel;
        private System.Windows.Forms.Label lbProdDescription;
        private System.Windows.Forms.Label lbProdID;
        private System.Windows.Forms.TableLayoutPanel tbxProdPanel;
        private System.Windows.Forms.TextBox tbxProductID;
        private System.Windows.Forms.TextBox tbxProdDescription;
        private System.Windows.Forms.ComboBox cbxProdStatus;
        private System.Windows.Forms.Label lbProdStatus;
        private System.Windows.Forms.TextBox tbxProdBrand;
        private System.Windows.Forms.Label lbProdBrand;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.Label lbProdPrice;
        private System.Windows.Forms.Button btnProdSave;
        private System.Windows.Forms.DataGridView ProductGrid;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid ProductGridNew;
    }
}