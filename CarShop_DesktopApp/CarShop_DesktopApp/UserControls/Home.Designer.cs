
namespace CarShop_DesktopApp.UserControls
{
    partial class Home
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
            this.panelDatePicker = new System.Windows.Forms.Panel();
            this.datePicekrAppointments = new System.Windows.Forms.DateTimePicker();
            this.panelAppointments = new System.Windows.Forms.Panel();
            this.panelDatePicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatePicker
            // 
            this.panelDatePicker.Controls.Add(this.datePicekrAppointments);
            this.panelDatePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatePicker.Location = new System.Drawing.Point(0, 0);
            this.panelDatePicker.Name = "panelDatePicker";
            this.panelDatePicker.Size = new System.Drawing.Size(786, 62);
            this.panelDatePicker.TabIndex = 0;
            // 
            // datePicekrAppointments
            // 
            this.datePicekrAppointments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePicekrAppointments.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datePicekrAppointments.CustomFormat = " MMMM dd yyyy";
            this.datePicekrAppointments.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicekrAppointments.Location = new System.Drawing.Point(402, 36);
            this.datePicekrAppointments.Name = "datePicekrAppointments";
            this.datePicekrAppointments.Size = new System.Drawing.Size(200, 23);
            this.datePicekrAppointments.TabIndex = 0;
            this.datePicekrAppointments.ValueChanged += new System.EventHandler(this.datePicekrAppointments_ValueChanged);
            // 
            // panelAppointments
            // 
            this.panelAppointments.AutoScroll = true;
            this.panelAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAppointments.Location = new System.Drawing.Point(0, 62);
            this.panelAppointments.Margin = new System.Windows.Forms.Padding(0);
            this.panelAppointments.Name = "panelAppointments";
            this.panelAppointments.Padding = new System.Windows.Forms.Padding(15);
            this.panelAppointments.Size = new System.Drawing.Size(786, 431);
            this.panelAppointments.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelAppointments);
            this.Controls.Add(this.panelDatePicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(786, 493);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelDatePicker.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDatePicker;
        private System.Windows.Forms.Panel panelAppointments;
        private System.Windows.Forms.DateTimePicker datePicekrAppointments;
    }
}
