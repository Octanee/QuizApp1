namespace QuizGUI1.UserControls
{
    partial class ListOfQuizzes
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
            this.flpListOfQuizzes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpListOfQuizzes
            // 
            this.flpListOfQuizzes.AutoScroll = true;
            this.flpListOfQuizzes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListOfQuizzes.Location = new System.Drawing.Point(0, 0);
            this.flpListOfQuizzes.Margin = new System.Windows.Forms.Padding(0);
            this.flpListOfQuizzes.Name = "flpListOfQuizzes";
            this.flpListOfQuizzes.Padding = new System.Windows.Forms.Padding(10);
            this.flpListOfQuizzes.Size = new System.Drawing.Size(1000, 770);
            this.flpListOfQuizzes.TabIndex = 0;
            // 
            // ListOfQuizzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpListOfQuizzes);
            this.Name = "ListOfQuizzes";
            this.Size = new System.Drawing.Size(1000, 770);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpListOfQuizzes;
    }
}
