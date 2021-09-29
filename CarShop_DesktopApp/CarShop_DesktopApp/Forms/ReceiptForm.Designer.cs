
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
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFormName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 56);
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 210);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(26, 44);
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
            this.cbPaymentMethod.Location = new System.Drawing.Point(132, 36);
            this.cbPaymentMethod.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Padding = new System.Windows.Forms.Padding(2);
            this.cbPaymentMethod.Size = new System.Drawing.Size(214, 30);
            this.cbPaymentMethod.TabIndex = 2;
            this.cbPaymentMethod.Texts = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(88, 113);
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
            this.cbBuyer.Location = new System.Drawing.Point(132, 105);
            this.cbBuyer.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbBuyer.Name = "cbBuyer";
            this.cbBuyer.Padding = new System.Windows.Forms.Padding(2);
            this.cbBuyer.Size = new System.Drawing.Size(214, 30);
            this.cbBuyer.TabIndex = 4;
            this.cbBuyer.Texts = "";
            this.cbBuyer.OnSelectedIndexChanged += new System.EventHandler(this.cbBuyer_OnSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buyers work orders:";
            // 
            // cblWorkOrders
            // 
            this.cblWorkOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblWorkOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cblWorkOrders.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cblWorkOrders.FormattingEnabled = true;
            this.cblWorkOrders.Location = new System.Drawing.Point(132, 141);
            this.cblWorkOrders.Name = "cblWorkOrders";
            this.cblWorkOrders.Size = new System.Drawing.Size(214, 66);
            this.cblWorkOrders.TabIndex = 6;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(431, 454);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ReceiptForm";
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
    }
}