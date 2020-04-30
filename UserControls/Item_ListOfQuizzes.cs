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

namespace QuizGUI1.UserControls
{
    public partial class Item_ListOfQuizzes : UserControl
    {

        private Quiz quiz;

        public Item_ListOfQuizzes(Quiz quiz)
        {
            InitializeComponent();

            this.quiz = quiz;

            SetQuizInfo();
        }

        private void SetQuizInfo()
        {
            labelQuizName.Text = quiz.Name;
            labelNumOfQuestions.Text = quiz.Questions.Count.ToString();
            labelCategory.Text = quiz.Category.ToString();
        }

        private void buttonStartQuiz_Click(object sender, EventArgs e)
        {
            FormMain.Instance.StartQuiz(quiz);
        }
    }
}
