
namespace CarShop_DesktopApp
{
    partial class Buyers
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
            this.tableLayoutBuyers = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridBuyers = new System.Windows.Forms.DataGridView();
            this.btnNewBuyer = new System.Windows.Forms.Button();
            this.tableLayoutBuyers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuyers)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutBuyers
            // 
            this.tableLayoutBuyers.ColumnCount = 1;
            this.tableLayoutBuyers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutBuyers.Controls.Add(this.dataGridBuyers, 0, 0);
            this.tableLayoutBuyers.Controls.Add(this.btnNewBuyer, 0, 1);
            this.tableLayoutBuyers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutBuyers.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutBuyers.Name = "tableLayoutBuyers";
            this.tableLayoutBuyers.RowCount = 2;
            this.tableLayoutBuyers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.41277F));
            this.tableLayoutBuyers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.58723F));
            this.tableLayoutBuyers.Size = new System.Drawing.Size(522, 332);
            this.tableLayoutBuyers.TabIndex = 0;
            // 
            // dataGridBuyers
            // 
            this.dataGridBuyers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBuyers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.dataGridBuyers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuyers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridBuyers.Location = new System.Drawing.Point(0, 0);
            this.dataGridBuyers.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridBuyers.Name = "dataGridBuyers";
            this.dataGridBuyers.ReadOnly = true;
            this.dataGridBuyers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBuyers.Size = new System.Drawing.Size(522, 293);
            this.dataGridBuyers.TabIndex = 0;
            this.dataGridBuyers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBuyers_CellClick);
            // 
            // btnNewBuyer
            // 
            this.btnNewBuyer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNewBuyer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewBuyer.ForeColor = System.Drawing.Color.White;
            this.btnNewBuyer.Location = new System.Drawing.Point(401, 296);
            this.btnNewBuyer.Name = "btnNewBuyer";
            this.btnNewBuyer.Size = new System.Drawing.Size(118, 33);
            this.btnNewBuyer.TabIndex = 1;
            this.btnNewBuyer.Text = "Add new buyer";
            this.btnNewBuyer.UseVisualStyleBackColor = false;
            this.btnNewBuyer.Click += new System.EventHandler(this.btnNewBuyer_Click);
            // 
            // Buyers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutBuyers);
            this.Name = "Buyers";
            this.Size = new System.Drawing.Size(522, 332);
            this.Load += new System.EventHandler(this.Buyers_Load);
            this.tableLayoutBuyers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuyers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutBuyers;
        private System.Windows.Forms.DataGridView dataGridBuyers;
        private System.Windows.Forms.Button btnNewBuyer;
    }
}
