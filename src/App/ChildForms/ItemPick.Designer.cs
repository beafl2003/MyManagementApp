namespace TestandoComponentes.ChildForms
{
    partial class ItemPick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemPick));
            this.ItemsGrid = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.ChooseOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxProductCode = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsGrid
            // 
            this.ItemsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsGrid.GroupByCaption = "Drag a column header here to group by that column";
            this.ItemsGrid.Images.Add(((System.Drawing.Image)(resources.GetObject("ItemsGrid.Images"))));
            this.ItemsGrid.Location = new System.Drawing.Point(1, 59);
            this.ItemsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ItemsGrid.Name = "ItemsGrid";
            this.ItemsGrid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.ItemsGrid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.ItemsGrid.PreviewInfo.ZoomFactor = 75D;
            this.ItemsGrid.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.ItemsGrid.PrintInfo.MeasurementPrinterName = null;
            this.ItemsGrid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("ItemsGrid.PrintInfo.PageSettings")));
            this.ItemsGrid.Size = new System.Drawing.Size(632, 287);
            this.ItemsGrid.TabIndex = 6;
            this.ItemsGrid.UseCompatibleTextRendering = false;
            this.ItemsGrid.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.ItemsGrid_RowColChange);
            this.ItemsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemsGrid_KeyDown);
            this.ItemsGrid.PropBag = resources.GetString("ItemsGrid.PropBag");
            // 
            // ChooseOrder
            // 
            this.ChooseOrder.AutoSize = true;
            this.ChooseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseOrder.Location = new System.Drawing.Point(12, 9);
            this.ChooseOrder.Name = "ChooseOrder";
            this.ChooseOrder.Size = new System.Drawing.Size(168, 15);
            this.ChooseOrder.TabIndex = 21;
            this.ChooseOrder.Text = "Press Enter to select the item:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Product:";
            // 
            // tbxProductCode
            // 
            this.tbxProductCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxProductCode.BackColor = System.Drawing.SystemColors.Info;
            this.tbxProductCode.Location = new System.Drawing.Point(69, 35);
            this.tbxProductCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbxProductCode.Name = "tbxProductCode";
            this.tbxProductCode.Size = new System.Drawing.Size(86, 20);
            this.tbxProductCode.TabIndex = 26;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxProductName.BackColor = System.Drawing.SystemColors.Info;
            this.tbxProductName.Location = new System.Drawing.Point(159, 35);
            this.tbxProductName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(462, 20);
            this.tbxProductName.TabIndex = 27;
            // 
            // ItemPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxProductCode);
            this.Controls.Add(this.tbxProductName);
            this.Controls.Add(this.ChooseOrder);
            this.Controls.Add(this.ItemsGrid);
            this.MaximumSize = new System.Drawing.Size(648, 385);
            this.MinimumSize = new System.Drawing.Size(648, 385);
            this.Name = "ItemPick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ItemPick";
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid ItemsGrid;
        private System.Windows.Forms.Label ChooseOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxProductCode;
        private System.Windows.Forms.TextBox tbxProductName;
    }
}