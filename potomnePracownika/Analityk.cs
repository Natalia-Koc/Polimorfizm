using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_Polimorfizm.potomnePracownika
{
    class Analityk : Pracownik
    {
        public Analityk() { }
        public Analityk(int numerIdentyfikacyjny, string imie, string nazwisko, int wiek, float pensja, int liczbaKlientow)
            : base(numerIdentyfikacyjny, imie, nazwisko, wiek, pensja)
        {
            LiczbaKlientow = liczbaKlientow;
        }



        private int liczbaKlientow;

        public int LiczbaKlientow
        {
            get { return liczbaKlientow; }
            set { liczbaKlientow = value; }
        }

        internal override string Podwyzka(float kwota)
        {
            Pensja += kwota * liczbaKlientow;
            return $"Pracownik {Imie} {Nazwisko} dostał/a podwyżkę, aktualna pensja: {Pensja}";
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko}, wiek: {Wiek}, pensja: {Pensja}, liczna klientów: {LiczbaKlientow}";
        }
    }
}
