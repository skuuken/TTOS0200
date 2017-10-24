using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab06
    {
        public class Opiskelija
        {
            #region PROPERTIES
            public string Etunimi { get; set; }
            public string Sukunimi { get; set; }
            public string AsioID { get; set; }
            public string Ryhma { get; set; }
            #endregion
            #region CONSTRUCTORS
            public Opiskelija()
            {

            }
            public Opiskelija(string etunimi, string sukunimi)
            {
                Etunimi = etunimi;
                Sukunimi = sukunimi;
            }
            public Opiskelija(string etunimi, string sukunimi, string asioid)
                : this(etunimi, sukunimi)
            {
                AsioID = asioid;
            }
            public Opiskelija(string etunimi, string sukunimi, string asioid, string ryhma)
                : this(etunimi, sukunimi, asioid)
            {
                Ryhma = ryhma;
            }
            #endregion
            #region METHODS
            public override string ToString()
            {
                return string.Format("{0} {1} {2} {3}", Etunimi, Sukunimi, AsioID, Ryhma);
            }
            #endregion

        }
        public static void Testaa()
        {
            //luodaan List-tyyppinen lista opiskelijoista
            List<Opiskelija> opiskelijat = new List<Opiskelija>();
            //testin vuoksi erilaisia tapoja lisätä olioita listaan
            Opiskelija masa = new Opiskelija("Masa", "Niemi");
            opiskelijat.Add(masa);
            opiskelijat.Add(new Opiskelija("Allan", "Aalto", "A1234"));
            //myös näin
            opiskelijat.Add(new Opiskelija { Etunimi = "Hanna", Sukunimi = "Husso", AsioID = "H5678" });
            opiskelijat.Add(new Opiskelija { Etunimi = "Teppo", Sukunimi = "Testaaja", AsioID = "T9876", Ryhma="TTV17S1" });
            Opiskelija kalle = new Opiskelija();
            kalle.Etunimi = "Kalle"; kalle.Sukunimi = "Ankka"; kalle.AsioID = "K6677";
            opiskelijat.Add(kalle);
            //yhden opiskelijan tietojen näyttäminen
            Console.WriteLine("Anna numero väliltä 1-{0}", opiskelijat.Count);
            int i = int.Parse(Console.ReadLine());
            if (i-1 < opiskelijat.Count)
                Console.WriteLine("MiniASIOn {0} opiskelija on {1}", i, opiskelijat[i - 1].ToString());
            else
                Console.WriteLine("MiniASIOSSA on vain {0} opiskelijaa", opiskelijat.Count);
            //kaikkien opiskelijoiden tiedot
            Console.WriteLine("MiniASIOn kaikki opiskelijat:");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //kaikkien opiskelijoiden tiedot aakkosjärjestyksessä sukunimen mukaan
            //sortataan oliot Sukunimi-ominaisuuden mukaiseen järjestykseen
            opiskelijat.Sort((x, y) => x.Sukunimi.CompareTo(y.Sukunimi));
            Console.WriteLine("MiniASIOn kaikki opiskelijat aakkosjärjestyksessä:");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //uuden opiskelijan lisääminen, huom. tehdään tarkistus ettei AsioID ole jo olemassa
            Console.WriteLine("Anna uuden opiskelijan AsioID");
            string asioid = Console.ReadLine();
            //tutkitaan onko listassa
            bool lippu = false;
            foreach (Opiskelija o in opiskelijat)
            {
                if (asioid == o.AsioID)
                {
                    lippu = true;
                    break;
                }
            }
            if (lippu)
            {
                Console.WriteLine("AsioID {0} on jo käytössä", asioid);
            }
            else
            {
                Console.WriteLine("Anna uuden opiskelijan etunimi");
                string etunimi = Console.ReadLine();
                Console.WriteLine("Anna sukunimi");
                string sukunimi = Console.ReadLine();
                Console.WriteLine("Anna ryhma");
                string ryhma = Console.ReadLine();
                //luodaan uusi Opiskelija olio
                Opiskelija uusi = new Opiskelija(etunimi, sukunimi, asioid, ryhma);
                opiskelijat.Add(uusi);
                Console.WriteLine("MiniASIOn kaikki {0} opiskelijaa:", opiskelijat.Count);
                foreach (var o in opiskelijat)
                {
                    Console.WriteLine(o.ToString());
                }
            }
        }
        public class CD
        {
            public string Name { get; set; }
            public string Artist { get; set; }
            public List<Song> songs = new List<Song>();
            
            public CD()
            {

            }

            public CD(string name, string artist)
            {
                Name = name;
                Artist = artist;
            }
            public override string ToString()
            {
                string retval = string.Format("CD Data:\n Name: {0}\n Artist: {1}\n Songs: \n", Name, Artist);
                foreach (Song item in songs)
                {
                    retval += item.ToString() + "\n";
                }
                return retval;
            }
        }
        public class Song
        {
            public string Name { get; set; }
            public string Duration { get; set; }

            public Song()
            {

            }
            public Song(string name, string duration)
            {
                Name = name;
                Duration = duration;
            }
            public override string ToString()
            {
                return string.Format("{0}, {1}", Name, Duration);
            }
        }
        public static void TestaaCD()
        {
            List<CD> levyt = new List<CD>();
            CD levy1 = new CD("Endless Forms Most Beautiful", "Nightwish");
            levy1.songs.Add(new Song("Shudder Before the beautiful", "6:29"));
            levy1.songs.Add(new Song("Weak Fantasy", "5:23"));
            levy1.songs.Add(new Song("Elan", "4:45"));
            levy1.songs.Add(new Song("Yours Is an Empty Hope", "5:34"));
            levy1.songs.Add(new Song("Our Decades in the Sun", "6:37"));
            levy1.songs.Add(new Song("My Walden", "4:38"));
            levy1.songs.Add(new Song("Endless Forms Most Beautiful", "5:07"));
            levy1.songs.Add(new Song("Edema Ruh", "5:15"));
            levy1.songs.Add(new Song("Alpenglow", "4:45"));
            levy1.songs.Add(new Song("The Eyes of Sharbat Gula", "6:03"));
            levy1.songs.Add(new Song("The Greatest Show on Earth", "24:00"));
            Console.WriteLine(levy1.ToString());
        }
        public class Pakka
        {
            public List<Kortti> Kortit;
            private static Random rng = new Random();

            public Pakka()
            {
                Kortit = new List<Kortti>();
            }

            public void Sekoita()
            {
                int n = Kortit.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    Kortti value = Kortit[k];
                    Kortit[k] = Kortit[n];
                    Kortit[n] = value;
                }
                Console.WriteLine("Kortit on sekoitettu");
            }
            public override string ToString()
            {
                int luku = 1;
                string retval = "";
                foreach (Kortti item in Kortit)
                {
                    retval += luku + item.ToString();
                    luku++;
                }
                return retval;
            }
        }
        public class Kortti
        {
            public string Maa { get; set; }
            public int Luku { get; set; }

            public Kortti()
            {

            }
            public Kortti(string maa, int luku)
            {
                Maa = maa;
                Luku = luku;
            }
            public override string ToString()
            {
                return string.Format(" kortti on {0}#{1}\n", Maa, Luku);
            }

        }
        public static void TestaaPakka()
        {
            Pakka pagga = new Pakka();

            for (int i = 1; i <= 13; i++)
            {
                pagga.Kortit.Add(new Kortti("Hertta", i));
            }
            for (int i = 1; i <= 13; i++)
            {
                pagga.Kortit.Add(new Kortti("Ruutu", i));
            }
            for (int i = 1; i <= 13; i++)
            {
                pagga.Kortit.Add(new Kortti("Risti", i));
            }
            for (int i = 1; i <= 13; i++)
            {
                pagga.Kortit.Add(new Kortti("Pata", i));
            }
            Console.WriteLine(pagga.ToString());
            pagga.Sekoita();
            Console.WriteLine(pagga.ToString());
        }
    }
}
