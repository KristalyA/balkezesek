using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string beolvasas = "balkezesek.csv";
        List<Dictionary<string, string>> adatok = new List<Dictionary<string, string>>();

        if (File.Exists(beolvasas))
        {
            string[] sorok = File.ReadAllLines(beolvasas);

            if (sorok.Length > 0)
            {
                string[] fejlec = sorok[0].Split(',');

                for (int i = 1; i < sorok.Length; i++)
                {
                    string[] adatSor = sorok[i].Split(',');
                    Dictionary<string, string> adatSorDict = new Dictionary<string, string>();

                    for (int j = 0; j < fejlec.Length; j++)
                    {
                        if (j < adatSor.Length)
                        {
                            adatSorDict[fejlec[j]] = adatSor[j];
                        }
                        else
                        {
                            adatSorDict[fejlec[j]] = string.Empty;
                        }
                    }

                    adatok.Add(adatSorDict);
                }

                Console.WriteLine("3. feladat");
                Console.WriteLine($"{adatok.Count}");

                Console.WriteLine("4. feladat");


                Console.WriteLine("5. feladat");

                int evszam;
                bool ervenyesEvszam = false;

                while (!ervenyesEvszam)
                {
                    Console.Write("Kérem adjon meg egy évszámot (1990 és 1999 között): ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out evszam) && evszam >= 1990 && evszam <= 1999)
                    {
                        ervenyesEvszam = true;
                    }
                    else
                    {
                        Console.WriteLine("Hibás adat, kérek egy 1990 és egy 1999 közötti évszámot!");
                    }
                }

                Console.WriteLine("6. feladat");
            }
            else
            {
                Console.WriteLine("Az állomány üres.");
            }
        }
        else
        {
            Console.WriteLine("Az állomány nem található.");
        }
    }
}
