using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_Polimorfizm.potomnePracownika.potomneProgramisty
{
    class ZdalnyProgramista : Programista
    {
        public ZdalnyProgramista() { }

        public ZdalnyProgramista(int numerIdentyfikacyjny, string imie, string nazwisko, int wiek, 
                                    float pensja, int liczbaWykorzystanychTechnologii, int odleglosc)
            : base(numerIdentyfikacyjny, imie, nazwisko, wiek, pensja, liczbaWykorzystanychTechnologii)
        {
            Odleglosc = odleglosc;
        }



        private float odleglosc;

        public float Odleglosc
        {
            get { return odleglosc; }
            set { odleglosc = value; }
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko}, wiek: {Wiek}, pensja: {Pensja}, " +
                $"liczby wykorzystywanych technologii: {LiczbaWykorzystanychTechnologii}, odległość: {Odleglosc}";
        }
    }
}
