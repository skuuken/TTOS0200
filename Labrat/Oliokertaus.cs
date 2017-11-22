using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Oliokertaus
    {
        public class Tutkinto
        {
            public string Nimi { get; set; }
            public List<Opintojakso> opintojaksot = new List<Opintojakso>();

            public Tutkinto(string nimi)
            {
                Nimi = nimi;
            }
        }

        public class Opintojakso
        {
            public string Nimi { get; set; }
            public List<Opiskelija> opiskelijat = new List<Opiskelija>();
            public List<Opettaja> opettajat = new List<Opettaja>();

            public Opintojakso(string nimi)
            {
                Nimi = nimi;
            }
        }

        public class Opettaja
        {
            public string Nimi { get; set; }

            public Opettaja(string nimi)
            {
                Nimi = nimi;
            }
        }

        public class Opiskelija
        {
            public string Nimi { get; set; }
            public string ID { get; set; }
            private static int opiskelijalkm = 0;

            public Opiskelija(string nimi, string id)
            {
                Nimi = nimi;
                ID = id;
                opiskelijalkm++;
            }
            public static int Montako()
            {
                return opiskelijalkm;
            }
        }

        public class AMK
        {

        }

        public static void PaaOhjelma()
        {
            Tutkinto ttv = new Tutkinto("Tieto- ja viestintätekniikka");
            Opintojakso olio = new Opintojakso("Olio ohjelmointi");
            Opintojakso network = new Opintojakso("Network infrastructure");
            Opintojakso linux = new Opintojakso("Linux servers");

            Tutkinto sahkotekniikka = new Tutkinto("Sähkö- ja automaatiotekniikka");
            Opintojakso elek = new Opintojakso("Elektroniikka");
            Opintojakso automaatio = new Opintojakso("Automaatio");
            Opintojakso suunnittelu = new Opintojakso("Suunnittelu");

            Tutkinto matkailu = new Tutkinto("Matkailu");
            Opintojakso olutkurssi = new Opintojakso("Oluen maistelu");
            Opintojakso viinikurssi = new Opintojakso("Viinin maistelu");
            Opintojakso kirjanpito = new Opintojakso("Kirjanpito");

            ttv.opintojaksot.Add(olio);
            ttv.opintojaksot.Add(network);
            ttv.opintojaksot.Add(linux);

            sahkotekniikka.opintojaksot.Add(elek);
            sahkotekniikka.opintojaksot.Add(automaatio);
            sahkotekniikka.opintojaksot.Add(suunnittelu);

            matkailu.opintojaksot.Add(olutkurssi);
            matkailu.opintojaksot.Add(viinikurssi);
            matkailu.opintojaksot.Add(kirjanpito);

            olio.opiskelijat.Add(new Opiskelija("Pena Virtanen", "H1234"));
            olio.opiskelijat.Add(new Opiskelija("Satu Lavikainen", "K6600"));
            olio.opiskelijat.Add(new Opiskelija("Regina Vanto", "K1995"));
            olio.opettajat.Add(new Opettaja("Olof"));

            network.opiskelijat.Add(new Opiskelija("Pena Virtanen", "H1234"));
            network.opiskelijat.Add(new Opiskelija("Satu Lavikainen", "K6600"));
            network.opiskelijat.Add(new Opiskelija("Regina Vanto", "K1995"));
            network.opettajat.Add(new Opettaja("Jabbe"));

            linux.opiskelijat.Add(new Opiskelija("Pena Virtanen", "H1234"));
            linux.opiskelijat.Add(new Opiskelija("Satu Lavikainen", "K6600"));
            linux.opiskelijat.Add(new Opiskelija("Regina Vanto", "K1995"));
            linux.opettajat.Add(new Opettaja("Nestori"));


            elek.opiskelijat.Add(new Opiskelija("Risto Räps", "K1122"));
            elek.opiskelijat.Add(new Opiskelija("Repe Sorsa", "K2211"));
            elek.opiskelijat.Add(new Opiskelija("Regina Vanto", "K1995"));
            elek.opettajat.Add(new Opettaja("Robbe"));

            automaatio.opiskelijat.Add(new Opiskelija("Risto Räps", "K1122"));
            automaatio.opiskelijat.Add(new Opiskelija("Repe Sorsa", "K2211"));
            automaatio.opiskelijat.Add(new Opiskelija("Gunnar Perälampi", "K3311"));
            automaatio.opettajat.Add(new Opettaja("Viltsu"));

            suunnittelu.opiskelijat.Add(new Opiskelija("Risto Räps", "K1122"));
            suunnittelu.opiskelijat.Add(new Opiskelija("Repe Sorsa", "K2211"));
            suunnittelu.opiskelijat.Add(new Opiskelija("Gunnar Perälampi", "K3311"));
            suunnittelu.opettajat.Add(new Opettaja("Antsa"));


            olutkurssi.opiskelijat.Add(new Opiskelija("Kassi Kattonen", "K3133"));
            olutkurssi.opiskelijat.Add(new Opiskelija("Snipedi Snaps", "K4455"));
            olutkurssi.opiskelijat.Add(new Opiskelija("Kalle Lehtinen", "H6888"));
            olutkurssi.opettajat.Add(new Opettaja("Hombre"));

            viinikurssi.opiskelijat.Add(new Opiskelija("Kassi Kattonen", "K3133"));
            viinikurssi.opiskelijat.Add(new Opiskelija("Snipedi Snaps", "K4455"));
            viinikurssi.opiskelijat.Add(new Opiskelija("Kalle Lehtinen", "H6888"));
            viinikurssi.opettajat.Add(new Opettaja("Papi"));

            kirjanpito.opiskelijat.Add(new Opiskelija("Kassi Kattonen", "K3133"));
            kirjanpito.opiskelijat.Add(new Opiskelija("Snipedi Snaps", "K4455"));
            kirjanpito.opiskelijat.Add(new Opiskelija("Kalle Lehtinen", "H6888"));
            kirjanpito.opettajat.Add(new Opettaja("Ulla"));

            Console.WriteLine(Opiskelija.Montako());
        }
    }
}
