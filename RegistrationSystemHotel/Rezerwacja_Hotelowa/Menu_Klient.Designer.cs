namespace Rezerwacja_Hotelowa
{
    partial class Menu_Klient
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_lbl_k = new System.Windows.Forms.Label();
            this.Zmiana_rezerwacji = new System.Windows.Forms.Button();
            this.Rezerwacja = new System.Windows.Forms.Button();
            this.Usuniecie_rezerwaci = new System.Windows.Forms.Button();
            this.Podglad = new System.Windows.Forms.Button();
            this.Profil = new System.Windows.Forms.Button();
            this.Wyloguj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_lbl_k
            // 
            this.time_lbl_k.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time_lbl_k.AutoSize = true;
            this.time_lbl_k.Location = new System.Drawing.Point(680, 9);
            this.time_lbl_k.Name = "time_lbl_k";
            this.time_lbl_k.Size = new System.Drawing.Size(42, 13);
            this.time_lbl_k.TabIndex = 0;
            this.time_lbl_k.Text = "Time_k";
            this.time_lbl_k.Click += new System.EventHandler(this.time_lbl_k_Click);
            // 
            // Zmiana_rezerwacji
            // 
            this.Zmiana_rezerwacji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Zmiana_rezerwacji.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zmiana_rezerwacji.Location = new System.Drawing.Point(638, 376);
            this.Zmiana_rezerwacji.Name = "Zmiana_rezerwacji";
            this.Zmiana_rezerwacji.Size = new System.Drawing.Size(175, 77);
            this.Zmiana_rezerwacji.TabIndex = 1;
            this.Zmiana_rezerwacji.Text = "Zmiana rezerwacji";
            this.Zmiana_rezerwacji.UseVisualStyleBackColor = true;
            this.Zmiana_rezerwacji.Click += new System.EventHandler(this.Zmiana_rezerwacji_Click);
            // 
            // Rezerwacja
            // 
            this.Rezerwacja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Rezerwacja.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rezerwacja.Location = new System.Drawing.Point(638, 254);
            this.Rezerwacja.Name = "Rezerwacja";
            this.Rezerwacja.Size = new System.Drawing.Size(175, 55);
            this.Rezerwacja.TabIndex = 2;
            this.Rezerwacja.Text = "Rezerwacja";
            this.Rezerwacja.UseVisualStyleBackColor = true;
            this.Rezerwacja.Click += new System.EventHandler(this.Rezerwacja_Click);
            // 
            // Usuniecie_rezerwaci
            // 
            this.Usuniecie_rezerwaci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Usuniecie_rezerwaci.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Usuniecie_rezerwaci.Location = new System.Drawing.Point(638, 459);
            this.Usuniecie_rezerwaci.Name = "Usuniecie_rezerwaci";
            this.Usuniecie_rezerwaci.Size = new System.Drawing.Size(175, 71);
            this.Usuniecie_rezerwaci.TabIndex = 3;
            this.Usuniecie_rezerwaci.Text = "Usunięcie rezerwaci";
            this.Usuniecie_rezerwaci.UseVisualStyleBackColor = true;
            this.Usuniecie_rezerwaci.Click += new System.EventHandler(this.Usuniecie_rezerwaci_Click);
            // 
            // Podglad
            // 
            this.Podglad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Podglad.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Podglad.Location = new System.Drawing.Point(638, 315);
            this.Podglad.Name = "Podglad";
            this.Podglad.Size = new System.Drawing.Size(175, 55);
            this.Podglad.TabIndex = 4;
            this.Podglad.Text = "Podgląd";
            this.Podglad.UseVisualStyleBackColor = true;
            this.Podglad.Click += new System.EventHandler(this.Podglad_Click);
            // 
            // Profil
            // 
            this.Profil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Profil.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Profil.Location = new System.Drawing.Point(638, 193);
            this.Profil.Name = "Profil";
            this.Profil.Size = new System.Drawing.Size(175, 55);
            this.Profil.TabIndex = 5;
            this.Profil.Text = "Profil";
            this.Profil.UseVisualStyleBackColor = true;
            this.Profil.Click += new System.EventHandler(this.Profil_Click);
            // 
            // Wyloguj
            // 
            this.Wyloguj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Wyloguj.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyloguj.Location = new System.Drawing.Point(638, 536);
            this.Wyloguj.Name = "Wyloguj";
            this.Wyloguj.Size = new System.Drawing.Size(175, 55);
            this.Wyloguj.TabIndex = 6;
            this.Wyloguj.Text = "Wyloguj";
            this.Wyloguj.UseVisualStyleBackColor = true;
            this.Wyloguj.Click += new System.EventHandler(this.Wyloguj_Click);
            // 
            // Menu_Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rezerwacja_Hotelowa.Properties.Resources.menu_klienta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 603);
            this.ControlBox = false;
            this.Controls.Add(this.Wyloguj);
            this.Controls.Add(this.Profil);
            this.Controls.Add(this.Podglad);
            this.Controls.Add(this.Usuniecie_rezerwaci);
            this.Controls.Add(this.Rezerwacja);
            this.Controls.Add(this.Zmiana_rezerwacji);
            this.Controls.Add(this.time_lbl_k);
            this.DoubleBuffered = true;
            this.Name = "Menu_Klient";
            this.Text = "Menu_Klient";
            this.Load += new System.EventHandler(this.Menu_Klient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time_lbl_k;
        private System.Windows.Forms.Button Zmiana_rezerwacji;
        private System.Windows.Forms.Button Rezerwacja;
        private System.Windows.Forms.Button Usuniecie_rezerwaci;
        private System.Windows.Forms.Button Podglad;
        private System.Windows.Forms.Button Profil;
        private System.Windows.Forms.Button Wyloguj;
    }
}