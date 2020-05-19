using QuizGUI1.CustomControls;
using QuizGUI1.Database.UnitOfWork;
using QuizGUI1.Forms;
using QuizGUI1.Source.Models;
using QuizGUI1.UserControls;
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

        private UnitOfWork UnitOfWork = null;
        public FormMain()
        {
            InitializeComponent();

            ShowMenu();
            UnitOfWork = new UnitOfWork();
        }

        #region UserControl
        private void ShowUserControl(UserControl control)
        {
            if (!panelUC.Controls.Contains(control))
            {
                panelUC.Controls.Add(control);
                control.Dock = DockStyle.Fill;
            }
            control.BringToFront();
        }

        public void RemoveControl(UserControl control)
        {
            if (panelUC.Controls.Contains(control))
            {
                panelUC.Controls.Remove(control);
            }
        }

        public void StartQuiz(Quiz quiz)
        {
            QuizUC.Instance.Quiz = quiz;
            ShowUserControl(QuizUC.Instance);
            QuizUC.Instance.StartQuiz();
        }

        public void ShowMenu()
        {
            ShowUserControl(MenuUC.Instance);
        }

        public void ShowQuizResult()
        {
            RemoveControl(QuizUC.Instance);
            ShowUserControl(QuizResult.Instance);
        }
        #endregion

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

        #region FunctionalButtons
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin.Instance.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

    }
}
