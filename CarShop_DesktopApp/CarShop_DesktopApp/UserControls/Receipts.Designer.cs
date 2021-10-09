
namespace CarShop_DesktopApp.UserControls
{
    partial class Receipts
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridReceipts = new System.Windows.Forms.DataGridView();
            this.btnNewReceipt = new System.Windows.Forms.Button();
            this.cbYear = new CarShop_DesktopApp.CustomControls.CustomComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceipts)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridReceipts, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNewReceipt, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbYear, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(548, 382);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridReceipts
            // 
            this.dataGridReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridReceipts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.dataGridReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceipts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridReceipts.Location = new System.Drawing.Point(0, 45);
            this.dataGridReceipts.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridReceipts.Name = "dataGridReceipts";
            this.dataGridReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReceipts.Size = new System.Drawing.Size(548, 290);
            this.dataGridReceipts.TabIndex = 0;
            // 
            // btnNewReceipt
            // 
            this.btnNewReceipt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNewReceipt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewReceipt.ForeColor = System.Drawing.Color.White;
            this.btnNewReceipt.Location = new System.Drawing.Point(427, 342);
            this.btnNewReceipt.Name = "btnNewReceipt";
            this.btnNewReceipt.Size = new System.Drawing.Size(118, 33);
            this.btnNewReceipt.TabIndex = 2;
            this.btnNewReceipt.UseVisualStyleBackColor = false;
            this.btnNewReceipt.Click += new System.EventHandler(this.btnNewReceipt_Click);
            // 
            // cbYear
            // 
            this.cbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbYear.BackColor = System.Drawing.Color.White;
            this.cbYear.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbYear.BorderSize = 2;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbYear.ForeColor = System.Drawing.Color.Black;
            this.cbYear.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbYear.ListBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbYear.ListTextColor = System.Drawing.Color.Black;
            this.cbYear.Location = new System.Drawing.Point(5, 5);
            this.cbYear.Margin = new System.Windows.Forms.Padding(5);
            this.cbYear.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbYear.Name = "cbYear";
            this.cbYear.Padding = new System.Windows.Forms.Padding(2);
            this.cbYear.Size = new System.Drawing.Size(200, 30);
            this.cbYear.TabIndex = 3;
            this.cbYear.Texts = "";
            this.cbYear.OnSelectedIndexChanged += new System.EventHandler(this.cbYear_OnSelectedIndexChanged);
            // 
            // Receipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Receipts";
            this.Size = new System.Drawing.Size(548, 382);
            this.Load += new System.EventHandler(this.Receipts_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceipts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridReceipts;
        private System.Windows.Forms.Button btnNewReceipt;
        private CustomControls.CustomComboBox cbYear;
    }
}
