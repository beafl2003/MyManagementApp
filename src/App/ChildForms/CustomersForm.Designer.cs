
namespace MyManagementApp.ChildForms
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.txbCustomerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tbxcustomerID = new System.Windows.Forms.TextBox();
            this.tbxcustomerName = new System.Windows.Forms.TextBox();
            this.CustomerPanel = new System.Windows.Forms.Panel();
            this.lbCustomerStatus = new System.Windows.Forms.Label();
            this.cbxCustomerStatus = new System.Windows.Forms.ComboBox();
            this.lbCustomerDescription = new System.Windows.Forms.Label();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.btnCustomerSave = new System.Windows.Forms.Button();
            this.CustomerGridNew = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbCustomerPanel.SuspendLayout();
            this.CustomerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridNew)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCustomerPanel
            // 
            this.txbCustomerPanel.ColumnCount = 2;
            this.txbCustomerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.71713F));
            this.txbCustomerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.28288F));
            this.txbCustomerPanel.Controls.Add(this.tbxcustomerID, 0, 0);
            this.txbCustomerPanel.Controls.Add(this.tbxcustomerName, 1, 0);
            this.txbCustomerPanel.Location = new System.Drawing.Point(5, 28);
            this.txbCustomerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCustomerPanel.Name = "txbCustomerPanel";
            this.txbCustomerPanel.RowCount = 1;
            this.txbCustomerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.txbCustomerPanel.Size = new System.Drawing.Size(595, 33);
            this.txbCustomerPanel.TabIndex = 3;
            // 
            // tbxcustomerID
            // 
            this.tbxcustomerID.BackColor = System.Drawing.SystemColors.Info;
            this.tbxcustomerID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxcustomerID.Location = new System.Drawing.Point(3, 2);
            this.tbxcustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxcustomerID.Name = "tbxcustomerID";
            this.tbxcustomerID.Size = new System.Drawing.Size(117, 22);
            this.tbxcustomerID.TabIndex = 0;
            // 
            // tbxcustomerName
            // 
            this.tbxcustomerName.BackColor = System.Drawing.SystemColors.Info;
            this.tbxcustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxcustomerName.Location = new System.Drawing.Point(126, 2);
            this.tbxcustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxcustomerName.Name = "tbxcustomerName";
            this.tbxcustomerName.Size = new System.Drawing.Size(466, 22);
            this.tbxcustomerName.TabIndex = 1;
            // 
            // CustomerPanel
            // 
            this.CustomerPanel.Controls.Add(this.lbCustomerStatus);
            this.CustomerPanel.Controls.Add(this.cbxCustomerStatus);
            this.CustomerPanel.Controls.Add(this.lbCustomerDescription);
            this.CustomerPanel.Controls.Add(this.lbCustomerID);
            this.CustomerPanel.Controls.Add(this.txbCustomerPanel);
            this.CustomerPanel.Location = new System.Drawing.Point(25, 12);
            this.CustomerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Size = new System.Drawing.Size(731, 66);
            this.CustomerPanel.TabIndex = 4;
            // 
            // lbCustomerStatus
            // 
            this.lbCustomerStatus.Location = new System.Drawing.Point(605, 9);
            this.lbCustomerStatus.Name = "lbCustomerStatus";
            this.lbCustomerStatus.Size = new System.Drawing.Size(100, 17);
            this.lbCustomerStatus.TabIndex = 10;
            this.lbCustomerStatus.Text = "Status";
            // 
            // cbxCustomerStatus
            // 
            this.cbxCustomerStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cbxCustomerStatus.FormattingEnabled = true;
            this.cbxCustomerStatus.Location = new System.Drawing.Point(605, 30);
            this.cbxCustomerStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCustomerStatus.Name = "cbxCustomerStatus";
            this.cbxCustomerStatus.Size = new System.Drawing.Size(121, 24);
            this.cbxCustomerStatus.TabIndex = 9;
            // 
            // lbCustomerDescription
            // 
            this.lbCustomerDescription.Location = new System.Drawing.Point(129, 7);
            this.lbCustomerDescription.Name = "lbCustomerDescription";
            this.lbCustomerDescription.Size = new System.Drawing.Size(100, 17);
            this.lbCustomerDescription.TabIndex = 8;
            this.lbCustomerDescription.Text = "Full Name";
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Location = new System.Drawing.Point(5, 7);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(85, 17);
            this.lbCustomerID.TabIndex = 7;
            this.lbCustomerID.Text = "Customer ID";
            // 
            // btnCustomerSave
            // 
            this.btnCustomerSave.Location = new System.Drawing.Point(681, 98);
            this.btnCustomerSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomerSave.Name = "btnCustomerSave";
            this.btnCustomerSave.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerSave.TabIndex = 12;
            this.btnCustomerSave.Text = "Save";
            this.btnCustomerSave.UseVisualStyleBackColor = true;
            // 
            // CustomerGridNew
            // 
            this.CustomerGridNew.GroupByCaption = "Drag a column header here to group by that column";
            this.CustomerGridNew.Location = new System.Drawing.Point(12, 144);
            this.CustomerGridNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerGridNew.Name = "CustomerGridNew";
            this.CustomerGridNew.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.CustomerGridNew.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.CustomerGridNew.PreviewInfo.ZoomFactor = 75D;
            this.CustomerGridNew.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.CustomerGridNew.PrintInfo.MeasurementPrinterName = null;
            this.CustomerGridNew.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("CustomerGridNew.PrintInfo.PageSettings")));
            this.CustomerGridNew.PropBag = resources.GetString("CustomerGridNew.PropBag");
            this.CustomerGridNew.Size = new System.Drawing.Size(775, 276);
            this.CustomerGridNew.TabIndex = 14;
            this.CustomerGridNew.UseCompatibleTextRendering = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(579, 98);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(475, 98);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.CustomerGridNew);
            this.Controls.Add(this.btnCustomerSave);
            this.Controls.Add(this.CustomerPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomersForm";
            this.Text = "Customers";
            this.txbCustomerPanel.ResumeLayout(false);
            this.txbCustomerPanel.PerformLayout();
            this.CustomerPanel.ResumeLayout(false);
            this.CustomerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel txbCustomerPanel;
        private System.Windows.Forms.TextBox tbxcustomerID;
        private System.Windows.Forms.TextBox tbxcustomerName;
        private System.Windows.Forms.Panel CustomerPanel;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Label lbCustomerDescription;
        private System.Windows.Forms.ComboBox cbxCustomerStatus;
        private System.Windows.Forms.Label lbCustomerStatus;
        private System.Windows.Forms.Button btnCustomerSave;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid CustomerGridNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}