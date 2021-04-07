using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_Polimorfizm
{
    abstract class Pracownik : Object
    {
        public Pracownik () { }

        public Pracownik (int numerIdentyfikacyjny, string imie, string nazwisko, int wiek, float pensja)
        {
            NumerIdentyfikacyjny = numerIdentyfikacyjny;
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Pensja = pensja;
        }


        private int numerIdentyfikacyjny;
        public int NumerIdentyfikacyjny
        {
            get { return numerIdentyfikacyjny; }
            set { numerIdentyfikacyjny = value; }
        }

        private string imie;
        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        private string nazwisko;
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        private int wiek;
        public int Wiek
        {
            get { return wiek; }
            set { wiek = value; }
        }

        private float pensja;
        public float Pensja
        {
            get { return pensja; }
            set { pensja = value; }
        }


        internal virtual string Podwyzka(float kwota)
        {
            Pensja += kwota;
            return $"Pracownik {Imie} {Nazwisko} dostał/a podwyżkę, aktualna pensja: {Pensja}";
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko}, wiek: {Wiek}, pensja: {Pensja}";
        }
    }
}
