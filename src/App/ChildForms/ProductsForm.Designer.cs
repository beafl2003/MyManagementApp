﻿
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
            this.lbProdStatus = new System.Windows.Forms.Label();
            this.lbProdDescription = new System.Windows.Forms.Label();
            this.lbProdID = new System.Windows.Forms.Label();
            this.tbxProdPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tbxProductID = new System.Windows.Forms.TextBox();
            this.tbxProdBrand = new System.Windows.Forms.TextBox();
            this.lbProdBrand = new System.Windows.Forms.Label();
            this.lbProdPrice = new System.Windows.Forms.Label();
            this.tbxProdDescription = new System.Windows.Forms.TextBox();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.btnProdSave = new System.Windows.Forms.Button();
            this.ProductGridNew = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxProdStatus = new System.Windows.Forms.ComboBox();
            this.tbxProdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridNew)).BeginInit();
            this.tableLayoutMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProdStatus
            // 
            this.lbProdStatus.Location = new System.Drawing.Point(703, 0);
            this.lbProdStatus.Name = "lbProdStatus";
            this.lbProdStatus.Size = new System.Drawing.Size(94, 17);
            this.lbProdStatus.TabIndex = 7;
            this.lbProdStatus.Text = "Status";
            // 
            // lbProdDescription
            // 
            this.lbProdDescription.Location = new System.Drawing.Point(103, 0);
            this.lbProdDescription.Name = "lbProdDescription";
            this.lbProdDescription.Size = new System.Drawing.Size(94, 17);
            this.lbProdDescription.TabIndex = 4;
            this.lbProdDescription.Text = "Description";
            // 
            // lbProdID
            // 
            this.lbProdID.AutoSize = true;
            this.lbProdID.Location = new System.Drawing.Point(3, 0);
            this.lbProdID.Name = "lbProdID";
            this.lbProdID.Size = new System.Drawing.Size(74, 17);
            this.lbProdID.TabIndex = 6;
            this.lbProdID.Text = "Product ID";
            // 
            // tbxProdPanel
            // 
            this.tbxProdPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxProdPanel.ColumnCount = 4;
            this.tableLayoutMain.SetColumnSpan(this.tbxProdPanel, 5);
            this.tbxProdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tbxProdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tbxProdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbxProdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tbxProdPanel.Controls.Add(this.lbProdStatus, 3, 0);
            this.tbxProdPanel.Controls.Add(this.tbxProductID, 0, 1);
            this.tbxProdPanel.Controls.Add(this.lbProdID, 0, 0);
            this.tbxProdPanel.Controls.Add(this.tbxProdBrand, 0, 3);
            this.tbxProdPanel.Controls.Add(this.lbProdBrand, 0, 2);
            this.tbxProdPanel.Controls.Add(this.lbProdPrice, 1, 2);
            this.tbxProdPanel.Controls.Add(this.tbxProdDescription, 1, 1);
            this.tbxProdPanel.Controls.Add(this.lbProdDescription, 1, 0);
            this.tbxProdPanel.Controls.Add(this.txtProdPrice, 1, 3);
            this.tbxProdPanel.Controls.Add(this.cbxProdStatus, 3, 1);
            this.tbxProdPanel.Location = new System.Drawing.Point(0, 3);
            this.tbxProdPanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tbxProdPanel.Name = "tbxProdPanel";
            this.tbxProdPanel.RowCount = 4;
            this.tbxProdPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbxProdPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbxProdPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbxProdPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbxProdPanel.Size = new System.Drawing.Size(800, 100);
            this.tbxProdPanel.TabIndex = 0;
            // 
            // tbxProductID
            // 
            this.tbxProductID.AccessibleDescription = "";
            this.tbxProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxProductID.BackColor = System.Drawing.SystemColors.Info;
            this.tbxProductID.Location = new System.Drawing.Point(3, 23);
            this.tbxProductID.Name = "tbxProductID";
            this.tbxProductID.Size = new System.Drawing.Size(94, 22);
            this.tbxProductID.TabIndex = 0;
            this.tbxProductID.Tag = "";
            // 
            // tbxProdBrand
            // 
            this.tbxProdBrand.AccessibleDescription = "";
            this.tbxProdBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxProdBrand.BackColor = System.Drawing.SystemColors.Window;
            this.tbxProdBrand.Location = new System.Drawing.Point(3, 73);
            this.tbxProdBrand.Name = "tbxProdBrand";
            this.tbxProdBrand.Size = new System.Drawing.Size(94, 22);
            this.tbxProdBrand.TabIndex = 3;
            this.tbxProdBrand.Tag = "";
            // 
            // lbProdBrand
            // 
            this.lbProdBrand.AutoSize = true;
            this.lbProdBrand.Location = new System.Drawing.Point(3, 50);
            this.lbProdBrand.Name = "lbProdBrand";
            this.lbProdBrand.Size = new System.Drawing.Size(46, 17);
            this.lbProdBrand.TabIndex = 8;
            this.lbProdBrand.Text = "Brand";
            // 
            // lbProdPrice
            // 
            this.lbProdPrice.AutoSize = true;
            this.lbProdPrice.Location = new System.Drawing.Point(103, 50);
            this.lbProdPrice.Name = "lbProdPrice";
            this.lbProdPrice.Size = new System.Drawing.Size(40, 17);
            this.lbProdPrice.TabIndex = 10;
            this.lbProdPrice.Text = "Price";
            // 
            // tbxProdDescription
            // 
            this.tbxProdDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxProdDescription.BackColor = System.Drawing.SystemColors.Info;
            this.tbxProdPanel.SetColumnSpan(this.tbxProdDescription, 2);
            this.tbxProdDescription.Location = new System.Drawing.Point(103, 23);
            this.tbxProdDescription.Name = "tbxProdDescription";
            this.tbxProdDescription.Size = new System.Drawing.Size(594, 22);
            this.tbxProdDescription.TabIndex = 1;
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProdPrice.Location = new System.Drawing.Point(103, 73);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(94, 22);
            this.txtProdPrice.TabIndex = 4;
            // 
            // btnProdSave
            // 
            this.btnProdSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProdSave.Location = new System.Drawing.Point(603, 109);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(94, 23);
            this.btnProdSave.TabIndex = 3;
            this.btnProdSave.Text = "Save";
            this.btnProdSave.UseVisualStyleBackColor = true;
            // 
            // ProductGridNew
            // 
            this.ProductGridNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutMain.SetColumnSpan(this.ProductGridNew, 5);
            this.ProductGridNew.GroupByCaption = "Drag a column header here to group by that column";
            this.ProductGridNew.Location = new System.Drawing.Point(3, 138);
            this.ProductGridNew.Name = "ProductGridNew";
            this.ProductGridNew.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.ProductGridNew.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.ProductGridNew.PreviewInfo.ZoomFactor = 75D;
            this.ProductGridNew.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.ProductGridNew.PrintInfo.MeasurementPrinterName = null;
            this.ProductGridNew.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("ProductGridNew.PrintInfo.PageSettings")));
            this.ProductGridNew.PropBag = resources.GetString("ProductGridNew.PropBag");
            this.ProductGridNew.Size = new System.Drawing.Size(794, 309);
            this.ProductGridNew.TabIndex = 5;
            this.ProductGridNew.UseCompatibleTextRendering = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(403, 108);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(703, 108);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 5;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutMain.Controls.Add(this.tbxProdPanel, 0, 0);
            this.tableLayoutMain.Controls.Add(this.btnAdd, 1, 1);
            this.tableLayoutMain.Controls.Add(this.btnDelete, 4, 1);
            this.tableLayoutMain.Controls.Add(this.btnProdSave, 3, 1);
            this.tableLayoutMain.Controls.Add(this.btnCancel, 2, 1);
            this.tableLayoutMain.Controls.Add(this.ProductGridNew, 0, 2);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 3;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMain.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(503, 108);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbxProdStatus
            // 
            this.cbxProdStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cbxProdStatus.FormattingEnabled = true;
            this.cbxProdStatus.Location = new System.Drawing.Point(703, 23);
            this.cbxProdStatus.Name = "cbxProdStatus";
            this.cbxProdStatus.Size = new System.Drawing.Size(94, 24);
            this.cbxProdStatus.TabIndex = 11;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.tbxProdPanel.ResumeLayout(false);
            this.tbxProdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridNew)).EndInit();
            this.tableLayoutMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbProdDescription;
        private System.Windows.Forms.Label lbProdID;
        private System.Windows.Forms.TableLayoutPanel tbxProdPanel;
        private System.Windows.Forms.TextBox tbxProductID;
        private System.Windows.Forms.TextBox tbxProdDescription;
        private System.Windows.Forms.Label lbProdStatus;
        private System.Windows.Forms.TextBox tbxProdBrand;
        private System.Windows.Forms.Label lbProdBrand;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.Label lbProdPrice;
        private System.Windows.Forms.Button btnProdSave;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid ProductGridNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbxProdStatus;
    }
}