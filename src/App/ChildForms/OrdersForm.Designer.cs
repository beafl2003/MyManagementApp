
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
            this.tbxOrderPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbOrderStatus = new System.Windows.Forms.Label();
            this.cbxOrderStatus = new System.Windows.Forms.ComboBox();
            this.OrderID = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.tbxCustomerDescription = new System.Windows.Forms.TextBox();
            this.tbxCustomer = new System.Windows.Forms.TextBox();
            this.tbxOrderID = new System.Windows.Forms.TextBox();
            this.tbxItemDescription = new System.Windows.Forms.TextBox();
            this.tbxItem = new System.Windows.Forms.TextBox();
            this.tbxLine = new System.Windows.Forms.TextBox();
            this.lbLine = new System.Windows.Forms.Label();
            this.lbltem = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.tbxTotalPrice = new System.Windows.Forms.TextBox();
            this.cbxOrderItemStatus = new System.Windows.Forms.ComboBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxQty = new System.Windows.Forms.TextBox();
            this.tbxBrand = new System.Windows.Forms.TextBox();
            this.lbItemStatus = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbQtyOrdered = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderItemsGrid = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.OrderItemsTheGrid = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.tbxOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemsTheGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxOrderPanel
            // 
            this.tbxOrderPanel.ColumnCount = 4;
            this.tbxOrderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tbxOrderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tbxOrderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbxOrderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tbxOrderPanel.Controls.Add(this.lbOrderStatus, 3, 0);
            this.tbxOrderPanel.Controls.Add(this.cbxOrderStatus, 3, 1);
            this.tbxOrderPanel.Controls.Add(this.OrderID, 0, 0);
            this.tbxOrderPanel.Controls.Add(this.lbCustomer, 1, 0);
            this.tbxOrderPanel.Controls.Add(this.tbxCustomerDescription, 2, 1);
            this.tbxOrderPanel.Controls.Add(this.tbxCustomer, 1, 1);
            this.tbxOrderPanel.Controls.Add(this.tbxOrderID, 0, 1);
            this.tbxOrderPanel.Location = new System.Drawing.Point(7, 9);
            this.tbxOrderPanel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tbxOrderPanel.Name = "tbxOrderPanel";
            this.tbxOrderPanel.RowCount = 3;
            this.tbxOrderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tbxOrderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tbxOrderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tbxOrderPanel.Size = new System.Drawing.Size(686, 54);
            this.tbxOrderPanel.TabIndex = 0;
            // 
            // lbOrderStatus
            // 
            this.lbOrderStatus.Location = new System.Drawing.Point(613, 0);
            this.lbOrderStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOrderStatus.Name = "lbOrderStatus";
            this.lbOrderStatus.Size = new System.Drawing.Size(70, 14);
            this.lbOrderStatus.TabIndex = 7;
            this.lbOrderStatus.Text = "Status";
            // 
            // cbxOrderStatus
            // 
            this.cbxOrderStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cbxOrderStatus.FormattingEnabled = true;
            this.cbxOrderStatus.Location = new System.Drawing.Point(613, 18);
            this.cbxOrderStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbxOrderStatus.Name = "cbxOrderStatus";
            this.cbxOrderStatus.Size = new System.Drawing.Size(71, 21);
            this.cbxOrderStatus.TabIndex = 3;
            // 
            // OrderID
            // 
            this.OrderID.AutoSize = true;
            this.OrderID.Location = new System.Drawing.Point(2, 0);
            this.OrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(33, 13);
            this.OrderID.TabIndex = 6;
            this.OrderID.Text = "Order";
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
            this.tbxCustomerDescription.BackColor = System.Drawing.SystemColors.Info;
            this.tbxCustomerDescription.Location = new System.Drawing.Point(152, 18);
            this.tbxCustomerDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbxCustomerDescription.Name = "tbxCustomerDescription";
            this.tbxCustomerDescription.Size = new System.Drawing.Size(457, 20);
            this.tbxCustomerDescription.TabIndex = 2;
            // 
            // tbxCustomer
            // 
            this.tbxCustomer.AccessibleDescription = "";
            this.tbxCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.tbxCustomer.Location = new System.Drawing.Point(77, 18);
            this.tbxCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.tbxCustomer.Name = "tbxCustomer";
            this.tbxCustomer.Size = new System.Drawing.Size(71, 20);
            this.tbxCustomer.TabIndex = 1;
            this.tbxCustomer.Tag = "";
            this.tbxCustomer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxCustomer_KeyUp);
            // 
            // tbxOrderID
            // 
            this.tbxOrderID.AccessibleDescription = "";
            this.tbxOrderID.BackColor = System.Drawing.SystemColors.Info;
            this.tbxOrderID.Location = new System.Drawing.Point(2, 18);
            this.tbxOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.tbxOrderID.Name = "tbxOrderID";
            this.tbxOrderID.Size = new System.Drawing.Size(71, 20);
            this.tbxOrderID.TabIndex = 0;
            this.tbxOrderID.Tag = "";
            this.tbxOrderID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxOrderID_KeyDown);
            this.tbxOrderID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxOrderID_KeyUp);
            // 
            // tbxItemDescription
            // 
            this.tbxItemDescription.BackColor = System.Drawing.SystemColors.Info;
            this.tbxItemDescription.Location = new System.Drawing.Point(158, 128);
            this.tbxItemDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbxItemDescription.Name = "tbxItemDescription";
            this.tbxItemDescription.Size = new System.Drawing.Size(457, 20);
            this.tbxItemDescription.TabIndex = 15;
            // 
            // tbxItem
            // 
            this.tbxItem.BackColor = System.Drawing.SystemColors.Info;
            this.tbxItem.Location = new System.Drawing.Point(84, 128);
            this.tbxItem.Margin = new System.Windows.Forms.Padding(2);
            this.tbxItem.Name = "tbxItem";
            this.tbxItem.Size = new System.Drawing.Size(72, 20);
            this.tbxItem.TabIndex = 14;
            // 
            // tbxLine
            // 
            this.tbxLine.AccessibleDescription = "";
            this.tbxLine.BackColor = System.Drawing.SystemColors.Window;
            this.tbxLine.Location = new System.Drawing.Point(11, 127);
            this.tbxLine.Margin = new System.Windows.Forms.Padding(2);
            this.tbxLine.Name = "tbxLine";
            this.tbxLine.Size = new System.Drawing.Size(72, 20);
            this.tbxLine.TabIndex = 3;
            this.tbxLine.Tag = "";
            // 
            // lbLine
            // 
            this.lbLine.AutoSize = true;
            this.lbLine.Location = new System.Drawing.Point(9, 112);
            this.lbLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(27, 13);
            this.lbLine.TabIndex = 8;
            this.lbLine.Text = "Line";
            // 
            // lbltem
            // 
            this.lbltem.AutoSize = true;
            this.lbltem.Location = new System.Drawing.Point(84, 112);
            this.lbltem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltem.Name = "lbltem";
            this.lbltem.Size = new System.Drawing.Size(27, 13);
            this.lbltem.TabIndex = 10;
            this.lbltem.Text = "Item";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(470, 66);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 19);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(547, 66);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 19);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(622, 66);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 19);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Location = new System.Drawing.Point(512, 204);
            this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(58, 13);
            this.lbTotalPrice.TabIndex = 21;
            this.lbTotalPrice.Text = "Total Price";
            // 
            // tbxTotalPrice
            // 
            this.tbxTotalPrice.BackColor = System.Drawing.SystemColors.Info;
            this.tbxTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbxTotalPrice.Location = new System.Drawing.Point(574, 201);
            this.tbxTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTotalPrice.Name = "tbxTotalPrice";
            this.tbxTotalPrice.Size = new System.Drawing.Size(130, 19);
            this.tbxTotalPrice.TabIndex = 23;
            // 
            // cbxOrderItemStatus
            // 
            this.cbxOrderItemStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cbxOrderItemStatus.FormattingEnabled = true;
            this.cbxOrderItemStatus.Location = new System.Drawing.Point(636, 169);
            this.cbxOrderItemStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbxOrderItemStatus.Name = "cbxOrderItemStatus";
            this.cbxOrderItemStatus.Size = new System.Drawing.Size(68, 21);
            this.cbxOrderItemStatus.TabIndex = 3;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitPrice.Location = new System.Drawing.Point(557, 174);
            this.tbxUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.tbxUnitPrice.TabIndex = 16;
            // 
            // tbxQty
            // 
            this.tbxQty.BackColor = System.Drawing.SystemColors.Info;
            this.tbxQty.Location = new System.Drawing.Point(475, 171);
            this.tbxQty.Margin = new System.Windows.Forms.Padding(2);
            this.tbxQty.Name = "tbxQty";
            this.tbxQty.Size = new System.Drawing.Size(72, 20);
            this.tbxQty.TabIndex = 14;
            // 
            // tbxBrand
            // 
            this.tbxBrand.Location = new System.Drawing.Point(9, 171);
            this.tbxBrand.Margin = new System.Windows.Forms.Padding(2);
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.Size = new System.Drawing.Size(462, 20);
            this.tbxBrand.TabIndex = 4;
            // 
            // lbItemStatus
            // 
            this.lbItemStatus.AutoSize = true;
            this.lbItemStatus.Location = new System.Drawing.Point(634, 154);
            this.lbItemStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbItemStatus.Name = "lbItemStatus";
            this.lbItemStatus.Size = new System.Drawing.Size(37, 13);
            this.lbItemStatus.TabIndex = 17;
            this.lbItemStatus.Text = "Status";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(548, 154);
            this.lbUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lbUnitPrice.TabIndex = 19;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbQtyOrdered
            // 
            this.lbQtyOrdered.AutoSize = true;
            this.lbQtyOrdered.BackColor = System.Drawing.Color.Transparent;
            this.lbQtyOrdered.Location = new System.Drawing.Point(472, 155);
            this.lbQtyOrdered.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQtyOrdered.Name = "lbQtyOrdered";
            this.lbQtyOrdered.Size = new System.Drawing.Size(23, 13);
            this.lbQtyOrdered.TabIndex = 18;
            this.lbQtyOrdered.Text = "Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Brand";
            // 
            // OrderItemsGrid
            // 
            this.OrderItemsGrid.GroupByCaption = "Drag a column header here to group by that column";
            this.OrderItemsGrid.Images.Add(((System.Drawing.Image)(resources.GetObject("OrderItemsGrid.Images"))));
            this.OrderItemsGrid.Location = new System.Drawing.Point(11, 253);
            this.OrderItemsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.OrderItemsGrid.Name = "OrderItemsGrid";
            this.OrderItemsGrid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.OrderItemsGrid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.OrderItemsGrid.PreviewInfo.ZoomFactor = 75D;
            this.OrderItemsGrid.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.OrderItemsGrid.PrintInfo.MeasurementPrinterName = null;
            this.OrderItemsGrid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("OrderItemsGrid.PrintInfo.PageSettings")));
            this.OrderItemsGrid.Size = new System.Drawing.Size(702, 129);
            this.OrderItemsGrid.TabIndex = 25;
            this.OrderItemsGrid.UseCompatibleTextRendering = false;
            this.OrderItemsGrid.Visible = false;
            this.OrderItemsGrid.PropBag = resources.GetString("OrderItemsGrid.PropBag");
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Location = new System.Drawing.Point(632, 223);
            this.btnSaveItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(70, 19);
            this.btnSaveItem.TabIndex = 28;
            this.btnSaveItem.Text = "Save";
            this.btnSaveItem.UseVisualStyleBackColor = true;
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Location = new System.Drawing.Point(557, 223);
            this.btnCancelItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(70, 19);
            this.btnCancelItem.TabIndex = 27;
            this.btnCancelItem.Text = "Cancel";
            this.btnCancelItem.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(483, 223);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(70, 19);
            this.btnAddItem.TabIndex = 26;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // OrderItemsTheGrid
            // 
            this.OrderItemsTheGrid.GroupByCaption = "Drag a column header here to group by that column";
            this.OrderItemsTheGrid.Images.Add(((System.Drawing.Image)(resources.GetObject("OrderItemsTheGrid.Images"))));
            this.OrderItemsTheGrid.Location = new System.Drawing.Point(11, 253);
            this.OrderItemsTheGrid.Margin = new System.Windows.Forms.Padding(2);
            this.OrderItemsTheGrid.Name = "OrderItemsTheGrid";
            this.OrderItemsTheGrid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.OrderItemsTheGrid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.OrderItemsTheGrid.PreviewInfo.ZoomFactor = 75D;
            this.OrderItemsTheGrid.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.OrderItemsTheGrid.PrintInfo.MeasurementPrinterName = null;
            this.OrderItemsTheGrid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("OrderItemsTheGrid.PrintInfo.PageSettings")));
            this.OrderItemsTheGrid.Size = new System.Drawing.Size(702, 262);
            this.OrderItemsTheGrid.TabIndex = 29;
            this.OrderItemsTheGrid.UseCompatibleTextRendering = false;
            this.OrderItemsTheGrid.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.OrderItems_RowColChange);
            this.OrderItemsTheGrid.PropBag = resources.GetString("OrderItemsTheGrid.PropBag");
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(722, 562);
            this.Controls.Add(this.OrderItemsTheGrid);
            this.Controls.Add(this.btnSaveItem);
            this.Controls.Add(this.btnCancelItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.OrderItemsGrid);
            this.Controls.Add(this.tbxItemDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxOrderPanel);
            this.Controls.Add(this.tbxItem);
            this.Controls.Add(this.tbxTotalPrice);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.tbxLine);
            this.Controls.Add(this.lbltem);
            this.Controls.Add(this.cbxOrderItemStatus);
            this.Controls.Add(this.lbLine);
            this.Controls.Add(this.tbxUnitPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxQty);
            this.Controls.Add(this.lbQtyOrdered);
            this.Controls.Add(this.tbxBrand);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbItemStatus);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(618, 409);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.Shown += new System.EventHandler(this.OrdersForm_Shown);
            this.tbxOrderPanel.ResumeLayout(false);
            this.tbxOrderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemsTheGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tbxOrderPanel;
        private System.Windows.Forms.Label lbOrderStatus;
        private System.Windows.Forms.TextBox tbxOrderID;
        private System.Windows.Forms.ComboBox cbxOrderStatus;
        private System.Windows.Forms.Label OrderID;
        private System.Windows.Forms.TextBox tbxLine;
        private System.Windows.Forms.Label lbLine;
        private System.Windows.Forms.Label lbltem;
        private System.Windows.Forms.TextBox tbxBrand;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.TextBox tbxCustomerDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxCustomer;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbQtyOrdered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxItemDescription;
        private System.Windows.Forms.TextBox tbxItem;
        private System.Windows.Forms.Label lbItemStatus;
        private System.Windows.Forms.TextBox tbxQty;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.TextBox tbxTotalPrice;
        private System.Windows.Forms.ComboBox cbxOrderItemStatus;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid OrderItemsGrid;
        private System.Windows.Forms.Button btnSaveItem;
        private System.Windows.Forms.Button btnCancelItem;
        private System.Windows.Forms.Button btnAddItem;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid OrderItemsTheGrid;
    }
}