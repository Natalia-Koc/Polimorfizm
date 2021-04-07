using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_Polimorfizm.potomnePracownika
{
    class Programista : Pracownik 
    {
        public Programista() { }
        public Programista(int numerIdentyfikacyjny, string imie, string nazwisko, int wiek, float pensja, int liczbaWykorzystanychTechnologii)
            :base(numerIdentyfikacyjny, imie, nazwisko, wiek,pensja)
        {
            LiczbaWykorzystanychTechnologii = liczbaWykorzystanychTechnologii;
        }


        private int liczbaWykorzystanychTechnologii;

        public int LiczbaWykorzystanychTechnologii
        {
            get { return liczbaWykorzystanychTechnologii; }
            set { liczbaWykorzystanychTechnologii = value; }
        }

        internal override string Podwyzka (float kwota)
        {
            Pensja += kwota * LiczbaWykorzystanychTechnologii;
            return $"Pracownik {Imie} {Nazwisko} dostał/a podwyżkę, aktualna pensja: {Pensja}";
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko}, wiek: {Wiek}, pensja: {Pensja}, liczby wykorzystywanych technologii: {LiczbaWykorzystanychTechnologii}";
        }
    }
}
