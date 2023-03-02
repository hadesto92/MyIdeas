using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezerwacja_Hotelowa
{
    public partial class Menu : Form
    {
        int r = 1;
        int l = 1;

        public Menu()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Wyjscie_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz wyjść?", "Zakończenie programu Rezerwacja Hotelowa",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                  == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Logowanie_Click(object sender, EventArgs e)
        {
            // Tworzymy obiekt odpowiedzialny za wysyłanie stosowych pakietów ICMP:
            Ping pingSender = new Ping();

            // Ten obiekt umożliwia ustawienie opcji Ttl i DontFragment:
            PingOptions options = new PingOptions();

            // Ustawiamy maksymalną ilość węzłów sieci, które będzie mógł przebyć
            // pakiet Echo Request:
            options.Ttl = 100;

            // Określamy czy pakiet będzie mógł być dzielony na fragmenty:
            options.DontFragment = true;

            // Pobieramy dane towarzyszące:
            string data = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

            // Tworzymy bufor dla tych danych:
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            // Ustalamy czas oczekiwania na odpowiedź:
            //int timeout = 500;
            try
            {
                // Wywołujemy metodę Send() a rezultat jej wykonania przechowujemy
                // w obiekcie PingReply:
                PingReply reply = pingSender.Send("onet.pl", 1000, buffer, options);

                // Sprawdzamy czy otrzymano odpowiedz:
                if (reply.Status == IPStatus.Success)
                {
                    l = 0;
                }
                else
                {
                    // Jeśli nie to sprawdzamy co poszło nie tak jak należy:
                    l = 0;
                }
            }
            catch (Exception ex)
            {
                l = 0;
            }
            if (l == 0)
            {
                Logowanie logowanie = new Logowanie();
                logowanie.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Brak połączenia z internetem! Aby się zalogować, proszę połączyć się z internetem.", "UWAGA!!!",
                  MessageBoxButtons.OK);
            }
        }

        private void Rejestracja_Click(object sender, EventArgs e)
        {
            // Tworzymy obiekt odpowiedzialny za wysyłanie stosowych pakietów ICMP:
            Ping pingSender = new Ping();

            // Ten obiekt umożliwia ustawienie opcji Ttl i DontFragment:
            PingOptions options = new PingOptions();

            // Ustawiamy maksymalną ilość węzłów sieci, które będzie mógł przebyć
            // pakiet Echo Request:
            options.Ttl = 100;

            // Określamy czy pakiet będzie mógł być dzielony na fragmenty:
            options.DontFragment = true;

            // Pobieramy dane towarzyszące:
            string data = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

            // Tworzymy bufor dla tych danych:
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            // Ustalamy czas oczekiwania na odpowiedź:
            //int timeout = 500;
            try
            {
                // Wywołujemy metodę Send() a rezultat jej wykonania przechowujemy
                // w obiekcie PingReply:
                PingReply reply = pingSender.Send("onet.pl", 1000, buffer, options);

                // Sprawdzamy czy otrzymano odpowiedz:
                if (reply.Status == IPStatus.Success)
                {
                    r = 0;
                }
                else
                {
                    // Jeśli nie to sprawdzamy co poszło nie tak jak należy:
                    r = 1;
                }
            }
            catch (Exception ex)
            {
            }

            if (r == 0)
            {
                Rejestracja rejestracja = new Rejestracja();
                rejestracja.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Brak połączenia z internetem! Aby się zarejestrować, proszę połączyć się z internetem.", "UWAGA!!!",
                  MessageBoxButtons.OK);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time_lbl.Text = dateTime.ToString();
        }

        private void time_lbl_Click(object sender, EventArgs e)
        {

        }
        private void sprawdzenie()
        {

           
        }
    }
}
