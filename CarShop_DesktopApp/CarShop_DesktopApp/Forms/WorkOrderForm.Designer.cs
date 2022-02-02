
namespace CarShop_DesktopApp.Forms
{
    partial class WorkOrderForm
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
            this.cbAppointment = new CarShop_DesktopApp.CustomControls.CustomComboBox();
            this.txtKm = new CarShop_DesktopApp.CustomControls.CustomTextBox();
            this.txtManufacturingYear = new CarShop_DesktopApp.CustomControls.CustomTextBox();
            this.txtDescription = new CarShop_DesktopApp.CustomControls.CustomTextBox();
            this.lblManufacturingYear = new System.Windows.Forms.Label();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblKM = new System.Windows.Forms.Label();
            this.chBWarranty = new System.Windows.Forms.CheckBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtCarType = new CarShop_DesktopApp.CustomControls.CustomTextBox();
            this.txtRegistrationPlate = new CarShop_DesktopApp.CustomControls.CustomTextBox();
            this.txtComment = new CarShop_DesktopApp.CustomControls.CustomTextBox();
            this.cbBuyers = new CarShop_DesktopApp.CustomControls.CustomComboBox();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.tableLayoutItems = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddWorkOrder = new System.Windows.Forms.Button();
            this.dataGridItemsWorkOrder = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblItems = new System.Windows.Forms.Label();
            this.btnItemsList = new System.Windows.Forms.Button();
            this.tableLayoutTitle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutItems.SuspendLayout();
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
            this.tableLayoutTitle.Size = new System.Drawing.Size(681, 51);
            this.tableLayoutTitle.TabIndex = 0;
            // 
            // lblFormName
            // 
            this.lblFormName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFormName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFormName.Location = new System.Drawing.Point(3, 17);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(675, 16);
            this.lblFormName.TabIndex = 8;
            this.lblFormName.Text = "Add work order form";
            this.lblFormName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.04858F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.03644F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.8421F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.07288F));
            this.tableLayoutPanel1.Controls.Add(this.cbAppointment, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtKm, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtManufacturingYear, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblManufacturingYear, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCarType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRegistration, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBuyer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblKM, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.chBWarranty, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblComment, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCarType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRegistrationPlate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtComment, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbBuyers, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblWarranty, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAppointment, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(681, 340);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbAppointment
            // 
            this.cbAppointment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbAppointment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAppointment.BackColor = System.Drawing.Color.White;
            this.cbAppointment.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbAppointment.BorderSize = 2;
            this.cbAppointment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbAppointment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbAppointment.ForeColor = System.Drawing.Color.Black;
            this.cbAppointment.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbAppointment.ListBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbAppointment.ListTextColor = System.Drawing.Color.Black;
            this.cbAppointment.Location = new System.Drawing.Point(477, 239);
            this.cbAppointment.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbAppointment.Name = "cbAppointment";
            this.cbAppointment.Padding = new System.Windows.Forms.Padding(2);
            this.cbAppointment.Size = new System.Drawing.Size(201, 30);
            this.cbAppointment.TabIndex = 31;
            this.cbAppointment.Texts = "";
            this.cbAppointment.Visible = false;
            // 
            // txtKm
            // 
            this.txtKm.BackColor = System.Drawing.SystemColors.Window;
            this.txtKm.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtKm.BorderSize = 2;
            this.txtKm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKm.ForeColor = System.Drawing.Color.Black;
            this.txtKm.Location = new System.Drawing.Point(477, 105);
            this.txtKm.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtKm.MaxLenght = 32767;
            this.txtKm.Multiline = false;
            this.txtKm.Name = "txtKm";
            this.txtKm.Padding = new System.Windows.Forms.Padding(7);
            this.txtKm.PasswordChar = false;
            this.txtKm.Size = new System.Drawing.Size(189, 28);
            this.txtKm.TabIndex = 25;
            this.txtKm.Texts = "";
            this.txtKm.UnderlinedStyle = true;
            this.txtKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKm_KeyPress);
            // 
            // txtManufacturingYear
            // 
            this.txtManufacturingYear.BackColor = System.Drawing.SystemColors.Window;
            this.txtManufacturingYear.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtManufacturingYear.BorderSize = 2;
            this.txtManufacturingYear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtManufacturingYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtManufacturingYear.ForeColor = System.Drawing.Color.Black;
            this.txtManufacturingYear.Location = new System.Drawing.Point(477, 37);
            this.txtManufacturingYear.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtManufacturingYear.MaxLenght = 32767;
            this.txtManufacturingYear.Multiline = false;
            this.txtManufacturingYear.Name = "txtManufacturingYear";
            this.txtManufacturingYear.Padding = new System.Windows.Forms.Padding(7);
            this.txtManufacturingYear.PasswordChar = false;
            this.txtManufacturingYear.Size = new System.Drawing.Size(189, 28);
            this.txtManufacturingYear.TabIndex = 24;
            this.txtManufacturingYear.Texts = "";
            this.txtManufacturingYear.UnderlinedStyle = true;
            this.txtManufacturingYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManufacturingYear_KeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDescription.BorderSize = 2;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(139, 241);
            this.txtDescription.MaxLenght = 32767;
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(7);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.Size = new System.Drawing.Size(218, 28);
            this.txtDescription.TabIndex = 23;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = true;
            // 
            // lblManufacturingYear
            // 
            this.lblManufacturingYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManufacturingYear.AutoSize = true;
            this.lblManufacturingYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblManufacturingYear.Location = new System.Drawing.Point(382, 33);
            this.lblManufacturingYear.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblManufacturingYear.Name = "lblManufacturingYear";
            this.lblManufacturingYear.Size = new System.Drawing.Size(89, 30);
            this.lblManufacturingYear.TabIndex = 11;
            this.lblManufacturingYear.Text = "Manufacturing year:";
            // 
            // lblCarType
            // 
            this.lblCarType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarType.AutoSize = true;
            this.lblCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCarType.Location = new System.Drawing.Point(79, 48);
            this.lblCarType.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(54, 15);
            this.lblCarType.TabIndex = 2;
            this.lblCarType.Text = "Car type:";
            // 
            // lblRegistration
            // 
            this.lblRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRegistration.Location = new System.Drawing.Point(27, 116);
            this.lblRegistration.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(106, 15);
            this.lblRegistration.TabIndex = 4;
            this.lblRegistration.Text = "Registration plate:";
            // 
            // lblBuyer
            // 
            this.lblBuyer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBuyer.Location = new System.Drawing.Point(92, 179);
            this.lblBuyer.Margin = new System.Windows.Forms.Padding(0, 3, 3, 10);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(41, 15);
            this.lblBuyer.TabIndex = 6;
            this.lblBuyer.Text = "Buyer:";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDescription.Location = new System.Drawing.Point(61, 252);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 15);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description:";
            // 
            // lblKM
            // 
            this.lblKM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKM.Location = new System.Drawing.Point(442, 116);
            this.lblKM.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(29, 15);
            this.lblKM.TabIndex = 10;
            this.lblKM.Text = "Km:";
            // 
            // chBWarranty
            // 
            this.chBWarranty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chBWarranty.AutoSize = true;
            this.chBWarranty.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chBWarranty.Location = new System.Drawing.Point(477, 187);
            this.chBWarranty.Name = "chBWarranty";
            this.chBWarranty.Size = new System.Drawing.Size(15, 14);
            this.chBWarranty.TabIndex = 16;
            this.chBWarranty.UseVisualStyleBackColor = true;
            // 
            // lblComment
            // 
            this.lblComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblComment.Location = new System.Drawing.Point(69, 275);
            this.lblComment.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(64, 15);
            this.lblComment.TabIndex = 14;
            this.lblComment.Text = "Comment:";
            // 
            // txtCarType
            // 
            this.txtCarType.BackColor = System.Drawing.SystemColors.Window;
            this.txtCarType.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCarType.BorderSize = 2;
            this.txtCarType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCarType.ForeColor = System.Drawing.Color.Black;
            this.txtCarType.Location = new System.Drawing.Point(139, 37);
            this.txtCarType.MaxLenght = 32767;
            this.txtCarType.Multiline = false;
            this.txtCarType.Name = "txtCarType";
            this.txtCarType.Padding = new System.Windows.Forms.Padding(7);
            this.txtCarType.PasswordChar = false;
            this.txtCarType.Size = new System.Drawing.Size(218, 28);
            this.txtCarType.TabIndex = 20;
            this.txtCarType.Texts = "";
            this.txtCarType.UnderlinedStyle = true;
            // 
            // txtRegistrationPlate
            // 
            this.txtRegistrationPlate.BackColor = System.Drawing.SystemColors.Window;
            this.txtRegistrationPlate.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtRegistrationPlate.BorderSize = 2;
            this.txtRegistrationPlate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtRegistrationPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRegistrationPlate.ForeColor = System.Drawing.Color.Black;
            this.txtRegistrationPlate.Location = new System.Drawing.Point(139, 105);
            this.txtRegistrationPlate.MaxLenght = 32767;
            this.txtRegistrationPlate.Multiline = false;
            this.txtRegistrationPlate.Name = "txtRegistrationPlate";
            this.txtRegistrationPlate.Padding = new System.Windows.Forms.Padding(7);
            this.txtRegistrationPlate.PasswordChar = false;
            this.txtRegistrationPlate.Size = new System.Drawing.Size(218, 28);
            this.txtRegistrationPlate.TabIndex = 21;
            this.txtRegistrationPlate.Texts = "";
            this.txtRegistrationPlate.UnderlinedStyle = true;
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.SystemColors.Window;
            this.txtComment.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtComment.BorderSize = 2;
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtComment.ForeColor = System.Drawing.Color.Black;
            this.txtComment.Location = new System.Drawing.Point(139, 275);
            this.txtComment.MaxLenght = 32767;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Padding = new System.Windows.Forms.Padding(7);
            this.txtComment.PasswordChar = false;
            this.txtComment.Size = new System.Drawing.Size(218, 62);
            this.txtComment.TabIndex = 28;
            this.txtComment.Texts = "";
            this.txtComment.UnderlinedStyle = false;
            // 
            // cbBuyers
            // 
            this.cbBuyers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbBuyers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBuyers.BackColor = System.Drawing.Color.White;
            this.cbBuyers.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbBuyers.BorderSize = 2;
            this.cbBuyers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbBuyers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbBuyers.ForeColor = System.Drawing.Color.Black;
            this.cbBuyers.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbBuyers.ListBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbBuyers.ListTextColor = System.Drawing.Color.Black;
            this.cbBuyers.Location = new System.Drawing.Point(139, 171);
            this.cbBuyers.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbBuyers.Name = "cbBuyers";
            this.cbBuyers.Padding = new System.Windows.Forms.Padding(2);
            this.cbBuyers.Size = new System.Drawing.Size(218, 30);
            this.cbBuyers.TabIndex = 29;
            this.cbBuyers.Texts = "";
            this.cbBuyers.OnSelectedIndexChanged += new System.EventHandler(this.cbBuyers_OnSelectedIndexChanged);
            // 
            // lblWarranty
            // 
            this.lblWarranty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarranty.AutoSize = true;
            this.lblWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWarranty.Location = new System.Drawing.Point(413, 184);
            this.lblWarranty.Margin = new System.Windows.Forms.Padding(0, 3, 3, 5);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(58, 15);
            this.lblWarranty.TabIndex = 15;
            this.lblWarranty.Text = "Warranty:";
            // 
            // lblAppointment
            // 
            this.lblAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Location = new System.Drawing.Point(402, 249);
            this.lblAppointment.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(69, 13);
            this.lblAppointment.TabIndex = 30;
            this.lblAppointment.Text = "Appointemnt:";
            this.lblAppointment.Visible = false;
            // 
            // tableLayoutItems
            // 
            this.tableLayoutItems.ColumnCount = 1;
            this.tableLayoutItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutItems.Controls.Add(this.btnAddWorkOrder, 0, 2);
            this.tableLayoutItems.Controls.Add(this.dataGridItemsWorkOrder, 0, 1);
            this.tableLayoutItems.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutItems.Location = new System.Drawing.Point(0, 391);
            this.tableLayoutItems.Name = "tableLayoutItems";
            this.tableLayoutItems.RowCount = 3;
            this.tableLayoutItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tableLayoutItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutItems.Size = new System.Drawing.Size(681, 302);
            this.tableLayoutItems.TabIndex = 2;
            // 
            // btnAddWorkOrder
            // 
            this.btnAddWorkOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddWorkOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddWorkOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddWorkOrder.Location = new System.Drawing.Point(532, 268);
            this.btnAddWorkOrder.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnAddWorkOrder.Name = "btnAddWorkOrder";
            this.btnAddWorkOrder.Size = new System.Drawing.Size(144, 29);
            this.btnAddWorkOrder.TabIndex = 3;
            this.btnAddWorkOrder.UseVisualStyleBackColor = false;
            this.btnAddWorkOrder.Click += new System.EventHandler(this.btnAddWorkOrder_Click);
            // 
            // dataGridItemsWorkOrder
            // 
            this.dataGridItemsWorkOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridItemsWorkOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.dataGridItemsWorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItemsWorkOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridItemsWorkOrder.Location = new System.Drawing.Point(3, 33);
            this.dataGridItemsWorkOrder.Name = "dataGridItemsWorkOrder";
            this.dataGridItemsWorkOrder.ReadOnly = true;
            this.dataGridItemsWorkOrder.Size = new System.Drawing.Size(675, 229);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(681, 30);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // lblItems
            // 
            this.lblItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblItems.Location = new System.Drawing.Point(3, 9);
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
            this.btnItemsList.Location = new System.Drawing.Point(139, 1);
            this.btnItemsList.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnItemsList.Name = "btnItemsList";
            this.btnItemsList.Size = new System.Drawing.Size(118, 29);
            this.btnItemsList.TabIndex = 2;
            this.btnItemsList.Text = "Add item";
            this.btnItemsList.UseVisualStyleBackColor = false;
            this.btnItemsList.Click += new System.EventHandler(this.btnItemsList_Click);
            // 
            // WorkOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 693);
            this.Controls.Add(this.tableLayoutItems);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutTitle);
            this.Name = "WorkOrderForm";
            this.Text = "AddWorkOrder";
            this.Load += new System.EventHandler(this.AddWorkOrder_Load);
            this.tableLayoutTitle.ResumeLayout(false);
            this.tableLayoutTitle.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutItems.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblManufacturingYear;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.CheckBox chBWarranty;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutItems;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.DataGridView dataGridItemsWorkOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAddWorkOrder;
        private System.Windows.Forms.Button btnItemsList;
        private CustomControls.CustomTextBox txtCarType;
        private CustomControls.CustomTextBox txtKm;
        private CustomControls.CustomTextBox txtManufacturingYear;
        private CustomControls.CustomTextBox txtDescription;
        private CustomControls.CustomTextBox txtRegistrationPlate;
        private CustomControls.CustomTextBox txtComment;
        private CustomControls.CustomComboBox cbBuyers;
        private CustomControls.CustomComboBox cbAppointment;
        private System.Windows.Forms.Label lblAppointment;
    }
}