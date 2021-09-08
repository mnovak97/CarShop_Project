
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
            this.placeHolder = new System.Windows.Forms.Panel();
            this.tableLayoutMenu = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnBuyers = new System.Windows.Forms.Button();
            this.btnWorkOrders = new System.Windows.Forms.Button();
            this.tableLayoutMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // placeHolder
            // 
            this.placeHolder.BackColor = System.Drawing.Color.White;
            this.placeHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeHolder.Location = new System.Drawing.Point(0, 38);
            this.placeHolder.Name = "placeHolder";
            this.placeHolder.Size = new System.Drawing.Size(830, 438);
            this.placeHolder.TabIndex = 3;
            // 
            // tableLayoutMenu
            // 
            this.tableLayoutMenu.ColumnCount = 4;
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0015F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.33283F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.33283F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.33283F));
            this.tableLayoutMenu.Controls.Add(this.btnWorkOrders, 3, 0);
            this.tableLayoutMenu.Controls.Add(this.btnBuyers, 2, 0);
            this.tableLayoutMenu.Controls.Add(this.lblUsername, 0, 0);
            this.tableLayoutMenu.Controls.Add(this.btnItems, 1, 0);
            this.tableLayoutMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMenu.Name = "tableLayoutMenu";
            this.tableLayoutMenu.RowCount = 1;
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMenu.Size = new System.Drawing.Size(830, 38);
            this.tableLayoutMenu.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUsername.Location = new System.Drawing.Point(3, 11);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(118, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "label1";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.Location = new System.Drawing.Point(124, 0);
            this.btnItems.Margin = new System.Windows.Forms.Padding(0);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(235, 38);
            this.btnItems.TabIndex = 1;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnBuyers
            // 
            this.btnBuyers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuyers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuyers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBuyers.ForeColor = System.Drawing.Color.White;
            this.btnBuyers.Location = new System.Drawing.Point(359, 0);
            this.btnBuyers.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuyers.Name = "btnBuyers";
            this.btnBuyers.Size = new System.Drawing.Size(235, 38);
            this.btnBuyers.TabIndex = 2;
            this.btnBuyers.Text = "Buyers";
            this.btnBuyers.UseVisualStyleBackColor = false;
            this.btnBuyers.Click += new System.EventHandler(this.btnBuyers_Click);
            // 
            // btnWorkOrders
            // 
            this.btnWorkOrders.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnWorkOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWorkOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWorkOrders.ForeColor = System.Drawing.Color.White;
            this.btnWorkOrders.Location = new System.Drawing.Point(594, 0);
            this.btnWorkOrders.Margin = new System.Windows.Forms.Padding(0);
            this.btnWorkOrders.Name = "btnWorkOrders";
            this.btnWorkOrders.Size = new System.Drawing.Size(236, 38);
            this.btnWorkOrders.TabIndex = 3;
            this.btnWorkOrders.Text = "Work orders";
            this.btnWorkOrders.UseVisualStyleBackColor = false;
            this.btnWorkOrders.Click += new System.EventHandler(this.btnWorkOrders_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 476);
            this.Controls.Add(this.placeHolder);
            this.Controls.Add(this.tableLayoutMenu);
            this.Name = "MainForm";
            this.Text = "Main";
            this.tableLayoutMenu.ResumeLayout(false);
            this.tableLayoutMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel placeHolder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMenu;
        private System.Windows.Forms.Button btnWorkOrders;
        private System.Windows.Forms.Button btnBuyers;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnItems;
    }
}