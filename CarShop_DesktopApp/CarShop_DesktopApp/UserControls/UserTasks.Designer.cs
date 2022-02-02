
namespace CarShop_DesktopApp.UserControls
{
    partial class UserTasks
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
            this.lblYourTasks = new System.Windows.Forms.Label();
            this.panelTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblYourTasks
            // 
            this.lblYourTasks.BackColor = System.Drawing.Color.White;
            this.lblYourTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYourTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblYourTasks.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblYourTasks.Location = new System.Drawing.Point(0, 0);
            this.lblYourTasks.Margin = new System.Windows.Forms.Padding(0);
            this.lblYourTasks.Name = "lblYourTasks";
            this.lblYourTasks.Size = new System.Drawing.Size(546, 51);
            this.lblYourTasks.TabIndex = 10;
            this.lblYourTasks.Text = "Your tasks";
            this.lblYourTasks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTasks
            // 
            this.panelTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTasks.Location = new System.Drawing.Point(0, 51);
            this.panelTasks.Name = "panelTasks";
            this.panelTasks.Padding = new System.Windows.Forms.Padding(15);
            this.panelTasks.Size = new System.Drawing.Size(546, 336);
            this.panelTasks.TabIndex = 11;
            // 
            // UserTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelTasks);
            this.Controls.Add(this.lblYourTasks);
            this.Name = "UserTasks";
            this.Size = new System.Drawing.Size(546, 387);
            this.Load += new System.EventHandler(this.UserTasks_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblYourTasks;
        private System.Windows.Forms.FlowLayoutPanel panelTasks;
    }
}
