using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sila = 1;
            int szybkosc = 0;
            int pancerz = 0;
            int zycie = 1;
            int szczescie = 0;

            Console.WriteLine("WITAJ! Jak sie nazywasz?");
            string imie = Console.ReadLine();
            Console.WriteLine($"A wiec {imie} rozdziel swoje punkty (masz ich 5): ");
            Console.WriteLine($"SILA - zwiekza obrazenia twojego ataku, posiadasz {sila} punktow");
            Console.WriteLine($"SZYBKOSC - zwieksza szanse na pdwojny atak, posiadasz {szybkosc} punktow");
            Console.WriteLine($"PANCERZ - zmniejsza obrazenia zadawanwe przez przeciwnika, posiadasz {pancerz} punktow");
            Console.WriteLine($"ZYCIE - zwieksze twoje maksymalne HP, posiadasz {zycie} punktow");
            Console.WriteLine($"SZCZESCIE - zwieksza towje szanse na cios krytyczny (cios krytyczny zadaje 200% obrazen), posiadasz {szczescie} punktow");
            Console.WriteLine("Jeden punkt szybkosci, pancerza lub szczecia wynosi 10%, a twoje poczatkowe HP ynosi 100, kazdy dodatkowy punkt daje ci 15 punktow zycia");
            Console.WriteLine("");
            Console.WriteLine("Aby dodac punkt do sily nacisnij 1, szybkosc - 2, pancerz - 3, zycie - 4, szczescie 5");
            

            for (int x = 1; x <= 5;  x++)
            {
                int staty = int.Parse(Console.ReadLine());
                switch (staty)
                {
                    case 1:
                        sila++;
                        break;
                    case 2:
                        szybkosc++;
                        break;
                    case 3:
                        pancerz++;
                        break;
                    case 4:
                        zycie++;
                        break;
                    case 5:
                        szczescie++;
                        break;
                    default:
                        Console.WriteLine("nic nie wybrales");
                        break;
                }
            }
            Console.WriteLine($"Twoje statystyki {imie} wygladaja tak:");
            Console.WriteLine($"SILA: {sila}");
            Console.WriteLine($"SZYBKOSC: {szybkosc}");
            Console.WriteLine($"PANCERZ: {pancerz}");
            Console.WriteLine($"ZYCIE: {zycie}");
            Console.WriteLine($"SZCZESCIE: {szczescie}");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Pierwsza walka {imie}: ");


            Console.ReadLine();
        }
    }
}
