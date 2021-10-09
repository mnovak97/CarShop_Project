
namespace CarShop_DesktopApp.UserControls
{
    partial class TaskAssignment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWorkOrder = new System.Windows.Forms.Label();
            this.lblWorker = new System.Windows.Forms.Label();
            this.btnAssignTask = new System.Windows.Forms.Button();
            this.cbWorker = new CarShop_DesktopApp.CustomControls.CustomComboBox();
            this.cbWorkOrders = new CarShop_DesktopApp.CustomControls.CustomComboBox();
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
            this.panel1.Size = new System.Drawing.Size(553, 100);
            this.panel1.TabIndex = 1;
            // 
            // lblFormName
            // 
            this.lblFormName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFormName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFormName.Location = new System.Drawing.Point(0, 0);
            this.lblFormName.Margin = new System.Windows.Forms.Padding(0);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(553, 100);
            this.lblFormName.TabIndex = 9;
            this.lblFormName.Text = "Assign task";
            this.lblFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.15058F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.84942F));
            this.tableLayoutPanel1.Controls.Add(this.cbWorker, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblWorker, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblWorkOrder, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbWorkOrders, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAssignTask, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 279);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblWorkOrder
            // 
            this.lblWorkOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWorkOrder.AutoSize = true;
            this.lblWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWorkOrder.Location = new System.Drawing.Point(91, 150);
            this.lblWorkOrder.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblWorkOrder.Name = "lblWorkOrder";
            this.lblWorkOrder.Size = new System.Drawing.Size(70, 15);
            this.lblWorkOrder.TabIndex = 12;
            this.lblWorkOrder.Text = "Work order:";
            // 
            // lblWorker
            // 
            this.lblWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWorker.Location = new System.Drawing.Point(112, 53);
            this.lblWorker.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(49, 15);
            this.lblWorker.TabIndex = 10;
            this.lblWorker.Text = "Worker:";
            // 
            // btnAssignTask
            // 
            this.btnAssignTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssignTask.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAssignTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignTask.ForeColor = System.Drawing.Color.White;
            this.btnAssignTask.Location = new System.Drawing.Point(400, 246);
            this.btnAssignTask.Name = "btnAssignTask";
            this.btnAssignTask.Size = new System.Drawing.Size(150, 30);
            this.btnAssignTask.TabIndex = 14;
            this.btnAssignTask.Text = "Assign ";
            this.btnAssignTask.UseVisualStyleBackColor = false;
            this.btnAssignTask.Click += new System.EventHandler(this.btnAssignTask_Click);
            // 
            // cbWorker
            // 
            this.cbWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbWorker.BackColor = System.Drawing.Color.White;
            this.cbWorker.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbWorker.BorderSize = 2;
            this.cbWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbWorker.ForeColor = System.Drawing.Color.Black;
            this.cbWorker.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbWorker.ListBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbWorker.ListTextColor = System.Drawing.Color.Black;
            this.cbWorker.Location = new System.Drawing.Point(164, 45);
            this.cbWorker.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Padding = new System.Windows.Forms.Padding(2);
            this.cbWorker.Size = new System.Drawing.Size(200, 30);
            this.cbWorker.TabIndex = 11;
            this.cbWorker.Texts = "";
            // 
            // cbWorkOrders
            // 
            this.cbWorkOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbWorkOrders.BackColor = System.Drawing.Color.White;
            this.cbWorkOrders.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbWorkOrders.BorderSize = 2;
            this.cbWorkOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbWorkOrders.ForeColor = System.Drawing.Color.Black;
            this.cbWorkOrders.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbWorkOrders.ListBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbWorkOrders.ListTextColor = System.Drawing.Color.Black;
            this.cbWorkOrders.Location = new System.Drawing.Point(164, 142);
            this.cbWorkOrders.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbWorkOrders.Name = "cbWorkOrders";
            this.cbWorkOrders.Padding = new System.Windows.Forms.Padding(2);
            this.cbWorkOrders.Size = new System.Drawing.Size(200, 30);
            this.cbWorkOrders.TabIndex = 13;
            this.cbWorkOrders.Texts = "";
            // 
            // TaskAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "TaskAssignment";
            this.Size = new System.Drawing.Size(553, 379);
            this.Load += new System.EventHandler(this.TaskAssignment_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblWorkOrder;
        private System.Windows.Forms.Label lblWorker;
        private CustomControls.CustomComboBox cbWorkOrders;
        private System.Windows.Forms.Button btnAssignTask;
        private CustomControls.CustomComboBox cbWorker;
    }
}
