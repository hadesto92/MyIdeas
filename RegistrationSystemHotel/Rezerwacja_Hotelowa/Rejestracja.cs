using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezerwacja_Hotelowa
{
    public partial class Rejestracja : Form
    {
        string m;

        string[] lines = System.IO.File.ReadAllLines("profile.txt");
        int ostatnia_linia = File.ReadAllLines("profile.txt").Length;


        public Rejestracja()
        {
            InitializeComponent();
        } 

        private void Zarejestruj_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Brak odpowiedniej funkcji, nastąpi powrót do MENU", "UWAGA!!!",
            //      MessageBoxButtons.OK);
            //Menu menu = new Menu();
            //menu.Show();
            //this.Close();

            int liczba = 1;
            int liczba_a = 1;
            int s = 0;

            while (liczba != 0)
            {
                liczba = liczba + 1;
                if (this.text_login.Text == lines[s])
                {
                    MessageBox.Show("Login jest zajęty! Proszę wpisać inny.","UWAGA!!!",
                      MessageBoxButtons.OK);
                    liczba = 0;
                }
                if (this.text_e_mail.Text == lines[s])
                {
                    MessageBox.Show("Adres e-mail już istnieje! Proszę wpisać inny.", "UWAGA!!!",
                      MessageBoxButtons.OK);
                    liczba = 0;
                }
                s = s + 1;
                if (s == ostatnia_linia)
                {
                    liczba = 0;
                    liczba_a = 0;
                }
            }

            if (liczba_a == 0)
            {
                string[] id = System.IO.File.ReadAllLines("id.txt");

                int n = Convert.ToInt32(id[0]);

                n = n + 1;

                string g = n.ToString();

                string[] t = new string[1];
                t[0] = g;
                File.WriteAllLines("id.txt", t);

                string[] nr = System.IO.File.ReadAllLines("nr.txt");

                int h = Convert.ToInt32(nr[0]);

                h = h + 1;

                string gh = h.ToString();

                string[] temp = new string[1];
                temp[0] = gh;
                File.WriteAllLines("id.txt", temp);

                string fileName = "profile.txt";
                string textToAdd = "Example text in file";
                using (StreamWriter swa = new StreamWriter(fileName, true))
                {
                    swa.WriteLine(n);
                    swa.WriteLine(this.text_login.Text);
                    swa.WriteLine(this.text_haslo.Text);
                    swa.WriteLine(this.text_e_mail.Text);
                    swa.WriteLine(this.text_imie.Text);
                    swa.WriteLine(this.text_nazwisko.Text);
                    swa.WriteLine(this.text_tel.Text);
                    swa.WriteLine(this.text_adres.Text);
                    swa.WriteLine(this.text_miasto.Text);
                    swa.WriteLine(this.text_kod_pocztowy.Text);
                }

                this.text_login.Clear();
                this.text_haslo.Clear();
                this.text_e_mail.Clear();
                this.text_imie.Clear();
                this.text_nazwisko.Clear();
                this.text_tel.Clear();
                this.text_adres.Clear();
                this.text_miasto.Clear();
                this.text_kod_pocztowy.Clear();

                MessageBox.Show("Nastąpilo zapisanie do pliku D: profile.txt", "Informacja",
                      MessageBoxButtons.OK);
                Menu menu = new Menu();
                menu.Show();
                this.Close();
            }
        }

        private void Powrot_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void text_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void haslo_Click(object sender, EventArgs e)
        {

        }

        private void text_haslo_TextChanged(object sender, EventArgs e)
        {

        }

        private void e_mail_Click(object sender, EventArgs e)
        {

        }

        private void text_e_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void imie_Click(object sender, EventArgs e)
        {

        }

        private void text_imie_TextChanged(object sender, EventArgs e)
        {

        }

        private void nazwisko_Click(object sender, EventArgs e)
        {

        }

        private void text_nazwisko_TextChanged(object sender, EventArgs e)
        {

        }

        private void tel_Click(object sender, EventArgs e)
        {

        }

        private void text_tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void adres_Click(object sender, EventArgs e)
        {

        }

        private void text_adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void miasto_Click(object sender, EventArgs e)
        {

        }

        private void text_miasto_TextChanged(object sender, EventArgs e)
        {

        }

        private void kod_pocztowy_Click(object sender, EventArgs e)
        {

        }

        private void text_kod_pocztowy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
