
namespace CarShop_DesktopApp.CustomControls
{
    partial class CustomPickUp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblPickupInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMobileTelephone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblAddressText = new System.Windows.Forms.Label();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblMobileTelephoneText = new System.Windows.Forms.Label();
            this.tblPickupInfo.SuspendLayout();
            this.tblButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPickupInfo
            // 
            this.tblPickupInfo.BackColor = System.Drawing.Color.White;
            this.tblPickupInfo.ColumnCount = 2;
            this.tblPickupInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.87738F));
            this.tblPickupInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.12261F));
            this.tblPickupInfo.Controls.Add(this.lblMobileTelephoneText, 1, 2);
            this.tblPickupInfo.Controls.Add(this.lblNameText, 1, 1);
            this.tblPickupInfo.Controls.Add(this.lblMobileTelephone, 0, 2);
            this.tblPickupInfo.Controls.Add(this.lblAddress, 0, 0);
            this.tblPickupInfo.Controls.Add(this.lblName, 0, 1);
            this.tblPickupInfo.Controls.Add(this.lblAddressText, 1, 0);
            this.tblPickupInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblPickupInfo.Location = new System.Drawing.Point(0, 0);
            this.tblPickupInfo.Name = "tblPickupInfo";
            this.tblPickupInfo.RowCount = 3;
            this.tblPickupInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPickupInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPickupInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPickupInfo.Size = new System.Drawing.Size(367, 158);
            this.tblPickupInfo.TabIndex = 0;
            // 
            // tblButton
            // 
            this.tblButton.BackColor = System.Drawing.Color.White;
            this.tblButton.ColumnCount = 2;
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.48774F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.51226F));
            this.tblButton.Controls.Add(this.btnFinish, 1, 0);
            this.tblButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButton.Location = new System.Drawing.Point(0, 158);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.Size = new System.Drawing.Size(367, 54);
            this.tblButton.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Location = new System.Drawing.Point(3, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(121, 52);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMobileTelephone
            // 
            this.lblMobileTelephone.AutoSize = true;
            this.lblMobileTelephone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMobileTelephone.Location = new System.Drawing.Point(3, 104);
            this.lblMobileTelephone.Name = "lblMobileTelephone";
            this.lblMobileTelephone.Size = new System.Drawing.Size(121, 54);
            this.lblMobileTelephone.TabIndex = 2;
            this.lblMobileTelephone.Text = "Mobile telephone:";
            this.lblMobileTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 52);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFinish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(243, 10);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(10);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(114, 34);
            this.btnFinish.TabIndex = 0;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            // 
            // lblAddressText
            // 
            this.lblAddressText.AutoSize = true;
            this.lblAddressText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddressText.Location = new System.Drawing.Point(130, 0);
            this.lblAddressText.Name = "lblAddressText";
            this.lblAddressText.Size = new System.Drawing.Size(234, 52);
            this.lblAddressText.TabIndex = 4;
            this.lblAddressText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameText.Location = new System.Drawing.Point(130, 52);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(234, 52);
            this.lblNameText.TabIndex = 5;
            this.lblNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMobileTelephoneText
            // 
            this.lblMobileTelephoneText.AutoSize = true;
            this.lblMobileTelephoneText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMobileTelephoneText.Location = new System.Drawing.Point(130, 104);
            this.lblMobileTelephoneText.Name = "lblMobileTelephoneText";
            this.lblMobileTelephoneText.Size = new System.Drawing.Size(234, 54);
            this.lblMobileTelephoneText.TabIndex = 6;
            this.lblMobileTelephoneText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomPickUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tblButton);
            this.Controls.Add(this.tblPickupInfo);
            this.Name = "CustomPickUp";
            this.Size = new System.Drawing.Size(367, 212);
            this.Load += new System.EventHandler(this.CustomPickUp_Load);
            this.tblPickupInfo.ResumeLayout(false);
            this.tblPickupInfo.PerformLayout();
            this.tblButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPickupInfo;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.Label lblMobileTelephone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblMobileTelephoneText;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblAddressText;
    }
}
