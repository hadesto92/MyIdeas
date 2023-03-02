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
    public partial class Klient_data : Form
    {
        public Klient_data()
        {
            InitializeComponent();
        }

        private void Powrot_Click(object sender, EventArgs e)
        {
            Menu_Klient menu_klient = new Menu_Klient();
            menu_klient.Show();
            this.Close();
        }

        private void Dalej_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brak odpowiedniej funkcji", "UWAGA!!!",
                  MessageBoxButtons.OK);
            string fileName = "rezerwacja.txt";
            string textToAdd = "Example text in file";
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                //sw.WriteLine(n);
                sw.WriteLine(this.date_od.Text);
                sw.WriteLine(this.date_do.Text);
            }
        }

        private void text_do_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_od_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_od_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_do_ValueChanged(object sender, EventArgs e)
        {

        }

        private void text_rezerwacji_TextChanged(object sender, EventArgs e)
        {

        }

        private void Klient_data_Load(object sender, EventArgs e)
        {

        }
    }
}
