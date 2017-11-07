using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab08
    {
        public class Dice
        {
            public int Tulos { get; set; }
            private static Random rng = new Random();

            public int Heita()
            {
                int dice = rng.Next(1, 7);
                Tulos = dice;
                return Tulos;
            }
        }
        public static void TestaaNoppa()
        {
            try
            {
                List<int> lista = new List<int>();
                Dice noppa = new Dice();
                Console.WriteLine("Eka heitto " + noppa.Heita());
                Console.WriteLine("Monta kertaa heitetään?");
                int input = int.Parse(Console.ReadLine());
                for (int i = 0; i < input; i++)
                {
                    lista.Add(noppa.Heita());
                }
                Console.WriteLine("Noppaa heitettiin {0} kertaa, keskiarvo on {1}", input, lista.Average());

                lista.Sort();

                var q = lista.GroupBy(x => x)
                    .Select(g => new { Value = g.Key, Count = g.Count() });

                foreach (var x in q)
                {
                    Console.WriteLine("Luku " + x.Value + " esiintyy " + x.Count + " kertaa");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public class Product
        {
            public string Nimi { get; set; }
            public double Hinta { get; set; }

            public Product()
            {

            }
            public Product(string nimi, double hinta)
            {
                Nimi = nimi;
                Hinta = hinta;
            }
            public override string ToString()
            {
                return string.Format("product : {0} {1} e", Nimi, Hinta);
            }
        }
        public static void TestaaOstokset()
        {
            try
            {
                List<Product> ostoskori = new List<Product>();
                int valinta;
                string nimi;
                double hinta;
                Console.WriteLine("Lisätääs tuotteita.");
                do
                {
                    Console.WriteLine("Nimi: ");
                    nimi = Console.ReadLine();
                    Console.WriteLine("Hinta: ");
                    hinta = double.Parse(Console.ReadLine());
                    ostoskori.Add(new Product { Nimi = nimi, Hinta = hinta });
                    Console.WriteLine("Vieläkö lisätään? 0=ei, 1=kyllä");
                    valinta = int.Parse(Console.ReadLine());
                } while (valinta == 1);
                Console.WriteLine("Ostoskorin sisältö: ");
                foreach (var item in ostoskori)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public class Fish
        {
            public string Laji { get; set; }
            public string Pituus { get; set; }
            public int Paino { get; set; }
            public string Paikka { get; set; }
            public string Sijainti { get; set; }

            public Fish(string laji, string pituus, int paino, string paikka, string sijainti)
            {
                Laji = laji;
                Pituus = pituus;
                Paino = paino;
                Paikka = paikka;
                Sijainti = sijainti;
            }
            public Fish()
            {

            }
            public override string ToString()
            {
                return string.Format("Laji: {0} {1} {2}\nPaikka: {3}\nSijainti: {4} \n",Laji,Pituus,Paino,Paikka,Sijainti);
            }
        }
        public class Fisherman
        {
            public string Nimi { get; set; }
            public string Puhelin { get; set; }
            public List<Fish> Kalat = new List<Fish>();

            public Fisherman(string nimi, string puhelin)
            {
                Nimi = nimi;
                Puhelin = puhelin;
            }
            public override string ToString()
            {
                string retval = "Kalastaja: " + Nimi + " Puhelinnumero: " + Puhelin + " on saanut kalat: \n\n";
                foreach (Fish kala in Kalat)
                {
                    retval += kala.ToString() + "\n";
                }
                return retval;
            }
        }
        public static void TestaaKalat()
        {
            try
            {
                Fisherman kalamies = new Fisherman("Kirsi Kernel", "0700666123");

                kalamies.Kalat.Add(new Fish("Siika", "40cm", 2, "Kuralampi", "Jyväskylä"));
                kalamies.Kalat.Add(new Fish("Hauki", "52cm", 5, "Pielisjoki", "Joensuu"));
                kalamies.Kalat.Add(new Fish("Sinivalas", "23m", 100000, "Rekilampi", "Kulho"));

                Console.WriteLine(kalamies.ToString());

                Console.WriteLine("Sorttia::::");
                kalamies.Kalat.Sort((x, y) => y.Paino.CompareTo(x.Paino));
                foreach (var item in kalamies.Kalat)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public abstract class Shape
        {
            public string Nimi { get; set; }

            public Shape(string nimi)
            {
                Nimi = nimi;
            }
            public Shape()
            {

            }
            public abstract double Area();
            public abstract double Circumference();
        }
        public class Circle : Shape
        {
            public int Radius { get; set; }

            public Circle(string nimi, int radius) : base (nimi)
            {
                Radius = radius;
            }
            public override double Area()
            {
                double area = 3.1415 * Radius*Radius;
                return area;
            }
            public override double Circumference()
            {
                double circumference = 2 * 3.1415 * Radius;
                return circumference;
            }
            public override string ToString()
            {
                return Nimi + " Radius: " + Radius + " Area: " + Area() + " Circumference: " + Circumference();
            }
        }
        public class Rectangle : Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public Rectangle(string nimi, int width, int height) : base (nimi)
            {
                Width = width;
                Height = height;
            }
            public override double Area()
            {
                double area = Width * Height;
                return area;
            }
            public override double Circumference()
            {
                double circumference = 2 * Width + 2 * Height;
                return circumference;
            }
            public override string ToString()
            {
                return Nimi + " Width: " + Width + " Height: " + Height + " Area: " + Area() + " Circumference: " + Circumference();
            }
        }
        public static void TestaaKuviot()
        {
            List<Shape> Kuviot = new List<Shape>();
            Kuviot.Add(new Circle("Circle",1));
            Kuviot.Add(new Circle("Circle", 2));
            Kuviot.Add(new Circle("Circle", 3));
            Kuviot.Add(new Rectangle("Rectangle", 10,20));
            Kuviot.Add(new Rectangle("Rectangle", 20,30));
            Kuviot.Add(new Rectangle("Rectangle", 40,50));

            foreach (Shape kuvio in Kuviot)
            {
                Console.WriteLine(kuvio.ToString());
            }
        }
    }
}
