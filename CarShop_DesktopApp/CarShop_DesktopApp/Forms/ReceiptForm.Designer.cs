
namespace CarShop_DesktopApp.Forms
{
    partial class ReceiptForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new CarShop_DesktopApp.CustomControls.CustomComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBuyer = new CarShop_DesktopApp.CustomControls.CustomComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cblWorkOrders = new System.Windows.Forms.CheckedListBox();
            this.btnAddWorkOrders = new System.Windows.Forms.Button();
            this.placeHolder = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnNewReceipt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFormName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 56);
            this.panel1.TabIndex = 0;
            // 
            // lblFormName
            // 
            this.lblFormName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFormName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFormName.Location = new System.Drawing.Point(166, 20);
            this.lblFormName.Margin = new System.Windows.Forms.Padding(0);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(96, 16);
            this.lblFormName.TabIndex = 8;
            this.lblFormName.Text = "Receipt form";
            this.lblFormName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.24378F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.90547F));
            this.tableLayoutPanel1.Controls.Add(this.lblPaymentMethod, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbPaymentMethod, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbBuyer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cblWorkOrders, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddWorkOrders, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 210);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(34, 45);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(103, 15);
            this.lblPaymentMethod.TabIndex = 1;
            this.lblPaymentMethod.Text = "Payment method:";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.BackColor = System.Drawing.Color.White;
            this.cbPaymentMethod.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbPaymentMethod.BorderSize = 2;
            this.cbPaymentMethod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbPaymentMethod.ForeColor = System.Drawing.Color.Black;
            this.cbPaymentMethod.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbPaymentMethod.ListBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbPaymentMethod.ListTextColor = System.Drawing.Color.Black;
            this.cbPaymentMethod.Location = new System.Drawing.Point(140, 37);
            this.cbPaymentMethod.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Padding = new System.Windows.Forms.Padding(2);
            this.cbPaymentMethod.Size = new System.Drawing.Size(228, 30);
            this.cbPaymentMethod.TabIndex = 2;
            this.cbPaymentMethod.Texts = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(96, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buyer:";
            // 
            // cbBuyer
            // 
            this.cbBuyer.BackColor = System.Drawing.Color.White;
            this.cbBuyer.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbBuyer.BorderSize = 2;
            this.cbBuyer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbBuyer.ForeColor = System.Drawing.Color.Black;
            this.cbBuyer.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbBuyer.ListBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbBuyer.ListTextColor = System.Drawing.Color.Black;
            this.cbBuyer.Location = new System.Drawing.Point(140, 107);
            this.cbBuyer.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbBuyer.Name = "cbBuyer";
            this.cbBuyer.Padding = new System.Windows.Forms.Padding(2);
            this.cbBuyer.Size = new System.Drawing.Size(228, 30);
            this.cbBuyer.TabIndex = 4;
            this.cbBuyer.Texts = "";
            this.cbBuyer.OnSelectedIndexChanged += new System.EventHandler(this.cbBuyer_OnSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(23, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buyers work orders:";
            // 
            // cblWorkOrders
            // 
            this.cblWorkOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblWorkOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cblWorkOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cblWorkOrders.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cblWorkOrders.FormattingEnabled = true;
            this.cblWorkOrders.Location = new System.Drawing.Point(140, 145);
            this.cblWorkOrders.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cblWorkOrders.Name = "cblWorkOrders";
            this.cblWorkOrders.Size = new System.Drawing.Size(228, 62);
            this.cblWorkOrders.TabIndex = 6;
            // 
            // btnAddWorkOrders
            // 
            this.btnAddWorkOrders.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddWorkOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddWorkOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorkOrders.ForeColor = System.Drawing.Color.White;
            this.btnAddWorkOrders.Location = new System.Drawing.Point(374, 177);
            this.btnAddWorkOrders.Name = "btnAddWorkOrders";
            this.btnAddWorkOrders.Size = new System.Drawing.Size(82, 30);
            this.btnAddWorkOrders.TabIndex = 7;
            this.btnAddWorkOrders.Text = "Select ";
            this.btnAddWorkOrders.UseVisualStyleBackColor = false;
            this.btnAddWorkOrders.Click += new System.EventHandler(this.btnAddWorkOrders_Click);
            // 
            // placeHolder
            // 
            this.placeHolder.AutoScroll = true;
            this.placeHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.placeHolder.Location = new System.Drawing.Point(0, 266);
            this.placeHolder.Name = "placeHolder";
            this.placeHolder.Size = new System.Drawing.Size(459, 100);
            this.placeHolder.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnNewReceipt, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalPrice, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 366);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(459, 96);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalPrice.Location = new System.Drawing.Point(396, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(60, 48);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "Total price:";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewReceipt
            // 
            this.btnNewReceipt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewReceipt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNewReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewReceipt.ForeColor = System.Drawing.Color.White;
            this.btnNewReceipt.Location = new System.Drawing.Point(338, 58);
            this.btnNewReceipt.Margin = new System.Windows.Forms.Padding(10);
            this.btnNewReceipt.Name = "btnNewReceipt";
            this.btnNewReceipt.Size = new System.Drawing.Size(111, 28);
            this.btnNewReceipt.TabIndex = 8;
            this.btnNewReceipt.Text = "Add receipt";
            this.btnNewReceipt.UseVisualStyleBackColor = false;
            this.btnNewReceipt.Click += new System.EventHandler(this.btnNewReceipt_Click);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 462);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.placeHolder);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ReceiptForm";
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPaymentMethod;
        private CustomControls.CustomComboBox cbPaymentMethod;
        private System.Windows.Forms.Label label1;
        private CustomControls.CustomComboBox cbBuyer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox cblWorkOrders;
        private System.Windows.Forms.Button btnAddWorkOrders;
        private System.Windows.Forms.Panel placeHolder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnNewReceipt;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}