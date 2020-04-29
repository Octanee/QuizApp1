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
    public class MenuButton : Button
    {
        private bool isChosen;

        public bool IsChosen
        {
            get { return isChosen; }
            set
            {
                isChosen = value;
                Invalidate();
            }
        }


        public Color SelectedBarColor { get; set; }
        public int SelectedBarSize { get; set; }

        public MenuButton()
        {
            this.isChosen = false;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (isChosen)
            {
                Graphics g = pevent.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Brush brush = new SolidBrush(SelectedBarColor);

                g.FillRectangle(brush, 0, 0, SelectedBarSize, Height);

                brush.Dispose();
            }
        }
    }
}


