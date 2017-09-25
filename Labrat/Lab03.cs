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
                }
            }
            public static void TestiHissi()
            {
                Hissi Dynamo = new Hissi();
                int currentfloor = 1;
                int wantedfloor;
                Console.WriteLine("Olet kerroksessa " + currentfloor);
                Console.WriteLine("Minne matka? ");
                wantedfloor = int.Parse(Console.ReadLine());
                Dynamo.CurrentFloor = wantedfloor;
                Console.WriteLine("Olet kerroksessa " + Dynamo.CurrentFloor);

            }
        }
    }
}
