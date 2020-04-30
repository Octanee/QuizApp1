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
    public partial class DashboardUC : UserControl
    {

        #region Singleton

        private static DashboardUC instance = null;
        public static DashboardUC Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DashboardUC();
                }

                return instance;
            }
        }

        #endregion

        public DashboardUC()
        {
            InitializeComponent();
        }
    }
}
