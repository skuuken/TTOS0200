using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab07
    {
        public static void Tehtava1()
        {
            //KÄYTTÄKÄÄ AINA TRY-CATCHIA
            try
            {
                string nimi;
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filu = filupath + @"\testi.txt";
                //kirjoitetaan käyttäjän antamat rivit tiedostoon
                //luodaan StreamWriter tyyppinen olio johon kirjoitetaan
                StreamWriter sw = new StreamWriter(filu);
                do
                {
                    Console.Write("Anna nimi (Enter lopettaa)");
                    nimi = Console.ReadLine();
                    if (nimi.Length > 0)
                    {
                        sw.WriteLine(nimi);
                    }
                } while (nimi.Length != 0);
                sw.Close();
                //avataan tiedosto uudestaan ja luetaan sen sisältö ja näytetään konsolissa
                if (File.Exists(filu))
                {
                    string teksti = File.ReadAllText(filu);
                    Console.WriteLine(teksti);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Tehtava2()
        {
            try
            {
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filu = filupath + @"\nimet.txt";
                if (File.Exists(filu))
                {
                    int nimet = 0;
                    List<string> teksti = File.ReadAllLines(filu).ToList();
                    var q = teksti.GroupBy(x => x)
                        .Select(g => new { Value = g.Key, Count = g.Count() });

                    foreach (var x in q)
                    {
                        nimet++;
                    }
                    Console.WriteLine("Löytyi " + teksti.Count + " riviä, ja " + nimet + " nimeä.");
                    foreach (var x in q)
                    {
                        Console.WriteLine("Nimi " + x.Value + " esiintyy " + x.Count + " kertaa");
                    }

                    teksti.Sort();

                    Console.WriteLine("Löytyi " + teksti.Count + " riviä, ja " + nimet + " nimeä sortattuna");
                    foreach (var x in q)
                    {
                        Console.WriteLine("Nimi " + x.Value + " esiintyy " + x.Count + " kertaa");
                    }

                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Tiedostoa ei löydy");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
