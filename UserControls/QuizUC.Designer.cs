namespace QuizGUI1.UserControls
{
    partial class QuizUC
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
            this.components = new System.ComponentModel.Container();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timerQuizTime = new System.Windows.Forms.Timer(this.components);
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.panelQuestionsButtons = new System.Windows.Forms.Panel();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.flpQuestionButoons = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            this.panelQuestionsButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTimer
            // 
            this.panelTimer.BackColor = System.Drawing.Color.Green;
            this.panelTimer.Location = new System.Drawing.Point(5, 750);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(1190, 15);
            this.panelTimer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 65);
            this.panel1.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(1000, 65);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1000, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 65);
            this.panel4.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "End Quiz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonEndQuiz_Click);
            // 
            // timerQuizTime
            // 
            this.timerQuizTime.Tick += new System.EventHandler(this.timerQuizTime_Tick);
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.flp);
            this.panelQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuestion.Location = new System.Drawing.Point(0, 65);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(1200, 580);
            this.panelQuestion.TabIndex = 3;
            // 
            // panelQuestionsButtons
            // 
            this.panelQuestionsButtons.Controls.Add(this.flpQuestionButoons);
            this.panelQuestionsButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuestionsButtons.Location = new System.Drawing.Point(0, 645);
            this.panelQuestionsButtons.Name = "panelQuestionsButtons";
            this.panelQuestionsButtons.Size = new System.Drawing.Size(1200, 100);
            this.panelQuestionsButtons.TabIndex = 4;
            // 
            // flp
            // 
            this.flp.AutoScroll = true;
            this.flp.Location = new System.Drawing.Point(500, 580);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(200, 100);
            this.flp.TabIndex = 0;
            // 
            // flpQuestionButoons
            // 
            this.flpQuestionButoons.AutoSize = true;
            this.flpQuestionButoons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpQuestionButoons.Location = new System.Drawing.Point(0, 0);
            this.flpQuestionButoons.Name = "flpQuestionButoons";
            this.flpQuestionButoons.Size = new System.Drawing.Size(1200, 100);
            this.flpQuestionButoons.TabIndex = 0;
            // 
            // QuizUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelQuestionsButtons);
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTimer);
            this.Name = "QuizUC";
            this.Size = new System.Drawing.Size(1200, 770);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestionsButtons.ResumeLayout(false);
            this.panelQuestionsButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerQuizTime;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Panel panelQuestionsButtons;
        private System.Windows.Forms.FlowLayoutPanel flpQuestionButoons;
    }
}
