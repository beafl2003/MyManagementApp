
namespace MyManagmentApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSearchCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.myAccountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiProducts,
            this.tsiCustomers,
            this.tsiOrders,
            this.tsiSearchCustomers});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.consultasToolStripMenuItem.Text = "Views";
            // 
            // tsiProducts
            // 
            this.tsiProducts.Name = "tsiProducts";
            this.tsiProducts.Size = new System.Drawing.Size(180, 22);
            this.tsiProducts.Text = "Products";
            // 
            // tsiCustomers
            // 
            this.tsiCustomers.Name = "tsiCustomers";
            this.tsiCustomers.Size = new System.Drawing.Size(180, 22);
            this.tsiCustomers.Text = "Customers";
            // 
            // tsiOrders
            // 
            this.tsiOrders.Name = "tsiOrders";
            this.tsiOrders.Size = new System.Drawing.Size(180, 22);
            this.tsiOrders.Text = "Orders";
            this.tsiOrders.Click += new System.EventHandler(this.tsiOrders_Click);
            // 
            // tsiSearchCustomers
            // 
            this.tsiSearchCustomers.Name = "tsiSearchCustomers";
            this.tsiSearchCustomers.Size = new System.Drawing.Size(180, 22);
            this.tsiSearchCustomers.Text = "Search Customers";
            this.tsiSearchCustomers.Visible = false;
            this.tsiSearchCustomers.Click += new System.EventHandler(this.tsiSearchCustomers_Click);
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoffToolStripMenuItem});
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.myAccountToolStripMenuItem.Text = "My Account";
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.logoffToolStripMenuItem.Text = "Log-off";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MyManagementApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiProducts;
        private System.Windows.Forms.ToolStripMenuItem tsiCustomers;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiOrders;
        private System.Windows.Forms.ToolStripMenuItem tsiSearchCustomers;
    }
}

