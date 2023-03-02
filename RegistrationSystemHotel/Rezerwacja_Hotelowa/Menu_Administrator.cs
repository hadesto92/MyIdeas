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
    public partial class Menu_Administrator : Form
    {
        public Menu_Administrator()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Wyloguj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nastąpiło poprawne wylogowanie", "INFORMACJA",
                  MessageBoxButtons.OK);
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void Podgląd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brak odpowiedniej funkcji", "UWAGA!!!",
                  MessageBoxButtons.OK);
        }

        private void Zmiana_rezerwacji_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brak odpowiedniej funkcji", "UWAGA!!!",
                  MessageBoxButtons.OK);
        }

        private void Usuń_rezerwacje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brak odpowiedniej funkcji", "UWAGA!!!",
                  MessageBoxButtons.OK);
        }

        private void Usuń_klienta_Click(object sender, EventArgs e)
        {
            Usun_Klienta usun_klienta = new Usun_Klienta();
               usun_klienta.Show();
               this.Close();
        }

        private void time_lbl_a_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time_lbl_a.Text = dateTime.ToString();
        }
    }
}
