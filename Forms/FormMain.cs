﻿using QuizGUI1.source;
using System;
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
    public partial class FormMain : Form
    {

        #region Singleton

        private static FormMain instance = null;
        public static FormMain Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormMain();
                }
                return instance;
            }
        }

        #endregion

        private Quiz quiz;

        public FormMain()
        {

            InitializeComponent();

            quiz = PopulateList(10);

            SummaryQuiz(1);
        }

        private Quiz PopulateList(int size)
        {
            var temp = new Quiz();
            for (int i = 0; i < size; i++)
            {
                Question question = new Question();
                question.Text = "Tekst pytania " + i;
                question.PoprawnaOdpowiedz = "Poprawna odwowiedz";
                question.BlednaOdpowiedz1 = "Bledna odpowiedz 1";
                question.BlednaOdpowiedz2 = "Bledna odpowiedz 2";
                question.BlednaOdpowiedz3 = "Bledna odpowiedz 3";

                temp.AddQuestion(question);
            }

            return temp;
        }

        private Form activeForm = null;

        private void SetForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            activeForm = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            panelParent.Controls.Add(form);
            activeForm.Show();
            activeForm.BringToFront();
        }

        public void SummaryQuiz(int points)
        {
            SetForm(new FormQuizResult());
        }
        
        public void StartQuiz(Quiz newQuiz)
        {
            SetForm(new FormQuiz(newQuiz));
        }


        #region MouseMovement 

        private bool dragging;
        private Point mouse;

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            mouse = e.Location;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - mouse.X, p.Y - mouse.Y);
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        #region Przyciski
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
