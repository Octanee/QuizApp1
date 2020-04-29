using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using QuizGUI1.source;

namespace QuizGUI1
{
    public partial class FormQuiz : Form
    {

        #region Properties
        private int timerStartWidth;
        private int timerStartX;
        private int timerWidth;
        private int questionTime = 5;
        private int showAnswerTime = 3;

        private int questionCount;

        private int correctAnswers = 0;

        private List<AnswerButtom> buttons;

        private Question currentQuestion;

        private Quiz currentQuiz;
        private List<Question> questions;

        #endregion

        public FormQuiz(Quiz quiz)
        {
            currentQuiz = quiz;
            questions = quiz.Questions;
            questionCount = questions.Count();

            InitializeComponent();

            timerStartWidth = panelTimer.Width;
            timerStartX = panelTimer.Location.X;

            timerAnswer.Interval = (showAnswerTime * 1000);

            SetAnswerButtons();

            RandomQuestion();
        }

        private void SetAnswerButtons()
        {
            buttons = new List<AnswerButtom>();

            buttons.Add(buttonA);
            buttons.Add(buttonB);
            buttons.Add(buttonC);
            buttons.Add(buttonD);

            ResetButtons();
        }

        private void EndQuiz()
        {
            timerAnswer.Stop();
            timerPytanie.Stop();
        }

        private void buttonEndQuiz_Click(object sender, EventArgs e)
        {
            // DialogResult result = MessageBox.Show(this, "Czy napewno chcesz zakończyc QUIZ?", "ZAKOŃCZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            EndQuiz();
            //    }
        }

        private void RandomQuestion()
        {
            if (questions.Count > 0)
            {
                ResetButtons();
                var rand = new Random();
                var temp = questions.ElementAt(rand.Next(questions.Count));
                currentQuestion = temp;
                SetPytanie(temp);
                questions.Remove(temp);
                ResetTimer();
                SetTimer();

                labelCount.Text = questionCount - questions.Count + "/" + questionCount;
            }
            else
            {
                EndQuiz();
            }
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            ShowAnswers();
            var button = sender as AnswerButtom;

            if (button.isCorrect)
            {
                correctAnswers++;
            }

            button.FlatAppearance.BorderSize = 2;
        }

        private void ShowAnswers()
        {
            foreach (var b in buttons)
            {
                b.Enabled = false;
                if (b.isCorrect)
                {
                    b.BackColor = Color.Green;
                }
                else
                {
                    b.BackColor = Color.Red;
                }
            }
            timerPytanie.Stop();
            timerAnswer.Start();
        }

        private void SetPytanie(Question current)
        {
            labelPytanie.Text = current.Text;

            var tmpButtons = new List<AnswerButtom>(buttons);

            ResetButtons();

            var tmpAnswers = new List<string>();
            tmpAnswers.Add(currentQuestion.PoprawnaOdpowiedz);
            tmpAnswers.Add(currentQuestion.BlednaOdpowiedz1);
            tmpAnswers.Add(currentQuestion.BlednaOdpowiedz2);
            tmpAnswers.Add(currentQuestion.BlednaOdpowiedz3);

            var rand = new Random();

            while (tmpButtons.Count > 0)
            {
                var numButton = rand.Next(tmpButtons.Count);
                var numAnswer = rand.Next(tmpAnswers.Count);

                SetButton(tmpButtons.ElementAt(numButton), tmpAnswers.ElementAt(numAnswer));

                tmpAnswers.RemoveAt(numAnswer);
                tmpButtons.RemoveAt(numButton);
            }
        }

        private void SetButton(AnswerButtom button, string answer)
        {
            button.Text = answer;
            if (answer == currentQuestion.PoprawnaOdpowiedz)
            {
                button.isCorrect = true;
            }
        }

        private void ResetButtons()
        {
            foreach (var b in buttons)
            {
                b.isCorrect = false;
                b.BackColor = Color.DimGray;
                b.FlatAppearance.BorderSize = 0;
                b.Enabled = true;
            }
        }

        #region Timers
        private void timerAnswer_Tick(object sender, EventArgs e)
        {
            timerAnswer.Stop();

            RandomQuestion();
        }

        private void timerPytanie_Tick(object sender, EventArgs e)
        {
            DecreaseTimerPanel();

            if (panelTimer.Size.Width <= 0)
            {
                ShowAnswers();
            }
        }

        private void DecreaseTimerPanel()
        {
            var width = panelTimer.Size.Width - 2;
            panelTimer.Size = new Size(width, panelTimer.Height);
            var X = panelTimer.Location.X + 1;
            panelTimer.Location = new Point(X, panelTimer.Location.Y);
        }

        private void SetTimer()
        {
            timerWidth = panelTimer.Width;
            var interval = 1000 / ((timerWidth / 2) / questionTime);
            timerPytanie.Interval = interval;

            timerPytanie.Start();
        }

        private void ResetTimer()
        {
            panelTimer.Width = timerStartWidth;
            panelTimer.Location = new Point(timerStartX, panelTimer.Location.Y);
        }
        #endregion

        private void FormQuiz_Load(object sender, EventArgs e)
        {

        }
    }
}
