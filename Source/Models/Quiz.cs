using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGUI1.Source.Models
{
	public class Quiz
	{
		[Key]
		public int QuizID { get; set; }

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private QuizCategory category;

		public QuizCategory Category
		{
			get { return category; }
			set { category = value; }
		}

		private List<Question> questions = new List<Question>();

		public List<Question> Questions
		{
			get { return questions; }
			set { questions = value; }
		}

		private int time;

		public int Time
		{
			get { return time; }
			set { time = value; }
		}


		public void AddQuestion(Question question)
		{
			questions.Add(question);
		}

		private int questionTime = 15;

		public int QuestionTime
		{
			get { return questionTime; }
			set { questionTime  = value; }
		}

	}

	public enum QuizCategory
	{
		Math,
		History,
		Art,
		Geography,
		Music,
		Sport,
		Science
	}
}
