namespace QuizGUI1.UserControls
{
    partial class MenuUC
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonListOfQuizzes = new System.Windows.Forms.Button();
            this.buttonLeaderboard = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelUC = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 100);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(200, 75);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonListOfQuizzes
            // 
            this.buttonListOfQuizzes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListOfQuizzes.FlatAppearance.BorderSize = 0;
            this.buttonListOfQuizzes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListOfQuizzes.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonListOfQuizzes.ForeColor = System.Drawing.Color.White;
            this.buttonListOfQuizzes.Location = new System.Drawing.Point(0, 175);
            this.buttonListOfQuizzes.Name = "buttonListOfQuizzes";
            this.buttonListOfQuizzes.Size = new System.Drawing.Size(200, 75);
            this.buttonListOfQuizzes.TabIndex = 2;
            this.buttonListOfQuizzes.Text = "List of Quizzes";
            this.buttonListOfQuizzes.UseVisualStyleBackColor = true;
            this.buttonListOfQuizzes.Click += new System.EventHandler(this.buttonListOfQuizzes_Click);
            // 
            // buttonLeaderboard
            // 
            this.buttonLeaderboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLeaderboard.FlatAppearance.BorderSize = 0;
            this.buttonLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeaderboard.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLeaderboard.ForeColor = System.Drawing.Color.White;
            this.buttonLeaderboard.Location = new System.Drawing.Point(0, 250);
            this.buttonLeaderboard.Name = "buttonLeaderboard";
            this.buttonLeaderboard.Size = new System.Drawing.Size(200, 75);
            this.buttonLeaderboard.TabIndex = 3;
            this.buttonLeaderboard.Text = "Leaderboard";
            this.buttonLeaderboard.UseVisualStyleBackColor = true;
            this.buttonLeaderboard.Click += new System.EventHandler(this.buttonLeaderboard_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.sidePanel.Location = new System.Drawing.Point(0, 100);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(7, 75);
            this.sidePanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.buttonLeaderboard);
            this.panel1.Controls.Add(this.buttonListOfQuizzes);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 770);
            this.panel1.TabIndex = 0;
            // 
            // panelUC
            // 
            this.panelUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUC.Location = new System.Drawing.Point(200, 0);
            this.panelUC.Name = "panelUC";
            this.panelUC.Size = new System.Drawing.Size(1000, 770);
            this.panelUC.TabIndex = 1;
            // 
            // MenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUC);
            this.Controls.Add(this.panel1);
            this.Name = "MenuUC";
            this.Size = new System.Drawing.Size(1200, 770);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonListOfQuizzes;
        private System.Windows.Forms.Button buttonLeaderboard;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelUC;
    }
}
