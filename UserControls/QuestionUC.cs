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
    public partial class QuestionUC : UserControl
    {
        public Question question;


        public QuestionUC(Question question)
        {
            this.question = question;
            InitializeComponent();
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            labelText.Text = question.Text;
            SetRandomAnswer();
        }

        private void SetRandomAnswer()
        {
            var random = new Random();
            var answers = new List<string>() { question.CorrectAnswer, question.IncorrectAnswer1, question.IncorrectAnswer2, question.IncorrectAnswer3 };

            var buttons = new List<AnswerButton> { answerA, answerB, answerC, answerD };

            foreach (var button in buttons)
            {
                var index = random.Next(answers.Count);
                var answer = answers[index];
                button.Text = answer;
                answers.Remove(answer);
            }
        }
    }
}
