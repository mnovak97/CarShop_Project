
namespace CarShop_DesktopApp.UserControls
{
    partial class PickUpRequests
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
            this.lblPickUpRequests = new System.Windows.Forms.Label();
            this.panelPickupRequests = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblPickUpRequests
            // 
            this.lblPickUpRequests.BackColor = System.Drawing.Color.White;
            this.lblPickUpRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPickUpRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPickUpRequests.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPickUpRequests.Location = new System.Drawing.Point(0, 0);
            this.lblPickUpRequests.Margin = new System.Windows.Forms.Padding(0);
            this.lblPickUpRequests.Name = "lblPickUpRequests";
            this.lblPickUpRequests.Size = new System.Drawing.Size(558, 51);
            this.lblPickUpRequests.TabIndex = 11;
            this.lblPickUpRequests.Text = "Pick up request";
            this.lblPickUpRequests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPickupRequests
            // 
            this.panelPickupRequests.AutoScroll = true;
            this.panelPickupRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPickupRequests.Location = new System.Drawing.Point(0, 51);
            this.panelPickupRequests.Name = "panelPickupRequests";
            this.panelPickupRequests.Padding = new System.Windows.Forms.Padding(15);
            this.panelPickupRequests.Size = new System.Drawing.Size(558, 335);
            this.panelPickupRequests.TabIndex = 12;
            // 
            // PickUpRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelPickupRequests);
            this.Controls.Add(this.lblPickUpRequests);
            this.Name = "PickUpRequests";
            this.Size = new System.Drawing.Size(558, 386);
            this.Load += new System.EventHandler(this.PickUpRequests_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPickUpRequests;
        private System.Windows.Forms.FlowLayoutPanel panelPickupRequests;
    }
}
