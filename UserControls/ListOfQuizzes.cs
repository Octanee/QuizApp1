using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizGUI1.Source.Models;

namespace QuizGUI1.UserControls
{
    public partial class ListOfQuizzes : UserControl
    {
        #region Singleton

        private static ListOfQuizzes instance = null;
        public static ListOfQuizzes Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListOfQuizzes();
                }

                return instance;
            }
        }

        #endregion

        private List<Quiz> quizzes;

        public List<Quiz> Quizzes
        {
            get { return quizzes; }
            set { quizzes = value; }
        }

        public ListOfQuizzes()
        {
            InitializeComponent();
            quizzes = GenerateQuiz(10);
            AddQuizButton();
        }

        private void AddQuizButton()
        {
            foreach (var quiz in quizzes)
            {
                Item_ListOfQuizzes item = new Item_ListOfQuizzes(quiz);
                flpListOfQuizzes.Controls.Add(item);
            }
        }

        #region Generate
        private List<Quiz> GenerateQuiz(int num)
        {
            var temp = new List<Quiz>();

            var random = new Random();

            for (int i = 0; i < num; i++)
            {
                var quiz = new Quiz();
                quiz.Name = "Quiz" + i;
                quiz.Questions = GenerateQuestions(random.Next(5, 50));
                quiz.Category = (QuizCategory) random.Next(Enum.GetNames(typeof(QuizCategory)).Length);
                quiz.Time = quiz.Questions.Count * quiz.QuestionTime;
                temp.Add(quiz);
            }

            return temp;
        }

        private List<Question> GenerateQuestions(int num)
        {
            var temp = new List<Question>();

            for (int i = 0; i < num; i++)
            {
                var question = new Question();
                question.Text = "Question" + i;
                question.CorrectAnswer = "Correct Answer";
                question.IncorrectAnswer1 = "Incorrect Answer 1";
                question.IncorrectAnswer2 = "Incorrect Answer 2";
                question.IncorrectAnswer3 = "Incorrect Answer 3";

                temp.Add(question);
            }

            return temp;
        }
        #endregion
    }
}
