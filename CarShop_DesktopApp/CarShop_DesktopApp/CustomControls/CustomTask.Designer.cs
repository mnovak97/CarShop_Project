
namespace CarShop_DesktopApp.CustomControls
{
    partial class CustomTask
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
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.TableLayoutPanel();
            this.txtTaskID = new System.Windows.Forms.Label();
            this.lblWorkOrder = new System.Windows.Forms.Label();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.txtWorkOrder = new System.Windows.Forms.LinkLabel();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCompleteTask.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCompleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCompleteTask.ForeColor = System.Drawing.Color.White;
            this.btnCompleteTask.Location = new System.Drawing.Point(0, 138);
            this.btnCompleteTask.Margin = new System.Windows.Forms.Padding(0, 15, 0, 3);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(282, 32);
            this.btnCompleteTask.TabIndex = 7;
            this.btnCompleteTask.Text = "Complete";
            this.btnCompleteTask.UseVisualStyleBackColor = false;
            this.btnCompleteTask.Click += new System.EventHandler(this.btnCompleteTask_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.ColumnCount = 2;
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.pnlContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63F));
            this.pnlContent.Controls.Add(this.txtTaskID, 1, 0);
            this.pnlContent.Controls.Add(this.lblWorkOrder, 0, 1);
            this.pnlContent.Controls.Add(this.lblTaskID, 0, 0);
            this.pnlContent.Controls.Add(this.txtWorkOrder, 1, 1);
            this.pnlContent.Location = new System.Drawing.Point(3, 3);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.RowCount = 2;
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlContent.Size = new System.Drawing.Size(276, 132);
            this.pnlContent.TabIndex = 8;
            // 
            // txtTaskID
            // 
            this.txtTaskID.AutoSize = true;
            this.txtTaskID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTaskID.Location = new System.Drawing.Point(105, 0);
            this.txtTaskID.Name = "txtTaskID";
            this.txtTaskID.Size = new System.Drawing.Size(168, 66);
            this.txtTaskID.TabIndex = 2;
            this.txtTaskID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWorkOrder
            // 
            this.lblWorkOrder.AutoSize = true;
            this.lblWorkOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWorkOrder.Location = new System.Drawing.Point(3, 66);
            this.lblWorkOrder.Name = "lblWorkOrder";
            this.lblWorkOrder.Size = new System.Drawing.Size(96, 66);
            this.lblWorkOrder.TabIndex = 1;
            this.lblWorkOrder.Text = "Word order:";
            this.lblWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTaskID.Location = new System.Drawing.Point(3, 0);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(96, 66);
            this.lblTaskID.TabIndex = 0;
            this.lblTaskID.Text = "Task ID:";
            this.lblTaskID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWorkOrder
            // 
            this.txtWorkOrder.AutoSize = true;
            this.txtWorkOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWorkOrder.Location = new System.Drawing.Point(105, 66);
            this.txtWorkOrder.Name = "txtWorkOrder";
            this.txtWorkOrder.Size = new System.Drawing.Size(168, 66);
            this.txtWorkOrder.TabIndex = 3;
            this.txtWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtWorkOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtWorkOrder_LinkClicked);
            // 
            // CustomTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.btnCompleteTask);
            this.MaximumSize = new System.Drawing.Size(282, 170);
            this.MinimumSize = new System.Drawing.Size(282, 170);
            this.Name = "CustomTask";
            this.Size = new System.Drawing.Size(282, 170);
            this.Load += new System.EventHandler(this.CustomTask_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.TableLayoutPanel pnlContent;
        private System.Windows.Forms.Label lblTaskID;
        private System.Windows.Forms.Label txtTaskID;
        private System.Windows.Forms.Label lblWorkOrder;
        private System.Windows.Forms.LinkLabel txtWorkOrder;
    }
}
