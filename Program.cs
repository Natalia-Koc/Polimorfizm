using Lab02_Polimorfizm.potomnePracownika;
using Lab02_Polimorfizm.potomnePracownika.potomneProgramisty;
using System;
using System.Collections.Generic;

namespace Lab02_Polimorfizm
{
    class Program
    {
        List<Pracownik> pracownicy = new List<Pracownik>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program program = new Program();
            List<Pracownik> pracownicy = program.pracownicy;
            pracownicy.Add(new Programista(1234, "Daria", "Markowicz", 21, 6000, 1));
            pracownicy.Add(new Programista(1214, "Albert", "Kowalski", 23, 5000, 2));
            pracownicy.Add(new Programista(1224, "Magdalena", "Wysocka", 24, 4000, 3));
            pracownicy.Add(new Programista(1234, "Paweł", "Bednarczyk", 25, 3000, 4));
            pracownicy.Add(new Programista(1244, "Weronika", "Kowalczyk", 26, 2000, 5));


            pracownicy.Add(new MenadzerProjektu(1135, "Wioletta", "Krawczyk", 25, 9000, 2));
            pracownicy.Add(new MenadzerProjektu(1235, "Bartosz", "Kowalczyk", 26, 7000, 4));
            pracownicy.Add(new MenadzerProjektu(1335, "Gabriela", "Zbieć", 41, 6000, 5));
            pracownicy.Add(new MenadzerProjektu(1435, "Amelia", "Górecka", 28, 4000, 6));
            pracownicy.Add(new MenadzerProjektu(1535, "Karol", "Wojewódzki", 32, 5000, 7));


            pracownicy.Add(new Analityk(1236, "Szymon", "Maciejewski", 29, 6000, 6));
            pracownicy.Add(new Analityk(2236, "Karolina", "Jastrzębska", 29, 3000, 5));
            pracownicy.Add(new Analityk(3236, "Milena", "Bajura", 31, 3000, 7));
            pracownicy.Add(new Analityk(4236, "Wiktor", "Niedziółka", 35, 9000, 4));
            pracownicy.Add(new Analityk(5236, "Piotr", "Sitkowski", 38, 8000, 3));


            pracownicy.Add(new ZdalnyProgramista(8274, "Patrycja", "Wrona", 24, 6000, 6, 5));
            pracownicy.Add(new ZdalnyProgramista(8631, "Aleksander", "Osik", 26, 3000, 5, 3));
            pracownicy.Add(new ZdalnyProgramista(8233, "Olga", "Domańska", 36, 7000, 5, 8));
            pracownicy.Add(new ZdalnyProgramista(8532, "Krzysztof", "Kowalski", 31, 2000, 4, 2));
            pracownicy.Add(new ZdalnyProgramista(8339, "Kamil", "Wiśniewski", 29, 5000, 3, 5));


            /*foreach (var item in pracownicy)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Podwyzka(100));
                Console.WriteLine(item);
                Console.WriteLine();
            }*/

            string liczba = null;

            while (liczba != "8")
            {
                program.Menu();
                liczba = Console.ReadLine();

                switch (liczba)
                {
                    case "1":
                        program.ListaWszystkichPracownikow();
                        break;
                    case "2":
                        program.ListaPosortowanychPracownikow();
                        break;
                    case "3":
                        program.ListaStanowisk();
                        break;
                    case "4":
                        Console.WriteLine("Podaj numer identyfikacyjny pracownika:");
                        string numer = Console.ReadLine();
                        Console.WriteLine("Podaj kwotę:");
                        float kwota = float.Parse(Console.ReadLine());
                        int szukanyNumerIdentyfikacyjny = int.Parse(numer);
                        program.PodwyzkaDlaPracownika(szukanyNumerIdentyfikacyjny, kwota);
                        break;
                    case "5":
                        Console.WriteLine("Podaj kwotę:");
                        kwota = float.Parse(Console.ReadLine());
                        program.PodwyzkaWedlugStanowiska(kwota);
                        break;
                    case "6":
                        Console.WriteLine("Podaj kwotę:");
                        kwota = float.Parse(Console.ReadLine());
                        program.PodwyzkaDlaWszystkich(kwota);
                        break;
                    case "7":
                        program.Statystyki();
                        break;
                    default:
                        break;
                }

            }
            
        }

        private void Statystyki()
        {
            Program program = new Program();
            float kwota = 0;
            float lacznaKwota = 0;

            Console.WriteLine("Miesięczna i roczna kwota potrzebna na wypłaty dla pracowników każdego ze stanowisk:");
            Console.WriteLine("Analityk: ");
            foreach (var item in pracownicy)
            {
                Analityk szukajAnalitykow = item as Analityk;
                if (szukajAnalitykow != null)
                {
                    kwota += item.Pensja;
                    lacznaKwota += item.Pensja;
                }
            }
            Console.WriteLine($" - miesięczna {kwota}");
            Console.WriteLine($" - roczna {kwota * 12}");

            kwota = 0;
            Console.WriteLine("Menadżer projektu: ");
            foreach (var item in pracownicy)
            {
                MenadzerProjektu szukajMenadzerow = item as MenadzerProjektu;
                if (szukajMenadzerow != null)
                {
                    kwota += item.Pensja;
                    lacznaKwota += item.Pensja;
                }
            }
            Console.WriteLine($" - miesięczna {kwota}");
            Console.WriteLine($" - roczna {kwota * 12}");

            kwota = 0;
            Console.WriteLine("Programista: ");
            foreach (var item in pracownicy)
            {
                Programista szukajProgramistow = item as Programista;
                if (szukajProgramistow != null)
                {
                    kwota += item.Pensja;
                    lacznaKwota += item.Pensja;
                }
            }
            Console.WriteLine($" - miesięczna {kwota}");
            Console.WriteLine($" - roczna {kwota * 12}");

            kwota = 0;
            Console.WriteLine("Zdalny programista: ");
            foreach (var item in pracownicy)
            {
                ZdalnyProgramista szukajZdalnychProgramistow = item as ZdalnyProgramista;
                if (szukajZdalnychProgramistow != null)
                {
                    kwota += item.Pensja;
                    lacznaKwota += item.Pensja;
                }
            }
            Console.WriteLine($" - miesięczna {kwota}");
            Console.WriteLine($" - roczna {kwota * 12}");

            Console.WriteLine("Miesięczna i roczna kwota potrzebna na wypłaty dla wszystkich pracowników:");
            Console.WriteLine($" - miesięczna {lacznaKwota}");
            Console.WriteLine($" - roczna {lacznaKwota * 12}");

            Console.WriteLine();
        }

