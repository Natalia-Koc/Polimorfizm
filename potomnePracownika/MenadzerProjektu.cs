using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_Polimorfizm.potomnePracownika
{
    class MenadzerProjektu : Pracownik
    {
        public MenadzerProjektu() { }
        public MenadzerProjektu(int numerIdentyfikacyjny, string imie, string nazwisko, int wiek, float pensja, int liczbaProjektow)
            : base(numerIdentyfikacyjny, imie, nazwisko, wiek, pensja)
        {
            LiczbaProjektow = liczbaProjektow;
        }



        private int liczbaProjektow;

        public int LiczbaProjektow
        {
            get { return liczbaProjektow; }
            set { liczbaProjektow = value; }
        }

        internal override string Podwyzka(float kwota)
        {
            Pensja += kwota * LiczbaProjektow;
            return $"Pracownik {Imie} {Nazwisko} dostał/a podwyżkę, aktualna pensja: {Pensja}";
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko}, wiek: {Wiek}, pensja: {Pensja}, liczba projektów: {LiczbaProjektow}";
        }

    }
}
