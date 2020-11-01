using System;
using System.Dynamic;

namespace schleife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie eine Zahl gößer gleich 10 und kleiner als 10000 ein: ");
            int zahl = Convert.ToInt32(Console.ReadLine());
            //ob diese Zahl zwischen 10 und 10000.
            while (zahl < 10 || zahl >= 10000)
            {
                Console.WriteLine("Ungültige Eingabe, bitte wiederholen.");
                Console.WriteLine(); Console.WriteLine();
                Console.Write("Geben Sie eine Zahl gößer gleich 10 und kleiner als 10000 ein: ");
                zahl = Convert.ToInt32(Console.ReadLine());
            }

            // Falls diese Zahl kleiner als 1000 ist, ist das Liste von 50-er.
            if (zahl < 1000)
            {
                Console.WriteLine("50 - er kleiner als " + zahl);
                for (int i = 1000; i > 1; i--)
                {
                    if (i % 50 == 0 && i < zahl)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            // Falls diese Zahl kleiner als 1000 ist, ist das Liste von 500-er.
            else if (zahl > 1000 && zahl < 10000)
            {
                Console.WriteLine("500 - er kleiner als " + zahl);
                for (int i = 10000; i > 1; i--)
                {
                    if (i % 500 == 0 && i <= zahl)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            int total = 0;
            Console.WriteLine();
            Console.WriteLine("Teiler von " + zahl + ":");
            for (int j = 2; j <= zahl - 1; j++)
            {
                if (zahl % j == 0)
                {
                    Console.WriteLine(j);
                    total += j;
                }

            }
            if (total > 0)
            {
                Console.WriteLine("Die Summe aller echten Teiler von " + zahl + " ist " + total + ".");
            }
            else
            {
                Console.WriteLine("Die Zahl ist " + zahl + " eine Primzahl.");
            }
            Console.WriteLine();
            //Anzahl der geraden und ungeraden Ziffern    
            int rest;
            int anzGeradezahl = 0;
            int anzUngeradezahl = 0;
            int zahl1 = zahl;
            while (zahl1 >= 1)
            {
                rest = zahl1 % 2;
                if (rest == 0)
                {
                    anzGeradezahl++;
                }
                else
                {
                    anzUngeradezahl++;
                }
                zahl1 /= 10;
            }
            Console.WriteLine("Die Zahl " + zahl + " hat  " + anzGeradezahl + " gerade und " + anzUngeradezahl + " ungerade Ziffern.");
            Console.WriteLine();
            // Das Finden von der ersten und letzten Ziffern
            int zahl2 = zahl;
            int ersteZiffer;
            ersteZiffer = zahl2 % 10;
            while (zahl2 > 9)
            {
                zahl2 /= 10;
            }
            Console.WriteLine("Das Produkt der ersten und letzten Ziffer von " + zahl + " ist " + ersteZiffer + "*" + zahl2 + "= " + (zahl2 * ersteZiffer));






























        }
    }
}
