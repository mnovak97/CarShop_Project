
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
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.mnStripMainForm = new System.Windows.Forms.MenuStrip();
            this.tsmUsername = new System.Windows.Forms.ToolStripMenuItem();
            this.viewItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIewWorkOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewWorkOrdersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewBuyer = new System.Windows.Forms.Button();
            this.btnNewWorkOrder = new System.Windows.Forms.Button();
            this.btnNewReceipt = new System.Windows.Forms.Button();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStripMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(324, 206);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(145, 23);
            this.btnAddNewItem.TabIndex = 1;
            this.btnAddNewItem.Text = "Add new item";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            // 
            // mnStripMainForm
            // 
            this.mnStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUsername});
            this.mnStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.mnStripMainForm.Name = "mnStripMainForm";
            this.mnStripMainForm.Size = new System.Drawing.Size(830, 24);
            this.mnStripMainForm.TabIndex = 2;
            this.mnStripMainForm.Text = "menuStripMain";
            // 
            // tsmUsername
            // 
            this.tsmUsername.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewItemsToolStripMenuItem,
            this.vIewWorkOrdersToolStripMenuItem,
            this.viewWorkOrdersToolStripMenuItem1,
            this.logOutToolStripMenuItem});
            this.tsmUsername.Name = "tsmUsername";
            this.tsmUsername.Size = new System.Drawing.Size(125, 20);
            this.tsmUsername.Text = "toolStripMenuItem1";
            // 
            // viewItemsToolStripMenuItem
            // 
            this.viewItemsToolStripMenuItem.Name = "viewItemsToolStripMenuItem";
            this.viewItemsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewItemsToolStripMenuItem.Text = "View buyers";
            // 
            // vIewWorkOrdersToolStripMenuItem
            // 
            this.vIewWorkOrdersToolStripMenuItem.Name = "vIewWorkOrdersToolStripMenuItem";
            this.vIewWorkOrdersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vIewWorkOrdersToolStripMenuItem.Text = "VIew items";
            // 
            // viewWorkOrdersToolStripMenuItem1
            // 
            this.viewWorkOrdersToolStripMenuItem1.Name = "viewWorkOrdersToolStripMenuItem1";
            this.viewWorkOrdersToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.viewWorkOrdersToolStripMenuItem1.Text = "View work orders";
            // 
            // btnNewBuyer
            // 
            this.btnNewBuyer.Location = new System.Drawing.Point(324, 177);
            this.btnNewBuyer.Name = "btnNewBuyer";
            this.btnNewBuyer.Size = new System.Drawing.Size(145, 23);
            this.btnNewBuyer.TabIndex = 3;
            this.btnNewBuyer.Text = "Add new buyer";
            this.btnNewBuyer.UseVisualStyleBackColor = true;
            // 
            // btnNewWorkOrder
            // 
            this.btnNewWorkOrder.Location = new System.Drawing.Point(324, 235);
            this.btnNewWorkOrder.Name = "btnNewWorkOrder";
            this.btnNewWorkOrder.Size = new System.Drawing.Size(145, 23);
            this.btnNewWorkOrder.TabIndex = 4;
            this.btnNewWorkOrder.Text = "Make a new work order";
            this.btnNewWorkOrder.UseVisualStyleBackColor = true;
            // 
            // btnNewReceipt
            // 
            this.btnNewReceipt.Location = new System.Drawing.Point(324, 264);
            this.btnNewReceipt.Name = "btnNewReceipt";
            this.btnNewReceipt.Size = new System.Drawing.Size(145, 23);
            this.btnNewReceipt.TabIndex = 5;
            this.btnNewReceipt.Text = "Make a receipt";
            this.btnNewReceipt.UseVisualStyleBackColor = true;
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 476);
            this.Controls.Add(this.btnNewReceipt);
            this.Controls.Add(this.btnNewWorkOrder);
            this.Controls.Add(this.btnNewBuyer);
            this.Controls.Add(this.btnAddNewItem);
            this.Controls.Add(this.mnStripMainForm);
            this.Name = "MainForm";
            this.Text = "Main";
            this.mnStripMainForm.ResumeLayout(false);
            this.mnStripMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.MenuStrip mnStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem tsmUsername;
        private System.Windows.Forms.ToolStripMenuItem viewItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIewWorkOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewWorkOrdersToolStripMenuItem1;
        private System.Windows.Forms.Button btnNewBuyer;
        private System.Windows.Forms.Button btnNewReceipt;
        private System.Windows.Forms.Button btnNewWorkOrder;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}