﻿
namespace MyManagementApp.ChildForms
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.cbxOrderItemStatus = new System.Windows.Forms.ComboBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbQtyOrdered = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxOrderPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tbxItemDescription = new System.Windows.Forms.TextBox();
            this.tbxItem = new System.Windows.Forms.TextBox();
            this.lbOrderStatus = new System.Windows.Forms.Label();
            this.tbxOrderID = new System.Windows.Forms.TextBox();
            this.cbxOrderStatus = new System.Windows.Forms.ComboBox();
            this.OrderID = new System.Windows.Forms.Label();
            this.tbxLine = new System.Windows.Forms.TextBox();
            this.lbLine = new System.Windows.Forms.Label();
            this.lbltem = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.tbxCustomerDescription = new System.Windows.Forms.TextBox();
            this.tbxCustomer = new System.Windows.Forms.TextBox();
            this.tbxProdPrice = new System.Windows.Forms.TextBox();
            this.lbItemStatus = new System.Windows.Forms.Label();
            this.tbxQty = new System.Windows.Forms.TextBox();
            this.OrderItemsGrid = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxTotalPrice = new System.Windows.Forms.TextBox();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.btnProdSave = new System.Windows.Forms.Button();
            this.tableLayoutMain.SuspendLayout();
            this.tbxOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 4;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutMain.Controls.Add(this.cbxOrderItemStatus, 3, 2);
            this.tableLayoutMain.Controls.Add(this.tbxUnitPrice, 2, 2);
            this.tableLayoutMain.Controls.Add(this.lbUnitPrice, 2, 1);
            this.tableLayoutMain.Controls.Add(this.lbQtyOrdered, 1, 1);
            this.tableLayoutMain.Controls.Add(this.label1, 0, 1);
            this.tableLayoutMain.Controls.Add(this.tbxOrderPanel, 0, 0);
            this.tableLayoutMain.Controls.Add(this.tbxProdPrice, 0, 2);
            this.tableLayoutMain.Controls.Add(this.lbItemStatus, 3, 1);
            this.tableLayoutMain.Controls.Add(this.tbxQty, 1, 2);
            this.tableLayoutMain.Controls.Add(this.OrderItemsGrid, 0, 6);
            this.tableLayoutMain.Controls.Add(this.btnAdd, 1, 4);
            this.tableLayoutMain.Controls.Add(this.btnCancel, 2, 4);
            this.tableLayoutMain.Controls.Add(this.tbxTotalPrice, 3, 3);
            this.tableLayoutMain.Controls.Add(this.lbTotalPrice, 2, 3);
            this.tableLayoutMain.Controls.Add(this.btnProdSave, 3, 4);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 7;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutMain.Size = new System.Drawing.Size(870, 562);
            this.tableLayoutMain.TabIndex = 2;
            // 
            // cbxOrderItemStatus
            // 
            this.cbxOrderItemStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cbxOrderItemStatus.FormattingEnabled = true;
            this.cbxOrderItemStatus.Location = new System.Drawing.Point(796, 102);
            this.cbxOrderItemStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxOrderItemStatus.Name = "cbxOrderItemStatus";
            this.cbxOrderItemStatus.Size = new System.Drawing.Size(68, 21);
            this.cbxOrderItemStatus.TabIndex = 3;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxUnitPrice.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitPrice.Location = new System.Drawing.Point(720, 102);
            this.tbxUnitPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.tbxUnitPrice.TabIndex = 16;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(720, 85);
            this.lbUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(60, 15);
            this.lbUnitPrice.TabIndex = 19;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbQtyOrdered
            // 
            this.lbQtyOrdered.AutoSize = true;
            this.lbQtyOrdered.BackColor = System.Drawing.Color.Transparent;
            this.lbQtyOrdered.Location = new System.Drawing.Point(644, 85);
            this.lbQtyOrdered.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQtyOrdered.Name = "lbQtyOrdered";
            this.lbQtyOrdered.Size = new System.Drawing.Size(24, 15);
            this.lbQtyOrdered.TabIndex = 18;
            this.lbQtyOrdered.Text = "Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Brand";
            // 
            // tbxOrderPanel
            // 
            this.tbxOrderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOrderPanel.ColumnCount = 4;
            this.tableLayoutMain.SetColumnSpan(this.tbxOrderPanel, 4);
            this.tbxOrderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tbxOrderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tbxOrderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbxOrderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tbxOrderPanel.Controls.Add(this.tbxItemDescription, 2, 3);
            this.tbxOrderPanel.Controls.Add(this.tbxItem, 0, 3);
            this.tbxOrderPanel.Controls.Add(this.lbOrderStatus, 3, 0);
            this.tbxOrderPanel.Controls.Add(this.tbxOrderID, 0, 1);
            this.tbxOrderPanel.Controls.Add(this.cbxOrderStatus, 3, 1);
            this.tbxOrderPanel.Controls.Add(this.OrderID, 0, 0);
            this.tbxOrderPanel.Controls.Add(this.tbxLine, 0, 3);
            this.tbxOrderPanel.Controls.Add(this.lbLine, 0, 2);
            this.tbxOrderPanel.Controls.Add(this.lbltem, 1, 2);
            this.tbxOrderPanel.Controls.Add(this.lbCustomer, 1, 0);
            this.tbxOrderPanel.Controls.Add(this.tbxCustomerDescription, 2, 1);
            this.tbxOrderPanel.Controls.Add(this.tbxCustomer, 1, 1);
            this.tbxOrderPanel.Location = new System.Drawing.Point(0, 2);
            this.tbxOrderPanel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tbxOrderPanel.Name = "tbxOrderPanel";
            this.tbxOrderPanel.RowCount = 4;
            this.tbxOrderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tbxOrderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tbxOrderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tbxOrderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tbxOrderPanel.Size = new System.Drawing.Size(870, 81);
            this.tbxOrderPanel.TabIndex = 0;
            // 
            // tbxItemDescription
            // 
            this.tbxItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxItemDescription.BackColor = System.Drawing.SystemColors.Info;
            this.tbxItemDescription.Location = new System.Drawing.Point(152, 58);
            this.tbxItemDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxItemDescription.Name = "tbxItemDescription";
            this.tbxItemDescription.Size = new System.Drawing.Size(641, 20);
            this.tbxItemDescription.TabIndex = 15;
            // 
            // tbxItem
            // 
            this.tbxItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxItem.BackColor = System.Drawing.SystemColors.Info;
            this.tbxItem.Location = new System.Drawing.Point(77, 58);
            this.tbxItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxItem.Name = "tbxItem";
            this.tbxItem.Size = new System.Drawing.Size(71, 20);
            this.tbxItem.TabIndex = 14;
            // 
            // lbOrderStatus
            // 
            this.lbOrderStatus.Location = new System.Drawing.Point(797, 0);
            this.lbOrderStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOrderStatus.Name = "lbOrderStatus";
            this.lbOrderStatus.Size = new System.Drawing.Size(70, 14);
            this.lbOrderStatus.TabIndex = 7;
            this.lbOrderStatus.Text = "Status";
            // 
            // tbxOrderID
            // 
            this.tbxOrderID.AccessibleDescription = "";
            this.tbxOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOrderID.BackColor = System.Drawing.SystemColors.Info;
            this.tbxOrderID.Location = new System.Drawing.Point(2, 18);
            this.tbxOrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxOrderID.Name = "tbxOrderID";
            this.tbxOrderID.Size = new System.Drawing.Size(71, 20);
            this.tbxOrderID.TabIndex = 0;
            this.tbxOrderID.Tag = "";
            // 
            // cbxOrderStatus
            // 
            this.cbxOrderStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cbxOrderStatus.FormattingEnabled = true;
            this.cbxOrderStatus.Location = new System.Drawing.Point(797, 18);
            this.cbxOrderStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxOrderStatus.Name = "cbxOrderStatus";
            this.cbxOrderStatus.Size = new System.Drawing.Size(71, 21);
            this.cbxOrderStatus.TabIndex = 2;
            // 
            // OrderID
            // 
            this.OrderID.AutoSize = true;
            this.OrderID.Location = new System.Drawing.Point(2, 0);
            this.OrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(38, 15);
            this.OrderID.TabIndex = 6;
            this.OrderID.Text = "Order";
            // 
            // tbxLine
            // 
            this.tbxLine.AccessibleDescription = "";
            this.tbxLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxLine.BackColor = System.Drawing.SystemColors.Window;
            this.tbxLine.Location = new System.Drawing.Point(2, 58);
            this.tbxLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxLine.Name = "tbxLine";
            this.tbxLine.Size = new System.Drawing.Size(71, 20);
            this.tbxLine.TabIndex = 3;
            this.tbxLine.Tag = "";
            // 
            // lbLine
            // 
            this.lbLine.AutoSize = true;
            this.lbLine.Location = new System.Drawing.Point(2, 40);
            this.lbLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(31, 15);
            this.lbLine.TabIndex = 8;
            this.lbLine.Text = "Line";
            // 
            // lbltem
            // 
            this.lbltem.AutoSize = true;
            this.lbltem.Location = new System.Drawing.Point(77, 40);
            this.lbltem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltem.Name = "lbltem";
            this.lbltem.Size = new System.Drawing.Size(31, 15);
            this.lbltem.TabIndex = 10;
            this.lbltem.Text = "Item";
            // 
            // lbCustomer
            // 
            this.lbCustomer.Location = new System.Drawing.Point(77, 0);
            this.lbCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(70, 14);
            this.lbCustomer.TabIndex = 4;
            this.lbCustomer.Text = "Customer";
            // 
            // tbxCustomerDescription
            // 
            this.tbxCustomerDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCustomerDescription.BackColor = System.Drawing.SystemColors.Info;
            this.tbxCustomerDescription.Location = new System.Drawing.Point(152, 18);
            this.tbxCustomerDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxCustomerDescription.Name = "tbxCustomerDescription";
            this.tbxCustomerDescription.Size = new System.Drawing.Size(641, 20);
            this.tbxCustomerDescription.TabIndex = 1;
            // 
            // tbxCustomer
            // 
            this.tbxCustomer.AccessibleDescription = "";
            this.tbxCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.tbxCustomer.Location = new System.Drawing.Point(77, 18);
            this.tbxCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxCustomer.Name = "tbxCustomer";
            this.tbxCustomer.Size = new System.Drawing.Size(71, 20);
            this.tbxCustomer.TabIndex = 12;
            this.tbxCustomer.Tag = "";
            // 
            // tbxProdPrice
            // 
            this.tbxProdPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxProdPrice.Location = new System.Drawing.Point(2, 102);
            this.tbxProdPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxProdPrice.Name = "tbxProdPrice";
            this.tbxProdPrice.Size = new System.Drawing.Size(638, 20);
            this.tbxProdPrice.TabIndex = 4;
            // 
            // lbItemStatus
            // 
            this.lbItemStatus.AutoSize = true;
            this.lbItemStatus.Location = new System.Drawing.Point(796, 85);
            this.lbItemStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbItemStatus.Name = "lbItemStatus";
            this.lbItemStatus.Size = new System.Drawing.Size(41, 15);
            this.lbItemStatus.TabIndex = 17;
            this.lbItemStatus.Text = "Status";
            // 
            // tbxQty
            // 
            this.tbxQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxQty.BackColor = System.Drawing.SystemColors.Info;
            this.tbxQty.Location = new System.Drawing.Point(644, 102);
            this.tbxQty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxQty.Name = "tbxQty";
            this.tbxQty.Size = new System.Drawing.Size(72, 20);
            this.tbxQty.TabIndex = 14;
            // 
            // OrderItemsGrid
            // 
            this.OrderItemsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutMain.SetColumnSpan(this.OrderItemsGrid, 4);
            this.OrderItemsGrid.GroupByCaption = "Drag a column header here to group by that column";
            this.OrderItemsGrid.Location = new System.Drawing.Point(2, 182);
            this.OrderItemsGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderItemsGrid.Name = "OrderItemsGrid";
            this.OrderItemsGrid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.OrderItemsGrid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.OrderItemsGrid.PreviewInfo.ZoomFactor = 75D;
            this.OrderItemsGrid.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.OrderItemsGrid.PrintInfo.MeasurementPrinterName = null;
            this.OrderItemsGrid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("OrderItemsGrid.PrintInfo.PageSettings")));
            this.OrderItemsGrid.PropBag = resources.GetString("OrderItemsGrid.PropBag");
            this.OrderItemsGrid.Size = new System.Drawing.Size(866, 378);
            this.OrderItemsGrid.TabIndex = 15;
            this.OrderItemsGrid.UseCompatibleTextRendering = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(644, 150);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 26);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(720, 150);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 26);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbxTotalPrice
            // 
            this.tbxTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTotalPrice.BackColor = System.Drawing.SystemColors.Info;
            this.tbxTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbxTotalPrice.Location = new System.Drawing.Point(796, 126);
            this.tbxTotalPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxTotalPrice.Name = "tbxTotalPrice";
            this.tbxTotalPrice.Size = new System.Drawing.Size(72, 22);
            this.tbxTotalPrice.TabIndex = 23;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Location = new System.Drawing.Point(727, 128);
            this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(65, 15);
            this.lbTotalPrice.TabIndex = 21;
            this.lbTotalPrice.Text = "Total Price";
            // 
            // btnProdSave
            // 
            this.btnProdSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProdSave.Location = new System.Drawing.Point(796, 150);
            this.btnProdSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(72, 25);
            this.btnProdSave.TabIndex = 3;
            this.btnProdSave.Text = "Save";
            this.btnProdSave.UseVisualStyleBackColor = true;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 562);
            this.Controls.Add(this.tableLayoutMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(618, 413);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Shown += new System.EventHandler(this.OrdersForm_Shown);
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutMain.PerformLayout();
            this.tbxOrderPanel.ResumeLayout(false);
            this.tbxOrderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tbxOrderPanel;
        private System.Windows.Forms.Label lbOrderStatus;
        private System.Windows.Forms.TextBox tbxOrderID;
        private System.Windows.Forms.ComboBox cbxOrderStatus;
        private System.Windows.Forms.Label OrderID;
        private System.Windows.Forms.TextBox tbxLine;
        private System.Windows.Forms.Label lbLine;
        private System.Windows.Forms.Label lbltem;
        private System.Windows.Forms.TextBox tbxProdPrice;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.TextBox tbxCustomerDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxCustomer;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbQtyOrdered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxItemDescription;
        private System.Windows.Forms.TextBox tbxItem;
        private System.Windows.Forms.Label lbItemStatus;
        private System.Windows.Forms.TextBox tbxQty;
        private System.Windows.Forms.Button btnProdSave;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.TextBox tbxTotalPrice;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid OrderItemsGrid;
        private System.Windows.Forms.ComboBox cbxOrderItemStatus;
    }
}