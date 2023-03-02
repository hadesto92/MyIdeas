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
    public partial class Usun_Klienta : Form
    {
        //string[] id = System.IO.File.ReadAllLines("nr.txt");
       // string[] lines = System.IO.File.ReadAllLines("test.txt");
        

        public Usun_Klienta()
        {
            InitializeComponent();
        }

        private void Usun_Click(object sender, EventArgs e)
        {
            string[] id = System.IO.File.ReadAllLines("nr.txt");
            string zm = lista_klientow.Text;
            string im = "";
            string ttp = "";
            string enn = "";
            int en = Convert.ToInt32(id[0]);
            int zmienna = 0, ajdi = 0;//, zmint = Convert.ToInt32(zm);
            string[] test = System.IO.File.ReadAllLines("test.txt");
            bool delete=false;
            for (int i = 0; i < en; i++)
            {
                //zmienna = Convert.ToInt32(test[0]);// +i * 10;
                im = test[4 + i * 10] + " " + test[5 + i * 10];
                if (zm == im)
                {
                    ajdi = i + 1;// Convert.ToInt32(test[0 + i * 10]);
                    break;
                }

            }
            //int en = Convert.ToInt32(id[0]);//liczba klientow
            int ostatnia_linia = File.ReadAllLines("test.txt").Length;
            //
            string line = "";
            List<string> testlist = new List<string>();
            string linia = "test";
            //czytanie
           // testlist.Add(linia);
            System.IO.StreamReader file = new System.IO.StreamReader("test.txt");
            while ((line = file.ReadLine()) != null)
            {
                testlist.Add(line);
               
            }
            for (int j = 0; j < 10; j++)
            {
                if (lista_klientow.SelectedIndex>=0)
                    testlist.RemoveAt(lista_klientow.SelectedIndex*10);
            }
            delete = true;
            
            file.Close();
            System.IO.StreamWriter file1 = new System.IO.StreamWriter("test.txt");
            foreach (string lined in testlist)
                file1.WriteLine(lined);
            file1.Close();
           // file1.WriteLine(testlist);
            en--;
            if (en < 0) en = 0;
            enn = Convert.ToString(en);
            //file.Close();
            System.IO.StreamWriter file2 = new System.IO.StreamWriter("nr.txt");
            file2.WriteLine(enn);
            file2.Close();

            if (delete == true)
            {
                lista_klientow.Items.Clear();
                load();


            }

            
/*
            
                

                    //pamietaj zeby zmiejszac wartosc tymczasowa (ilosc klientow) ktora tu bedziesz uzywac
                    //for (int i = 0; i < 10; i++) { test[(1 * 10) + i] = test[(2 * 10) + i]; }
            System.IO.StreamWriter file = new System.IO.StreamWriter("test.txt");
            file.Close();
            
            string tmp = "";
            if (en == 1)
            {
                file.WriteLine(tmp);
            }
            else if (en > 1 )
            {
                if (ajdi != en)
                {
                    for (int ii = ajdi-1; ii < en-1; ii++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            test[(ii * 10) + j] = test[((ii + 1) * 10) + j];
                        }
                    }
                    int a = (en - 1) * 10;
                    Array.Resize(ref test, a);
                    //ile.WriteLine(test);
                    File.WriteAllLines("test.txt", test);

                   
                    ttp = Convert.ToString(en--);
                    file1.WriteLine(ttp);
                    
                }
                else
                {
                    for (int i = 0; i < ostatnia_linia - 10; i++)
                    {
                        tmp = tmp + test[i] + "\r\n";
                    }
                    
                    ttp = Convert.ToString(en--);
                    file1.WriteLine(ttp);

                   // file.WriteLine(tmp);
                    File.WriteAllLines("test.txt", test);
                }
            }
            //for (int i = 0; i < en; i++) {
            //    for (int j = 0; j < 10; j++){
                    
            //    }
            //}
            // Compose a string that consists of three lines.
           // string lines = "First line.\r\nSecond line.\r\nThird line.";
            // Write the string to a file.

            
            //for(int i=0;i<ostatnia_linia-10;i++){
            //   tmp= tmp+ test[i]+"\r\n";
            //}
           
            
             //   file.WriteLine(tmp);
                //file.WriteLine(lines);
                //file.WriteLine(\n);
            en--;
            enn = Convert.ToString(en);
            //file.Close();
            file1.WriteLine("nr.txt", enn);
            file1.Close();
          */
        }

        private void Powrot_Click(object sender, EventArgs e)
        {
            Menu_Administrator menu_administrator = new Menu_Administrator();
               menu_administrator.Show();
               this.Close();
        }

        private void load()
        {
            string[] idd = System.IO.File.ReadAllLines("nr.txt");
            int n = Convert.ToInt32(idd[0]);
            string s;
            string[] liness = System.IO.File.ReadAllLines("test.txt");
            
            for (int i = 0; i < n; i++)
            {
                //lista_klientow.Items.Clear;
                s = liness[4 + 10 * i] + " " + liness[5 + 10 * i];
                lista_klientow.Items.Add(s);//,lines[5]);
                //lista_klientow.Items.Add("cos wpisac mozesz hehe2");

            }
        }
        private void Usun_Klienta_Load(object sender, EventArgs e)
        {
            load();
        }

        private void lista_klientow_SelectedIndexChanged(object sender, EventArgs e)
        {
            load();
        }
       
    }
}
