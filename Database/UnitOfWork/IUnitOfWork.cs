using QuizGUI1.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGUI1.Database.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAnswerRepository Answers { get; }
        IQuestionRepository Questions { get; }
        IQuizRepository Quizzes { get; }
        IResultRepository Results { get; }
        IUserRepository Users { get; }

        int Save();

    }
}
