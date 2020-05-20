using QuizGUI1.Database.Repositories;
using QuizGUI1.Database.Repositories.Interfaces;
using QuizGUI1.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGUI1.Database.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly QuizContext quizContext;

        public UnitOfWork(QuizContext context)
        {
            this.quizContext = context;
        }

        private IAnswerRepository answers;
        public IAnswerRepository Answers
        {
            get
            {
                if (answers == null) answers = new AnswerRepository(quizContext);
                return answers;
            }
        }

        private IQuestionRepository questions;
        public IQuestionRepository Questions
        {
            get
            {
                if (questions == null) questions = new QuestionRepository(quizContext);
                return questions;
            }
        }

        private IQuizRepository quizzes;
        public IQuizRepository Quizzes
        {
            get
            {
                if (quizzes == null) quizzes = new QuizRepository(quizContext);
                return quizzes;
            }
        }

        private IResultRepository results;
        public IResultRepository Results
        {
            get
            {
                if (results == null) results = new ResultRepository(quizContext);
                return results;
            }
        }

        private IUserRepository users;
        public IUserRepository Users
        {
            get
            {
                if (users == null) users = new UserRepository(quizContext);
                return users;
            }
        }

        public int Save()
        {
            return quizContext.SaveChanges();
        }

        public void Dispose()
        {
            quizContext.Dispose();
        }

        public void Clear()
        {
            try
            {
                Answers.RemoveRange(Answers.GetAll().ToList());
                Questions.RemoveRange(Questions.GetAll().ToList());
                Quizzes.RemoveRange(Quizzes.GetAll().ToList());
                Results.RemoveRange(Results.GetAll().ToList());
                Users.RemoveRange(Users.GetAll().ToList());
            }catch(Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace, "Clear UnitOfWork Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
