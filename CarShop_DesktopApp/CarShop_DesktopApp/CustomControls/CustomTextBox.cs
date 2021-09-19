using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop_DesktopApp.CustomControls
{
    public partial class CustomTextBox : UserControl
    {
        private Color borderColor = Color.Black;
        private int borderSize = 2;
        private bool underlinedStyle = false;

        public CustomTextBox()
        {
            InitializeComponent();
        }
        [Category("Custom properties")]
        public Color BorderColor { get => borderColor; set => borderColor = value; }
        [Category("Custom properties")]
        public int BorderSize { get => borderSize; set => borderSize = value; }
        [Category("Custom properties")]
        public bool UnderlinedStyle { get => underlinedStyle; set => underlinedStyle = value; }
        [Category("Custom properties")]
        public bool PasswordChar { get { return txtCustom.UseSystemPasswordChar; } set { txtCustom.UseSystemPasswordChar = value; } }
        [Category("Custom properties")]
        public bool Multiline { get { return txtCustom.Multiline; } set { txtCustom.Multiline = value; }}
        [Category("Custom properties")]
        public override Color BackColor { get => base.BackColor; set { base.BackColor = value; txtCustom.BackColor = value;} }
        [Category("Custom properties")]
        public override Color ForeColor { get => base.ForeColor; set { base.ForeColor = value; txtCustom.ForeColor = value; } }
        [Category("Custom properties")]
        public override Font Font 
        {
            get => base.Font; 
            set 
            { 
                base.Font = value; 
                txtCustom.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            } 
        }
        [Category("Custom properties")]
        public string Texts
        {
            get
            {
                return txtCustom.Text;
            }
            set
            {
                txtCustom.Text = value;
            }
        }
        [Category("Custom properties")]
        public int MaxLenght { get => txtCustom.MaxLength; set => txtCustom.MaxLength = value; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            using (Pen penBorder = new Pen(borderColor,borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (underlinedStyle)
                {
                    graphics.DrawLine(penBorder,0,this.Height-1,this.Width,this.Height-1);
                }
                else
                {
                    graphics.DrawLine(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (txtCustom.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                txtCustom.Multiline = true;
                txtCustom.MinimumSize = new Size(0, txtHeight);
                txtCustom.Multiline = false;

                this.Height = txtCustom.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void txtCustom_Validating(object sender, CancelEventArgs e)
        {
            this.OnValidating(e);
        }

        private void txtCustom_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }
    }
}
