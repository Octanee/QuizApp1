using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGUI1.UserControls
{
    public partial class QuestionUC : UserControl
    {
        public Question question;


        public QuestionUC(Question question)
        {
            this.question = question;
            InitializeComponent();
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            label1.Text = question.Text;
        }
    }
}
