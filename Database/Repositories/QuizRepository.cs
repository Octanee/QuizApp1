﻿using QuizGUI1.Database.Repositories.Interfaces;
using QuizGUI1.Source.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGUI1.Database.Repositories
{
    public class QuizRepository : Repository<Quiz>, IQuizRepository
    {
        public QuizRepository(DbContext context) : base(context)
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
