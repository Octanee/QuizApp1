using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizGUI1.source;
using QuizGUI1.CustomControls;

namespace QuizGUI1.UserControls
{
    public partial class QuizUC : UserControl
    {
        #region Singleton

        private static QuizUC instance;

        public static QuizUC Instance
        {
            get {
                if (instance == null)
                {
                    instance = new QuizUC();
                }
                return instance; 
            }
        }

        #endregion

        #region Properties
        private Quiz quiz;

        public Quiz Quiz
        {
            get { return quiz; }
            set { quiz = value; }
        }

        #endregion

        public QuizUC()
        {
            InitializeComponent();
        }
    }
}
