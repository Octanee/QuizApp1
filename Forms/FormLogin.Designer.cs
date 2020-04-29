namespace QuizGUI1.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ellipseButton2 = new QuizGUI1.CustomControls.EllipseButton();
            this.ellipseButton1 = new QuizGUI1.CustomControls.EllipseButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ellipseButton3 = new QuizGUI1.CustomControls.EllipseButton();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTop.Controls.Add(this.ellipseButton3);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(300, 150);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign In";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(53, 60);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(238, 29);
            this.textBoxLogin.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(15, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 3);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(15, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 3);
            this.panel3.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(53, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(238, 29);
            this.textBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ellipseButton2);
            this.panel1.Controls.Add(this.ellipseButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 350);
            this.panel1.TabIndex = 1;
            // 
            // ellipseButton2
            // 
            this.ellipseButton2.BorderColor = System.Drawing.Color.Transparent;
            this.ellipseButton2.BorderThickness = 0;
            this.ellipseButton2.ButtonColor = System.Drawing.Color.RoyalBlue;
            this.ellipseButton2.FlatAppearance.BorderSize = 0;
            this.ellipseButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseButton2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ellipseButton2.Location = new System.Drawing.Point(15, 284);
            this.ellipseButton2.Name = "ellipseButton2";
            this.ellipseButton2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.ellipseButton2.OnHoverButtonColor = System.Drawing.Color.CornflowerBlue;
            this.ellipseButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.ellipseButton2.Size = new System.Drawing.Size(273, 40);
            this.ellipseButton2.TabIndex = 10;
            this.ellipseButton2.Text = "Registration";
            this.ellipseButton2.TextColor = System.Drawing.Color.White;
            this.ellipseButton2.UseVisualStyleBackColor = true;
            // 
            // ellipseButton1
            // 
            this.ellipseButton1.BorderColor = System.Drawing.Color.Transparent;
            this.ellipseButton1.BorderThickness = 0;
            this.ellipseButton1.ButtonColor = System.Drawing.Color.RoyalBlue;
            this.ellipseButton1.FlatAppearance.BorderSize = 0;
            this.ellipseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseButton1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ellipseButton1.Location = new System.Drawing.Point(15, 226);
            this.ellipseButton1.Name = "ellipseButton1";
            this.ellipseButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.ellipseButton1.OnHoverButtonColor = System.Drawing.Color.CornflowerBlue;
            this.ellipseButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.ellipseButton1.Size = new System.Drawing.Size(273, 40);
            this.ellipseButton1.TabIndex = 9;
            this.ellipseButton1.Text = "Log in";
            this.ellipseButton1.TextColor = System.Drawing.Color.White;
            this.ellipseButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ellipseButton3
            // 
            this.ellipseButton3.BorderColor = System.Drawing.Color.Transparent;
            this.ellipseButton3.BorderThickness = 0;
            this.ellipseButton3.ButtonColor = System.Drawing.Color.Transparent;
            this.ellipseButton3.FlatAppearance.BorderSize = 0;
            this.ellipseButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseButton3.Location = new System.Drawing.Point(277, 3);
            this.ellipseButton3.Name = "ellipseButton3";
            this.ellipseButton3.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.ellipseButton3.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.ellipseButton3.OnHoverTextColor = System.Drawing.Color.Black;
            this.ellipseButton3.Size = new System.Drawing.Size(20, 20);
            this.ellipseButton3.TabIndex = 2;
            this.ellipseButton3.Text = "X";
            this.ellipseButton3.TextColor = System.Drawing.Color.Black;
            this.ellipseButton3.UseVisualStyleBackColor = true;
            this.ellipseButton3.Click += new System.EventHandler(this.ellipseButton3_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz - Logowanie";
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.EllipseButton ellipseButton1;
        private CustomControls.EllipseButton ellipseButton2;
        private CustomControls.EllipseButton ellipseButton3;
    }
}