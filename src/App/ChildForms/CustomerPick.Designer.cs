
namespace MyManagementApp.ChildForms
{
    partial class CustomerPick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPick));
            this.CustomerGrid = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.ChooseCustomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerGrid
            // 
            this.CustomerGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CustomerGrid.GroupByCaption = "Drag a column header here to group by that column";
            this.CustomerGrid.Location = new System.Drawing.Point(0, 26);
            this.CustomerGrid.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerGrid.Name = "CustomerGrid";
            this.CustomerGrid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.CustomerGrid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.CustomerGrid.PreviewInfo.ZoomFactor = 75D;
            this.CustomerGrid.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.CustomerGrid.PrintInfo.MeasurementPrinterName = null;
            this.CustomerGrid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("CustomerGridNew.PrintInfo.PageSettings")));
            this.CustomerGrid.PropBag = resources.GetString("CustomerGrid.PropBag");
            this.CustomerGrid.Size = new System.Drawing.Size(633, 322);
            this.CustomerGrid.TabIndex = 15;
            this.CustomerGrid.UseCompatibleTextRendering = false;
            // 
            // ChooseCustomer
            // 
            this.ChooseCustomer.AutoSize = true;
            this.ChooseCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseCustomer.Location = new System.Drawing.Point(-1, 9);
            this.ChooseCustomer.Name = "ChooseCustomer";
            this.ChooseCustomer.Size = new System.Drawing.Size(171, 15);
            this.ChooseCustomer.TabIndex = 16;
            this.ChooseCustomer.Text = "Please choose your customer;";
            // 
            // CustomerPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 348);
            this.Controls.Add(this.ChooseCustomer);
            this.Controls.Add(this.CustomerGrid);
            this.MinimumSize = new System.Drawing.Size(649, 387);
            this.Name = "CustomerPick";
            this.Text = "CustomerPick";
            this.Shown += new System.EventHandler(this.CustomerPick_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid CustomerGrid;
        private System.Windows.Forms.Label ChooseCustomer;
    }
}