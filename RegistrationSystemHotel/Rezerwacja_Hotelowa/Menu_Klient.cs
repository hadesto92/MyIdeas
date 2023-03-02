using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezerwacja_Hotelowa
{
    public partial class Menu_Klient : Form
    {
        public Menu_Klient()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void time_lbl_k_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time_lbl_k.Text = dateTime.ToString();
        }

        private void Profil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brak odpowiedniej funkcji", "UWAGA!!!",
                  MessageBoxButtons.OK);
        }

        private void Rezerwacja_Click(object sender, EventArgs e)
        {
            Klient_data klienta_data = new Klient_data();
            klienta_data.Show();
            this.Close();
        }

        private void Podglad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brak odpowiedniej funkcji", "UWAGA!!!",
                  MessageBoxButtons.OK);
        }

        private void Zmiana_rezerwacji_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brak odpowiedniej funkcji", "UWAGA!!!",
                  MessageBoxButtons.OK);
        }

        private void Usuniecie_rezerwaci_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brak odpowiedniej funkcji", "UWAGA!!!",
                  MessageBoxButtons.OK);
        }

        private void Wyloguj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nastąpiło poprawne wylogowanie", "INFORMACJA",
                  MessageBoxButtons.OK);
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void Menu_Klient_Load(object sender, EventArgs e)
        {

        }
    }
}
