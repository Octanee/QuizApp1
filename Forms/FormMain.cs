using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGUI1
{
    public partial class FormMain : Form
    {

        #region Singleton

        private static FormMain instance = null;
        public static FormMain Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormMain();
                }
                return instance;
            }
        }

        #endregion

        private List<Question> pytania;

        public FormMain()
        {

            InitializeComponent();

            pytania = PopulateList(10);

            SetForm(new FormQuiz(pytania));
        }

        private List<Question> PopulateList(int size)
        {
            var temp = new List<Question>();
            for (int i = 0; i < size; i++)
            {
                Question p = new Question();
                p.Text = "Tekst pytania " + i;
                p.PoprawnaOdpowiedz = "Poprawna odwowiedz";
                p.BlednaOdpowiedz1 = "Bledna odpowiedz 1";
                p.BlednaOdpowiedz2 = "Bledna odpowiedz 2";
                p.BlednaOdpowiedz3 = "Bledna odpowiedz 3";

                temp.Add(p);
            }

            return temp;
        }

        private Form activeForm = null;

        private void SetForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            activeForm = form;
            form.TopLevel = false;
            panelParent.Controls.Add(form);
            form.Show();
        }

        public void SummaryQuiz(int points)
        {
            MessageBox.Show("Zdobyte punkty: " + points);
        }


        #region MouseMovement 

        private bool dragging;
        private Point mouse;

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            mouse = e.Location;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - mouse.X, p.Y - mouse.Y);
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        #region Przyciski
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
