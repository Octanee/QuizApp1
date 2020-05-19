using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGUI1.Source.Models
{
    public class Result
    {
		[Key]
		public int ResultID { get; set; }

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
