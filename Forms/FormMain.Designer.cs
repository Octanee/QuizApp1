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
            this.panelParent = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMinimize = new QuizGUI1.CustomControls.RoundedButton();
            this.buttonClose = new QuizGUI1.CustomControls.RoundedButton();
            this.menuButton1 = new QuizGUI1.CustomControls.MenuButton();
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
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
            // panelParent
            // 
            this.panelParent.BackColor = System.Drawing.Color.White;
            this.panelParent.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelParent.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelParent.Location = new System.Drawing.Point(200, 30);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(1000, 770);
            this.panelParent.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(57)))), ((int)(((byte)(84)))));
            this.panelMenu.Controls.Add(this.menuButton1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 770);
            this.panelMenu.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(214)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // menuButton1
            // 
            this.menuButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButton1.FlatAppearance.BorderSize = 0;
            this.menuButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton1.IsChosen = false;
            this.menuButton1.Location = new System.Drawing.Point(0, 75);
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.SelectedBarColor = System.Drawing.Color.Green;
            this.menuButton1.SelectedBarSize = 3;
            this.menuButton1.Size = new System.Drawing.Size(200, 50);
            this.menuButton1.TabIndex = 1;
            this.menuButton1.Text = "Dashboard\r\n";
            this.menuButton1.UseVisualStyleBackColor = true;
            this.menuButton1.Click += new System.EventHandler(this.menuButton1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelParent);
            this.Controls.Add(this.panelTop);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelParent;
        private CustomControls.RoundedButton buttonClose;
        private System.Windows.Forms.Panel panelMenu;
        private CustomControls.RoundedButton buttonMinimize;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private CustomControls.MenuButton menuButton1;
    }
}

