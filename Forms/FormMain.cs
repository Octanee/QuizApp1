using QuizGUI1.CustomControls;
using QuizGUI1.Forms;
using QuizGUI1.source;
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

        private Quiz quiz;

        public FormMain()
        {
            InitializeComponent();

            quiz = PopulateList(10);

            ShowMenu();
        }


        private Quiz PopulateList(int size)
        {
            var temp = new Quiz();
            for (int i = 0; i < size; i++)
            {
                Question question = new Question();
                question.Text = "Tekst pytania " + i;
                question.CorrectAnswer = "Poprawna odwowiedz";
                question.IncorrectAnswer1 = "Bledna odpowiedz 1";
                question.IncorrectAnswer2 = "Bledna odpowiedz 2";
                question.IncorrectAnswer3 = "Bledna odpowiedz 3";

                temp.AddQuestion(question);
            }

            return temp;
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

        private void RemoveControl(UserControl control)
        {
            if (panelUC.Controls.Contains(control))
            {
                panelUC.Controls.Remove(control);
            }
        }

        private void StartQuiz()
        {
            ShowUserControl(QuizUC.Instance);
        }

        private void ShowMenu()
        {
            ShowUserControl(MenuUC.Instance);
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

        #region Menu


        

        private void mButtonDashboard_Click(object sender, EventArgs e)
        {

        }

        private void mButtonNewQuiz_Click(object sender, EventArgs e)
        {

        }

        private void mButtonListOfQuizzes_Click(object sender, EventArgs e)
        {

        }

        private void mButtonLeaderboard_Click(object sender, EventArgs e)
        {

        }

        private void SetSidePanel()
        {

        }

        #endregion
    }
}
