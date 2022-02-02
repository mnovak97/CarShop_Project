
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
            this.lblUserControl = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnTasks = new FontAwesome.Sharp.IconButton();
            this.btnPickUp = new FontAwesome.Sharp.IconButton();
            this.btnReceipt = new FontAwesome.Sharp.IconButton();
            this.btnWorkOrders = new FontAwesome.Sharp.IconButton();
            this.btnBuyers = new FontAwesome.Sharp.IconButton();
            this.btnItems = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconCurrent = new FontAwesome.Sharp.IconPictureBox();
            this.placeHolder = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserControl
            // 
            this.lblUserControl.AutoSize = true;
            this.lblUserControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUserControl.ForeColor = System.Drawing.Color.White;
            this.lblUserControl.Location = new System.Drawing.Point(57, 28);
            this.lblUserControl.Name = "lblUserControl";
            this.lblUserControl.Size = new System.Drawing.Size(49, 16);
            this.lblUserControl.TabIndex = 0;
            this.lblUserControl.Text = "Home";
            this.lblUserControl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelMenu.Controls.Add(this.btnTasks);
            this.panelMenu.Controls.Add(this.btnPickUp);
            this.panelMenu.Controls.Add(this.btnReceipt);
            this.panelMenu.Controls.Add(this.btnWorkOrders);
            this.panelMenu.Controls.Add(this.btnBuyers);
            this.panelMenu.Controls.Add(this.btnItems);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(179, 476);
            this.panelMenu.TabIndex = 4;
            // 
            // btnTasks
            // 
            this.btnTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTasks.FlatAppearance.BorderSize = 0;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTasks.ForeColor = System.Drawing.Color.White;
            this.btnTasks.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btnTasks.IconColor = System.Drawing.Color.White;
            this.btnTasks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTasks.IconSize = 32;
            this.btnTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.Location = new System.Drawing.Point(0, 350);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTasks.Size = new System.Drawing.Size(179, 50);
            this.btnTasks.TabIndex = 6;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnPickUp
            // 
            this.btnPickUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPickUp.FlatAppearance.BorderSize = 0;
            this.btnPickUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPickUp.ForeColor = System.Drawing.Color.White;
            this.btnPickUp.IconChar = FontAwesome.Sharp.IconChar.CarCrash;
            this.btnPickUp.IconColor = System.Drawing.Color.White;
            this.btnPickUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPickUp.IconSize = 32;
            this.btnPickUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPickUp.Location = new System.Drawing.Point(0, 300);
            this.btnPickUp.Name = "btnPickUp";
            this.btnPickUp.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPickUp.Size = new System.Drawing.Size(179, 50);
            this.btnPickUp.TabIndex = 5;
            this.btnPickUp.Text = "Pick up requests";
            this.btnPickUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPickUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPickUp.UseVisualStyleBackColor = true;
            this.btnPickUp.Click += new System.EventHandler(this.btnPickUp_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReceipt.ForeColor = System.Drawing.Color.White;
            this.btnReceipt.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnReceipt.IconColor = System.Drawing.Color.White;
            this.btnReceipt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReceipt.IconSize = 32;
            this.btnReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipt.Location = new System.Drawing.Point(0, 250);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReceipt.Size = new System.Drawing.Size(179, 50);
            this.btnReceipt.TabIndex = 4;
            this.btnReceipt.Text = "Receipts";
            this.btnReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnWorkOrders
            // 
            this.btnWorkOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkOrders.FlatAppearance.BorderSize = 0;
            this.btnWorkOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWorkOrders.ForeColor = System.Drawing.Color.White;
            this.btnWorkOrders.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            this.btnWorkOrders.IconColor = System.Drawing.Color.White;
            this.btnWorkOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWorkOrders.IconSize = 32;
            this.btnWorkOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkOrders.Location = new System.Drawing.Point(0, 200);
            this.btnWorkOrders.Name = "btnWorkOrders";
            this.btnWorkOrders.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnWorkOrders.Size = new System.Drawing.Size(179, 50);
            this.btnWorkOrders.TabIndex = 3;
            this.btnWorkOrders.Text = "Work orders";
            this.btnWorkOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWorkOrders.UseVisualStyleBackColor = true;
            this.btnWorkOrders.Click += new System.EventHandler(this.btnWorkOrders_Click);
            // 
            // btnBuyers
            // 
            this.btnBuyers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuyers.FlatAppearance.BorderSize = 0;
            this.btnBuyers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBuyers.ForeColor = System.Drawing.Color.White;
            this.btnBuyers.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnBuyers.IconColor = System.Drawing.Color.White;
            this.btnBuyers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuyers.IconSize = 32;
            this.btnBuyers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuyers.Location = new System.Drawing.Point(0, 150);
            this.btnBuyers.Name = "btnBuyers";
            this.btnBuyers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBuyers.Size = new System.Drawing.Size(179, 50);
            this.btnBuyers.TabIndex = 2;
            this.btnBuyers.Text = "Buyers";
            this.btnBuyers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuyers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuyers.UseVisualStyleBackColor = true;
            this.btnBuyers.Click += new System.EventHandler(this.btnBuyers_Click);
            // 
            // btnItems
            // 
            this.btnItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItems.FlatAppearance.BorderSize = 0;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnItems.IconColor = System.Drawing.Color.White;
            this.btnItems.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnItems.IconSize = 32;
            this.btnItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItems.Location = new System.Drawing.Point(0, 100);
            this.btnItems.Name = "btnItems";
            this.btnItems.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnItems.Size = new System.Drawing.Size(179, 50);
            this.btnItems.TabIndex = 1;
            this.btnItems.Text = "Items";
            this.btnItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.imgHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 100);
            this.panel2.TabIndex = 0;
            // 
            // imgHome
            // 
            this.imgHome.Image = global::CarShop_DesktopApp.Properties.Resources.logo;
            this.imgHome.Location = new System.Drawing.Point(32, 12);
            this.imgHome.Name = "imgHome";
            this.imgHome.Size = new System.Drawing.Size(117, 73);
            this.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHome.TabIndex = 0;
            this.imgHome.TabStop = false;
            this.imgHome.Click += new System.EventHandler(this.imgHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lblUserControl);
            this.panel1.Controls.Add(this.iconCurrent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(179, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 55);
            this.panel1.TabIndex = 5;
            // 
            // iconCurrent
            // 
            this.iconCurrent.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconCurrent.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrent.IconColor = System.Drawing.Color.White;
            this.iconCurrent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrent.Location = new System.Drawing.Point(19, 12);
            this.iconCurrent.Name = "iconCurrent";
            this.iconCurrent.Size = new System.Drawing.Size(32, 32);
            this.iconCurrent.TabIndex = 1;
            this.iconCurrent.TabStop = false;
            // 
            // placeHolder
            // 
            this.placeHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeHolder.Location = new System.Drawing.Point(179, 55);
            this.placeHolder.Name = "placeHolder";
            this.placeHolder.Size = new System.Drawing.Size(651, 421);
            this.placeHolder.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 476);
            this.Controls.Add(this.placeHolder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.Text = "Main";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUserControl;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnWorkOrders;
        private FontAwesome.Sharp.IconButton btnBuyers;
        private FontAwesome.Sharp.IconButton btnItems;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imgHome;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrent;
        private System.Windows.Forms.Panel placeHolder;
        private FontAwesome.Sharp.IconButton btnReceipt;
        private FontAwesome.Sharp.IconButton btnPickUp;
        private FontAwesome.Sharp.IconButton btnTasks;
    }
}