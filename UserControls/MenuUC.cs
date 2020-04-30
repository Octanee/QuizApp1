using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGUI1.UserControls
{
    public partial class MenuUC : UserControl
    {

        #region Singleton

        private static MenuUC instance = null;
        public static MenuUC Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MenuUC();
                }

                return instance;
            }
        }

        #endregion

        public MenuUC()
        {
            InitializeComponent();
            sidePanel.Visible = false;
        }

        private void buttonDashboard_Click(object sender , EventArgs e)
        {
            SetSidePanel(sender);
            ShowUserControl(DashboardUC.Instance);
        }

        private void buttonListOfQuizzes_Click(object sender, EventArgs e)
        {
            SetSidePanel(sender);
            ShowUserControl(ListOfQuizzes.Instance);
        }

        private void buttonLeaderboard_Click(object sender, EventArgs e)
        {
            SetSidePanel(sender);
            ShowUserControl(LeaderboardUC.Instance);
        }

        private void SetSidePanel(object sender)
        {
            var button = sender as Button;
            sidePanel.Height = button.Height;
            sidePanel.Top = button.Top;
            sidePanel.Visible = true;
        }

        private void ShowUserControl(UserControl control)
        {
            if (!panelUC.Controls.Contains(control))
            {
                panelUC.Controls.Add(control);
                control.Dock = DockStyle.Fill;
            }
            control.BringToFront();
        }

        public void ShowQuizResult()
        {
            FormMain.Instance.RemoveControl(QuizUC.Instance);
            ShowUserControl(QuizResult.Instance);
        }
    }
}
