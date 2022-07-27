using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SGB.Controles
{
    [DefaultEvent("_TextChanged")]
    public partial class CustomMaskedTextBox : UserControl
    {
        #region -> Fields
            //Fields
            private Color borderColor = Color.MediumSlateBlue;
            private Color borderFocusColor = Color.HotPink;
            private int borderSize = 2;
            private bool underlinedStyle = false;
            private bool isFocused = false;

            private int borderRadius = 0;
            private Color placeholderColor = Color.DarkGray;
            private string placeholderText = "";
            private bool isPlaceholder = false;
            private bool isPasswordChar = false;

            //Events
            public event EventHandler _TextChanged;

            #endregion

        //-> Constructor
        public CustomMaskedTextBox()
        {
            //Created by designer
            InitializeComponent();
        }

        #region -> Properties
        [Category("Aparência")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Aparência")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        [Category("Aparência")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                if (value >= 1)
                {
                    borderSize = value;
                    this.Invalidate();
                }
            }
        }

        [Category("Aparência")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("Aparência")]
        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set
            {
                isPasswordChar = value;
                if (!isPlaceholder)
                    Mbx_Pricipal.UseSystemPasswordChar = value;
            }
        }

        [Category("Aparência")]
        public bool Multiline
        {
            get { return Mbx_Pricipal.Multiline; }
            set { Mbx_Pricipal.Multiline = value; }
        }

        [Category("Aparência")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                Mbx_Pricipal.BackColor = value;
            }
        }

        [Category("Aparência")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                Mbx_Pricipal.ForeColor = value;
            }
        }

        [Category("Aparência")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                Mbx_Pricipal.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("Aparência")]
        public string Texts
        {
            get
            {
                if (isPlaceholder) return "";
                else return Mbx_Pricipal.Text;
            }
            set
            {
                Mbx_Pricipal.Text = value;
                SetPlaceholder();
            }
        }

        [Category("Aparência")]
        public bool ReadOnly
        {
            get
            {
                return Mbx_Pricipal.ReadOnly;
            }
            set
            {
                Mbx_Pricipal.ReadOnly = value;
            }
        }

        [Category("Aparência")]
        public bool HidePromptOnLeave
        {
            get
            {
                return Mbx_Pricipal.HidePromptOnLeave;
            }
            set
            {
                Mbx_Pricipal.HidePromptOnLeave = value;
            }
        }

        [Category("Aparência")]
        public string Mask
        {
            get
            {
                return Mbx_Pricipal.Mask;
            }
            set
            {
                Mbx_Pricipal.Mask = value;
            }
        }

        [Category("Aparência")]       
        public int MaxLength
        {
            get
            {
                return Mbx_Pricipal.MaxLength;
            }
            set
            {
                Mbx_Pricipal.MaxLength = value;
            }

        }

        [Category("Aparência")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();//Redraw control
                }
            }
        }

        [Category("Aparência")]
        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set
            {
                placeholderColor = value;
                if (isPlaceholder)
                    Mbx_Pricipal.ForeColor = value;
            }
        }

        [Category("Aparência")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                Mbx_Pricipal.Text = "";
                SetPlaceholder();
            }
        }

        #endregion

        #region -> Overridden methods
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
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1)//Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Square/Normal TextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }
        #endregion

        #region -> Private methods
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(Mbx_Pricipal.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                Mbx_Pricipal.Text = placeholderText;
                Mbx_Pricipal.ForeColor = placeholderColor;
                if (isPasswordChar)
                    Mbx_Pricipal.UseSystemPasswordChar = false;
            }
        }
        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                Mbx_Pricipal.Text = "";
                Mbx_Pricipal.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    Mbx_Pricipal.UseSystemPasswordChar = true;
            }
        }
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(Mbx_Pricipal.ClientRectangle, borderRadius - borderSize);
                Mbx_Pricipal.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(Mbx_Pricipal.ClientRectangle, borderSize * 2);
                Mbx_Pricipal.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }
        private void UpdateControlHeight()
        {
            if (Mbx_Pricipal.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                Mbx_Pricipal.Multiline = true;
                Mbx_Pricipal.MinimumSize = new Size(0, txtHeight);
                Mbx_Pricipal.Multiline = false;

                this.Height = Mbx_Pricipal.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        #endregion

        #region -> TextBox events
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }

        ///::::+
        #endregion

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

