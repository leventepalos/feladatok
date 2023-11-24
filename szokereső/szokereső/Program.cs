using System;
using System.IO;
using System.Text;

namespace szokereső
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Szavak = new String[15];
            string[] Tippre_valasz = new String[6];
            bool Leall = false;
            string valasz;
            int darab = 1;
            int szamol = 0;

            StreamReader Beolvas = new StreamReader("szavak.txt", Encoding.Default);

            for (int i = 0; i < 15; i++)
            {
                Szavak[i] = Beolvas.ReadLine();
            }

            Beolvas.Close();

            Random Rnd = new Random();
            int index = Rnd.Next(0, 15);

            string Rejtett_szo = Szavak[index];
            Console.WriteLine(Rejtett_szo);

            Console.Write("Kérem a tippet: ");
            valasz = Console.ReadLine();
            if (valasz == "stop")
            {
                Leall = true;
            }

            while (Leall == false)
            {
                if (valasz == Rejtett_szo)
                {
                    Console.WriteLine("Az eredmény: {0}", Rejtett_szo);
                    Console.WriteLine("\n{0} tippeléssel sikerült kitalálni.", darab);
                    Leall = true;
                }

                for (int i = 0; i < 6; i++)
                {
                    string betu_valasz = valasz.Substring(i, 1);
                    string betu_rejtett = Rejtett_szo.Substring(i, 1);

                    if (betu_valasz == betu_rejtett)
                    {
                        Tippre_valasz[i] = betu_valasz;
                    }
                    else
                    {
                        Tippre_valasz[i] = ".";
                    }
                }

                darab++;

                for (int i = 0; i < 6; i++)
                {
                    if (Tippre_valasz[i] == Rejtett_szo.Substring(i, 1))
                    {
                        szamol++;
                    }
                }

                if (szamol == 6)
                {
                    Console.WriteLine("Az eredmény: {0}", Rejtett_szo);
                    Console.WriteLine("\n{0} tippeléssel sikerült kitalálni.", darab);
                    Leall = true;
                }
                else
                {
                    Console.Write("Az eredmény: ");
                    for (int i = 0; i < 6; i++)
                    {
                        Console.Write(Tippre_valasz[i]);
                    }
                    Console.Write("\n\nKérem a tippet: ");
                    valasz = Console.ReadLine();
                    if (valasz == "stop")
                    {
                        Leall = true;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}

