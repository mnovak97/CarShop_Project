
namespace CarShop_DesktopApp
{
    partial class AddItem
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFormName = new System.Windows.Forms.Label();
            this.txtTitle = new CarShop_DesktopApp.CustomControls.CustomTextBox();
            this.txtPrice = new CarShop_DesktopApp.CustomControls.CustomTextBox();
            this.txtCode = new CarShop_DesktopApp.CustomControls.CustomTextBox();
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.lblErrorPrice = new System.Windows.Forms.Label();
            this.lblErrorCode = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddItem, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCode, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPrice, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFormName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTitle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCode, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblErrorTitle, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblErrorPrice, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblErrorCode, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.005F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.005F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 321);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(128, 270);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(119, 32);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblCode
            // 
            this.lblCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCode.Location = new System.Drawing.Point(86, 214);
            this.lblCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(39, 15);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Code:";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrice.Location = new System.Drawing.Point(87, 161);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 15);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(92, 108);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // lblFormName
            // 
            this.lblFormName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFormName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFormName.Location = new System.Drawing.Point(128, 32);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(119, 16);
            this.lblFormName.TabIndex = 7;
            this.lblFormName.Text = "Item form";
            this.lblFormName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitle.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTitle.BorderSize = 2;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(128, 102);
            this.txtTitle.Multiline = false;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Padding = new System.Windows.Forms.Padding(7);
            this.txtTitle.PasswordChar = false;
            this.txtTitle.Size = new System.Drawing.Size(119, 28);
            this.txtTitle.TabIndex = 8;
            this.txtTitle.Texts = "";
            this.txtTitle.UnderlinedStyle = true;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPrice.BorderSize = 2;
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(128, 155);
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrice.PasswordChar = false;
            this.txtPrice.Size = new System.Drawing.Size(119, 28);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.Texts = "";
            this.txtPrice.UnderlinedStyle = true;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtCode.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCode.BorderSize = 2;
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.Location = new System.Drawing.Point(128, 208);
            this.txtCode.Multiline = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.Padding = new System.Windows.Forms.Padding(7);
            this.txtCode.PasswordChar = false;
            this.txtCode.Size = new System.Drawing.Size(119, 28);
            this.txtCode.TabIndex = 10;
            this.txtCode.Texts = "";
            this.txtCode.UnderlinedStyle = true;
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.AutoSize = true;
            this.lblErrorTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErrorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblErrorTitle.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTitle.Location = new System.Drawing.Point(253, 118);
            this.lblErrorTitle.Name = "lblErrorTitle";
            this.lblErrorTitle.Size = new System.Drawing.Size(120, 15);
            this.lblErrorTitle.TabIndex = 11;
            // 
            // lblErrorPrice
            // 
            this.lblErrorPrice.AutoSize = true;
            this.lblErrorPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErrorPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblErrorPrice.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrice.Location = new System.Drawing.Point(253, 171);
            this.lblErrorPrice.Name = "lblErrorPrice";
            this.lblErrorPrice.Size = new System.Drawing.Size(120, 15);
            this.lblErrorPrice.TabIndex = 12;
            // 
            // lblErrorCode
            // 
            this.lblErrorCode.AutoSize = true;
            this.lblErrorCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErrorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblErrorCode.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCode.Location = new System.Drawing.Point(253, 224);
            this.lblErrorCode.Name = "lblErrorCode";
            this.lblErrorCode.Size = new System.Drawing.Size(120, 15);
            this.lblErrorCode.TabIndex = 13;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(376, 321);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "AddItem";
            this.Text = "Add item";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblFormName;
        private CustomControls.CustomTextBox txtTitle;
        private CustomControls.CustomTextBox txtPrice;
        private CustomControls.CustomTextBox txtCode;
        private System.Windows.Forms.Label lblErrorTitle;
        private System.Windows.Forms.Label lblErrorPrice;
        private System.Windows.Forms.Label lblErrorCode;
    }
}