namespace QuizGUI1
{
    partial class FormQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelImage = new System.Windows.Forms.Panel();
            this.labelCount = new System.Windows.Forms.Label();
            this.panelText = new System.Windows.Forms.Panel();
            this.labelPytanie = new System.Windows.Forms.Label();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.timerPytanie = new System.Windows.Forms.Timer(this.components);
            this.timerAnswer = new System.Windows.Forms.Timer(this.components);
            this.buttonEndQuiz = new System.Windows.Forms.Button();
            this.buttonD = new QuizGUI1.AnswerButtom();
            this.buttonC = new QuizGUI1.AnswerButtom();
            this.buttonB = new QuizGUI1.AnswerButtom();
            this.buttonA = new QuizGUI1.AnswerButtom();
            this.panelImage.SuspendLayout();
            this.panelText.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelImage.Controls.Add(this.labelCount);
            this.panelImage.Location = new System.Drawing.Point(12, 35);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(752, 153);
            this.panelImage.TabIndex = 0;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCount.Location = new System.Drawing.Point(0, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(44, 19);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "1/10";
            // 
            // panelText
            // 
            this.panelText.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelText.Controls.Add(this.labelPytanie);
            this.panelText.Location = new System.Drawing.Point(12, 194);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(752, 92);
            this.panelText.TabIndex = 1;
            // 
            // labelPytanie
            // 
            this.labelPytanie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPytanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPytanie.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPytanie.Location = new System.Drawing.Point(0, 0);
            this.labelPytanie.Name = "labelPytanie";
            this.labelPytanie.Padding = new System.Windows.Forms.Padding(10);
            this.labelPytanie.Size = new System.Drawing.Size(752, 92);
            this.labelPytanie.TabIndex = 0;
            this.labelPytanie.Text = "Text pytanie";
            this.labelPytanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTimer
            // 
            this.panelTimer.BackColor = System.Drawing.Color.Green;
            this.panelTimer.Location = new System.Drawing.Point(12, 434);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(752, 11);
            this.panelTimer.TabIndex = 6;
            // 
            // timerPytanie
            // 
            this.timerPytanie.Interval = 10;
            this.timerPytanie.Tick += new System.EventHandler(this.timerPytanie_Tick);
            // 
            // timerAnswer
            // 
            this.timerAnswer.Tick += new System.EventHandler(this.timerAnswer_Tick);
            // 
            // buttonEndQuiz
            // 
            this.buttonEndQuiz.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEndQuiz.FlatAppearance.BorderSize = 0;
            this.buttonEndQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEndQuiz.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEndQuiz.Location = new System.Drawing.Point(689, 6);
            this.buttonEndQuiz.Name = "buttonEndQuiz";
            this.buttonEndQuiz.Size = new System.Drawing.Size(75, 23);
            this.buttonEndQuiz.TabIndex = 13;
            this.buttonEndQuiz.Text = "Zakończ";
            this.buttonEndQuiz.UseVisualStyleBackColor = false;
            this.buttonEndQuiz.Click += new System.EventHandler(this.buttonEndQuiz_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonD.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonD.FlatAppearance.BorderSize = 0;
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonD.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonD.isCorrect = false;
            this.buttonD.Location = new System.Drawing.Point(391, 363);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(373, 65);
            this.buttonD.TabIndex = 12;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonC.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonC.FlatAppearance.BorderSize = 0;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonC.isCorrect = false;
            this.buttonC.Location = new System.Drawing.Point(12, 363);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(373, 65);
            this.buttonC.TabIndex = 11;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonB.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonB.FlatAppearance.BorderSize = 0;
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonB.isCorrect = false;
            this.buttonB.Location = new System.Drawing.Point(391, 292);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(373, 65);
            this.buttonB.TabIndex = 10;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonA.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonA.FlatAppearance.BorderSize = 0;
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonA.isCorrect = false;
            this.buttonA.Location = new System.Drawing.Point(12, 292);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(373, 65);
            this.buttonA.TabIndex = 9;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // FormPytanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(776, 457);
            this.Controls.Add(this.buttonEndQuiz);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.panelTimer);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.panelImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPytanie";
            this.Text = "FormPytanie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPytanie_FormClosed);
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            this.panelText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Label labelPytanie;
        private System.Windows.Forms.Timer timerPytanie;
        private System.Windows.Forms.Timer timerAnswer;
        private AnswerButtom buttonA;
        private AnswerButtom buttonB;
        private AnswerButtom buttonD;
        private AnswerButtom buttonC;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonEndQuiz;
    }
}