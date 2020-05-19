using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGUI1.Source.Models
{
    public class Question
	{
		[Key]
		public int QuestionID { get; set; }

		private string text;

		public string Text
		{
			get { return text; }
			set { text = value; }
		}

		private string correctAnswer;

		public string CorrectAnswer
		{
			get { return correctAnswer; }
			set { correctAnswer = value; }
		}

		private string incorrectAnswer1;

		public string IncorrectAnswer1
		{
			get { return incorrectAnswer1; }
			set { incorrectAnswer1 = value; }
		}
		private string incorrectAnswer2;

		public string IncorrectAnswer2
		{
			get { return incorrectAnswer2; }
			set { incorrectAnswer2 = value; }
		}
		private string incorrectAnswer3;

		public string IncorrectAnswer3
		{
			get { return incorrectAnswer3; }
			set { incorrectAnswer3 = value; }
		}
	}
}
