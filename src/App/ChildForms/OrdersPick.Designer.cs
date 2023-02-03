namespace TestandoComponentes.ChildForms
{
    partial class OrdersPick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersPick));
            this.OrdersGrid = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.CustomerGrid = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.c1TrueDBGrid2 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.ChooseOrder = new System.Windows.Forms.Label();
            this.lbPreview = new System.Windows.Forms.Label();
            this.tbxcustomerID = new System.Windows.Forms.TextBox();
            this.tbxcustomerName = new System.Windows.Forms.TextBox();
            this.tbxOrdernum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            this.c1Button2 = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button2)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrdersGrid.GroupByCaption = "Drag a column header here to group by that column";
            this.OrdersGrid.Images.Add(((System.Drawing.Image)(resources.GetObject("OrdersGrid.Images"))));
            this.OrdersGrid.Location = new System.Drawing.Point(0, 59);
            this.OrdersGrid.Margin = new System.Windows.Forms.Padding(2);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.OrdersGrid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.OrdersGrid.PreviewInfo.ZoomFactor = 75D;
            this.OrdersGrid.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.OrdersGrid.PrintInfo.MeasurementPrinterName = null;
            this.OrdersGrid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("OrdersGrid.PrintInfo.PageSettings")));
            this.OrdersGrid.Size = new System.Drawing.Size(632, 287);
            this.OrdersGrid.TabIndex = 16;
            this.OrdersGrid.UseCompatibleTextRendering = false;
            this.OrdersGrid.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.OrdersGrid_RowColChange);
            this.OrdersGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrdersGrid_KeyDown);
            this.OrdersGrid.PropBag = resources.GetString("OrdersGrid.PropBag");
            // 
            // CustomerGrid
            // 
            this.CustomerGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CustomerGrid.GroupByCaption = "Drag a column header here to group by that column";
            this.CustomerGrid.Images.Add(((System.Drawing.Image)(resources.GetObject("CustomerGrid.Images"))));
            this.CustomerGrid.Location = new System.Drawing.Point(0, -232);
            this.CustomerGrid.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerGrid.MaximumSize = new System.Drawing.Size(632, 291);
            this.CustomerGrid.MinimumSize = new System.Drawing.Size(632, 291);
            this.CustomerGrid.Name = "CustomerGrid";
            this.CustomerGrid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.CustomerGrid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.CustomerGrid.PreviewInfo.ZoomFactor = 75D;
            this.CustomerGrid.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.CustomerGrid.PrintInfo.MeasurementPrinterName = null;
            this.CustomerGrid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("CustomerGrid.PrintInfo.PageSettings")));
            this.CustomerGrid.Size = new System.Drawing.Size(632, 291);
            this.CustomerGrid.TabIndex = 17;
            this.CustomerGrid.UseCompatibleTextRendering = false;
            this.CustomerGrid.PropBag = resources.GetString("CustomerGrid.PropBag");
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(0, -523);
            this.c1TrueDBGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.c1TrueDBGrid1.PrintInfo.MeasurementPrinterName = null;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(632, 291);
            this.c1TrueDBGrid1.TabIndex = 18;
            this.c1TrueDBGrid1.UseCompatibleTextRendering = false;
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // c1TrueDBGrid2
            // 
            this.c1TrueDBGrid2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.c1TrueDBGrid2.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid2.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid2.Images"))));
            this.c1TrueDBGrid2.Location = new System.Drawing.Point(0, -814);
            this.c1TrueDBGrid2.Margin = new System.Windows.Forms.Padding(2);
            this.c1TrueDBGrid2.Name = "c1TrueDBGrid2";
            this.c1TrueDBGrid2.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid2.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid2.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid2.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.c1TrueDBGrid2.PrintInfo.MeasurementPrinterName = null;
            this.c1TrueDBGrid2.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid2.PrintInfo.PageSettings")));
            this.c1TrueDBGrid2.Size = new System.Drawing.Size(632, 291);
            this.c1TrueDBGrid2.TabIndex = 19;
            this.c1TrueDBGrid2.UseCompatibleTextRendering = false;
            this.c1TrueDBGrid2.PropBag = resources.GetString("c1TrueDBGrid2.PropBag");
            // 
            // ChooseOrder
            // 
            this.ChooseOrder.AutoSize = true;
            this.ChooseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseOrder.Location = new System.Drawing.Point(12, 9);
            this.ChooseOrder.Name = "ChooseOrder";
            this.ChooseOrder.Size = new System.Drawing.Size(201, 15);
            this.ChooseOrder.TabIndex = 20;
            this.ChooseOrder.Text = "Press Pick Order to select the order:";
            // 
            // lbPreview
            // 
            this.lbPreview.AutoSize = true;
            this.lbPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreview.Location = new System.Drawing.Point(12, 33);
            this.lbPreview.Name = "lbPreview";
            this.lbPreview.Size = new System.Drawing.Size(41, 15);
            this.lbPreview.TabIndex = 21;
            this.lbPreview.Text = "Order:";
            // 
            // tbxcustomerID
            // 
            this.tbxcustomerID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxcustomerID.BackColor = System.Drawing.SystemColors.Info;
            this.tbxcustomerID.Location = new System.Drawing.Point(185, 32);
            this.tbxcustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.tbxcustomerID.Name = "tbxcustomerID";
            this.tbxcustomerID.Size = new System.Drawing.Size(54, 20);
            this.tbxcustomerID.TabIndex = 22;
            // 
            // tbxcustomerName
            // 
            this.tbxcustomerName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxcustomerName.BackColor = System.Drawing.SystemColors.Info;
            this.tbxcustomerName.Location = new System.Drawing.Point(243, 32);
            this.tbxcustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxcustomerName.Name = "tbxcustomerName";
            this.tbxcustomerName.Size = new System.Drawing.Size(284, 20);
            this.tbxcustomerName.TabIndex = 23;
            // 
            // tbxOrdernum
            // 
            this.tbxOrdernum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxOrdernum.BackColor = System.Drawing.SystemColors.Info;
            this.tbxOrdernum.Location = new System.Drawing.Point(58, 33);
            this.tbxOrdernum.Margin = new System.Windows.Forms.Padding(2);
            this.tbxOrdernum.Name = "tbxOrdernum";
            this.tbxOrdernum.Size = new System.Drawing.Size(54, 20);
            this.tbxOrdernum.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Customer:";
            // 
            // c1Button1
            // 
            this.c1Button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.c1Button1.Location = new System.Drawing.Point(532, 31);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(88, 23);
            this.c1Button1.TabIndex = 26;
            this.c1Button1.Text = "Pick Order";
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            this.c1Button1.Click += new System.EventHandler(this.c1Button1_Click);
            // 
            // c1Button2
            // 
            this.c1Button2.Location = new System.Drawing.Point(526, 9);
            this.c1Button2.Name = "c1Button2";
            this.c1Button2.Size = new System.Drawing.Size(8, 8);
            this.c1Button2.TabIndex = 27;
            this.c1Button2.Text = "c1Button2";
            this.c1Button2.UseVisualStyleBackColor = true;
            // 
            // OrdersPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 346);
            this.Controls.Add(this.c1Button2);
            this.Controls.Add(this.c1Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxOrdernum);
            this.Controls.Add(this.tbxcustomerID);
            this.Controls.Add(this.tbxcustomerName);
            this.Controls.Add(this.lbPreview);
            this.Controls.Add(this.ChooseOrder);
            this.Controls.Add(this.c1TrueDBGrid2);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Controls.Add(this.CustomerGrid);
            this.Controls.Add(this.OrdersGrid);
            this.MaximumSize = new System.Drawing.Size(648, 385);
            this.MinimumSize = new System.Drawing.Size(648, 385);
            this.Name = "OrdersPick";
            this.Text = "OrdersPick";
            this.Load += new System.EventHandler(this.OrdersPick_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid OrdersGrid;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid CustomerGrid;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid2;
        private System.Windows.Forms.Label ChooseOrder;
        private System.Windows.Forms.Label lbPreview;
        private System.Windows.Forms.TextBox tbxcustomerID;
        private System.Windows.Forms.TextBox tbxcustomerName;
        private System.Windows.Forms.TextBox tbxOrdernum;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1Button c1Button1;
        private C1.Win.C1Input.C1Button c1Button2;
    }
}