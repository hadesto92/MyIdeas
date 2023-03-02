namespace Rezerwacja_Hotelowa
{
    partial class Menu_Administrator
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
            this.Wyloguj = new System.Windows.Forms.Button();
            this.Podgląd = new System.Windows.Forms.Button();
            this.Usuń_klienta = new System.Windows.Forms.Button();
            this.Usuń_rezerwacje = new System.Windows.Forms.Button();
            this.Zmiana_rezerwacji = new System.Windows.Forms.Button();
            this.time_lbl_a = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Wyloguj
            // 
            this.Wyloguj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Wyloguj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Wyloguj.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyloguj.Location = new System.Drawing.Point(621, 460);
            this.Wyloguj.Name = "Wyloguj";
            this.Wyloguj.Size = new System.Drawing.Size(175, 55);
            this.Wyloguj.TabIndex = 0;
            this.Wyloguj.Text = "Wyloguj";
            this.Wyloguj.UseVisualStyleBackColor = true;
            this.Wyloguj.Click += new System.EventHandler(this.Wyloguj_Click);
            // 
            // Podgląd
            // 
            this.Podgląd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Podgląd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Podgląd.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Podgląd.Location = new System.Drawing.Point(621, 181);
            this.Podgląd.Name = "Podgląd";
            this.Podgląd.Size = new System.Drawing.Size(175, 55);
            this.Podgląd.TabIndex = 1;
            this.Podgląd.Text = "Podgląd";
            this.Podgląd.UseVisualStyleBackColor = true;
            this.Podgląd.Click += new System.EventHandler(this.Podgląd_Click);
            // 
            // Usuń_klienta
            // 
            this.Usuń_klienta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Usuń_klienta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Usuń_klienta.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Usuń_klienta.Location = new System.Drawing.Point(621, 399);
            this.Usuń_klienta.Name = "Usuń_klienta";
            this.Usuń_klienta.Size = new System.Drawing.Size(175, 55);
            this.Usuń_klienta.TabIndex = 2;
            this.Usuń_klienta.Text = "Usuń klienta";
            this.Usuń_klienta.UseVisualStyleBackColor = true;
            this.Usuń_klienta.Click += new System.EventHandler(this.Usuń_klienta_Click);
            // 
            // Usuń_rezerwacje
            // 
            this.Usuń_rezerwacje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Usuń_rezerwacje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Usuń_rezerwacje.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Usuń_rezerwacje.Location = new System.Drawing.Point(621, 320);
            this.Usuń_rezerwacje.Name = "Usuń_rezerwacje";
            this.Usuń_rezerwacje.Size = new System.Drawing.Size(175, 73);
            this.Usuń_rezerwacje.TabIndex = 3;
            this.Usuń_rezerwacje.Text = "Usuń rezerwacje";
            this.Usuń_rezerwacje.UseVisualStyleBackColor = true;
            this.Usuń_rezerwacje.Click += new System.EventHandler(this.Usuń_rezerwacje_Click);
            // 
            // Zmiana_rezerwacji
            // 
            this.Zmiana_rezerwacji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Zmiana_rezerwacji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Zmiana_rezerwacji.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zmiana_rezerwacji.Location = new System.Drawing.Point(621, 242);
            this.Zmiana_rezerwacji.Name = "Zmiana_rezerwacji";
            this.Zmiana_rezerwacji.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Zmiana_rezerwacji.Size = new System.Drawing.Size(175, 72);
            this.Zmiana_rezerwacji.TabIndex = 4;
            this.Zmiana_rezerwacji.Text = "Zmiana rezerwacji";
            this.Zmiana_rezerwacji.UseVisualStyleBackColor = true;
            this.Zmiana_rezerwacji.Click += new System.EventHandler(this.Zmiana_rezerwacji_Click);
            // 
            // time_lbl_a
            // 
            this.time_lbl_a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time_lbl_a.AutoSize = true;
            this.time_lbl_a.Location = new System.Drawing.Point(674, 9);
            this.time_lbl_a.Name = "time_lbl_a";
            this.time_lbl_a.Size = new System.Drawing.Size(42, 13);
            this.time_lbl_a.TabIndex = 5;
            this.time_lbl_a.Text = "Time_a";
            this.time_lbl_a.Click += new System.EventHandler(this.time_lbl_a_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Enabled = false;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(432, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ADMINISTRATOR";
            // 
            // Menu_Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rezerwacja_Hotelowa.Properties.Resources.menu_administrator;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 527);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time_lbl_a);
            this.Controls.Add(this.Zmiana_rezerwacji);
            this.Controls.Add(this.Usuń_rezerwacje);
            this.Controls.Add(this.Usuń_klienta);
            this.Controls.Add(this.Podgląd);
            this.Controls.Add(this.Wyloguj);
            this.DoubleBuffered = true;
            this.Name = "Menu_Administrator";
            this.Text = "Menu_Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Wyloguj;
        private System.Windows.Forms.Button Podgląd;
        private System.Windows.Forms.Button Usuń_klienta;
        private System.Windows.Forms.Button Usuń_rezerwacje;
        private System.Windows.Forms.Button Zmiana_rezerwacji;
        private System.Windows.Forms.Label time_lbl_a;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}