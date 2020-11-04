using System;
using System.Text.RegularExpressions;

namespace Szamolo01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Lokális változók */
            String muvelet = "",
                valasz="";
            int szam1 = 0,
                szam2 = 0;
            bool tovabb = true;

            /* Reguláris kifejezés a műveleti jelek ellenőrzéséhez */
            Regex pattern = new Regex(@"^[+-/*]");

            // A számolás
            int szamol(int a, int b, string m)
            {
                switch (m)
                {
                    case "+":
                        return a + b;
                    case "-":
                        return a - b;
                    case "/":
                        return a / b;
                    case "*":
                        return a * b;
                }
                return 0;
            }


            // A program szerkezete
            while (tovabb)
            {
                Console.WriteLine("Kérek egy műveleti jelet (+-/*): ");
                muvelet = Console.ReadLine();
                if (!pattern.IsMatch(muvelet.Substring(0, 1)))
                {
                    Console.WriteLine("Nem műveleti jelet adott meg!");
                }
                else
                {
                    Console.WriteLine("Kérem az első számot: ");
                    try
                    {
                        szam1 = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            Console.WriteLine("Kérem a második számot: ");
                            szam2 = Convert.ToInt32(Console.ReadLine());

                            if (szam2==0)
                            {
                                Console.WriteLine("A szám nem lehet nulla!");
                            }
                            else
                            {
                                Console.WriteLine("A számítás eredménye: {0}", szamol(szam1, szam2, muvelet));
                            }
                        }
                        catch (Exception e)
                        {
                            throw;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Nem számot adott meg!");
                        Console.WriteLine(e.ToString());
                    }
                }

                Console.WriteLine("Folytatja (I/N): ");
                valasz = Console.ReadLine().ToLower().Substring(0,1);

                if (String.Compare(valasz,"n") == 0)
                {
                    Console.WriteLine("Köszönöm a játékot!");
                    tovabb = false;
                }

            }
        }
    }
}
