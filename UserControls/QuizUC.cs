using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizGUI1.source;
using QuizGUI1.CustomControls;

namespace QuizGUI1.UserControls
{
    public partial class QuizUC : UserControl
    {
        #region Singleton
        private static QuizUC instance = null;
        public static QuizUC Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuizUC();
                }

                return instance;
            }
        }
        #endregion

        #region Properties
        private Quiz quiz;

        public Quiz Quiz
        {
            get { return quiz; }
            set { quiz = value; }
        }

        private List<QuestionUC> questionUCs = new List<QuestionUC>();
        #endregion

        public QuizUC()
        {
            InitializeComponent();
        }

        public void StartQuiz()
        {
            CreateQuestionsUC();
            CreateQuestionsUCButton();
            SetQuizTimer();
        }

        private void EndQuiz()
        {
            FormMain.Instance.ShowMenu();
            MenuUC.Instance.ShowQuizResult();
        }

        private void CreateQuestionsUC()
        {
            foreach (var question in quiz.Questions)
            {
                var questionUC = new QuestionUC(question);
                questionUCs.Add(questionUC);
                panelQuestion.Controls.Add(questionUC);
            }
        }

        private void CreateQuestionsUCButton()
        {
            foreach (var uc in questionUCs)
            {
                RoundedButton button = new RoundedButton();
                button.Size = new Size(42, 40);
                button.BorderThickness = 0;
                flpQuestionButoons.Controls.Add(button);
            }
        }

        private void buttonEndQuiz_Click(object sender, EventArgs e)
        {
            timerQuizTime.Stop();
            EndQuiz();
        }

        #region Timer
        private void timerQuizTime_Tick(object sender, EventArgs e)
        {
            DecreaseTimerPanel();

            if (panelTimer.Width <= 0)
            {
                EndQuiz();
            }
        }

        private void DecreaseTimerPanel()
        {
            var width = panelTimer.Size.Width - 2;
            panelTimer.Size = new Size(width, panelTimer.Height);
            var X = panelTimer.Location.X + 1;
            panelTimer.Location = new Point(X, panelTimer.Location.Y);
        }

        private void SetQuizTimer()
        {
            var panelWidth = panelTimer.Width / 2;
            var timeInMilisecound = (quiz.Time * 1000);
            var interval = timeInMilisecound / panelWidth;
            timerQuizTime.Interval = interval;
            timerQuizTime.Start();
        }
        #endregion
    }
}
