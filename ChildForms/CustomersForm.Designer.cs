
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
            this.txbCustomerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tbxcustomerID = new System.Windows.Forms.TextBox();
            this.tbxcustomerName = new System.Windows.Forms.TextBox();
            this.CustomerPanel = new System.Windows.Forms.Panel();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.lbCustomerDescription = new System.Windows.Forms.Label();
            this.cbxCustomerStatus = new System.Windows.Forms.ComboBox();
            this.lbCustomerStatus = new System.Windows.Forms.Label();
            this.txbCustomerPanel.SuspendLayout();
            this.CustomerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbCustomerPanel
            // 
            this.txbCustomerPanel.ColumnCount = 2;
            this.txbCustomerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.71713F));
            this.txbCustomerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.28288F));
            this.txbCustomerPanel.Controls.Add(this.tbxcustomerID, 0, 0);
            this.txbCustomerPanel.Controls.Add(this.tbxcustomerName, 1, 0);
            this.txbCustomerPanel.Location = new System.Drawing.Point(6, 28);
            this.txbCustomerPanel.Name = "txbCustomerPanel";
            this.txbCustomerPanel.RowCount = 1;
            this.txbCustomerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.txbCustomerPanel.Size = new System.Drawing.Size(594, 33);
            this.txbCustomerPanel.TabIndex = 3;
            // 
            // tbxcustomerID
            // 
            this.tbxcustomerID.BackColor = System.Drawing.SystemColors.Info;
            this.tbxcustomerID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxcustomerID.Location = new System.Drawing.Point(3, 3);
            this.tbxcustomerID.Name = "tbxcustomerID";
            this.tbxcustomerID.Size = new System.Drawing.Size(117, 22);
            this.tbxcustomerID.TabIndex = 0;
            // 
            // tbxcustomerName
            // 
            this.tbxcustomerName.BackColor = System.Drawing.SystemColors.Info;
            this.tbxcustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxcustomerName.Location = new System.Drawing.Point(126, 3);
            this.tbxcustomerName.Name = "tbxcustomerName";
            this.tbxcustomerName.Size = new System.Drawing.Size(465, 22);
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
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Size = new System.Drawing.Size(731, 66);
            this.CustomerPanel.TabIndex = 4;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Location = new System.Drawing.Point(6, 8);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(85, 17);
            this.lbCustomerID.TabIndex = 7;
            this.lbCustomerID.Text = "Customer ID";
            // 
            // lbCustomerDescription
            // 
            this.lbCustomerDescription.Location = new System.Drawing.Point(129, 8);
            this.lbCustomerDescription.Name = "lbCustomerDescription";
            this.lbCustomerDescription.Size = new System.Drawing.Size(100, 17);
            this.lbCustomerDescription.TabIndex = 8;
            this.lbCustomerDescription.Text = "Full Name";
            // 
            // cbxCustomerStatus
            // 
            this.cbxCustomerStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cbxCustomerStatus.FormattingEnabled = true;
            this.cbxCustomerStatus.Location = new System.Drawing.Point(606, 29);
            this.cbxCustomerStatus.Name = "cbxCustomerStatus";
            this.cbxCustomerStatus.Size = new System.Drawing.Size(121, 24);
            this.cbxCustomerStatus.TabIndex = 9;
            // 
            // lbCustomerStatus
            // 
            this.lbCustomerStatus.Location = new System.Drawing.Point(606, 9);
            this.lbCustomerStatus.Name = "lbCustomerStatus";
            this.lbCustomerStatus.Size = new System.Drawing.Size(100, 17);
            this.lbCustomerStatus.TabIndex = 10;
            this.lbCustomerStatus.Text = "Status";
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerPanel);
            this.Name = "CustomersForm";
            this.Text = "Customers";
            this.txbCustomerPanel.ResumeLayout(false);
            this.txbCustomerPanel.PerformLayout();
            this.CustomerPanel.ResumeLayout(false);
            this.CustomerPanel.PerformLayout();
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
    }
}