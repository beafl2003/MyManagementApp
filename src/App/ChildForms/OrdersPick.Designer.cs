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
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrdersGrid.GroupByCaption = "Drag a column header here to group by that column";
            this.OrdersGrid.Location = new System.Drawing.Point(0, 57);
            this.OrdersGrid.Margin = new System.Windows.Forms.Padding(2);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.OrdersGrid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.OrdersGrid.PreviewInfo.ZoomFactor = 75D;
            this.OrdersGrid.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.OrdersGrid.PrintInfo.MeasurementPrinterName = null;
            this.OrdersGrid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("OrdersGrid.PrintInfo.PageSettings")));
            this.OrdersGrid.PropBag = resources.GetString("OrdersGrid.PropBag");
            this.OrdersGrid.Size = new System.Drawing.Size(633, 291);
            this.OrdersGrid.TabIndex = 16;
            this.OrdersGrid.UseCompatibleTextRendering = false;
            // 
            // CustomerGrid
            // 
            this.CustomerGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CustomerGrid.GroupByCaption = "Drag a column header here to group by that column";
            this.CustomerGrid.Location = new System.Drawing.Point(0, -234);
            this.CustomerGrid.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerGrid.Name = "CustomerGrid";
            this.CustomerGrid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.CustomerGrid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.CustomerGrid.PreviewInfo.ZoomFactor = 75D;
            this.CustomerGrid.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.CustomerGrid.PrintInfo.MeasurementPrinterName = null;
            this.CustomerGrid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("CustomerGrid.PrintInfo.PageSettings")));
            this.CustomerGrid.PropBag = resources.GetString("CustomerGrid.PropBag");
            this.CustomerGrid.Size = new System.Drawing.Size(633, 291);
            this.CustomerGrid.TabIndex = 17;
            this.CustomerGrid.UseCompatibleTextRendering = false;
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(0, -525);
            this.c1TrueDBGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.c1TrueDBGrid1.PrintInfo.MeasurementPrinterName = null;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(633, 291);
            this.c1TrueDBGrid1.TabIndex = 18;
            this.c1TrueDBGrid1.UseCompatibleTextRendering = false;
            // 
            // c1TrueDBGrid2
            // 
            this.c1TrueDBGrid2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.c1TrueDBGrid2.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid2.Location = new System.Drawing.Point(0, -816);
            this.c1TrueDBGrid2.Margin = new System.Windows.Forms.Padding(2);
            this.c1TrueDBGrid2.Name = "c1TrueDBGrid2";
            this.c1TrueDBGrid2.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid2.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid2.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid2.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.c1TrueDBGrid2.PrintInfo.MeasurementPrinterName = null;
            this.c1TrueDBGrid2.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid2.PrintInfo.PageSettings")));
            this.c1TrueDBGrid2.PropBag = resources.GetString("c1TrueDBGrid2.PropBag");
            this.c1TrueDBGrid2.Size = new System.Drawing.Size(633, 291);
            this.c1TrueDBGrid2.TabIndex = 19;
            this.c1TrueDBGrid2.UseCompatibleTextRendering = false;
            // 
            // ChooseOrder
            // 
            this.ChooseOrder.AutoSize = true;
            this.ChooseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseOrder.Location = new System.Drawing.Point(12, 9);
            this.ChooseOrder.Name = "ChooseOrder";
            this.ChooseOrder.Size = new System.Drawing.Size(152, 15);
            this.ChooseOrder.TabIndex = 20;
            this.ChooseOrder.Text = "Please choose your order: ";
            // 
            // lbPreview
            // 
            this.lbPreview.AutoSize = true;
            this.lbPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreview.Location = new System.Drawing.Point(110, 34);
            this.lbPreview.Name = "lbPreview";
            this.lbPreview.Size = new System.Drawing.Size(53, 15);
            this.lbPreview.TabIndex = 21;
            this.lbPreview.Text = "Preview:";
            // 
            // tbxcustomerID
            // 
            this.tbxcustomerID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxcustomerID.BackColor = System.Drawing.SystemColors.Info;
            this.tbxcustomerID.Location = new System.Drawing.Point(168, 33);
            this.tbxcustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.tbxcustomerID.Name = "tbxcustomerID";
            this.tbxcustomerID.Size = new System.Drawing.Size(54, 20);
            this.tbxcustomerID.TabIndex = 22;
            // 
            // tbxcustomerName
            // 
            this.tbxcustomerName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxcustomerName.BackColor = System.Drawing.SystemColors.Info;
            this.tbxcustomerName.Location = new System.Drawing.Point(225, 33);
            this.tbxcustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxcustomerName.Name = "tbxcustomerName";
            this.tbxcustomerName.Size = new System.Drawing.Size(397, 20);
            this.tbxcustomerName.TabIndex = 23;
            // 
            // OrdersPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 348);
            this.Controls.Add(this.tbxcustomerID);
            this.Controls.Add(this.tbxcustomerName);
            this.Controls.Add(this.lbPreview);
            this.Controls.Add(this.ChooseOrder);
            this.Controls.Add(this.c1TrueDBGrid2);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Controls.Add(this.CustomerGrid);
            this.Controls.Add(this.OrdersGrid);
            this.MaximumSize = new System.Drawing.Size(649, 387);
            this.MinimumSize = new System.Drawing.Size(649, 387);
            this.Name = "OrdersPick";
            this.Text = "OrdersPick";
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid2)).EndInit();
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
    }
}