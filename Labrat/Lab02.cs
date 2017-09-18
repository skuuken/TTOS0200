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
            public bool virta { get; set; }
            public int lampotila { get; set; }
            public int kosteus { get; set; }

            public Kiuas()
            {
                this.virta = virta;
                this.lampotila = lampotila;
                this.kosteus = kosteus;
            }
        }
            public static void TestaaKiuas()
            {
            Kiuas Harvia = new Kiuas();

            Console.WriteLine("Onko kiuas päällä? (true/false): ");
            Harvia.virta = bool.Parse(Console.ReadLine());
            if (Harvia.virta == true)
            {
                Console.WriteLine("Anna lämpötila: ");
                Harvia.lampotila = int.Parse(Console.ReadLine());
                Console.WriteLine("Anna kosteus: ");
                Harvia.kosteus = int.Parse(Console.ReadLine());
                Console.WriteLine("Kiukaan lämpötila on " + Harvia.lampotila);
                Console.WriteLine("Kiukaan kosteus on " + Harvia.kosteus);
            }
            else
            {
                Console.WriteLine("Pistä se piäle");
            }
            }
        public class Pesukone
        {
            
        }
    }
}
