using QuizGUI1.Database.Repositories;
using QuizGUI1.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGUI1.Database.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly QuizContext quizContext;

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
    }
}
