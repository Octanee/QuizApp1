using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGUI1.CustomControls
{
    public class RoundedButton : Button
    {
        #region Properties
        private Color borderColor = Color.Silver;
        private Color onHoverBorderColor = Color.Gray;
        private Color buttonColor = Color.Red;
        private Color onHoverButtonColor = Color.Yellow;
        private Color textColor = Color.White;
        private Color onHoverTextColor = Color.Gray;

        private bool isHovering;
        private int borderThickness = 2;
        private int borderThicknessByTwo = 1;
        #endregion

        public RoundedButton()
        {
            DoubleBuffered = true;
            MouseEnter += (sender, e) =>
             {
                 isHovering = true;
                 Invalidate();
             };
            MouseLeave += (sender, e) =>
            {
                isHovering = false;
                Invalidate();
            };

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Brush brush = new SolidBrush(isHovering ? onHoverBorderColor : borderColor);

            g.FillEllipse(brush, 0, 0, Height, Height);
            g.FillEllipse(brush, Width - Height, 0, Height, Height);
            g.FillRectangle(brush, Height / 2, 0, Width - Height, Height);

            brush.Dispose();

            brush = new SolidBrush(isHovering ? onHoverButtonColor : buttonColor);

            g.FillEllipse(brush, borderThicknessByTwo, borderThicknessByTwo, Height - borderThickness, Height - borderThickness);
            g.FillEllipse(brush, (Width - Height) + borderThicknessByTwo, borderThicknessByTwo, Height - borderThickness, Height - borderThickness);
            g.FillRectangle(brush, Height / 2 + borderThicknessByTwo, borderThicknessByTwo, Width - Height - borderThickness, Height - borderThickness);

            brush.Dispose();

            brush = new SolidBrush(isHovering ? onHoverTextColor : textColor);
            SizeF stringSize = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, brush, (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);
        }

        #region Get and Set
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }
        public Color OnHoverBorderColor
        {
            get => onHoverBorderColor;
            set
            {
                onHoverBorderColor = value;
                Invalidate();
            }
        }
        public Color ButtonColor
        {
            get => buttonColor;
            set
            {
                buttonColor = value;
                Invalidate();
            }
        }
        public Color OnHoverButtonColor
        {
            get => onHoverButtonColor;
            set
            {
                onHoverButtonColor = value;
                Invalidate();
            }
        }
        public Color TextColor
        {
            get => textColor;
            set
            {
                textColor = value;
                Invalidate();
            }
        }
        public Color OnHoverTextColor
        {
            get => onHoverTextColor;
            set
            {
                onHoverTextColor = value;
                Invalidate();
            }
        }

        public int BorderThickness
        {
            get => borderThickness;
            set
            {
                borderThickness = value;
                borderThicknessByTwo = value / 2;
                Invalidate();
            }

        }
        #endregion
    }
}
