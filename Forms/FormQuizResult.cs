﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGUI1
{
    public partial class FormQuizResult : Form
    {
        public FormQuizResult()
        {
            InitializeComponent();
            Console.WriteLine("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain.Instance.StartQuiz(new source.Quiz());
        }
    }
}
