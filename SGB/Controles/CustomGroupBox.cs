using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGB.Controles
{
    /// <summary>
    /// Group personalizada e melhorada
    /// </summary>
    public partial class CustomGroupBox : UserControl
    {
        private int borderSize = 1;
        private Color borderColor = Color.Black;

        public CustomGroupBox()
        {
            InitializeComponent();
            UpdateBorderColor();
            Lbl_Principal.Text = Name;
        }

        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                Pnl_Bot.Height = borderSize; 
                Pnl_Top.Height = borderSize;
                Pnl_Left.Width = borderSize;
                Pnl_Right.Width = borderSize;
            }
        }

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                UpdateBorderColor();
            }
        }

        public Color GroupBackColor
        {
            get
            {
                return Pnl_BackGround.BackColor;
            }
            set
            {
                Pnl_BackGround.BackColor = value;
            }
        }

        public string LabelText
        {
            get
            {
                return Lbl_Principal.Text;
            }
            set
            {
                Lbl_Principal.Text = value;
            }
        }

        public Font LabelFont
        {
            get
            {
                return Lbl_Principal.Font;
            }
            set
            {
                Lbl_Principal.Font = value;
            }
        }

        private void UpdateBorderColor()
        {
            Pnl_Bot.BackColor = borderColor;
            Pnl_Top.BackColor = borderColor;
            Pnl_Left.BackColor = borderColor;
            Pnl_Right.BackColor = borderColor;
        }
    }
}
