namespace Rezerwacja_Hotelowa
{
    partial class Logowanie
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
            this.Zaloguj = new System.Windows.Forms.Button();
            this.Powrot_logowanie = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Label();
            this.haslo = new System.Windows.Forms.Label();
            this.text_login = new System.Windows.Forms.TextBox();
            this.text_haslo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Zaloguj
            // 
            this.Zaloguj.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zaloguj.Location = new System.Drawing.Point(255, 380);
            this.Zaloguj.Name = "Zaloguj";
            this.Zaloguj.Size = new System.Drawing.Size(175, 55);
            this.Zaloguj.TabIndex = 0;
            this.Zaloguj.Text = "Zaloguj";
            this.Zaloguj.UseVisualStyleBackColor = true;
            this.Zaloguj.Click += new System.EventHandler(this.Zaloguj_Click);
            // 
            // Powrot_logowanie
            // 
            this.Powrot_logowanie.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Powrot_logowanie.Location = new System.Drawing.Point(12, 379);
            this.Powrot_logowanie.Name = "Powrot_logowanie";
            this.Powrot_logowanie.Size = new System.Drawing.Size(175, 56);
            this.Powrot_logowanie.TabIndex = 1;
            this.Powrot_logowanie.Text = "Powrót";
            this.Powrot_logowanie.UseVisualStyleBackColor = true;
            this.Powrot_logowanie.Click += new System.EventHandler(this.Powrot_logowanie_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Enabled = false;
            this.login.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login.Location = new System.Drawing.Point(98, 119);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(76, 27);
            this.login.TabIndex = 2;
            this.login.Text = "Login:";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // haslo
            // 
            this.haslo.AutoSize = true;
            this.haslo.Enabled = false;
            this.haslo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haslo.Location = new System.Drawing.Point(98, 179);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(77, 27);
            this.haslo.TabIndex = 3;
            this.haslo.Text = "Hasło:";
            this.haslo.Click += new System.EventHandler(this.haslo_Click);
            // 
            // text_login
            // 
            this.text_login.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_login.Location = new System.Drawing.Point(201, 119);
            this.text_login.Multiline = true;
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(157, 26);
            this.text_login.TabIndex = 4;
            this.text_login.TextChanged += new System.EventHandler(this.text_login_TextChanged);
            // 
            // text_haslo
            // 
            this.text_haslo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_haslo.Location = new System.Drawing.Point(201, 179);
            this.text_haslo.Multiline = true;
            this.text_haslo.Name = "text_haslo";
            this.text_haslo.Size = new System.Drawing.Size(157, 26);
            this.text_haslo.TabIndex = 5;
            this.text_haslo.TextChanged += new System.EventHandler(this.text_haslo_TextChanged);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::Rezerwacja_Hotelowa.Properties.Resources._794891_krakowwejscie_do_hotelu_andels;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(442, 447);
            this.ControlBox = false;
            this.Controls.Add(this.text_haslo);
            this.Controls.Add(this.text_login);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Powrot_logowanie);
            this.Controls.Add(this.Zaloguj);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Zaloguj;
        private System.Windows.Forms.Button Powrot_logowanie;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label haslo;
        private System.Windows.Forms.TextBox text_login;
        private System.Windows.Forms.TextBox text_haslo;
    }
}