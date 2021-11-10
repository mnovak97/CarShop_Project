
namespace CarShop_DesktopApp
{
    partial class WorkOrders
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
            this.btnOngoing = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.placeHolderWorkOrders = new System.Windows.Forms.Panel();
            this.tableLayoutWorkOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutWorkOrders
            // 
            this.tableLayoutWorkOrders.ColumnCount = 2;
            this.tableLayoutWorkOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutWorkOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutWorkOrders.Controls.Add(this.btnOngoing, 1, 0);
            this.tableLayoutWorkOrders.Controls.Add(this.btnDone, 0, 0);
            this.tableLayoutWorkOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutWorkOrders.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutWorkOrders.Name = "tableLayoutWorkOrders";
            this.tableLayoutWorkOrders.RowCount = 1;
            this.tableLayoutWorkOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutWorkOrders.Size = new System.Drawing.Size(534, 39);
            this.tableLayoutWorkOrders.TabIndex = 0;
            // 
            // btnOngoing
            // 
            this.btnOngoing.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOngoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOngoing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOngoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOngoing.ForeColor = System.Drawing.Color.White;
            this.btnOngoing.Location = new System.Drawing.Point(267, 0);
            this.btnOngoing.Margin = new System.Windows.Forms.Padding(0);
            this.btnOngoing.Name = "btnOngoing";
            this.btnOngoing.Size = new System.Drawing.Size(267, 39);
            this.btnOngoing.TabIndex = 1;
            this.btnOngoing.Text = "Ongoing";
            this.btnOngoing.UseVisualStyleBackColor = false;
            this.btnOngoing.Click += new System.EventHandler(this.btnOngoing_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(0, 0);
            this.btnDone.Margin = new System.Windows.Forms.Padding(0);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(267, 39);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // placeHolderWorkOrders
            // 
            this.placeHolderWorkOrders.BackColor = System.Drawing.Color.White;
            this.placeHolderWorkOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeHolderWorkOrders.Location = new System.Drawing.Point(0, 39);
            this.placeHolderWorkOrders.Name = "placeHolderWorkOrders";
            this.placeHolderWorkOrders.Size = new System.Drawing.Size(534, 347);
            this.placeHolderWorkOrders.TabIndex = 1;
            // 
            // WorkOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.placeHolderWorkOrders);
            this.Controls.Add(this.tableLayoutWorkOrders);
            this.Name = "WorkOrders";
            this.Size = new System.Drawing.Size(534, 386);
            this.Load += new System.EventHandler(this.WorkOrders_Load);
            this.tableLayoutWorkOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutWorkOrders;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Panel placeHolderWorkOrders;
        private System.Windows.Forms.Button btnOngoing;
    }
}
