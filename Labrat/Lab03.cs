using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Labrat
{
    class Lab03
    {
        public class Lukupvm
        {
            public string Luku { get; set; }
            public string Pvm { get; set; }

            public Lukupvm(string Luku, string Pvm)
            {
                this.Luku = Luku;
                this.Pvm = Pvm;
            }

            public Lukupvm()
            {
            }

            public static bool OnkoLuku(string Luku)
            {
                Console.WriteLine("Anna luku (kokonaisluku tai desimaaliluku erottimena pilkku, pistettä ei hyväksytä): ");
                Luku = Console.ReadLine();
                double number;
                bool result = double.TryParse(Luku, out number);
                if (result)
                {
                    Console.WriteLine("TRUE");
                    return true;
                }
                else
                {
                    Console.WriteLine("FALSE");
                    return false;
                }
            }
            public static bool OnkoPvm(string Pvm)
            {
                var dateFormats = new[] { "dd.MM.yyyy", "dd.MM.yy", "dd.M.yyyy", "dd.M.yy", "d.MM.yyyy", "d.M.yyyy", "d.M.yy", "d.MM.yy" };
                Console.WriteLine("Anna päivämäärä (pp.kk.vvvv tai pp.kk.vv");
                Pvm = Console.ReadLine();
                DateTime deitti;
                bool validDate = DateTime.TryParseExact(Pvm, dateFormats, DateTimeFormatInfo.InvariantInfo,DateTimeStyles.None, out deitti);
                if (validDate)
                {
                    Console.WriteLine("TRUE " + deitti.ToShortDateString());
                    return true;
                }
                else
                {
                    Console.WriteLine("FALSE " + Pvm);
                    return false;
                }
            }
        }
        public static void TestiPeti()
        {
            Lukupvm Testi = new Lukupvm();
            Lukupvm.OnkoLuku(Testi.Luku);
            Lukupvm.OnkoPvm(Testi.Pvm);
        }
        public class Hissi
        {
            public int CurrentFloor { get; set; }
            public Hissi()
            {
                this.CurrentFloor = CurrentFloor;
                this.WantedFloor = WantedFloor;
                CurrentFloor = 1;
            }
            private int wantedfloor;
            public int WantedFloor
            {
                get
                {
                    return wantedfloor;
                }
                set
                {
                    if (value > 5)
                    {
                        Console.WriteLine("LIIAN ISO");
                    }
                    else if (value < 0) {
                        Console.WriteLine("LIIAN PIENI");
                    }
                    else
                    {
                        wantedfloor = value;
                    }
                }
            }
            public int GoToFloor()
            {
                Console.WriteLine("Aseta kerros mihkä mennää (0-5): ");
                WantedFloor = int.Parse(Console.ReadLine());
                return WantedFloor;
            }
            public void PrintFloor()
            {
                CurrentFloor = WantedFloor;
                Console.WriteLine("Olet kerroksessa " + CurrentFloor);
            }
            public static void TestiHissi()
            {
                Hissi Dynamo = new Hissi();
                while (true)
                {
                    Dynamo.GoToFloor();
                    Dynamo.PrintFloor();
                }
            }
        }
        public class Vahvistin
        {
            public int CurrentVolyme { get; set; }
            public Vahvistin()
            {
                this.CurrentVolyme = CurrentVolyme;
                this.WantedVolyme = WantedVolyme;
                CurrentVolyme = 1;
            }
            private int wantedvolyme;
            public int WantedVolyme
            {
                get
                {
                    return wantedvolyme;
                }
                set
                {
                    if (value > 100)
                    {
                        Console.WriteLine("LIIAN ISO. ASETETAAN MAKSIMIIN");
                        wantedvolyme = 100;
                    }
                    else if (value < 0)
                    {
                        Console.WriteLine("LIIAN PIENI. ASETETAAN MINIMIIN");
                        wantedvolyme = 0;
                    }
                    else
                    {
                        wantedvolyme = value;
                    }
                }
            }
            public int ChangeVolyme()
            {
                Console.WriteLine("Aseta uusi volyymi (0-100): ");
                WantedVolyme = int.Parse(Console.ReadLine());
                return WantedVolyme;
            }
            public void PrintVolyme()
            {
                CurrentVolyme = WantedVolyme;
                Console.WriteLine("Vahvarin vola on " + CurrentVolyme);
            }
            public static void TestiVahvari()
            {
                Vahvistin Marsu = new Vahvistin();
                while (true)
                {
                    Marsu.ChangeVolyme();
                    Marsu.PrintVolyme();
                }
            }
        }
    }
}
