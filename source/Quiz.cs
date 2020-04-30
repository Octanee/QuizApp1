using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGUI1.source
{
	public class Quiz
	{
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
