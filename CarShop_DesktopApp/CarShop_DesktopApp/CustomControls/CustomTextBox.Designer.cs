
namespace CarShop_DesktopApp.CustomControls
{
    partial class CustomTextBox
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
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCustom
            // 
            this.txtCustom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustom.Location = new System.Drawing.Point(7, 7);
            this.txtCustom.Margin = new System.Windows.Forms.Padding(0);
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(236, 13);
            this.txtCustom.TabIndex = 0;
            this.txtCustom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustom_KeyPress);
            this.txtCustom.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustom_Validating);
            // 
            // CustomTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.txtCustom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CustomTextBox";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustom;
    }
}
