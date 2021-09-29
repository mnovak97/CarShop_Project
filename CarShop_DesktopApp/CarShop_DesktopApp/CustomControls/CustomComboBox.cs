using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop_DesktopApp.CustomControls
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public partial class CustomComboBox : UserControl
    {
        //Fields
        private Color backColor = Color.White;
        private Color iconColor = SystemColors.MenuHighlight;
        private Color listBackColor = Color.White;
        private Color listTextColor = Color.Black;
        private Color borderColor = SystemColors.MenuHighlight;
        private int borderSize = 1;

        //Controls
        private ComboBox cbList;
        private Label lblText;
        private Button btnIcon;

        [Category("Custom properties")]
        public new Color BackColor 
        { 
            get => backColor; 
            set
            {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            } 
        }
        [Category("Custom properties")]
        public Color IconColor 
        {
            get => iconColor;
            set 
            {
                iconColor = value;
                btnIcon.Invalidate();//redraw icon
            }
        }
        [Category("Custom properties")]
        public Color ListBackColor
        { 
            get => listBackColor;
            set 
            { 
                listBackColor = value;
                cbList.BackColor = listBackColor;
            } 
        }
        [Category("Custom properties")]
        public Color ListTextColor 
        { 
            get => listTextColor;
            set 
            { 
                listTextColor = value;
                cbList.ForeColor = listTextColor;
            } 
        }
        [Category("Custom properties")]
        public Color BorderColor 
        { 
            get => borderColor;
            set 
            { 
                borderColor = value;
                base.BackColor = borderColor;
            }
        }
        [Category("Custom properties")]
        public int BorderSize 
        { 
            get => borderSize;
            set 
            {
                borderSize = value;
                this.Padding = new Padding(borderSize); //Border size
                AdjustComboBoxDimensions();
            } 
        }
        [Category("Custom properties")]
        public override Color ForeColor 
        { 
            get => base.ForeColor;
            set 
            {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }
        [Category("Custom properties")]
        public override Font Font 
        {
            get => base.Font;
            set 
            { 
                base.Font = value;
                lblText.Font = value;
                cbList.Font = value;
            }
        }
        [Category("Custom properties")]
        public string Texts { get => lblText.Text; set => lblText.Text = value; }
        [Category("Custom properties")]
        public ComboBoxStyle DropDownStyle 
        { 
            get => cbList.DropDownStyle;
            set 
            {   
                if(cbList.DropDownStyle != ComboBoxStyle.Simple)
                    cbList.DropDownStyle = value; 
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        [Category("Custom properties")]
        public ComboBox.ObjectCollection Items 
        {
            get { return cbList.Items; }
        }

        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        [Category("Custom properties")]
        public object DataSource
        {
            get
            {
                return cbList.DataSource;
            }
            set
            {
                cbList.DataSource = value;
            } 
        }

      
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        [Category("Custom properties")]
        public AutoCompleteStringCollection AutoCompleteCustomSource 
        {
            get { return cbList.AutoCompleteCustomSource; }
            set { cbList.AutoCompleteCustomSource = value; }
        }
      
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Custom properties")]
        public AutoCompleteSource AutoCompleteSource 
        {
            get 
            {
                return cbList.AutoCompleteSource;
            }
            set 
            {
                cbList.AutoCompleteSource = value;
            }
        }
        
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Custom properties")]
        public AutoCompleteMode AutoCompleteMode 
        {
            get 
            {
                return cbList.AutoCompleteMode;
            }
            set
            {
                cbList.AutoCompleteMode = value;
            }
        }

     
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Category("Custom properties")]
        public object SelectedItem 
        {
            get { return cbList.SelectedItem; }
            set { cbList.SelectedItem = value; }
        }
       
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Category("Custom properties")]
        public int SelectedIndex { get => cbList.SelectedIndex; set => cbList.SelectedIndex = value; }

        //Events
        public event EventHandler OnSelectedIndexChanged;//Default event


        public CustomComboBox()
        {
            cbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            cbList.BackColor = listBackColor;
            cbList.Font = new Font(this.Font.Name, 10F);
            cbList.ForeColor = listTextColor;
            cbList.SelectedIndexChanged += CbList_SelectedIndexChanged;
            cbList.TextChanged += CbList_TextChanged;

            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += BtnIcon_Click;
            btnIcon.Paint += BtnIcon_Paint;

            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);
            lblText.Click += LblText_Click;

            this.Controls.Add(lblText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cbList);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);
            base.BackColor = borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        private void AdjustComboBoxDimensions()
        {
            cbList.Width = lblText.Width;
            cbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cbList.Width,
                Y = lblText.Bottom - cbList.Height
            };
        }

        private void LblText_Click(object sender, EventArgs e)
        {
            cbList.Select();
            if (cbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cbList.DroppedDown = true;
        }

        private void BtnIcon_Paint(object sender, PaintEventArgs e)
        {
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graphics = e.Graphics;

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graphics.DrawPath(pen, path);
            }
        }

        private void BtnIcon_Click(object sender, EventArgs e)
        {
            cbList.Select();
            cbList.DroppedDown = true;
        }

        private void CbList_TextChanged(object sender, EventArgs e)
        {
            lblText.Text = cbList.Text;
        }

        private void CbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);

            lblText.Text = cbList.Text;
        }
    }
}
