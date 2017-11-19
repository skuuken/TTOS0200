using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLab10._2
{
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
    }

    public class Seura
    {
        public List<Pelaaja> Pelaajat = new List<Pelaaja>();
        public static List<Pelaaja> HaePelaajat()
        {
            Seura jyp = new Seura();
            List<Pelaaja> Pelaajat = new List<Pelaaja>();
            jyp.Pelaajat.Add(new Pelaaja("Eetu", "Laurikainen", "MV", "L"));
            jyp.Pelaajat.Add(new Pelaaja("Mikko", "Kalteva", "VP", "L"));
            jyp.Pelaajat.Add(new Pelaaja("Juuso", "Vainio", "OP", "R"));
            jyp.Pelaajat.Add(new Pelaaja("Joonas", "Nättinen", "KH", "R"));
            jyp.Pelaajat.Add(new Pelaaja("Juuso", "Puustinen", "OL", "R"));
            jyp.Pelaajat.Add(new Pelaaja("Jani", "Tuppurainen", "VL", "L"));
            return jyp.Pelaajat;
        }
    }
}
