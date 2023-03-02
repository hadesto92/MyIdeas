namespace Rezerwacja_Hotelowa
{
    partial class Menu
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
            this.Wyjscie = new System.Windows.Forms.Button();
            this.Logowanie = new System.Windows.Forms.Button();
            this.Rejestracja = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Wyjscie
            // 
            this.Wyjscie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Wyjscie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Wyjscie.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyjscie.Location = new System.Drawing.Point(651, 603);
            this.Wyjscie.Name = "Wyjscie";
            this.Wyjscie.Size = new System.Drawing.Size(175, 55);
            this.Wyjscie.TabIndex = 0;
            this.Wyjscie.Text = "Wyjście";
            this.Wyjscie.UseVisualStyleBackColor = true;
            this.Wyjscie.Click += new System.EventHandler(this.Wyjscie_Click);
            // 
            // Logowanie
            // 
            this.Logowanie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Logowanie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logowanie.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Logowanie.Location = new System.Drawing.Point(470, 603);
            this.Logowanie.Name = "Logowanie";
            this.Logowanie.Size = new System.Drawing.Size(175, 55);
            this.Logowanie.TabIndex = 1;
            this.Logowanie.Text = "Logowanie";
            this.Logowanie.UseVisualStyleBackColor = true;
            this.Logowanie.Click += new System.EventHandler(this.Logowanie_Click);
            // 
            // Rejestracja
            // 
            this.Rejestracja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Rejestracja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rejestracja.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rejestracja.Location = new System.Drawing.Point(289, 603);
            this.Rejestracja.Name = "Rejestracja";
            this.Rejestracja.Size = new System.Drawing.Size(175, 55);
            this.Rejestracja.TabIndex = 2;
            this.Rejestracja.Text = "Rejestracja";
            this.Rejestracja.UseVisualStyleBackColor = true;
            this.Rejestracja.Click += new System.EventHandler(this.Rejestracja_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_lbl
            // 
            this.time_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time_lbl.AutoSize = true;
            this.time_lbl.Location = new System.Drawing.Point(710, 20);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(30, 13);
            this.time_lbl.TabIndex = 3;
            this.time_lbl.Text = "Time";
            this.time_lbl.Click += new System.EventHandler(this.time_lbl_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rezerwacja_Hotelowa.Properties.Resources.menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 670);
            this.ControlBox = false;
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.Rejestracja);
            this.Controls.Add(this.Logowanie);
            this.Controls.Add(this.Wyjscie);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.Text = "RejestracjaHotelowa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Wyjscie;
        private System.Windows.Forms.Button Logowanie;
        private System.Windows.Forms.Button Rejestracja;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time_lbl;
    }
}

