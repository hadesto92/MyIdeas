namespace Rezerwacja_Hotelowa
{
    partial class Usun_Klienta
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
            this.Usun = new System.Windows.Forms.Button();
            this.Powrot = new System.Windows.Forms.Button();
            this.lista_klientow = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Usun
            // 
            this.Usun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Usun.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Usun.Location = new System.Drawing.Point(255, 380);
            this.Usun.Name = "Usun";
            this.Usun.Size = new System.Drawing.Size(175, 55);
            this.Usun.TabIndex = 0;
            this.Usun.Text = "Usuń";
            this.Usun.UseVisualStyleBackColor = true;
            this.Usun.Click += new System.EventHandler(this.Usun_Click);
            // 
            // Powrot
            // 
            this.Powrot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Powrot.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Powrot.Location = new System.Drawing.Point(12, 380);
            this.Powrot.Name = "Powrot";
            this.Powrot.Size = new System.Drawing.Size(175, 55);
            this.Powrot.TabIndex = 1;
            this.Powrot.Text = "Powrót";
            this.Powrot.UseVisualStyleBackColor = true;
            this.Powrot.Click += new System.EventHandler(this.Powrot_Click);
            // 
            // lista_klientow
            // 
            this.lista_klientow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lista_klientow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lista_klientow.FormattingEnabled = true;
            this.lista_klientow.Location = new System.Drawing.Point(135, 135);
            this.lista_klientow.Name = "lista_klientow";
            this.lista_klientow.Size = new System.Drawing.Size(161, 21);
            this.lista_klientow.TabIndex = 2;
            this.lista_klientow.SelectedIndexChanged += new System.EventHandler(this.lista_klientow_SelectedIndexChanged);
            // 
            // Usun_Klienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 447);
            this.ControlBox = false;
            this.Controls.Add(this.lista_klientow);
            this.Controls.Add(this.Powrot);
            this.Controls.Add(this.Usun);
            this.Name = "Usun_Klienta";
            this.Text = "Usun_Klienta";
            this.Load += new System.EventHandler(this.Usun_Klienta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Usun;
        private System.Windows.Forms.Button Powrot;
        private System.Windows.Forms.ComboBox lista_klientow;
    }
}