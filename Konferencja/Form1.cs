using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Konferencja
{
    public partial class Form1 : Form
    {
        List<Sesja> listasesji = new List<Sesja>();
        List<List<int>> listakrawedzi = new List<List<int>>();
        static int iloscSal;

        public static void setIloscSal(int iS)
        {
            iloscSal = iS;
        }

        class Sesja : IComparable
        {
            internal string nazwa;
            internal int godzinaR;
            internal int minutaR;
            internal int godzinaZ;
            internal int minutaZ;
            internal int kolor = -1;

            int IComparable.CompareTo(object obj)
            {
                if (obj == null)
                {
                    return 1;
                }
                Sesja s = obj as Sesja;
                if (s != null)
                {
                    if (godzinaR == s.godzinaR && minutaR == minutaZ)
                        return 0;
                    if (godzinaR > s.godzinaR || (godzinaR == s.godzinaR && minutaR > s.minutaR))
                    {
                        return 1;
                    }
                    else return -1;

                }
                else throw new ArgumentException("Argument nie jest Sesją");
            }

            public Sesja(string nazwa, int godzinaR, int minutaR, int godzinaZ, int minutaZ)
            {
                this.nazwa = nazwa;
                this.godzinaR = godzinaR;
                this.godzinaZ = godzinaZ;
                this.minutaR = minutaR;
                this.minutaZ = minutaZ;
            }

            public override string ToString()
            {
                string res = nazwa + ": ";
                if (godzinaR < 10)
                {
                    res = res + "0" + godzinaR;
                }
                else res = res + godzinaR;
                res = res + ":";
                if (minutaR < 10)
                {
                    res = res + "0" + minutaR;
                }
                else res = res + minutaR;
                res = res + " - ";
                if (godzinaZ < 10)
                {
                    res = res + "0" + godzinaZ;
                }
                else res = res + godzinaZ;
                res = res + ":";
                if (minutaZ < 10)
                {
                    res = res + "0" + minutaZ;
                }
                else res = res + minutaZ;
                return res;
            }
        }

        private class SesjaCoparer : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Sesja s1 = x as Sesja;
                Sesja s2 = x as Sesja;
                if (s1.godzinaR == s2.godzinaR && s1.minutaR == s2.minutaR)
                {
                    return 0;
                }
                if (s1.godzinaR < s2.godzinaR || (s1.godzinaR == s2.godzinaR && s1.minutaR < s2.minutaR))
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void WypiszSesje(Sesja sesja)
        {
            string sesjelabel = "";
            sesjelabel += sesja.ToString() + "\n";
            wypisanesesje.Text += sesjelabel;
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            string nazwa = nazwaSesjiTextbox.Text;
            bool czynazwaok = true;
            string godzinaR = godzinaRTextbox.Text;
            string godzinaZ = godzinaZTextbox.Text;
            string minutaR = minutaRTextbox.Text;
            string minutaZ = minutaZTextbox.Text;
            int IgodzinaR = 0;
            int IgodzinaZ = 0;
            int IminutaR = 0;
            int IminutaZ = 0;
            Regex g = new Regex(@"^[0-9]{1,2}$");
            Regex m = new Regex(@"^[0-9]{2}$");
            bool czygodzinaok = true;
            if (nazwa == "")
            {
                zledane.Text = "Podaj nazwę sesji!";
                czynazwaok = false;
            }
            if (g.IsMatch(godzinaR) && g.IsMatch(godzinaZ) && m.IsMatch(minutaR) && m.IsMatch(minutaZ))
            {
                IgodzinaR = Convert.ToInt32(godzinaR);
                IgodzinaZ = Convert.ToInt32(godzinaZ);
                IminutaR = Convert.ToInt32(minutaR);
                IminutaZ = Convert.ToInt32(minutaZ);
                if (IgodzinaR > 24)
                {
                    zledane.Text = "Godzina wpisana nieprawidłowo";
                    czygodzinaok = false;
                }
                if (IgodzinaZ > 24)
                {
                    zledane.Text = "Godzina wpisana nieprawidłowo";
                    czygodzinaok = false;
                }
                if (IminutaR > 60)
                {
                    zledane.Text = "Godzina wpisana nieprawidłowo";
                    czygodzinaok = false;
                }
                if (IminutaZ > 60)
                {
                    zledane.Text = "Godzina wpisana nieprawidłowo";
                    czygodzinaok = false;
                }
                if (IgodzinaR > IgodzinaZ || ((IgodzinaR == IgodzinaZ && IminutaR > IminutaZ)))
                {
                    zledane.Text = "Godzina wpisana nieprawidłowo";
                    czygodzinaok = false;
                }
                if (IgodzinaR == IgodzinaZ && IminutaR == IminutaZ)
                {
                    zledane.Text = "Godzina rozpoczęcia identyczna z godziną zakończenia.";
                    czygodzinaok = false;
                }
            }
            else
            {
                zledane.Text = "Godzina wpisana nieprawidłowo";
                czygodzinaok = false;
            }

            if (czygodzinaok && czynazwaok)
            {
                Sesja sesja = new Sesja(nazwa, IgodzinaR, IminutaR, IgodzinaZ, IminutaZ);
                listasesji.Add(sesja);
                WypiszSesje(sesja);
                WyczyscTexty();
            }

        }

        private void WyczyscTexty()
        {
            zledane.Text = "";
            nazwaSesjiTextbox.Text = "";
            godzinaRTextbox.Text = "";
            minutaRTextbox.Text = "";
            godzinaZTextbox.Text = "";
            minutaZTextbox.Text = "";
        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            listasesji = new List<Sesja>();
            wypisanesesje.Text = "";
            iloscSal = 0;
        }

        private void zaplanuj_Click(object sender, EventArgs e)
        {
            if (listasesji.Count > 0 && iloscSal > 0)
            {
                for (int i = 0; i < listasesji.Count; i++)
                {
                    listasesji[i].kolor = -1;
                }
                listakrawedzi = new List<List<int>>();
                listasesji.Sort();
                //inicjalizacja grafu
                for (int i = 0; i < listasesji.Count; i++)
                {
                    List<int> vs = new List<int>();
                    for (int j = 0; j < listasesji.Count; j++)
                    {
                        if (i != j)
                        {
                            if (NakladajaSie(listasesji[i], listasesji[j]))
                            {
                                vs.Add(j);
                            }
                        }
                    }
                    listakrawedzi.Add(vs);
                }


                //kolorowanie
                bool[] C = new bool[listasesji.Count]; //tworzymy pomocniczą tablicę przechowującą zajęte kolory
                listasesji[0].kolor = 0; //ustalamy kolor 1 wierzchołka na 0
                for (int i = 1; i < listasesji.Count; i++) 
                {
                    for (int j = 0; j < C.Length; j++)
                    {
                        C[j] = false; //wszystkie kolory ustalamy jako wolne
                    }

                    if (listakrawedzi[i].Count > 0)
                    {
                        for (int k = 0; k < listakrawedzi[i].Count; k++)
                        {
                            int x = listasesji[listakrawedzi[i][k]].kolor;
                            if (x > -1) //dla każdego sąsiada wierzchołka w którym się znajdujemy 
							//sprawdzamy zajęte kolory które przechowujemy w tablicy C
                            {
                                C[x] = true;
                            }
                        }
                    }
                    int l = 0;
                    while (C[l] == true) l++;
                    listasesji[i].kolor = l; //wierzchołkowi przypisujemy najmniejszy niezajęty kolor
                }

                Form2 forma2 = new Form2();
                forma2.Sale.Text = Convert.ToString(iloscSal);
                forma2.tablica.Text += Wypisz();
                forma2.ShowDialog();            }

            if (iloscSal > 0)
            {
            }
            else zledane.Text = "Podaj liczbę sal.";
            if (listasesji.Count > 0) { }
            else zledane.Text = "Lista sesji jest pusta.";

        }

        //źle ??
        private bool NakladajaSie(Sesja s1, Sesja s2)
        {
            bool czynakladajasie = true;
            if ((s1.godzinaR > s2.godzinaZ) || (s1.godzinaR == s2.godzinaZ && s1.minutaR >= s2.minutaZ))
            {
                czynakladajasie = false;
            }
            if ((s2.godzinaR > s1.godzinaZ) || (s2.godzinaR == s1.godzinaZ && s2.minutaR >= s1.minutaZ))
            {
                czynakladajasie = false;
            }
            return czynakladajasie;
        }

        private string WypiszKonferencje(Sesja sesja)
        {
            string sesjelabel = "";
            sesjelabel += sesja.ToString() + " " + CzyDostepnaSala(sesja) + "\n";
            return sesjelabel;
        }

        private string Wypisz()
        {
            string konf = "";
            for (int i = 0; i < listasesji.Count(); i++)
            {
                konf += WypiszKonferencje(listasesji[i]);
            }
            return konf;
        }

        private void wyjdzButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 forma3 = new Form3();
            forma3.ShowDialog();
        }

        private string CzyDostepnaSala(Sesja sesja)
        {
            string nr = "";
            if (iloscSal >= sesja.kolor + 1)
                nr = "sala numer " + (sesja.kolor + 1) + ".";
            else nr = "brak wystarczającej ilości sal.";
            return nr;
        }
    }
}
