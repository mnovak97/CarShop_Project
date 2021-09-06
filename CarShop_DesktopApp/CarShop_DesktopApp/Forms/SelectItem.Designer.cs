
namespace CarShop_DesktopApp.Forms
{
    partial class SelectItem
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
            this.placeHolderItems = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // placeHolderItems
            // 
            this.placeHolderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeHolderItems.Location = new System.Drawing.Point(0, 0);
            this.placeHolderItems.Name = "placeHolderItems";
            this.placeHolderItems.Size = new System.Drawing.Size(800, 450);
            this.placeHolderItems.TabIndex = 0;
            // 
            // SelectItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.placeHolderItems);
            this.MaximizeBox = false;
            this.Name = "SelectItem";
            this.Text = "SelectItem";
            this.Load += new System.EventHandler(this.SelectItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel placeHolderItems;
    }
}