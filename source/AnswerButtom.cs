﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGUI1
{
    class AnswerButtom : Button
    {
        public bool isCorrect { get; set; } = false;
    }
}