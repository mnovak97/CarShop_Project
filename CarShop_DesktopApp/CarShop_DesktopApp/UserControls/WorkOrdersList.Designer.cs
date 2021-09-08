
namespace CarShop_DesktopApp.UserControls
{
    partial class WorkOrdersList
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
            this.tableLayoutWorkOrders = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewWorkOrder = new System.Windows.Forms.Button();
            this.dataGridWorkOrders = new System.Windows.Forms.DataGridView();
            this.tableLayoutWorkOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutWorkOrders
            // 
            this.tableLayoutWorkOrders.ColumnCount = 1;
            this.tableLayoutWorkOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutWorkOrders.Controls.Add(this.btnNewWorkOrder, 0, 1);
            this.tableLayoutWorkOrders.Controls.Add(this.dataGridWorkOrders, 0, 0);
            this.tableLayoutWorkOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutWorkOrders.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutWorkOrders.Name = "tableLayoutWorkOrders";
            this.tableLayoutWorkOrders.RowCount = 2;
            this.tableLayoutWorkOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.41F));
            this.tableLayoutWorkOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.59F));
            this.tableLayoutWorkOrders.Size = new System.Drawing.Size(489, 326);
            this.tableLayoutWorkOrders.TabIndex = 0;
            // 
            // btnNewWorkOrder
            // 
            this.btnNewWorkOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNewWorkOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewWorkOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewWorkOrder.Location = new System.Drawing.Point(331, 291);
            this.btnNewWorkOrder.Name = "btnNewWorkOrder";
            this.btnNewWorkOrder.Size = new System.Drawing.Size(155, 32);
            this.btnNewWorkOrder.TabIndex = 2;
            this.btnNewWorkOrder.Text = "Add new work order";
            this.btnNewWorkOrder.UseVisualStyleBackColor = false;
            this.btnNewWorkOrder.Click += new System.EventHandler(this.btnNewWorkOrder_Click);
            // 
            // dataGridWorkOrders
            // 
            this.dataGridWorkOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridWorkOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.dataGridWorkOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWorkOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridWorkOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridWorkOrders.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridWorkOrders.Name = "dataGridWorkOrders";
            this.dataGridWorkOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWorkOrders.Size = new System.Drawing.Size(489, 288);
            this.dataGridWorkOrders.TabIndex = 0;
            this.dataGridWorkOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridWorkOrders_CellClick);
            // 
            // WorkOrdersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutWorkOrders);
            this.Name = "WorkOrdersList";
            this.Size = new System.Drawing.Size(489, 326);
            this.Load += new System.EventHandler(this.WorkOrdersList_Load);
            this.tableLayoutWorkOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutWorkOrders;
        private System.Windows.Forms.DataGridView dataGridWorkOrders;
        private System.Windows.Forms.Button btnNewWorkOrder;
    }
}
