
namespace CarShop_DesktopApp
{
    partial class Items
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
            this.tableLayoutItems = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridItems = new System.Windows.Forms.DataGridView();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.tableLayoutItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutItems
            // 
            this.tableLayoutItems.ColumnCount = 1;
            this.tableLayoutItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutItems.Controls.Add(this.dataGridItems, 0, 0);
            this.tableLayoutItems.Controls.Add(this.btnNewItem, 0, 1);
            this.tableLayoutItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutItems.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutItems.Name = "tableLayoutItems";
            this.tableLayoutItems.RowCount = 2;
            this.tableLayoutItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.41F));
            this.tableLayoutItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.59F));
            this.tableLayoutItems.Size = new System.Drawing.Size(586, 508);
            this.tableLayoutItems.TabIndex = 2;
            // 
            // dataGridItems
            // 
            this.dataGridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.dataGridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridItems.Location = new System.Drawing.Point(0, 0);
            this.dataGridItems.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridItems.Name = "dataGridItems";
            this.dataGridItems.ReadOnly = true;
            this.dataGridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridItems.Size = new System.Drawing.Size(586, 449);
            this.dataGridItems.TabIndex = 2;
            this.dataGridItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridItems_CellClick);
            // 
            // btnNewItem
            // 
            this.btnNewItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNewItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewItem.ForeColor = System.Drawing.Color.White;
            this.btnNewItem.Location = new System.Drawing.Point(465, 462);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(118, 33);
            this.btnNewItem.TabIndex = 1;
            this.btnNewItem.UseVisualStyleBackColor = false;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutItems);
            this.Name = "Items";
            this.Size = new System.Drawing.Size(586, 508);
            this.Load += new System.EventHandler(this.Items_Load);
            this.tableLayoutItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutItems;
        private System.Windows.Forms.DataGridView dataGridItems;
        private System.Windows.Forms.Button btnNewItem;
    }
}
