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
            public string pesuohjelma { get; set; }
            public int kesto { get; set; }
            public int lampotila { get; set; }

            public Pesukone()
            {
                this.pesuohjelma = pesuohjelma;
                this.kesto = kesto;
                this.lampotila = lampotila;
            }
            public int AsetaLampotila()
            {
                Console.WriteLine("Anna lämpötila: ");
                lampotila = int.Parse(Console.ReadLine());
                TestaaPesukone();
                return lampotila;
            }
            public string AsetaPesuohjelma()
            {
                Console.WriteLine("Anna pesuohjelma: ");
                Console.WriteLine("1. Päivittäispesu");
                Console.WriteLine("2. Pikapesu");
                Console.WriteLine("3. Röllipesu");
                int valinta = int.Parse(Console.ReadLine());
                if (valinta == 1)
                {
                    Console.WriteLine("Päivittäispesu valittu");
                    pesuohjelma = "Päivittäispesu";
                }
                else if (valinta == 2)
                {
                    Console.WriteLine("Pikapesu valittu");
                    pesuohjelma = "Pikapesu";
                }
                else if (valinta == 3)
                {
                    Console.WriteLine("UltraMax-röllipesu valittu");
                    pesuohjelma = "Röllipesu";
                }
                TestaaPesukone();
                return pesuohjelma;
            }
            public int AsetaKesto()
            {
                Console.WriteLine("Anna ohjelman kesto: ");
                kesto = int.Parse(Console.ReadLine());
                TestaaPesukone();
                return kesto;
            }
        }
        public static void TestaaPesukone()
        {
            Pesukone Siemens = new Pesukone();
            int valinta;
            Console.WriteLine("Alotettaas pyykinpesu");
            Console.WriteLine("1. Valitse pesuohjelma");
            Console.WriteLine("2. Valitse ohjelman lämpötila");
            Console.WriteLine("3. Valitse ohjelman kesto");
            Console.WriteLine("4. Aloita pesu");
            valinta = int.Parse(Console.ReadLine());
            if (valinta == 1)
            {
                Siemens.AsetaPesuohjelma();
            }
            else if (valinta == 2)
            {
                Siemens.AsetaLampotila();
            }
            else if (valinta == 3)
            {
                Siemens.AsetaKesto();
            }
            else if (valinta == 4)
            {
                Console.WriteLine("Surrurrr");
            }
        }
        public class Televisio
        {
            public bool virta { get; set; }
            public int kanava { get; set; }
            public int volyymi { get; set; }

            public Televisio()
            {
                this.virta = virta;
                this.kanava = kanava;
                this.volyymi = volyymi;
            }
            public int LisaaVolyymia()
            {
                Console.WriteLine("Lisää volaa 10:llä");
                volyymi += 10;
                TestaaTelevisio();
                return volyymi;
            }
            public int LaskeVolyymia()
            {
                Console.WriteLine("Laske volaa 10:llä");
                volyymi -= 10;
                TestaaTelevisio();
                return volyymi;
            }
            public int VaihdaKanava()
            {
                Console.WriteLine("Mikä kanava laitettaan?");
                int valinta = int.Parse(Console.ReadLine());
                if (valinta == 1)
                {
                    Console.WriteLine("Yle 1");
                }
                else if (valinta == 2)
                {
                    Console.WriteLine("Yle 2");
                }
                else if (valinta == 3)
                {
                    Console.WriteLine("MTV3");
                }
                else if (valinta == 4)
                {
                    Console.WriteLine("Nelonen");
                }
                TestaaTelevisio();
                return kanava;
            }
        }
        public static void TestaaTelevisio()
        {
            Televisio Samsung = new Televisio();
            int valinta;
            Console.WriteLine("Vilikastaas töllöö, laitetaanko virta päälle?");
            Samsung.virta = bool.Parse(Console.ReadLine());
            if (Samsung.virta == true)
            {
                Console.WriteLine("1. Lisää volyymia");
                Console.WriteLine("2. Laske volyymia");
                Console.WriteLine("3. Vaihda kanavaa");
                Console.WriteLine("4. Lokoisa asento");
                valinta = int.Parse(Console.ReadLine());
                if (valinta == 1)
                {
                    Samsung.LisaaVolyymia();
                }
                else if (valinta == 2)
                {
                    Samsung.LaskeVolyymia();
                }
                else if (valinta == 3)
                {
                    Samsung.VaihdaKanava();
                }
                else if (valinta == 4)
                {
                    Console.WriteLine("Rötiröti rötvätään");
                }
            } else
            {
                Console.WriteLine("Ei sitte");
            }
        }
    }
}
