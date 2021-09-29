
namespace CarShop_DesktopApp
{
    partial class AddBuyer
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
            this.tableLayoutBuyer = new System.Windows.Forms.TableLayoutPanel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMobilePhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblOIB = new System.Windows.Forms.Label();
            this.btnAddBuyer = new System.Windows.Forms.Button();
            this.txtName = new CarShop_DesktopApp.CustomControls.CustomTextBox();
            this.txtEmail = new CarShop_DesktopApp.CustomControls.CustomTextBox();
            this.txtMobilePhone = new CarShop_DesktopApp.CustomControls.CustomTextBox();
            this.txtAddress = new CarShop_DesktopApp.CustomControls.CustomTextBox();
            this.txtOIB = new CarShop_DesktopApp.CustomControls.CustomTextBox();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorMobilePhone = new System.Windows.Forms.Label();
            this.lblErrorAddress = new System.Windows.Forms.Label();
            this.lblErrorOIB = new System.Windows.Forms.Label();
            this.tableLayoutBuyer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutBuyer
            // 
            this.tableLayoutBuyer.ColumnCount = 3;
            this.tableLayoutBuyer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutBuyer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutBuyer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutBuyer.Controls.Add(this.lblFormTitle, 1, 0);
            this.tableLayoutBuyer.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutBuyer.Controls.Add(this.lblEmail, 0, 2);
            this.tableLayoutBuyer.Controls.Add(this.lblMobilePhone, 0, 3);
            this.tableLayoutBuyer.Controls.Add(this.lblAddress, 0, 4);
            this.tableLayoutBuyer.Controls.Add(this.lblOIB, 0, 5);
            this.tableLayoutBuyer.Controls.Add(this.btnAddBuyer, 1, 6);
            this.tableLayoutBuyer.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutBuyer.Controls.Add(this.txtEmail, 1, 2);
            this.tableLayoutBuyer.Controls.Add(this.txtMobilePhone, 1, 3);
            this.tableLayoutBuyer.Controls.Add(this.txtAddress, 1, 4);
            this.tableLayoutBuyer.Controls.Add(this.txtOIB, 1, 5);
            this.tableLayoutBuyer.Controls.Add(this.lblErrorName, 2, 1);
            this.tableLayoutBuyer.Controls.Add(this.lblErrorEmail, 2, 2);
            this.tableLayoutBuyer.Controls.Add(this.lblErrorMobilePhone, 2, 3);
            this.tableLayoutBuyer.Controls.Add(this.lblErrorAddress, 2, 4);
            this.tableLayoutBuyer.Controls.Add(this.lblErrorOIB, 2, 5);
            this.tableLayoutBuyer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutBuyer.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutBuyer.Name = "tableLayoutBuyer";
            this.tableLayoutBuyer.RowCount = 7;
            this.tableLayoutBuyer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutBuyer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutBuyer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutBuyer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutBuyer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutBuyer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutBuyer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutBuyer.Size = new System.Drawing.Size(412, 505);
            this.tableLayoutBuyer.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFormTitle.Location = new System.Drawing.Point(140, 42);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(131, 16);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Buyer form";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(90, 141);
            this.lblName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(88, 201);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 15);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblMobilePhone
            // 
            this.lblMobilePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMobilePhone.Location = new System.Drawing.Point(48, 261);
            this.lblMobilePhone.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblMobilePhone.Name = "lblMobilePhone";
            this.lblMobilePhone.Size = new System.Drawing.Size(86, 15);
            this.lblMobilePhone.TabIndex = 8;
            this.lblMobilePhone.Text = "Mobile phone:";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddress.Location = new System.Drawing.Point(80, 321);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 15);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address:";
            // 
            // lblOIB
            // 
            this.lblOIB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOIB.AutoSize = true;
            this.lblOIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOIB.Location = new System.Drawing.Point(104, 381);
            this.lblOIB.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(30, 15);
            this.lblOIB.TabIndex = 10;
            this.lblOIB.Text = "OIB:";
            // 
            // btnAddBuyer
            // 
            this.btnAddBuyer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBuyer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddBuyer.ForeColor = System.Drawing.Color.White;
            this.btnAddBuyer.Location = new System.Drawing.Point(140, 437);
            this.btnAddBuyer.Name = "btnAddBuyer";
            this.btnAddBuyer.Size = new System.Drawing.Size(131, 32);
            this.btnAddBuyer.TabIndex = 11;
            this.btnAddBuyer.UseVisualStyleBackColor = false;
            this.btnAddBuyer.Click += new System.EventHandler(this.btnAddBuyer_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtName.BorderSize = 2;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(140, 130);
            this.txtName.MaxLenght = 32767;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PasswordChar = false;
            this.txtName.Size = new System.Drawing.Size(131, 28);
            this.txtName.TabIndex = 12;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(140, 190);
            this.txtEmail.MaxLenght = 32767;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(131, 28);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtMobilePhone.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMobilePhone.BorderSize = 2;
            this.txtMobilePhone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMobilePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMobilePhone.ForeColor = System.Drawing.Color.Black;
            this.txtMobilePhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMobilePhone.Location = new System.Drawing.Point(140, 250);
            this.txtMobilePhone.MaxLenght = 32767;
            this.txtMobilePhone.Multiline = false;
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Padding = new System.Windows.Forms.Padding(7);
            this.txtMobilePhone.PasswordChar = false;
            this.txtMobilePhone.Size = new System.Drawing.Size(131, 28);
            this.txtMobilePhone.TabIndex = 15;
            this.txtMobilePhone.Texts = "";
            this.txtMobilePhone.UnderlinedStyle = true;
            this.txtMobilePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobilePhone_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtAddress.BorderSize = 2;
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(140, 310);
            this.txtAddress.MaxLenght = 32767;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(7);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.Size = new System.Drawing.Size(131, 28);
            this.txtAddress.TabIndex = 16;
            this.txtAddress.Texts = "";
            this.txtAddress.UnderlinedStyle = true;
            // 
            // txtOIB
            // 
            this.txtOIB.BackColor = System.Drawing.SystemColors.Window;
            this.txtOIB.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtOIB.BorderSize = 2;
            this.txtOIB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOIB.ForeColor = System.Drawing.Color.Black;
            this.txtOIB.Location = new System.Drawing.Point(140, 370);
            this.txtOIB.MaxLenght = 11;
            this.txtOIB.Multiline = false;
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Padding = new System.Windows.Forms.Padding(7);
            this.txtOIB.PasswordChar = false;
            this.txtOIB.Size = new System.Drawing.Size(131, 28);
            this.txtOIB.TabIndex = 14;
            this.txtOIB.Texts = "";
            this.txtOIB.UnderlinedStyle = true;
            this.txtOIB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOIB_KeyPress);
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(277, 148);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(132, 13);
            this.lblErrorName.TabIndex = 17;
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(277, 208);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(132, 13);
            this.lblErrorEmail.TabIndex = 18;
            // 
            // lblErrorMobilePhone
            // 
            this.lblErrorMobilePhone.AutoSize = true;
            this.lblErrorMobilePhone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErrorMobilePhone.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMobilePhone.Location = new System.Drawing.Point(277, 268);
            this.lblErrorMobilePhone.Name = "lblErrorMobilePhone";
            this.lblErrorMobilePhone.Size = new System.Drawing.Size(132, 13);
            this.lblErrorMobilePhone.TabIndex = 19;
            // 
            // lblErrorAddress
            // 
            this.lblErrorAddress.AutoSize = true;
            this.lblErrorAddress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErrorAddress.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAddress.Location = new System.Drawing.Point(277, 328);
            this.lblErrorAddress.Name = "lblErrorAddress";
            this.lblErrorAddress.Size = new System.Drawing.Size(132, 13);
            this.lblErrorAddress.TabIndex = 20;
            // 
            // lblErrorOIB
            // 
            this.lblErrorOIB.AutoSize = true;
            this.lblErrorOIB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErrorOIB.ForeColor = System.Drawing.Color.Red;
            this.lblErrorOIB.Location = new System.Drawing.Point(277, 388);
            this.lblErrorOIB.Name = "lblErrorOIB";
            this.lblErrorOIB.Size = new System.Drawing.Size(132, 13);
            this.lblErrorOIB.TabIndex = 21;
            // 
            // AddBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 505);
            this.Controls.Add(this.tableLayoutBuyer);
            this.MaximizeBox = false;
            this.Name = "AddBuyer";
            this.Text = "AddBuyer";
            this.tableLayoutBuyer.ResumeLayout(false);
            this.tableLayoutBuyer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutBuyer;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobilePhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.Button btnAddBuyer;
        private CustomControls.CustomTextBox txtName;
        private CustomControls.CustomTextBox txtEmail;
        private CustomControls.CustomTextBox txtMobilePhone;
        private CustomControls.CustomTextBox txtAddress;
        private CustomControls.CustomTextBox txtOIB;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorMobilePhone;
        private System.Windows.Forms.Label lblErrorAddress;
        private System.Windows.Forms.Label lblErrorOIB;
    }
}