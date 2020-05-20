using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGUI1.Source.Models
{
	public class Answer
	{
		[Key]
		public int AnswerID { get; set; }

		private Question question;

		public Question Question
		{
			get { return question; }
			set { question = value; }
		}

		private string userAnswer;

		public string UserAnswer
		{
			get { return userAnswer; }
			set { userAnswer = value; }
		}
	}
}
