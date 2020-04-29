namespace QuizGUI1.UserControls
{
    partial class Item_ListOfQuizzes
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
            this.labelQuizName = new System.Windows.Forms.Label();
            this.labelNumOfQuestions = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.roundedButton1 = new QuizGUI1.CustomControls.RoundedButton();
            this.panelName.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuizName
            // 
            this.labelQuizName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQuizName.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQuizName.ForeColor = System.Drawing.Color.White;
            this.labelQuizName.Location = new System.Drawing.Point(5, 5);
            this.labelQuizName.Name = "labelQuizName";
            this.labelQuizName.Size = new System.Drawing.Size(745, 45);
            this.labelQuizName.TabIndex = 1;
            this.labelQuizName.Text = "label1";
            this.labelQuizName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNumOfQuestions
            // 
            this.labelNumOfQuestions.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumOfQuestions.ForeColor = System.Drawing.Color.White;
            this.labelNumOfQuestions.Location = new System.Drawing.Point(204, 25);
            this.labelNumOfQuestions.Name = "labelNumOfQuestions";
            this.labelNumOfQuestions.Size = new System.Drawing.Size(165, 25);
            this.labelNumOfQuestions.TabIndex = 2;
            this.labelNumOfQuestions.Text = "label1";
            this.labelNumOfQuestions.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.labelQuizName);
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Margin = new System.Windows.Forms.Padding(0);
            this.panelName.Name = "panelName";
            this.panelName.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.panelName.Size = new System.Drawing.Size(750, 50);
            this.panelName.TabIndex = 3;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.labelCategory);
            this.panelInfo.Controls.Add(this.labelNumOfQuestions);
            this.panelInfo.Location = new System.Drawing.Point(0, 50);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(750, 50);
            this.panelInfo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(375, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Questions:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelCategory
            // 
            this.labelCategory.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCategory.ForeColor = System.Drawing.Color.White;
            this.labelCategory.Location = new System.Drawing.Point(471, 25);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(276, 25);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "label1";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BorderColor = System.Drawing.Color.Silver;
            this.roundedButton1.BorderThickness = 0;
            this.roundedButton1.ButtonColor = System.Drawing.Color.DarkSlateBlue;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Location = new System.Drawing.Point(800, 25);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButton1.OnHoverButtonColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundedButton1.Size = new System.Drawing.Size(150, 50);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.Text = "Start";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = true;
            // 
            // Item_ListOfQuizzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.roundedButton1);
            this.Name = "Item_ListOfQuizzes";
            this.Size = new System.Drawing.Size(960, 100);
            this.panelName.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundedButton roundedButton1;
        private System.Windows.Forms.Label labelQuizName;
        private System.Windows.Forms.Label labelNumOfQuestions;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
