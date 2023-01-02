
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
            this.tbxcustomerName = new System.Windows.Forms.TextBox();
            this.tbxcustomerID = new System.Windows.Forms.TextBox();
            this.lbPreview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerGrid
            // 
            this.CustomerGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CustomerGrid.GroupByCaption = "Drag a column header here to group by that column";
            this.CustomerGrid.Location = new System.Drawing.Point(0, 60);
            this.CustomerGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerGrid.Name = "CustomerGrid";
            this.CustomerGrid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.CustomerGrid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.CustomerGrid.PreviewInfo.ZoomFactor = 75D;
            this.CustomerGrid.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.CustomerGrid.PrintInfo.MeasurementPrinterName = null;
            this.CustomerGrid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("CustomerGrid.PrintInfo.PageSettings")));
            this.CustomerGrid.PropBag = resources.GetString("CustomerGrid.PropBag");
            this.CustomerGrid.Size = new System.Drawing.Size(841, 358);
            this.CustomerGrid.TabIndex = 15;
            this.CustomerGrid.UseCompatibleTextRendering = false;
            this.CustomerGrid.DoubleClick += new System.EventHandler(this.CustomerGrid_DoubleClick);
            this.CustomerGrid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CustomerGrid_KeyUp);
            // 
            // ChooseCustomer
            // 
            this.ChooseCustomer.AutoSize = true;
            this.ChooseCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseCustomer.Location = new System.Drawing.Point(16, 11);
            this.ChooseCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseCustomer.Name = "ChooseCustomer";
            this.ChooseCustomer.Size = new System.Drawing.Size(301, 23);
            this.ChooseCustomer.TabIndex = 16;
            this.ChooseCustomer.Text = "Press Enter to select the customer:";
            // 
            // tbxcustomerName
            // 
            this.tbxcustomerName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxcustomerName.BackColor = System.Drawing.SystemColors.Info;
            this.tbxcustomerName.Location = new System.Drawing.Point(287, 42);
            this.tbxcustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxcustomerName.Name = "tbxcustomerName";
            this.tbxcustomerName.Size = new System.Drawing.Size(528, 22);
            this.tbxcustomerName.TabIndex = 18;
            // 
            // tbxcustomerID
            // 
            this.tbxcustomerID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxcustomerID.BackColor = System.Drawing.SystemColors.Info;
            this.tbxcustomerID.Location = new System.Drawing.Point(211, 42);
            this.tbxcustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxcustomerID.Name = "tbxcustomerID";
            this.tbxcustomerID.Size = new System.Drawing.Size(71, 22);
            this.tbxcustomerID.TabIndex = 17;
            // 
            // lbPreview
            // 
            this.lbPreview.AutoSize = true;
            this.lbPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreview.Location = new System.Drawing.Point(128, 42);
            this.lbPreview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPreview.Name = "lbPreview";
            this.lbPreview.Size = new System.Drawing.Size(64, 18);
            this.lbPreview.TabIndex = 19;
            this.lbPreview.Text = "Preview:";
            // 
            // CustomerPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 418);
            this.Controls.Add(this.tbxcustomerID);
            this.Controls.Add(this.tbxcustomerName);
            this.Controls.Add(this.lbPreview);
            this.Controls.Add(this.ChooseCustomer);
            this.Controls.Add(this.CustomerGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(859, 465);
            this.MinimumSize = new System.Drawing.Size(859, 465);
            this.Name = "CustomerPick";
            this.Text = "CustomerPick";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerPick_FormClosing);
            this.Shown += new System.EventHandler(this.CustomerPick_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid CustomerGrid;
        private System.Windows.Forms.Label ChooseCustomer;
        private System.Windows.Forms.TextBox tbxcustomerName;
        private System.Windows.Forms.TextBox tbxcustomerID;
        private System.Windows.Forms.Label lbPreview;
    }
}