
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
            this.tbxProdPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbOrderStatus = new System.Windows.Forms.Label();
            this.tbxOrderID = new System.Windows.Forms.TextBox();
            this.cbxOrderStatus = new System.Windows.Forms.ComboBox();
            this.OrderID = new System.Windows.Forms.Label();
            this.tbxLine = new System.Windows.Forms.TextBox();
            this.lbLine = new System.Windows.Forms.Label();
            this.lbltem = new System.Windows.Forms.Label();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.tbxCustomerDescription = new System.Windows.Forms.TextBox();
            this.tbxCustomer = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnProdSave = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ItemDescription = new System.Windows.Forms.TextBox();
            this.OrderItemsGrid = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.lbItemStatus = new System.Windows.Forms.Label();
            this.lbQtyOrdered = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tableLayoutMain.SuspendLayout();
            this.tbxProdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 4;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutMain.Controls.Add(this.textBox5, 3, 2);
            this.tableLayoutMain.Controls.Add(this.textBox1, 2, 2);
            this.tableLayoutMain.Controls.Add(this.lbUnitPrice, 2, 1);
            this.tableLayoutMain.Controls.Add(this.lbQtyOrdered, 1, 1);
            this.tableLayoutMain.Controls.Add(this.label1, 0, 1);
            this.tableLayoutMain.Controls.Add(this.tbxProdPanel, 0, 0);
            this.tableLayoutMain.Controls.Add(this.txtProdPrice, 0, 2);
            this.tableLayoutMain.Controls.Add(this.lbItemStatus, 3, 1);
            this.tableLayoutMain.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutMain.Controls.Add(this.OrderItemsGrid, 0, 6);
            this.tableLayoutMain.Controls.Add(this.btnAdd, 1, 4);
            this.tableLayoutMain.Controls.Add(this.btnCancel, 2, 4);
            this.tableLayoutMain.Controls.Add(this.btnProdSave, 3, 4);
            this.tableLayoutMain.Controls.Add(this.textBox7, 3, 3);
            this.tableLayoutMain.Controls.Add(this.lbTotalPrice, 2, 3);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 7;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutMain.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutMain.TabIndex = 2;
            // 
            // tbxProdPanel
            // 
            this.tbxProdPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxProdPanel.ColumnCount = 4;
            this.tableLayoutMain.SetColumnSpan(this.tbxProdPanel, 4);
            this.tbxProdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tbxProdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tbxProdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbxProdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tbxProdPanel.Controls.Add(this.ItemDescription, 2, 3);
            this.tbxProdPanel.Controls.Add(this.textBox2, 0, 3);
            this.tbxProdPanel.Controls.Add(this.lbOrderStatus, 3, 0);
            this.tbxProdPanel.Controls.Add(this.tbxOrderID, 0, 1);
            this.tbxProdPanel.Controls.Add(this.cbxOrderStatus, 3, 1);
            this.tbxProdPanel.Controls.Add(this.OrderID, 0, 0);
            this.tbxProdPanel.Controls.Add(this.tbxLine, 0, 3);
            this.tbxProdPanel.Controls.Add(this.lbLine, 0, 2);
            this.tbxProdPanel.Controls.Add(this.lbltem, 1, 2);
            this.tbxProdPanel.Controls.Add(this.lbCustomer, 1, 0);
            this.tbxProdPanel.Controls.Add(this.tbxCustomerDescription, 2, 1);
            this.tbxProdPanel.Controls.Add(this.tbxCustomer, 1, 1);
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
            // lbOrderStatus
            // 
            this.lbOrderStatus.Location = new System.Drawing.Point(703, 0);
            this.lbOrderStatus.Name = "lbOrderStatus";
            this.lbOrderStatus.Size = new System.Drawing.Size(94, 17);
            this.lbOrderStatus.TabIndex = 7;
            this.lbOrderStatus.Text = "Status";
            // 
            // tbxOrderID
            // 
            this.tbxOrderID.AccessibleDescription = "";
            this.tbxOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOrderID.BackColor = System.Drawing.SystemColors.Info;
            this.tbxOrderID.Location = new System.Drawing.Point(3, 23);
            this.tbxOrderID.Name = "tbxOrderID";
            this.tbxOrderID.Size = new System.Drawing.Size(94, 22);
            this.tbxOrderID.TabIndex = 0;
            this.tbxOrderID.Tag = "";
            // 
            // cbxOrderStatus
            // 
            this.cbxOrderStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cbxOrderStatus.FormattingEnabled = true;
            this.cbxOrderStatus.Location = new System.Drawing.Point(703, 23);
            this.cbxOrderStatus.Name = "cbxOrderStatus";
            this.cbxOrderStatus.Size = new System.Drawing.Size(94, 24);
            this.cbxOrderStatus.TabIndex = 2;
            // 
            // OrderID
            // 
            this.OrderID.AutoSize = true;
            this.OrderID.Location = new System.Drawing.Point(3, 0);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(45, 17);
            this.OrderID.TabIndex = 6;
            this.OrderID.Text = "Order";
            // 
            // tbxLine
            // 
            this.tbxLine.AccessibleDescription = "";
            this.tbxLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxLine.BackColor = System.Drawing.SystemColors.Window;
            this.tbxLine.Location = new System.Drawing.Point(3, 73);
            this.tbxLine.Name = "tbxLine";
            this.tbxLine.Size = new System.Drawing.Size(94, 22);
            this.tbxLine.TabIndex = 3;
            this.tbxLine.Tag = "";
            // 
            // lbLine
            // 
            this.lbLine.AutoSize = true;
            this.lbLine.Location = new System.Drawing.Point(3, 50);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(35, 17);
            this.lbLine.TabIndex = 8;
            this.lbLine.Text = "Line";
            // 
            // lbltem
            // 
            this.lbltem.AutoSize = true;
            this.lbltem.Location = new System.Drawing.Point(103, 50);
            this.lbltem.Name = "lbltem";
            this.lbltem.Size = new System.Drawing.Size(34, 17);
            this.lbltem.TabIndex = 10;
            this.lbltem.Text = "Item";
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProdPrice.Location = new System.Drawing.Point(3, 126);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(483, 22);
            this.txtProdPrice.TabIndex = 4;
            // 
            // lbCustomer
            // 
            this.lbCustomer.Location = new System.Drawing.Point(103, 0);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(94, 17);
            this.lbCustomer.TabIndex = 4;
            this.lbCustomer.Text = "Customer";
            // 
            // tbxCustomerDescription
            // 
            this.tbxCustomerDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCustomerDescription.BackColor = System.Drawing.SystemColors.Info;
            this.tbxCustomerDescription.Location = new System.Drawing.Point(203, 23);
            this.tbxCustomerDescription.Name = "tbxCustomerDescription";
            this.tbxCustomerDescription.Size = new System.Drawing.Size(494, 22);
            this.tbxCustomerDescription.TabIndex = 1;
            // 
            // tbxCustomer
            // 
            this.tbxCustomer.AccessibleDescription = "";
            this.tbxCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.tbxCustomer.Location = new System.Drawing.Point(103, 23);
            this.tbxCustomer.Name = "tbxCustomer";
            this.tbxCustomer.Size = new System.Drawing.Size(94, 22);
            this.tbxCustomer.TabIndex = 12;
            this.tbxCustomer.Tag = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(492, 185);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(593, 185);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnProdSave
            // 
            this.btnProdSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProdSave.Location = new System.Drawing.Point(713, 186);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(84, 23);
            this.btnProdSave.TabIndex = 3;
            this.btnProdSave.Text = "Save";
            this.btnProdSave.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(103, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 22);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(492, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(95, 22);
            this.textBox3.TabIndex = 14;
            // 
            // ItemDescription
            // 
            this.ItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemDescription.BackColor = System.Drawing.SystemColors.Info;
            this.ItemDescription.Location = new System.Drawing.Point(203, 73);
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.Size = new System.Drawing.Size(494, 22);
            this.ItemDescription.TabIndex = 15;
            // 
            // OrderItemsGrid
            // 
            this.OrderItemsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutMain.SetColumnSpan(this.OrderItemsGrid, 4);
            this.OrderItemsGrid.GroupByCaption = "Drag a column header here to group by that column";
            this.OrderItemsGrid.Location = new System.Drawing.Point(3, 223);
            this.OrderItemsGrid.Name = "OrderItemsGrid";
            this.OrderItemsGrid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.OrderItemsGrid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.OrderItemsGrid.PreviewInfo.ZoomFactor = 75D;
            this.OrderItemsGrid.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.OrderItemsGrid.PrintInfo.MeasurementPrinterName = null;
            this.OrderItemsGrid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("OrderItemsGrid.PrintInfo.PageSettings")));
            this.OrderItemsGrid.PropBag = resources.GetString("OrderItemsGrid.PropBag");
            this.OrderItemsGrid.Size = new System.Drawing.Size(794, 224);
            this.OrderItemsGrid.TabIndex = 15;
            this.OrderItemsGrid.UseCompatibleTextRendering = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Brand";
            // 
            // lbItemStatus
            // 
            this.lbItemStatus.AutoSize = true;
            this.lbItemStatus.Location = new System.Drawing.Point(713, 106);
            this.lbItemStatus.Name = "lbItemStatus";
            this.lbItemStatus.Size = new System.Drawing.Size(48, 17);
            this.lbItemStatus.TabIndex = 17;
            this.lbItemStatus.Text = "Status";
            // 
            // lbQtyOrdered
            // 
            this.lbQtyOrdered.AutoSize = true;
            this.lbQtyOrdered.BackColor = System.Drawing.Color.Transparent;
            this.lbQtyOrdered.Location = new System.Drawing.Point(492, 106);
            this.lbQtyOrdered.Name = "lbQtyOrdered";
            this.lbQtyOrdered.Size = new System.Drawing.Size(30, 17);
            this.lbQtyOrdered.TabIndex = 18;
            this.lbQtyOrdered.Text = "Qty";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(593, 106);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(69, 17);
            this.lbUnitPrice.TabIndex = 19;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(593, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 22);
            this.textBox1.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.Location = new System.Drawing.Point(713, 126);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(84, 22);
            this.textBox5.TabIndex = 20;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Location = new System.Drawing.Point(593, 153);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(76, 17);
            this.lbTotalPrice.TabIndex = 21;
            this.lbTotalPrice.Text = "Total Price";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.BackColor = System.Drawing.SystemColors.Info;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox7.Location = new System.Drawing.Point(713, 156);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(84, 22);
            this.textBox7.TabIndex = 23;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutMain.PerformLayout();
            this.tbxProdPanel.ResumeLayout(false);
            this.tbxProdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tbxProdPanel;
        private System.Windows.Forms.Label lbOrderStatus;
        private System.Windows.Forms.TextBox tbxOrderID;
        private System.Windows.Forms.ComboBox cbxOrderStatus;
        private System.Windows.Forms.Label OrderID;
        private System.Windows.Forms.TextBox tbxLine;
        private System.Windows.Forms.Label lbLine;
        private System.Windows.Forms.Label lbltem;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.TextBox tbxCustomerDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxCustomer;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbQtyOrdered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemDescription;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbItemStatus;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnProdSave;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.TextBox textBox7;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid OrderItemsGrid;
    }
}