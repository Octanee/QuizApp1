using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGUI1
{
    public class Quiz
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}


		private List<Question> questions = new List<Question>();

		public List<Question> Questions 
		{
			get { return questions; }
			set { questions = value; }
		}

		public void AddQuestion(Question question)
		{
			questions.Add(question);
		}
	}
}
