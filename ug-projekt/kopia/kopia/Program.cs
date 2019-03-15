using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt1
{
    class Gracz
    {
        public string imie;
        public string klasa;
        public int sila = 1;
        public int szybkosc = 1;
        public int pancerz = 1;
        public int zycie = 1;
        public int szczescie = 1;
        public int HP = 100;
        public int attackMnoznik = 7;
        public int attackPodstawowy()
        {
            int attack = sila * attackMnoznik;
            Random losowanie = new Random();
            int bonus = losowanie.Next(1, sila*(attackMnoznik-2));
            if (bonus <= 10)
            {
                attack = attack + bonus;
            }
            else {
                attack = attack - bonus;
            }
            
            return attack;
        }
        public int attack()
        {
            int attack = attackPodstawowy();

            if (attackszczescie() == true)
            {
                attack = attack * 2;
            }
            if (attackPodwojny() == true)
            {
                attack = attack * 2;
            }
            return attack;
        }
        public bool attackPodwojny(){
            Random losowanie = new Random();
            int losszybkosc = losowanie.Next(1, 15);
            if (losszybkosc <= szybkosc)
            {
                return true;
            }
            else { return false; }
        }
        public bool attackszczescie()
        {
            Random losowanie = new Random();
            int losszczescie = losowanie.Next(1, 20);
            if(losszczescie <= szczescie)
            {
                return true;
            }
            else { return false; }
        }
        public bool kontra()
        {
            Random losowanie = new Random();
            int losszczescie = losowanie.Next(1, 20);
            if (losszczescie <= 2)
            {
                return true;
            }
            else { return false; }
        }
        public int attackLekki()
        {
            int attackDefault = attack();

            int attackLekki;
            if(szybkosc > 2)
            {
                attackLekki = attackDefault * (szybkosc / 2);
            }
            else
            {
                attackLekki = attackDefault;
            }

            return attackLekki;
        }
        public int attackMocny()
        {
            int attackDefault = attack();

            int attackMocny;
            if (sila > 2)
            {
                attackMocny = attackDefault * (sila / 2) ;
            }
            else
            {
                attackMocny = attackDefault;
            }
            

            return attackMocny;
        }
    }
    class Gra
    {
        
        static void Main()
        {


            Gracz gracz = new Gracz();

            Console.WriteLine("WITAJ! Jak sie nazywasz?");
            //gracz.imie = Console.ReadLine();
            gracz.imie = "Rafał Dawidczyk";

            Console.WriteLine("Wybierz klasę postaci: 1-wojownik 2-mag 3-złodziej");

            int klasa = int.Parse(Console.ReadLine());
            switch (klasa)
            {
                case 1:
                    gracz.sila = 1;
                    gracz.szybkosc = 1;
                    gracz.HP = 500;
                    gracz.pancerz = 4;
                    gracz.szczescie = 1;
                    gracz.attackMnoznik = 5;
                    break;
                case 2:
                    gracz.sila = 1;
                    gracz.szybkosc = 3;
                    gracz.HP = 300;
                    gracz.pancerz = 1;
                    gracz.szczescie = 3;
                    break;
                case 3:
                    gracz.sila = 1;
                    gracz.szybkosc = 3;
                    gracz.HP = 200;
                    gracz.pancerz = 2;
                    gracz.szczescie = 3;
                    break;
                case 5:
                default:
                    gracz.sila = 1;
                    gracz.szybkosc = 1;
                    gracz.HP = 100;
                    gracz.pancerz = 1;
                    gracz.szczescie = 1;
                    break;
            }
            Console.WriteLine($"A wiec {gracz.imie} rozdziel swoje punkty (masz ich 5): ");
            Console.WriteLine($"SILA - zwiekza obrazenia twojego ataku, posiadasz {gracz.sila} punktow");
            Console.WriteLine($"SZYBKOSC - zwieksza szanse na pdwojny atak, posiadasz {gracz.szybkosc} punktow");
            Console.WriteLine($"PANCERZ - zmniejsza obrazenia zadawanwe przez przeciwnika, posiadasz {gracz.pancerz} punktow");
            Console.WriteLine($"ZYCIE - zwieksze twoje maksymalne HP, posiadasz {gracz.zycie} punktow");
            Console.WriteLine($"SZCZESCIE - zwieksza towje szanse na cios krytyczny (cios krytyczny zadaje 200% obrazen), posiadasz {gracz.szczescie} punktow");
            Console.WriteLine("Jeden punkt szybkosci lub szczescie wynosi 10%, pancerz obniza atak przeciwika o 20%, 1 pkt ataku wynosi 7, bazowe hp wynosi 100 kazdy dodatkowy punkt zwieksza hp o 20");
            Console.WriteLine("");
            Console.WriteLine("Aby dodac punkt do sily nacisnij 1, szybkosc - 2, pancerz - 3, zycie - 4, szczescie 5");


            for (int x = 1; x <= 5; x++)
            {
                int staty = int.Parse(Console.ReadLine());
                switch (staty)
                {
                    case 1:
                        gracz.sila++;
                        break;
                    case 2:
                        gracz.szybkosc++;
                        break;
                    case 3:
                        gracz.pancerz++;
                        break;
                    case 4:
                        gracz.zycie++;
                        break;
                    case 5:
                        gracz.szczescie++;
                        break;
                    default:
                        Console.WriteLine("nic nie wybrales");
                        x++;
                        break;
                }
            }
            Console.WriteLine($"Twoje statystyki {gracz.imie} wygladaja tak:");
            Console.WriteLine($"SILA: {gracz.sila}");
            Console.WriteLine($"SZYBKOSC: {gracz.szybkosc}");
            Console.WriteLine($"PANCERZ: {gracz.pancerz}");
            Console.WriteLine($"ZYCIE: {gracz.zycie}");
            Console.WriteLine($"SZCZESCIE: {gracz.szczescie}");
            Console.ReadLine();

            walka1();
            void walka1()
            {
                Gracz przeciwnik1 = new Gracz();
                przeciwnik1.imie = "Tymoteusz Hinca";
                przeciwnik1.sila = 3;
                przeciwnik1.HP = 400;
                przeciwnik1.pancerz = 6;

                Console.Clear();
                Console.WriteLine($"Pierwsza walka {gracz.imie} z {przeciwnik1.imie} ");
                Console.WriteLine("");
                Console.ReadLine();

                for (int numberRound = 1; numberRound < 100; numberRound++)
                {
                    Console.WriteLine($"RUNDA {numberRound}");

                    Console.WriteLine("Wybierz typ ataku:");
                    Console.WriteLine("Cięzki: 1");
                    Console.WriteLine("Sredni: 2");
                    Console.WriteLine("Szybki: 3");
                    Console.WriteLine("W przypadku nie wybrania zadnego z powyzszych atakow wybrana zostaje obrona");

                    int wyborAtaku = int.Parse(Console.ReadLine());
                    //int staty = int.Parse(Console.ReadLine());
                    int attack1, attack2;
                    bool obrona1 = false;
                    bool obrona2 = false;

                    Random losowanie = new Random();
                    int wyborprzeciwnika = losowanie.Next(1, 4);

                    switch (wyborAtaku)
                    {
                        case 1:
                            attack1 = (gracz.attackMocny() * (1 - przeciwnik1.pancerz / 10));
                            break;
                        case 2:
                            attack1 = (gracz.attack() * (1 - przeciwnik1.pancerz / 10));
                            break;
                        case 3:
                            attack1 = (gracz.attackLekki() * (1 - przeciwnik1.pancerz / 10));
                            break;
                        default:
                            attack1 = 0;
                            obrona1 = true;
                            break;
                    }
                    switch (wyborprzeciwnika)
                    {
                        case 1:
                            attack2 = (przeciwnik1.attackMocny() * (1 - gracz.pancerz / 10));
                            break;
                        case 2:
                            attack2 = (przeciwnik1.attack() * (1 - gracz.pancerz / 10));
                            break;
                        case 3:
                            attack2 = (przeciwnik1.attackLekki() * (1 - gracz.pancerz / 10));
                            break;
                        default:
                            attack2 = 0;
                            obrona2 = true;
                            break;
                    }

                    //int attack1 = (gracz.attack() * (1 - przeciwnik1.pancerz / 10));
                    if (przeciwnik1.kontra() == false)
                    {
                        if(obrona2 == false)
                        {
                            przeciwnik1.HP = przeciwnik1.HP - attack1;
                            Console.WriteLine($"Zadajesz {attack1} obrazen!");
                        }
                        else
                        {
                            Console.WriteLine($"Przeciwnik blokuje atak!");
                        }
                        
                    }
                    else
                    {
                        gracz.HP = gracz.HP - attack1;
                        Console.WriteLine($"Kontra! {przeciwnik1.imie} zadaje ci {attack1} obrazen!");
                    }

                    if (przeciwnik1.HP <= 0)
                    {
                        Console.WriteLine($"Wygrałeś");
                        Console.WriteLine("Aby dodac punkt do sily nacisnij 1, szybkosc - 2, pancerz - 3, zycie - 4, szczescie 5");


                        for (int x = 1; x <= 3; x++)
                        {
                            int staty = int.Parse(Console.ReadLine());
                            switch (staty)
                            {
                                case 1:
                                    gracz.sila++;
                                    break;
                                case 2:
                                    gracz.szybkosc++;
                                    break;
                                case 3:
                                    gracz.pancerz++;
                                    break;
                                case 4:
                                    gracz.zycie++;
                                    break;
                                case 5:
                                    gracz.szczescie++;
                                    break;
                                default:
                                    Console.WriteLine("nic nie wybrales");
                                    x++;
                                    break;
                            }
                        }
                        walka2();
                        break;
                    }
                    Console.WriteLine($"Przeciwnikowi zostało {przeciwnik1.HP} ");

                    //int attack2 = (przeciwnik1.attack() * (1 - gracz.pancerz / 10));
                    if (gracz.kontra() == false)
                    {
                        if (obrona1 == false)
                        {
                            gracz.HP = gracz.HP - attack2;
                            Console.WriteLine($"Przeciwnik zadaje Ci {attack2} obrazen!");
                        }
                        else
                        {
                            Console.WriteLine($"Blokujesz atak!");
                        }
                        
                    }
                    else
                    {
                        przeciwnik1.HP = przeciwnik1.HP - attack2;
                        Console.WriteLine($"Kontra! Zadajesz {attack2} obrazen!");
                    }

                    
                    if (gracz.HP <= 0)
                    {
                        Console.WriteLine($"Przegrałeś");
                        break;
                    }
                    Console.WriteLine($"Zostało ci {gracz.HP}");

                    
                    
                }
                

            }
            
            void walka2()
            {
                Gracz przeciwnik1 = new Gracz();
                przeciwnik1.imie = "Roman Kamilowski";
                przeciwnik1.sila = 4;
                przeciwnik1.HP = 500;
                przeciwnik1.pancerz = 7;

                Console.Clear();
                Console.WriteLine($"Druga walka {gracz.imie} z {przeciwnik1.imie} ");
                Console.WriteLine("");
                gracz.HP = gracz.HP + 300;
                Console.WriteLine($"Twoje HP wynosi {gracz.HP}");
                Console.ReadLine();

                for (int numberRound = 1; numberRound < 100; numberRound++)
                {
                    Console.WriteLine($"RUNDA {numberRound}");

                    Console.WriteLine("Wybierz typ ataku:");
                    Console.WriteLine("Cięzki: 1");
                    Console.WriteLine("Sredni: 2");
                    Console.WriteLine("Szybki: 3");
                    Console.WriteLine("W przypadku nie wybrania zadnego z powyzszych atakow wybrana zostaje obrona");

                    int wyborAtaku = int.Parse(Console.ReadLine());
                    //int staty = int.Parse(Console.ReadLine());
                    int attack1, attack2;
                    bool obrona1 = false;
                    bool obrona2 = false;

                    Random losowanie = new Random();
                    int wyborprzeciwnika = losowanie.Next(1, 4);

                    switch (wyborAtaku)
                    {
                        case 1:
                            attack1 = (gracz.attackMocny() * (1 - przeciwnik1.pancerz / 10));
                            break;
                        case 2:
                            attack1 = (gracz.attack() * (1 - przeciwnik1.pancerz / 10));
                            break;
                        case 3:
                            attack1 = (gracz.attackLekki() * (1 - przeciwnik1.pancerz / 10));
                            break;
                        default:
                            attack1 = 0;
                            obrona1 = true;
                            break;
                    }
                    switch (wyborprzeciwnika)
                    {
                        case 1:
                            attack2 = (przeciwnik1.attackMocny() * (1 - gracz.pancerz / 10));
                            break;
                        case 2:
                            attack2 = (przeciwnik1.attack() * (1 - gracz.pancerz / 10));
                            break;
                        case 3:
                            attack2 = (przeciwnik1.attackLekki() * (1 - gracz.pancerz / 10));
                            break;
                        default:
                            attack2 = 0;
                            obrona2 = true;
                            break;
                    }

                    //int attack1 = (gracz.attack() * (1 - przeciwnik1.pancerz / 10));
                    if (przeciwnik1.kontra() == false)
                    {
                        if (obrona2 == false)
                        {
                            przeciwnik1.HP = przeciwnik1.HP - attack1;
                            Console.WriteLine($"Zadajesz {attack1} obrazen!");
                        }
                        else
                        {
                            Console.WriteLine($"Przeciwnik blokuje atak!");
                        }

                    }
                    else
                    {
                        gracz.HP = gracz.HP - attack1;
                        Console.WriteLine($"Kontra! {przeciwnik1.imie} zadaje ci {attack1} obrazen!");
                    }

                    if (przeciwnik1.HP <= 0)
                    {
                        Console.WriteLine($"Wygrałeś");
                        Console.WriteLine("Aby dodac punkt do sily nacisnij 1, szybkosc - 2, pancerz - 3, zycie - 4, szczescie 5");


                        for (int x = 1; x <= 3; x++)
                        {
                            int staty = int.Parse(Console.ReadLine());
                            switch (staty)
                            {
                                case 1:
                                    gracz.sila++;
                                    break;
                                case 2:
                                    gracz.szybkosc++;
                                    break;
                                case 3:
                                    gracz.pancerz++;
                                    break;
                                case 4:
                                    gracz.zycie++;
                                    break;
                                case 5:
                                    gracz.szczescie++;
                                    break;
                                default:
                                    Console.WriteLine("nic nie wybrales");
                                    x++;
                                    break;
                            }
                        }
                        break;
                    }
                    Console.WriteLine($"Przeciwnikowi zostało {przeciwnik1.HP} ");

                    //int attack2 = (przeciwnik1.attack() * (1 - gracz.pancerz / 10));
                    if (gracz.kontra() == false)
                    {
                        if (obrona1 == false)
                        {
                            gracz.HP = gracz.HP - attack2;
                            Console.WriteLine($"Przeciwnik zadaje Ci {attack2} obrazen!");
                        }
                        else
                        {
                            Console.WriteLine($"Blokujesz atak!");
                        }

                    }
                    else
                    {
                        przeciwnik1.HP = przeciwnik1.HP - attack2;
                        Console.WriteLine($"Kontra! Zadajesz {attack2} obrazen!");
                    }


                    if (gracz.HP <= 0)
                    {
                        Console.WriteLine($"Przegrałeś");
                        break;
                    }
                    Console.WriteLine($"Zostało ci {gracz.HP}");



                }


            }


            Console.ReadLine();       
        }
        
    }
}