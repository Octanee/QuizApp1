namespace QuizGUI1.UserControls
{
    partial class QuestionUC
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
            this.panelImage = new System.Windows.Forms.Panel();
            this.panelQuestionText = new System.Windows.Forms.Panel();
            this.labelText = new System.Windows.Forms.Label();
            this.answerD = new QuizGUI1.AnswerButton();
            this.answerC = new QuizGUI1.AnswerButton();
            this.answerB = new QuizGUI1.AnswerButton();
            this.answerA = new QuizGUI1.AnswerButton();
            this.panelQuestionText.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Margin = new System.Windows.Forms.Padding(5);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(1200, 150);
            this.panelImage.TabIndex = 0;
            // 
            // panelQuestionText
            // 
            this.panelQuestionText.BackColor = System.Drawing.Color.Silver;
            this.panelQuestionText.Controls.Add(this.labelText);
            this.panelQuestionText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuestionText.Location = new System.Drawing.Point(0, 150);
            this.panelQuestionText.Name = "panelQuestionText";
            this.panelQuestionText.Size = new System.Drawing.Size(1200, 100);
            this.panelQuestionText.TabIndex = 1;
            // 
            // labelText
            // 
            this.labelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelText.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelText.ForeColor = System.Drawing.Color.White;
            this.labelText.Location = new System.Drawing.Point(0, 0);
            this.labelText.Margin = new System.Windows.Forms.Padding(3);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(1200, 100);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Question text";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerD
            // 
            this.answerD.BorderColor = System.Drawing.Color.Silver;
            this.answerD.BorderThickness = 0;
            this.answerD.ButtonColor = System.Drawing.Color.RoyalBlue;
            this.answerD.FlatAppearance.BorderSize = 0;
            this.answerD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerD.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerD.isCorrect = false;
            this.answerD.Location = new System.Drawing.Point(610, 420);
            this.answerD.Margin = new System.Windows.Forms.Padding(5);
            this.answerD.Name = "answerD";
            this.answerD.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.answerD.OnHoverButtonColor = System.Drawing.Color.CornflowerBlue;
            this.answerD.OnHoverTextColor = System.Drawing.Color.Gray;
            this.answerD.Size = new System.Drawing.Size(585, 155);
            this.answerD.TabIndex = 5;
            this.answerD.Text = "answerButton3";
            this.answerD.TextColor = System.Drawing.Color.White;
            this.answerD.UseVisualStyleBackColor = true;
            // 
            // answerC
            // 
            this.answerC.BorderColor = System.Drawing.Color.Silver;
            this.answerC.BorderThickness = 0;
            this.answerC.ButtonColor = System.Drawing.Color.RoyalBlue;
            this.answerC.FlatAppearance.BorderSize = 0;
            this.answerC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerC.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerC.isCorrect = false;
            this.answerC.Location = new System.Drawing.Point(5, 420);
            this.answerC.Margin = new System.Windows.Forms.Padding(5);
            this.answerC.Name = "answerC";
            this.answerC.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.answerC.OnHoverButtonColor = System.Drawing.Color.CornflowerBlue;
            this.answerC.OnHoverTextColor = System.Drawing.Color.Gray;
            this.answerC.Size = new System.Drawing.Size(585, 155);
            this.answerC.TabIndex = 4;
            this.answerC.Text = "answerButton4";
            this.answerC.TextColor = System.Drawing.Color.White;
            this.answerC.UseVisualStyleBackColor = true;
            // 
            // answerB
            // 
            this.answerB.BorderColor = System.Drawing.Color.Silver;
            this.answerB.BorderThickness = 0;
            this.answerB.ButtonColor = System.Drawing.Color.RoyalBlue;
            this.answerB.FlatAppearance.BorderSize = 0;
            this.answerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerB.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerB.isCorrect = false;
            this.answerB.Location = new System.Drawing.Point(610, 258);
            this.answerB.Margin = new System.Windows.Forms.Padding(5);
            this.answerB.Name = "answerB";
            this.answerB.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.answerB.OnHoverButtonColor = System.Drawing.Color.CornflowerBlue;
            this.answerB.OnHoverTextColor = System.Drawing.Color.Gray;
            this.answerB.Size = new System.Drawing.Size(585, 155);
            this.answerB.TabIndex = 3;
            this.answerB.Text = "answerButton2";
            this.answerB.TextColor = System.Drawing.Color.White;
            this.answerB.UseVisualStyleBackColor = true;
            // 
            // answerA
            // 
            this.answerA.BorderColor = System.Drawing.Color.Silver;
            this.answerA.BorderThickness = 0;
            this.answerA.ButtonColor = System.Drawing.Color.RoyalBlue;
            this.answerA.FlatAppearance.BorderSize = 0;
            this.answerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerA.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerA.isCorrect = false;
            this.answerA.Location = new System.Drawing.Point(5, 258);
            this.answerA.Margin = new System.Windows.Forms.Padding(5);
            this.answerA.Name = "answerA";
            this.answerA.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.answerA.OnHoverButtonColor = System.Drawing.Color.CornflowerBlue;
            this.answerA.OnHoverTextColor = System.Drawing.Color.Gray;
            this.answerA.Size = new System.Drawing.Size(585, 155);
            this.answerA.TabIndex = 2;
            this.answerA.Text = "answerButton1";
            this.answerA.TextColor = System.Drawing.Color.White;
            this.answerA.UseVisualStyleBackColor = true;
            // 
            // QuestionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.answerD);
            this.Controls.Add(this.answerC);
            this.Controls.Add(this.answerB);
            this.Controls.Add(this.answerA);
            this.Controls.Add(this.panelQuestionText);
            this.Controls.Add(this.panelImage);
            this.Name = "QuestionUC";
            this.Size = new System.Drawing.Size(1200, 580);
            this.panelQuestionText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panelQuestionText;
        private AnswerButton answerA;
        private AnswerButton answerB;
        private AnswerButton answerD;
        private AnswerButton answerC;
        private System.Windows.Forms.Label labelText;
    }
}
