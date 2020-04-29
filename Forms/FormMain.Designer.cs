namespace QuizGUI1
{
    partial class FormMain
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonMinimize = new QuizGUI1.CustomControls.RoundedButton();
            this.buttonClose = new QuizGUI1.CustomControls.RoundedButton();
            this.panelUC = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightGray;
            this.panelTop.Controls.Add(this.buttonMinimize);
            this.panelTop.Controls.Add(this.buttonClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 30);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BorderColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BorderThickness = 0;
            this.buttonMinimize.ButtonColor = System.Drawing.Color.LimeGreen;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(1150, 5);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonMinimize.OnHoverButtonColor = System.Drawing.Color.PaleGreen;
            this.buttonMinimize.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonMinimize.Size = new System.Drawing.Size(20, 20);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.TextColor = System.Drawing.Color.White;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BorderColor = System.Drawing.Color.Transparent;
            this.buttonClose.BorderThickness = 0;
            this.buttonClose.ButtonColor = System.Drawing.Color.OrangeRed;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(1175, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonClose.OnHoverButtonColor = System.Drawing.Color.Coral;
            this.buttonClose.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonClose.Size = new System.Drawing.Size(20, 20);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.TextColor = System.Drawing.Color.White;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelUC
            // 
            this.panelUC.BackColor = System.Drawing.Color.White;
            this.panelUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUC.Location = new System.Drawing.Point(0, 30);
            this.panelUC.Name = "panelUC";
            this.panelUC.Size = new System.Drawing.Size(1200, 770);
            this.panelUC.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panelUC);
            this.Controls.Add(this.panelTop);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private CustomControls.RoundedButton buttonClose;
        private CustomControls.RoundedButton buttonMinimize;
        private System.Windows.Forms.Panel panelUC;
    }
}

