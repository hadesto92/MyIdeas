using System;
using System.IO;
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
    public partial class Logowanie : Form
    {

        string[] lines = System.IO.File.ReadAllLines("profile.txt");

        public Logowanie()
        {
            InitializeComponent();
            this.text_login.Clear();
            this.text_haslo.Clear();
        } 

        private void Zaloguj_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Brak odpowiedniej funkcji, nastąpi powrót do MENU", "UWAGA!!!",
            //      MessageBoxButtons.OK);
            //Menu menu = new Menu();
            //menu.Show();
            //this.Close();

            int liczba = 1;
            int n = 0;
            int ostatnia_linia = File.ReadAllLines("profile.txt").Length;

            if ((this.text_login.Text == "admin") && (this.text_haslo.Text == "qazWSX1234"))
            {
                Menu_Administrator menu_administrator = new Menu_Administrator();
                menu_administrator.Show();
                this.Close();

                liczba = 0;
            }

            //else if ((this.text_login.Text == "klient") && (this.text_haslo.Text == "1234"))
            //{
            //    Menu_Klient menu_klient = new Menu_Klient();
            //    menu_klient.Show();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Niepoprawne dane! Proszę spróbować ponownie");
            //    this.text_login.Clear();
            //    this.text_haslo.Clear();
            //}

            
            while (liczba != 0)
            {
                liczba = liczba + 1;
                if (this.text_login.Text == lines[n])
                {
                    int m = n + 1;

                    if (lines[m] == this.text_haslo.Text)
                    {

                        int i = n - 1;

                        string[] t = new string[1];
                        t[0] = lines[i];
                        File.WriteAllLines("ida.txt", t);
                        
                        Menu_Klient menu_klient = new Menu_Klient();
                        menu_klient.Show();
                        this.Close();

                        liczba = 0;
                        n = 0;
                    }
                }
                n = n + 1;
                if (n == ostatnia_linia)
                {
                    MessageBox.Show("Niepoprawne dane! Proszę spróbować ponownie","UWAGA!!!",
                      MessageBoxButtons.OK);
                    this.text_login.Clear();
                    this.text_haslo.Clear();

                    liczba = 0;
                }
            }
        }

        private void Powrot_logowanie_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void haslo_Click(object sender, EventArgs e)
        {

        }

        private void text_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_haslo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
