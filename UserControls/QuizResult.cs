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
    public partial class QuizResult : UserControl
    {
        #region Singleton
        private static QuizResult instance = null;
        public static QuizResult Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuizResult();
                }

                return instance;
            }
        }
        #endregion

        public QuizResult()
        {
            InitializeComponent();
        }
    }
}
