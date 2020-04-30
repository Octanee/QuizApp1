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
    public partial class LeaderboardUC : UserControl
    {

        #region Singleton

        private static LeaderboardUC instance = null;
        public static LeaderboardUC Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LeaderboardUC();
                }

                return instance;
            }
        }

        #endregion

        public LeaderboardUC()
        {
            InitializeComponent();
        }
    }
}
