
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
            this.cbxCustomerStatus = new System.Windows.Forms.ComboBox();
            this.lbCustomerStatus = new System.Windows.Forms.Label();
            this.lbCustomerDescription = new System.Windows.Forms.Label();
            this.tbxcustomerID = new System.Windows.Forms.TextBox();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.tbxcustomerName = new System.Windows.Forms.TextBox();
            this.btnCustomerSave = new System.Windows.Forms.Button();
            this.CustomerGridNew = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbCustomerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridNew)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbCustomerPanel
            // 
            this.txbCustomerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCustomerPanel.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.txbCustomerPanel, 5);
            this.txbCustomerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.txbCustomerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.txbCustomerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.txbCustomerPanel.Controls.Add(this.cbxCustomerStatus, 2, 1);
            this.txbCustomerPanel.Controls.Add(this.lbCustomerStatus, 2, 0);
            this.txbCustomerPanel.Controls.Add(this.lbCustomerDescription, 1, 0);
            this.txbCustomerPanel.Controls.Add(this.tbxcustomerID, 0, 1);
            this.txbCustomerPanel.Controls.Add(this.lbCustomerID, 0, 0);
            this.txbCustomerPanel.Controls.Add(this.tbxcustomerName, 1, 1);
            this.txbCustomerPanel.Location = new System.Drawing.Point(0, 3);
            this.txbCustomerPanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txbCustomerPanel.Name = "txbCustomerPanel";
            this.txbCustomerPanel.RowCount = 2;
            this.txbCustomerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.txbCustomerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.txbCustomerPanel.Size = new System.Drawing.Size(800, 52);
            this.txbCustomerPanel.TabIndex = 3;
            // 
            // cbxCustomerStatus
            // 
            this.cbxCustomerStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCustomerStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cbxCustomerStatus.FormattingEnabled = true;
            this.cbxCustomerStatus.Location = new System.Drawing.Point(703, 22);
            this.cbxCustomerStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCustomerStatus.Name = "cbxCustomerStatus";
            this.cbxCustomerStatus.Size = new System.Drawing.Size(94, 24);
            this.cbxCustomerStatus.TabIndex = 9;
            // 
            // lbCustomerStatus
            // 
            this.lbCustomerStatus.Location = new System.Drawing.Point(703, 0);
            this.lbCustomerStatus.Name = "lbCustomerStatus";
            this.lbCustomerStatus.Size = new System.Drawing.Size(94, 17);
            this.lbCustomerStatus.TabIndex = 10;
            this.lbCustomerStatus.Text = "Status";
            // 
            // lbCustomerDescription
            // 
            this.lbCustomerDescription.Location = new System.Drawing.Point(103, 0);
            this.lbCustomerDescription.Name = "lbCustomerDescription";
            this.lbCustomerDescription.Size = new System.Drawing.Size(100, 17);
            this.lbCustomerDescription.TabIndex = 8;
            this.lbCustomerDescription.Text = "Full Name";
            // 
            // tbxcustomerID
            // 
            this.tbxcustomerID.BackColor = System.Drawing.SystemColors.Info;
            this.tbxcustomerID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxcustomerID.Location = new System.Drawing.Point(3, 22);
            this.tbxcustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxcustomerID.Name = "tbxcustomerID";
            this.tbxcustomerID.Size = new System.Drawing.Size(94, 22);
            this.tbxcustomerID.TabIndex = 0;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Location = new System.Drawing.Point(3, 0);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(85, 17);
            this.lbCustomerID.TabIndex = 7;
            this.lbCustomerID.Text = "Customer ID";
            // 
            // tbxcustomerName
            // 
            this.tbxcustomerName.BackColor = System.Drawing.SystemColors.Info;
            this.tbxcustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxcustomerName.Location = new System.Drawing.Point(103, 22);
            this.tbxcustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxcustomerName.Name = "tbxcustomerName";
            this.tbxcustomerName.Size = new System.Drawing.Size(594, 22);
            this.tbxcustomerName.TabIndex = 1;
            // 
            // btnCustomerSave
            // 
            this.btnCustomerSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomerSave.Location = new System.Drawing.Point(603, 60);
            this.btnCustomerSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomerSave.Name = "btnCustomerSave";
            this.btnCustomerSave.Size = new System.Drawing.Size(94, 23);
            this.btnCustomerSave.TabIndex = 12;
            this.btnCustomerSave.Text = "Save";
            this.btnCustomerSave.UseVisualStyleBackColor = true;
            // 
            // CustomerGridNew
            // 
            this.CustomerGridNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.CustomerGridNew, 5);
            this.CustomerGridNew.GroupByCaption = "Drag a column header here to group by that column";
            this.CustomerGridNew.Location = new System.Drawing.Point(3, 87);
            this.CustomerGridNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerGridNew.Name = "CustomerGridNew";
            this.CustomerGridNew.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.CustomerGridNew.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.CustomerGridNew.PreviewInfo.ZoomFactor = 75D;
            this.CustomerGridNew.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.CustomerGridNew.PrintInfo.MeasurementPrinterName = null;
            this.CustomerGridNew.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("CustomerGridNew.PrintInfo.PageSettings")));
            this.CustomerGridNew.PropBag = resources.GetString("CustomerGridNew.PropBag");
            this.CustomerGridNew.Size = new System.Drawing.Size(794, 361);
            this.CustomerGridNew.TabIndex = 14;
            this.CustomerGridNew.UseCompatibleTextRendering = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(403, 60);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(703, 60);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCustomerSave, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbCustomerPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CustomerGridNew, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(503, 60);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "CustomersForm";
            this.Text = "Customers";
            this.txbCustomerPanel.ResumeLayout(false);
            this.txbCustomerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridNew)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel txbCustomerPanel;
        private System.Windows.Forms.TextBox tbxcustomerID;
        private System.Windows.Forms.TextBox tbxcustomerName;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Label lbCustomerDescription;
        private System.Windows.Forms.ComboBox cbxCustomerStatus;
        private System.Windows.Forms.Label lbCustomerStatus;
        private System.Windows.Forms.Button btnCustomerSave;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid CustomerGridNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
    }
}