using System;

class Program
{
    static void Main()
    {
        
        Random random = new Random();
        int gondoltSzam = random.Next(1, 101);

        Console.WriteLine("Gondoltam egy számra 1 és 100 között. Próbáld meg kitalálni!");

        int tipp;
        bool helyes = false;

        while (!helyes)
        {
            Console.Write("Tippelj egy számot: ");

           
            if (int.TryParse(Console.ReadLine(), out tipp))
            {
                if (tipp < 1 || tipp > 100)
                {
                    Console.WriteLine("A számnak 1 és 100 között kell lennie. Próbáld újra!");
                }
                else
                {
                    
                    if (tipp < gondoltSzam)
                    {
                        Console.WriteLine("Túl kicsi próbáld újra.");
                    }
                    else if (tipp > gondoltSzam)
                    {
                        Console.WriteLine("Túl nagy próbáld újra.");
                    }
                    else
                    {
                        Console.WriteLine($"Gratulálok eltaláltad a számot ({gondoltSzam}).");
                        helyes = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Érvénytelen bemenet. Kérlek írj be egy érvényes számot.");
            }
        }

        Console.ReadKey();
    }
}

