using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab02
    {

        public class Kiuas
        {
            public bool Virta { get; set; }
            public int Lampotila { get; set; }
            public int Kosteus { get; set; }

            public Kiuas()
            {
                this.Virta = Virta;
                this.Lampotila = Lampotila;
                this.Kosteus = Kosteus;
            }
        }
            public static void TestaaKiuas()
            {
            Kiuas Harvia = new Kiuas();

            Console.WriteLine("Onko kiuas päällä? (true/false): ");
            Harvia.Virta = bool.Parse(Console.ReadLine());
            Console.WriteLine("Anna lämpötila: ");
            Harvia.Lampotila = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kosteus: ");
            Harvia.Kosteus = int.Parse(Console.ReadLine());
            Console.WriteLine("Kiukaan lämpötila on " + Harvia.Lampotila);
            Console.WriteLine("Kiukaan kosteus on " + Harvia.Kosteus);
            }
        public class Pesukone
        {

        }
    }
}
