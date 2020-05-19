using QuizGUI1.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGUI1.Database.Repositories
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(DbContext context) : base(context)
        {
        }
        public QuizContext QuizContext
        {
            get
            {
                return Context as QuizContext;
            }
        }
    }
}
