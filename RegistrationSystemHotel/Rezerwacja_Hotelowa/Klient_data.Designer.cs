namespace Rezerwacja_Hotelowa
{
    partial class Klient_data
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
            this.Dalej = new System.Windows.Forms.Button();
            this.Powrot = new System.Windows.Forms.Button();
            this.date_od = new System.Windows.Forms.DateTimePicker();
            this.date_do = new System.Windows.Forms.DateTimePicker();
            this.text_od = new System.Windows.Forms.TextBox();
            this.text_do = new System.Windows.Forms.TextBox();
            this.text_rezerwacji = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Dalej
            // 
            this.Dalej.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Dalej.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dalej.Location = new System.Drawing.Point(250, 143);
            this.Dalej.Name = "Dalej";
            this.Dalej.Size = new System.Drawing.Size(175, 55);
            this.Dalej.TabIndex = 0;
            this.Dalej.Text = "Dalej";
            this.Dalej.UseVisualStyleBackColor = true;
            this.Dalej.Click += new System.EventHandler(this.Dalej_Click);
            // 
            // Powrot
            // 
            this.Powrot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Powrot.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Powrot.Location = new System.Drawing.Point(12, 143);
            this.Powrot.Name = "Powrot";
            this.Powrot.Size = new System.Drawing.Size(175, 55);
            this.Powrot.TabIndex = 1;
            this.Powrot.Text = "Powrót";
            this.Powrot.UseVisualStyleBackColor = true;
            this.Powrot.Click += new System.EventHandler(this.Powrot_Click);
            // 
            // date_od
            // 
            this.date_od.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_od.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_od.Location = new System.Drawing.Point(195, 59);
            this.date_od.Name = "date_od";
            this.date_od.Size = new System.Drawing.Size(99, 20);
            this.date_od.TabIndex = 2;
            this.date_od.ValueChanged += new System.EventHandler(this.date_od_ValueChanged);
            // 
            // date_do
            // 
            this.date_do.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_do.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_do.Location = new System.Drawing.Point(195, 85);
            this.date_do.Name = "date_do";
            this.date_do.Size = new System.Drawing.Size(99, 20);
            this.date_do.TabIndex = 3;
            this.date_do.ValueChanged += new System.EventHandler(this.date_do_ValueChanged);
            // 
            // text_od
            // 
            this.text_od.Enabled = false;
            this.text_od.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_od.Location = new System.Drawing.Point(121, 59);
            this.text_od.Name = "text_od";
            this.text_od.Size = new System.Drawing.Size(57, 20);
            this.text_od.TabIndex = 4;
            this.text_od.Text = "Od";
            this.text_od.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_od.TextChanged += new System.EventHandler(this.text_od_TextChanged);
            // 
            // text_do
            // 
            this.text_do.Enabled = false;
            this.text_do.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_do.Location = new System.Drawing.Point(121, 88);
            this.text_do.Name = "text_do";
            this.text_do.Size = new System.Drawing.Size(56, 20);
            this.text_do.TabIndex = 5;
            this.text_do.Text = "Do";
            this.text_do.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_do.TextChanged += new System.EventHandler(this.text_do_TextChanged);
            // 
            // text_rezerwacji
            // 
            this.text_rezerwacji.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_rezerwacji.Enabled = false;
            this.text_rezerwacji.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_rezerwacji.Location = new System.Drawing.Point(102, 31);
            this.text_rezerwacji.Name = "text_rezerwacji";
            this.text_rezerwacji.Size = new System.Drawing.Size(207, 22);
            this.text_rezerwacji.TabIndex = 6;
            this.text_rezerwacji.Text = "Wybierz datę rezerwacji";
            this.text_rezerwacji.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_rezerwacji.TextChanged += new System.EventHandler(this.text_rezerwacji_TextChanged);
            // 
            // Klient_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 210);
            this.ControlBox = false;
            this.Controls.Add(this.text_rezerwacji);
            this.Controls.Add(this.text_do);
            this.Controls.Add(this.text_od);
            this.Controls.Add(this.date_do);
            this.Controls.Add(this.date_od);
            this.Controls.Add(this.Powrot);
            this.Controls.Add(this.Dalej);
            this.Name = "Klient_data";
            this.Text = "Wybór daty";
            this.Load += new System.EventHandler(this.Klient_data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dalej;
        private System.Windows.Forms.Button Powrot;
        private System.Windows.Forms.DateTimePicker date_od;
        private System.Windows.Forms.DateTimePicker date_do;
        private System.Windows.Forms.TextBox text_od;
        private System.Windows.Forms.TextBox text_do;
        private System.Windows.Forms.TextBox text_rezerwacji;
    }
}