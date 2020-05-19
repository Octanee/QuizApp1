using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGUI1.Source.Models
{
    public class Result
    {

		private Quiz quiz;

		public Quiz Quiz
		{
			get { return quiz; }
			set { quiz = value; }
		}

		private User user;

		public User User
		{
			get { return user; }
			set { user = value; }
		}

		private List<Answer> answers;

		public List<Answer> Answers
		{
			get { return answers; }
			set { answers = value; }
		}
	}
}
