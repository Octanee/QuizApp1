using QuizGUI1.Source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGUI1.Forms
{
    public partial class FormLogin : Form
    {
        #region Singleton
        private static FormLogin instance = null;
        public static FormLogin Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormLogin();
                }

                return instance;
            }
        }
        #endregion

        private List<User> users = new List<User>();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int leftRect, int topRect, int rightRect, int bottomRect, int widthEllipse, int heightEllipse);

        public FormLogin()
        {
            instance = this;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            User admin = new User("admin", "admin");
            users.Add(admin);
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

        private void ellipseButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (userExists(login, password))
            {
                FormMain main = FormMain.Instance;
                main.Show();
                this.Visible = false;
            }

            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            panel2.BackColor = Color.Red;
            panel3.BackColor = Color.Red;
        }

        private bool userExists(string login, string password)
        {
            foreach (var user in users)
            {
                if (user.Login.Equals(login) && user.Password.Equals(password))
                {
                    return true;
                }
            }
            return false;
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }
    }
}
