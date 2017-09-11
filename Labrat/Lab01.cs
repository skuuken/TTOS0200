using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Olio-ohjelmoinnin tehtävät Labra 1
//Saku Hopponen
namespace Labrat
{
    class Lab01
    {
        public static void Tehtava1()
        {
            //tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".
            int luku;

            Console.WriteLine("Anna luku: ");
            luku = int.Parse(Console.ReadLine());
            if (luku == 1)
            {
                Console.WriteLine("Annoit luvun yksi");
            }
            if (luku == 2)
            {
                Console.WriteLine("Annoit luvun kaksi");
            }
            if (luku == 3)
            {
                Console.WriteLine("Annoit luvun kolme");
            }
            if (luku != 1 && luku != 2 && luku != 3)
            {
                Console.WriteLine("ANNA JOKU MUU LUKU");
            }
        }
        public static void Tehtava2()
        {
            //Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron)
            int pisteet;

            Console.WriteLine("Anna pistemäärä: ");
            pisteet = int.Parse(Console.ReadLine());
            if (pisteet >= 0 && pisteet <= 1)
            {
                Console.WriteLine("Koulunumero on 0");
            }
            if (pisteet >= 2 && pisteet <= 3)
            {
                Console.WriteLine("Koulunumero on 1");
            }
            if (pisteet >= 4 && pisteet <= 5)
            {
                Console.WriteLine("Koulunumero on 2");
            }
            if (pisteet >= 6 && pisteet <= 7)
            {
                Console.WriteLine("Koulunumero on 3");
            }
            if (pisteet >= 8 && pisteet <= 9)
            {
                Console.WriteLine("Koulunumero on 4");
            }
            if (pisteet >= 10 && pisteet <= 12)
            {
                Console.WriteLine("Koulunumero on 5");
            }
        }
        public static void Tehtava3()
        {
            //Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.
            double luku1, luku2, luku3, summa, keskiarvo;
            Console.WriteLine("Anna 1. luku ");
            luku1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Anna 2. luku ");
            luku2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Anna 3. luku ");
            luku3 = double.Parse(Console.ReadLine());
            summa = luku1 + luku2 + luku3;
            keskiarvo = summa / 3;
            Console.WriteLine("Summa on " + summa + " ja keskiarvo on " + keskiarvo);

        }
        public static void Tehtava4()
        {
            //Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
            int ika;
            Console.WriteLine("Anna ikä ");
            ika = int.Parse(Console.ReadLine());
            if (ika < 18)
            {
                Console.WriteLine("ALAIKÄINEN");
            }
            if (ika >= 18 && ika <= 65)
            {
                Console.WriteLine("AIKUINEN");
            }
            if (ika > 65)
            {
                Console.WriteLine("SENIORI");
            }
        }
        public static void Tehtava5()
        {
            //Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä.
            int sekunnit, sekunnit2, minuutit, tunnit;
            Console.WriteLine("Anna sekunnit ");
            sekunnit = int.Parse(Console.ReadLine());
            sekunnit2 = sekunnit % 60;
            minuutit = sekunnit2 % 60;
            tunnit = sekunnit / 3600;

            Console.WriteLine("Antamasi sekunnit voidaan ilmaista muodossa: " + tunnit + " tuntia " + minuutit + " minuuttia " + sekunnit2 + " sekuntia ");

        }
        public static void Tehtava6()
        {
            //Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa.Tee ohjelma, joka tulostaa ajetulla matkalla(kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.
            int matka;
            double bensa, kustannus;
            Console.WriteLine("Anna matka: ");
            matka = int.Parse(Console.ReadLine());
            bensa = 7.02 / 100 * matka;
            kustannus = bensa * 1.595;
            Console.WriteLine("Bensaa kuluu " + bensa + " litraa, kustannus " + kustannus + " euroa");
        }
        public static void Tehtava7()
        {
            //Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
            int vuosi;
            Console.WriteLine("Anna vuosi :");
            vuosi = int.Parse(Console.ReadLine());
            if (vuosi % 4 == 0 || vuosi % 400 == 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
            else
            {
                Console.WriteLine("EI OLE KARKAUSVUOSI");
            }
        }
        public static void Tehtava8()
        {
            //Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
            int luku1, luku2, luku3;
            Console.WriteLine("Anna luku: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku: ");
            luku3 = int.Parse(Console.ReadLine());

            if (luku1 > luku2 && luku1 > luku3)
            {
                Console.WriteLine(luku1);
            }
            if (luku2 > luku1 && luku2 > luku3)
            {
                Console.WriteLine(luku2);
            }
            if (luku3 > luku1 && luku3 > luku2)
            {
                Console.WriteLine(luku3);
            }
        }
        public static void Tehtava9()
        {
            //Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
            int luku, summa = 0;
            do
            {
                Console.WriteLine("Anna luku: ");
                luku = int.Parse(Console.ReadLine());
                summa = summa + luku;
            } while (luku != 0);
            Console.WriteLine(summa);
        }
        public static void Tehtava10()
        {
            //Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.
            int[] luvut = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            foreach (int i in luvut)
            {
                Console.WriteLine(i);
                if (i % 2 == 0)
                {
                    Console.WriteLine("HEP");
                }
            }
        }
        public static void Tehtava11()
        {
            //Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion. Käyttäjä antaa syötteenä tähtirivien lukumäärän.
            int luku, j;
            Console.WriteLine("Anna luku: ");
            luku = int.Parse(Console.ReadLine());
            for (int i = 0; i < luku; i++)
            {
                Console.WriteLine("*");
                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
            }
        }
        public static void Tehtava12()
        {
            //Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
            int[] luvut = new int[5];
            for (int i=0; i<luvut.Length; i++)
            {
                Console.WriteLine("Anna luku: ");
                luvut[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Luvut ovat: ");
            for (int j=4; j>=0; j--)
            {
                Console.Write(luvut[j] + " ");
            }
        }
        public static void Tehtava13()
        {
            //Mäkihypyssä käytetään viittä arvostelutuomaria. Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, että summasta on vähennetty pois pienin ja suurin tyylipiste
            int[] pisteet = new int[5];
            int summa;
            for (int i=0; i<pisteet.Length; i++)
            {
                Console.WriteLine("Anna pojot:");
                pisteet[i] = int.Parse(Console.ReadLine());
            }
            summa = pisteet.Sum();
            summa = summa - pisteet.Max() - pisteet.Min();

            Console.WriteLine("Kokonaispisteet ovat: " + summa);
        }
        public static void Tehtava14()
        {
            //KESKEN
            //Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon). Tulosta arvosanajakauma käyttäen tähtimerkkejä seuraavasti
            int[] arvosanat = new int[30];
            int luku=0;
            Console.WriteLine("Lopetus antamalla 9");
            for (int i = 0; luku != 9; i++)
            {
                Console.WriteLine("Anna arvosana (0-5):");
                luku = int.Parse(Console.ReadLine());
                arvosanat[i] = luku;
            }   
            Console.WriteLine("Arvosanat:");
            for (int j = 0; j < arvosanat.Length; j++)
            {
                luku = arvosanat[j];
                if (luku == 0)
                {
                    Console.Write("*");
                }
            }
        }

    }
}