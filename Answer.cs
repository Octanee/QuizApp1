using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGUI1
{
    class Answer: Question
    {
		private Question question;

		public Question Question
		{
			get { return question; }
			set { question = value; }
		}

		private bool isCorrect = false;

		public bool IsCorrect
		{
			get { return isCorrect = false; }
			set { isCorrect = value; }
		}

		public Answer(Question question)
		{
			this.question = question;
		}
	}
}