        private void PodwyzkaDlaWszystkich(float kwota)
        {
            foreach (var item in pracownicy)
            {
                item.Podwyzka(kwota);
            }
        }

        private void PodwyzkaWedlugStanowiska(float kwota)
        {
            Program program = new Program();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Analityk.");
            Console.WriteLine("2. Menadżer projektu.");
            Console.WriteLine("3. Programista.");
            Console.WriteLine("4. Zdalny programista.");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            string liczba = Console.ReadLine();


            switch (liczba)
            {
                case "1":
                    foreach (var item in pracownicy)
                    {
                        
                        if (item is Analityk)
                        {
                            item.Podwyzka(kwota);
                        }
                    }
                    break;
                case "2":
                    foreach (var item in pracownicy)
                    {
                        if (item is MenadzerProjektu)
                        {
                            item.Podwyzka(kwota);
                        }
                    }
                    break;
                case "3":
                    foreach (var item in pracownicy)
                    {
                        if (item is Programista)
                        {
                            item.Podwyzka(kwota);
                        }
                    }
                    break;
                case "4":
                    foreach (var item in pracownicy)
                    {
                        if (item is ZdalnyProgramista)
                        {
                            item.Podwyzka(kwota);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("ERROR! Wybierz liczbę 1-4 i wciśnij 'enter'");
                    ListaStanowisk();
                    break;
            }
            Console.WriteLine();
        }

        private void PodwyzkaDlaPracownika(int szukanyNumerIdentyfikacyjny, float kwota)
        {
            foreach (var item in pracownicy)
            {
                if (item.NumerIdentyfikacyjny == szukanyNumerIdentyfikacyjny)
                {
                    item.Podwyzka(kwota);
                }
            }
        }

        private void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("1. Lista wszystkich pracowników.");
            Console.WriteLine("2. Pracownicy posortowanie malejąco względem wysokości pensji.");
            Console.WriteLine("3. Lista pracowników wybranego działu.");
            Console.WriteLine("4. Zwiększenie pensji wybranego pracownika.");
            Console.WriteLine("5. Zwiększenie pensji dla pracowników na wybranym stanowisku.");
            Console.WriteLine("6. Zwiększenie pensji dla wszystkich pracowników.");
            Console.WriteLine("7. Statystyki dotyczące pensji.");
            Console.WriteLine("8. Zakończ.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void ListaStanowisk()
        {
            Program program = new Program();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Analityk.");
            Console.WriteLine("2. Menadżer projektu.");
            Console.WriteLine("3. Programista.");
            Console.WriteLine("4. Zdalny programista.");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            string liczba = Console.ReadLine();


            switch (liczba)
            {
                case "1":
                    foreach (var item in pracownicy)
                    {
                        Analityk szukajAnalitykow = item as Analityk;
                        if (szukajAnalitykow != null)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "2":
                    foreach (var item in pracownicy)
                    {
                        MenadzerProjektu szukajAnalitykow = item as MenadzerProjektu;
                        if (szukajAnalitykow != null)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "3":
                    foreach (var item in pracownicy)
                    {
                        Programista szukajAnalitykow = item as Programista;
                        if (szukajAnalitykow != null)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "4":
                    foreach (var item in pracownicy)
                    {
                        ZdalnyProgramista szukajAnalitykow = item as ZdalnyProgramista;
                        if (szukajAnalitykow != null)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("ERROR! Wybierz liczbę 1-4 i wciśnij 'enter'");
                    ListaStanowisk();
                    break;
            }
            Console.WriteLine();
        }

        private void ListaWszystkichPracownikow()
        {
            foreach (var item in pracownicy)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private void ListaPosortowanychPracownikow()
        {
            float maxPensja = 0;
            float kolejnaPensja = 0;
            foreach (var item in pracownicy)
            {
                if (maxPensja < item.Pensja)
                {
                    maxPensja = item.Pensja;
                }
            }

            foreach (var item in pracownicy)
            {
                foreach (var item1 in pracownicy)
                {
                    if (item1.Pensja == maxPensja)
                    {
                        Console.WriteLine(item1);
                    }
                }
                foreach (var item2 in pracownicy)
                {
                    if (kolejnaPensja <= item2.Pensja && maxPensja > item2.Pensja)
                    {
                        kolejnaPensja = item2.Pensja;
                    }
                }
                maxPensja = kolejnaPensja;
                kolejnaPensja = 0;
            }
            Console.WriteLine();
        }


    }
}
