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
        private List<Control> menuButtons;

        private Quiz quiz;

        public FormMain()
        {
            InitializeComponent();

            menuButtons = GetAll(this, typeof(MenuButton)).ToList();
            UncheckAllMenuButtons();
            quiz = PopulateList(10);
        }


        private Quiz PopulateList(int size)
        {
            var temp = new Quiz();
            for (int i = 0; i < size; i++)
            {
                Question question = new Question();
                question.Text = "Tekst pytania " + i;
                question.PoprawnaOdpowiedz = "Poprawna odwowiedz";
                question.BlednaOdpowiedz1 = "Bledna odpowiedz 1";
                question.BlednaOdpowiedz2 = "Bledna odpowiedz 2";
                question.BlednaOdpowiedz3 = "Bledna odpowiedz 3";

                temp.AddQuestion(question);
            }

            return temp;
        }

        private void StartQuiz()
        {
            ShowUserControl(QuizUC.Instance);
        }

        #region UserControl
        private void ShowUserControl(UserControl control)
        {
            if (!panelParent.Controls.Contains(control))
            {
                AddNewControl(control);
            }
            control.BringToFront();
        }

        private void AddNewControl(UserControl control)
        {
            panelParent.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void RemoveControl(UserControl control)
        {
            if (panelParent.Controls.Contains(control))
            {
                panelParent.Controls.Remove(control);
            }
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
            FormLogin.Instance.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Menu

        private void menuButton1_Click(object sender, EventArgs e)
        {
            menuButton1.IsChosen = true;
            ShowUserControl(QuizUC.Instance);
        }

        private void UncheckAllMenuButtons()
        {
            foreach (MenuButton button in menuButtons)
            {
                button.IsChosen = false; 
            }
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        #endregion

    }
}
