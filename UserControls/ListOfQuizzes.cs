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
using QuizGUI1.Database.UnitOfWork;

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
            using (var unitOfWork = new UnitOfWork(new Database.QuizContext()))
            {
                Console.WriteLine("Using unitOfWork");
                quizzes = unitOfWork.Quizzes.GetAll().ToList();
                if (quizzes.Count == 0)
                {
                    Console.WriteLine("Count == 0");
                    quizzes = GenerateQuizzes(10, unitOfWork);
                }
                var temp = unitOfWork.Questions.GetAll().ToList();
                foreach (var item in temp)
                {
                    Console.WriteLine("QUESTION - ID: {0}, Text: {1}", item.QuestionID, item.Text);
                }

               /* foreach (var quiz in quizzes)
                {
                    Console.WriteLine("QUIZ - ID: {0}, Name: {1}, Category: {2}, QuestionsCount: {3}", quiz.QuizID, quiz.Name, quiz.Category,quiz.Questions.Count);
                    foreach (var question in quiz.Questions)
                    {
                        Console.WriteLine("QUESTION - ID: {0}, Text: {1}");
                    }
                    Console.WriteLine("QUIZ END");
                }*/
                Console.WriteLine("UnitOfWork save");
                unitOfWork.Save();
            }
            AddQuizItem();
        }

        private void AddQuizItem()
        {
            foreach (var quiz in quizzes)
            {
                Item_ListOfQuizzes item = new Item_ListOfQuizzes(quiz);
                flpListOfQuizzes.Controls.Add(item);
            }
        }

        #region Generate
        private List<Quiz> GenerateQuizzes(int num, UnitOfWork unitOfWork)
        {
            var temp = new List<Quiz>();

            var random = new Random();

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Generete new Quiz");

                var quiz = new Quiz();
                quiz.Name = "Quiz" + i;
                quiz.Questions = GenerateQuestions(random.Next(5, 50), unitOfWork);
                quiz.Category = (QuizCategory)random.Next(Enum.GetNames(typeof(QuizCategory)).Length);
                quiz.Time = quiz.Questions.Count * quiz.QuestionTime;
                temp.Add(quiz);
                unitOfWork.Quizzes.Add(quiz);
            }

            return temp;
        }

        private List<Question> GenerateQuestions(int num, UnitOfWork unitOfWork)
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
                unitOfWork.Questions.Add(question);
            }

            return temp;
        }
        #endregion
    }
}
