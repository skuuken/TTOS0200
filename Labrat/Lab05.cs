using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab05
    {
        public class Tire
        {
            public string Name { get; set; }
            public string Model { get; set; }
            public string TireSize { get; set; }

            public Tire()
            {

            }
            public Tire(string name, string model, string tiresize)
            {
                Name = name;
                Model = model;
                TireSize = tiresize;
            }
            public override string ToString()
            {
                return "Name: " + Name + " Model: " + Model + " TireSize: " + TireSize;
            }
        }
        public class Vehicle
        {
            public string Name { get; set; }
            public string Model { get; set; }
            public List<Tire> Tires;

            public Vehicle()
            {
                Tires = new List<Tire>();
            }
            public override string ToString()
            {
                string retval = "Ajoneuvo " + Name + " käyttää renkaita: \n";
                foreach (Tire rengas in Tires)
                {
                    retval += rengas.ToString() + "\n";
                }
                return retval;
            }
        }
        public static void TestaaRenkaat()
        {
            Vehicle vehje1 = new Vehicle();
            vehje1.Name = "Porsche";
            vehje1.Model = "911";
            Console.WriteLine("Created a new vehicle " + vehje1.Name + " model " + vehje1.Model);
            vehje1.Tires.Add(new Tire("Nokia", "Hakkapeliitta", "205R16"));
            vehje1.Tires.Add(new Tire("Nokia", "Hakkapeliitta", "205R16"));
            vehje1.Tires.Add(new Tire("Nokia", "Hakkapeliitta", "205R16"));
            vehje1.Tires.Add(new Tire("Nokia", "Hakkapeliitta", "205R16"));
            Console.WriteLine(vehje1.ToString());

            Vehicle vehje2 = new Vehicle();
            vehje2.Name = "Ducati";
            vehje2.Model = "Diavel";
            Console.WriteLine("Created a new vehicle " + vehje2.Name + " model " + vehje2.Model);
            vehje2.Tires.Add(new Tire("MIC", "Pilot", "160R17"));
            vehje2.Tires.Add(new Tire("MIC", "Pilot", "140R16"));
            Console.WriteLine(vehje2.ToString());
        }
        public class Fridge
        {
            public string Name { get; set; }
            public string Model { get; set; }
            public List<Food> Foods;
            public List<Drink> Drinks;


            public Fridge()
            {
                Foods = new List<Food>();
                Drinks = new List<Drink>();
            }
            public override string ToString()
            {
                string retval = "Name: " + Name + " malli: " + Model + " sisältää \n";
                foreach (Food ruoka in Foods)
                {
                    retval += ruoka.ToString() + "\n";
                }
                foreach (Drink juoma in Drinks)
                {
                    retval += juoma.ToString() + "\n";
                }
                return retval;
            }
        }
        public class Food
        {
            public string Name { get; set; }
            public string ExpDate { get; set; }

            public Food(string name, string expdate)
            {
                Name = name;
                ExpDate = expdate;
            }
            public Food()
            {
            }
            public override string ToString()
            {
                return "FOOD: " + Name + " ExpirationDate: " + ExpDate;
            }
        }
        public class Drink
        {
            public string Name { get; set; }
            public string BottleSize { get; set; }

            public Drink(string name, string bottlesize)
            {
                Name = name;
                BottleSize = bottlesize;
            }
            public Drink()
            {
            }
            public override string ToString()
            {
                return "DRINK: " + Name + " BottleSize: " + BottleSize;
            }
        }
        public static void JaaKaappi()
        {
            Fridge samsung = new Fridge();
            samsung.Name = "Samsung";
            samsung.Model = "RB7000";
            samsung.Foods.Add(new Food("Makaronipulimössö", "20.7.1969"));
            samsung.Drinks.Add(new Drink("Pirkka Olut", "0,33L"));
            samsung.Drinks.Add(new Drink("Pirkka Olut", "0,33L"));
            samsung.Drinks.Add(new Drink("Pirkka Olut", "0,33L"));
            samsung.Drinks.Add(new Drink("Pirkka Olut", "0,33L"));
            Console.WriteLine(samsung.ToString());
        }
        public class Pelaaja
        {
            public string Etunimi { get; set; }
            public string Sukunimi { get; set; }
            public string Pelipaikka { get; set; }
            public string Katisyys { get; set; }

            public Pelaaja(string etunimi, string sukunimi, string pelipaikka, string katisyys)
            {
                Etunimi = etunimi;
                Sukunimi = sukunimi;
                Pelipaikka = pelipaikka;
                Katisyys = katisyys;
            }
            public Pelaaja()
            {
            }
            public override string ToString()
            {
                return Etunimi + " " + Sukunimi + " " + Pelipaikka + " " + Katisyys;
            }
        }
        public class Seura
        {
            public string Nimi { get; set; }
            public string Kaupunki { get; set; }
            public List<Pelaaja> Pelaajat;

            public Seura()
            {
                Pelaajat = new List<Pelaaja>();
            }
            public Seura(string nimi, string kaupunki)
            {
                Nimi = nimi;
                Kaupunki = kaupunki;
            }
            public override string ToString()
            {
                string retval = "Seura: " + Nimi + " Kaupungista: " + Kaupunki + "\n";
                foreach (Pelaaja pleijeri in Pelaajat)
                {
                    retval += pleijeri.ToString() + "\n";
                }
                return retval;
            }
        }
        public static void TestaaSeura()
        {
            Seura saipa = new Seura();
            saipa.Nimi = "SaiPa";
            saipa.Kaupunki = "Lappeenranta";
            saipa.Pelaajat.Add(new Pelaaja("Jussi", "Markkanen", "MV", "L"));
            saipa.Pelaajat.Add(new Pelaaja("Kasperi", "Torikka", "VP", "L"));
            saipa.Pelaajat.Add(new Pelaaja("Lasse", "Lappalainen", "OP", "L"));
            saipa.Pelaajat.Add(new Pelaaja("Ville", "Koho", "KH", "L"));
            saipa.Pelaajat.Add(new Pelaaja("Joni", "Nikko", "VL", "L"));
            saipa.Pelaajat.Add(new Pelaaja("Valtteri", "Virkkunen", "VL", "L"));

            Seura jyp = new Seura();
            jyp.Nimi = "JYP";
            jyp.Kaupunki = "Jyväskylä";
            jyp.Pelaajat.Add(new Pelaaja("Eetu", "Laurikainen", "MV", "L"));
            jyp.Pelaajat.Add(new Pelaaja("Mikko", "Kalteva", "VP", "L"));
            jyp.Pelaajat.Add(new Pelaaja("Juuso", "Vainio", "OP", "R"));
            jyp.Pelaajat.Add(new Pelaaja("Joonas", "Nättinen", "KH", "R"));
            jyp.Pelaajat.Add(new Pelaaja("Juuso", "Puustinen", "OL", "R"));
            jyp.Pelaajat.Add(new Pelaaja("Jani", "Tuppurainen", "VL", "L"));

            Console.WriteLine("Kumman seuran pelaajat haluat tulostaa? (1: JYP, 2: SaiPa)");
            int valinta = int.Parse(Console.ReadLine());
            if (valinta == 1)
            {
            Console.WriteLine(jyp.ToString() + "jne jne \n");
            }
            else if (valinta == 2)
            {
            Console.WriteLine(saipa.ToString() + "jne jne \n");
            }
            else
            {
                Console.WriteLine("Nou nou");
            }
        }
        abstract class Nisakas
        {
            public int Ika { get; set; }

            public abstract void Liiku();
        }
        class Ihminen : Nisakas
        {
            public string Nimi { get; set; }
            public int Pituus { get; set; }
            public int Paino { get; set; }

            public Ihminen(string nimi, int pituus, int paino)
            {
                Nimi = nimi;
                Pituus = pituus;
                Paino = paino;
            }
            public Ihminen()
            {

            }
            public int Kasva()
            {
                Ika = Ika + 1;
                return Ika;
            }

            public override void Liiku()
            {
                Console.WriteLine("Liikun");
            }
        }
        class Vauva : Ihminen
        {
            public string Vaippa { get; set; }

            public Vauva(string nimi, int pituus, int paino)
                :  base (nimi, pituus, paino)
            {
                
            }
            public Vauva()
            {

            }
            public override void Liiku()
            {
                Console.WriteLine("Konttaa");
            }
        }
        class Aikuinen : Ihminen
        {
            public string Auto { get; set; }

            public Aikuinen(string nimi, int pituus, int paino)
                :  base (nimi, pituus, paino)
            {

            }

            public override void Liiku()
            {
                Console.WriteLine("Kävelee");
            }
        }
        public static void TestaaElukat()
        {
            Ihminen koe = new Ihminen("Ernesti", 160, 113);
            koe.Ika = 42;
            Console.WriteLine("Uusi ihminen luotu, nimi:" + koe.Nimi + " ikä:" + koe.Ika + " pituus:" + koe.Pituus + " paino:" + koe.Paino);
            koe.Liiku();
            koe.Kasva();
            Console.WriteLine("Ikäsi on nyt: " + koe.Ika + "\n");

            Vauva koe2 = new Vauva("Pikku Petteri", 30, 10);
            koe2.Vaippa = "Viikon vanhat";
            Console.WriteLine("Uusi vauva luotu, nimi:" + koe2.Nimi + " ikä:" + koe2.Ika + " pituus:" + koe2.Pituus + " paino:" + koe2.Paino + " vaipat:" + koe2.Vaippa);
            koe2.Liiku();
            koe2.Liiku();
            koe2.Kasva();
            koe2.Kasva();
            Console.WriteLine("Ikäsi on: " + koe2.Ika + "\n");

            Aikuinen koe3 = new Aikuinen("Olof", 201, 99);
            koe3.Auto = "Nissan Micra";
            koe3.Ika = 25;
            Console.WriteLine("Uusi aikuinen luotu, nimi:" + koe3.Nimi + " ikä:" + koe3.Ika + " pituus:" + koe3.Pituus + " paino:" + koe3.Paino + " auto:" + koe3.Auto);
            koe3.Liiku();
            koe3.Kasva();
            Console.WriteLine("Ikäsi on nyt: " + koe3.Ika);

        }
    }
}
