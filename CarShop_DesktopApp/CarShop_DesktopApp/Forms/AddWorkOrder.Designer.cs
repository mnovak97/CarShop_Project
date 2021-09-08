
namespace CarShop_DesktopApp.Forms
{
    partial class AddWorkOrder
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
            this.tableLayoutTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblDone = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtManufacturingYear = new System.Windows.Forms.TextBox();
            this.lblManufacturingYear = new System.Windows.Forms.Label();
            this.lblCarType = new System.Windows.Forms.Label();
            this.txtCarType = new System.Windows.Forms.TextBox();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.txtRegistrationPlate = new System.Windows.Forms.TextBox();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.cbBuyers = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblKM = new System.Windows.Forms.Label();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.chBWarranty = new System.Windows.Forms.CheckBox();
            this.chBDone = new System.Windows.Forms.CheckBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddWorkOrder = new System.Windows.Forms.Button();
            this.dataGridItemsWorkOrder = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblItems = new System.Windows.Forms.Label();
            this.btnItemsList = new System.Windows.Forms.Button();
            this.tableLayoutTitle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemsWorkOrder)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutTitle
            // 
            this.tableLayoutTitle.ColumnCount = 1;
            this.tableLayoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutTitle.Controls.Add(this.lblFormName, 0, 0);
            this.tableLayoutTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutTitle.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutTitle.Name = "tableLayoutTitle";
            this.tableLayoutTitle.RowCount = 1;
            this.tableLayoutTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutTitle.Size = new System.Drawing.Size(619, 57);
            this.tableLayoutTitle.TabIndex = 0;
            // 
            // lblFormName
            // 
            this.lblFormName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFormName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFormName.Location = new System.Drawing.Point(3, 20);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(613, 16);
            this.lblFormName.TabIndex = 8;
            this.lblFormName.Text = "Add work order form";
            this.lblFormName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.txtComment, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDone, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtKm, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtManufacturingYear, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblManufacturingYear, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCarType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCarType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRegistration, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRegistrationPlate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBuyer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbBuyers, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblKM, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblWarranty, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.chBWarranty, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.chBDone, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblComment, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 340);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtComment
            // 
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.Location = new System.Drawing.Point(126, 275);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(148, 62);
            this.txtComment.TabIndex = 19;
            // 
            // lblDone
            // 
            this.lblDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDone.Location = new System.Drawing.Point(388, 252);
            this.lblDone.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(40, 15);
            this.lblDone.TabIndex = 18;
            this.lblDone.Text = "Done:";
            // 
            // txtKm
            // 
            this.txtKm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKm.Location = new System.Drawing.Point(434, 113);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(148, 20);
            this.txtKm.TabIndex = 13;
            // 
            // txtManufacturingYear
            // 
            this.txtManufacturingYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtManufacturingYear.Location = new System.Drawing.Point(434, 45);
            this.txtManufacturingYear.Name = "txtManufacturingYear";
            this.txtManufacturingYear.Size = new System.Drawing.Size(148, 20);
            this.txtManufacturingYear.TabIndex = 12;
            // 
            // lblManufacturingYear
            // 
            this.lblManufacturingYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManufacturingYear.AutoSize = true;
            this.lblManufacturingYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblManufacturingYear.Location = new System.Drawing.Point(313, 48);
            this.lblManufacturingYear.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblManufacturingYear.Name = "lblManufacturingYear";
            this.lblManufacturingYear.Size = new System.Drawing.Size(115, 15);
            this.lblManufacturingYear.TabIndex = 11;
            this.lblManufacturingYear.Text = "Manufacturing year:";
            // 
            // lblCarType
            // 
            this.lblCarType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarType.AutoSize = true;
            this.lblCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCarType.Location = new System.Drawing.Point(66, 48);
            this.lblCarType.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(54, 15);
            this.lblCarType.TabIndex = 2;
            this.lblCarType.Text = "Car type:";
            // 
            // txtCarType
            // 
            this.txtCarType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCarType.Location = new System.Drawing.Point(126, 45);
            this.txtCarType.Name = "txtCarType";
            this.txtCarType.Size = new System.Drawing.Size(148, 20);
            this.txtCarType.TabIndex = 3;
            // 
            // lblRegistration
            // 
            this.lblRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRegistration.Location = new System.Drawing.Point(14, 116);
            this.lblRegistration.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(106, 15);
            this.lblRegistration.TabIndex = 4;
            this.lblRegistration.Text = "Registration plate:";
            // 
            // txtRegistrationPlate
            // 
            this.txtRegistrationPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRegistrationPlate.Location = new System.Drawing.Point(126, 113);
            this.txtRegistrationPlate.Name = "txtRegistrationPlate";
            this.txtRegistrationPlate.Size = new System.Drawing.Size(148, 20);
            this.txtRegistrationPlate.TabIndex = 5;
            // 
            // lblBuyer
            // 
            this.lblBuyer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBuyer.Location = new System.Drawing.Point(79, 184);
            this.lblBuyer.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(41, 15);
            this.lblBuyer.TabIndex = 6;
            this.lblBuyer.Text = "Buyer:";
            // 
            // cbBuyers
            // 
            this.cbBuyers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbBuyers.FormattingEnabled = true;
            this.cbBuyers.Location = new System.Drawing.Point(126, 180);
            this.cbBuyers.Name = "cbBuyers";
            this.cbBuyers.Size = new System.Drawing.Size(148, 21);
            this.cbBuyers.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDescription.Location = new System.Drawing.Point(48, 252);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 15);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescription.Location = new System.Drawing.Point(126, 249);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(148, 20);
            this.txtDescription.TabIndex = 9;
            // 
            // lblKM
            // 
            this.lblKM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKM.Location = new System.Drawing.Point(399, 116);
            this.lblKM.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(29, 15);
            this.lblKM.TabIndex = 10;
            this.lblKM.Text = "Km:";
            // 
            // lblWarranty
            // 
            this.lblWarranty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarranty.AutoSize = true;
            this.lblWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWarranty.Location = new System.Drawing.Point(370, 184);
            this.lblWarranty.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(58, 15);
            this.lblWarranty.TabIndex = 15;
            this.lblWarranty.Text = "Warranty:";
            // 
            // chBWarranty
            // 
            this.chBWarranty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chBWarranty.AutoSize = true;
            this.chBWarranty.Location = new System.Drawing.Point(434, 187);
            this.chBWarranty.Name = "chBWarranty";
            this.chBWarranty.Size = new System.Drawing.Size(15, 14);
            this.chBWarranty.TabIndex = 16;
            this.chBWarranty.UseVisualStyleBackColor = true;
            // 
            // chBDone
            // 
            this.chBDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chBDone.AutoSize = true;
            this.chBDone.Location = new System.Drawing.Point(434, 255);
            this.chBDone.Name = "chBDone";
            this.chBDone.Size = new System.Drawing.Size(15, 14);
            this.chBDone.TabIndex = 17;
            this.chBDone.UseVisualStyleBackColor = true;
            // 
            // lblComment
            // 
            this.lblComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblComment.Location = new System.Drawing.Point(56, 275);
            this.lblComment.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(64, 15);
            this.lblComment.TabIndex = 14;
            this.lblComment.Text = "Comment:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddWorkOrder, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dataGridItemsWorkOrder, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 397);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(619, 296);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnAddWorkOrder
            // 
            this.btnAddWorkOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddWorkOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddWorkOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddWorkOrder.Location = new System.Drawing.Point(501, 267);
            this.btnAddWorkOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddWorkOrder.Name = "btnAddWorkOrder";
            this.btnAddWorkOrder.Size = new System.Drawing.Size(118, 29);
            this.btnAddWorkOrder.TabIndex = 3;
            this.btnAddWorkOrder.Text = "Add work order";
            this.btnAddWorkOrder.UseVisualStyleBackColor = false;
            this.btnAddWorkOrder.Click += new System.EventHandler(this.btnAddWorkOrder_Click);
            // 
            // dataGridItemsWorkOrder
            // 
            this.dataGridItemsWorkOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridItemsWorkOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.dataGridItemsWorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItemsWorkOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridItemsWorkOrder.Location = new System.Drawing.Point(3, 32);
            this.dataGridItemsWorkOrder.Name = "dataGridItemsWorkOrder";
            this.dataGridItemsWorkOrder.ReadOnly = true;
            this.dataGridItemsWorkOrder.Size = new System.Drawing.Size(613, 230);
            this.dataGridItemsWorkOrder.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Controls.Add(this.lblItems, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnItemsList, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(619, 29);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // lblItems
            // 
            this.lblItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblItems.Location = new System.Drawing.Point(3, 8);
            this.lblItems.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(45, 16);
            this.lblItems.TabIndex = 0;
            this.lblItems.Text = "Items";
            // 
            // btnItemsList
            // 
            this.btnItemsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnItemsList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnItemsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnItemsList.ForeColor = System.Drawing.Color.White;
            this.btnItemsList.Location = new System.Drawing.Point(126, 0);
            this.btnItemsList.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnItemsList.Name = "btnItemsList";
            this.btnItemsList.Size = new System.Drawing.Size(118, 29);
            this.btnItemsList.TabIndex = 2;
            this.btnItemsList.Text = "Add item";
            this.btnItemsList.UseVisualStyleBackColor = false;
            this.btnItemsList.Click += new System.EventHandler(this.btnItemsList_Click);
            // 
            // AddWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 693);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutTitle);
            this.Name = "AddWorkOrder";
            this.Text = "AddWorkOrder";
            this.Load += new System.EventHandler(this.AddWorkOrder_Load);
            this.tableLayoutTitle.ResumeLayout(false);
            this.tableLayoutTitle.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemsWorkOrder)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutTitle;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.TextBox txtCarType;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtManufacturingYear;
        private System.Windows.Forms.Label lblManufacturingYear;
        private System.Windows.Forms.TextBox txtRegistrationPlate;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.ComboBox cbBuyers;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.CheckBox chBWarranty;
        private System.Windows.Forms.CheckBox chBDone;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.DataGridView dataGridItemsWorkOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAddWorkOrder;
        private System.Windows.Forms.Button btnItemsList;
    }
}