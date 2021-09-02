
namespace CarShop_DesktopApp
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
            this.mnStripMainForm = new System.Windows.Forms.MenuStrip();
            this.tsmUsername = new System.Windows.Forms.ToolStripMenuItem();
            this.viewWorkOrdersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItems = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBuyers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWorkOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.placeHolder = new System.Windows.Forms.Panel();
            this.mnStripMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnStripMainForm
            // 
            this.mnStripMainForm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mnStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUsername,
            this.tsmItems,
            this.tsmBuyers,
            this.tsmWorkOrders});
            this.mnStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.mnStripMainForm.Name = "mnStripMainForm";
            this.mnStripMainForm.Size = new System.Drawing.Size(830, 33);
            this.mnStripMainForm.TabIndex = 2;
            this.mnStripMainForm.Text = "menuStripMain";
            // 
            // tsmUsername
            // 
            this.tsmUsername.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewWorkOrdersToolStripMenuItem1,
            this.logOutToolStripMenuItem});
            this.tsmUsername.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tsmUsername.Name = "tsmUsername";
            this.tsmUsername.Size = new System.Drawing.Size(84, 29);
            this.tsmUsername.Text = "Place holder";
            // 
            // viewWorkOrdersToolStripMenuItem1
            // 
            this.viewWorkOrdersToolStripMenuItem1.Name = "viewWorkOrdersToolStripMenuItem1";
            this.viewWorkOrdersToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.viewWorkOrdersToolStripMenuItem1.Text = "My profile";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // tsmItems
            // 
            this.tsmItems.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tsmItems.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tsmItems.ForeColor = System.Drawing.SystemColors.Window;
            this.tsmItems.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.tsmItems.Name = "tsmItems";
            this.tsmItems.Size = new System.Drawing.Size(72, 29);
            this.tsmItems.Text = "Items";
            this.tsmItems.Click += new System.EventHandler(this.tsmItems_Click);
            // 
            // tsmBuyers
            // 
            this.tsmBuyers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tsmBuyers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tsmBuyers.ForeColor = System.Drawing.SystemColors.Window;
            this.tsmBuyers.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.tsmBuyers.Name = "tsmBuyers";
            this.tsmBuyers.Size = new System.Drawing.Size(84, 29);
            this.tsmBuyers.Text = "Buyers";
            this.tsmBuyers.Click += new System.EventHandler(this.tsmBuyers_Click);
            // 
            // tsmWorkOrders
            // 
            this.tsmWorkOrders.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tsmWorkOrders.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tsmWorkOrders.ForeColor = System.Drawing.SystemColors.Window;
            this.tsmWorkOrders.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.tsmWorkOrders.Name = "tsmWorkOrders";
            this.tsmWorkOrders.Size = new System.Drawing.Size(138, 29);
            this.tsmWorkOrders.Text = "Work Orders";
            this.tsmWorkOrders.Click += new System.EventHandler(this.tsmWorkOrders_Click);
            // 
            // placeHolder
            // 
            this.placeHolder.BackColor = System.Drawing.Color.White;
            this.placeHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeHolder.Location = new System.Drawing.Point(0, 33);
            this.placeHolder.Name = "placeHolder";
            this.placeHolder.Size = new System.Drawing.Size(830, 443);
            this.placeHolder.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(830, 476);
            this.Controls.Add(this.placeHolder);
            this.Controls.Add(this.mnStripMainForm);
            this.Name = "MainForm";
            this.Text = "Main";
            this.mnStripMainForm.ResumeLayout(false);
            this.mnStripMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem tsmUsername;
        private System.Windows.Forms.ToolStripMenuItem viewWorkOrdersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmItems;
        private System.Windows.Forms.ToolStripMenuItem tsmBuyers;
        private System.Windows.Forms.ToolStripMenuItem tsmWorkOrders;
        private System.Windows.Forms.Panel placeHolder;
    }
}