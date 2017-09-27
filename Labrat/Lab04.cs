using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab04
    {
        public class Employee
        {
            public string Name { get; set; }
            public string Profession { get; set; }
            public string Salary { get; set; }

            public Employee(string name, string profession, string salary)
            {
                Name = name;
                Profession = profession;
                Salary = salary;
            }
            public override string ToString()
            {
                return "Name: " + Name + " Profession: " + Profession + " Salary: " + Salary;
            }

        }
        public class Boss : Employee
        {
            public string Bonus { get; set; }
            public string Car { get; set; }

            public Boss(string name, string profession, string salary, string car, string bonus)
                : base(name, profession, salary)
            {
                Car = car;
                Bonus = bonus;
            }
            public override string ToString()
            {
                return base.ToString() + " Car: " + Car + " Bonus: " + Bonus;
            }
        }
        public static void EmployeeTest()
        {
            Employee duunari = new Employee("Kirsi Kernel", "Teacher", "1200");
            Boss pomo = new Boss("Jussi Jurkka", "Head of Institute", "30000", "Audi", "5555");

            Console.WriteLine(duunari.ToString());
            Console.WriteLine(pomo.ToString());
            duunari.Salary = "2200";
            Console.WriteLine(duunari.ToString());
        }

        public class Vehicle
        {
            public string Name { get; set; }
            public string Model { get; set; }
            public string Year { get; set; }
            public string Color { get; set; }

            public Vehicle(string name, string model, string year, string color)
            {
                Name = name;
                Model = model;
                Year = year;
                Color = color;
            }
            public override string ToString()
            {
                return "Name: " + Name + " Model: " + Model + " Year: " + Year + " Color: " + Color;
            }

        }
        public class Bike : Vehicle
        {
            public bool Gears { get; set; }
            public string GearName { get; set; }

            public Bike(string name, string model, string year, string color, bool gears)
                : base(name, model, year, color)
            {
                Gears = gears;
            }
            public override string ToString()
            {
                return base.ToString() + " Gears: " + Gears + " GearName: " + GearName;
            }
        }
        public class Boat : Vehicle
        {
            public string BoatType  { get; set; }
            public string SeatCount { get; set; }

            public Boat(string name, string model, string year, string color, string boattype, string seatcount)
                : base(name, model, year, color)
            {
                BoatType = boattype;
                SeatCount = seatcount;
            }
            public override string ToString()
            {
                return base.ToString() + " BoatType: " + BoatType + " SeatCount: " + SeatCount;
            }
        }
        public static void VehicleTest()
        {
            Bike bike1 = new Bike("Jopo", "Street", "2016", "Blue", false);
            Bike bike2 = new Bike("Tunturi", "StreetPower", "2010", "Black", true);
            Boat boat1 = new Boat("Suvi", "S900", "1890", "White", "Rowboat", "3");
            Boat boat2 = new Boat("Yamaha", "Model 1000", "2011", "Yellow", "Motorboat", "5");
            bike2.GearName = "Shimano";

            Console.WriteLine("Bike info \n" + bike1.ToString());
            Console.WriteLine("Bike2 info \n" + bike2.ToString());
            Console.WriteLine("Boat info \n" + boat1.ToString());
            Console.WriteLine("Boat2 info \n" + boat2.ToString());
        }

        public class Radio
        {
            public bool Power { get; set; }

            private int volyme = 0;
            public int Volyme
            {
                get
                {
                    return volyme;
                }
                set
                {
                    if (value > 9)
                    {
                        Console.WriteLine("Max volyymi on 9");
                    }
                    else if (value < 0)
                    {
                        Console.WriteLine("Min volyymi on 0");
                    }
                    else
                    {
                        volyme = value;
                    }
                }
            }
            private double frequency = 2000;
            public double Frequency
            {
                get
                {
                    return frequency;
                }
                set
                {
                    if (value > 26000.0)
                    {
                        Console.WriteLine("Max säädettävä taajuus on 26000,0 ");
                    }
                    else if (value < 2000.0)
                    {
                        Console.WriteLine("Min säädettävä taajuus on 2000,0 ");
                    }
                    else
                    {
                        frequency = value;
                    }
                }
            }
            public Radio()
            {
                this.Power = Power;
                this.Volyme = Volyme;
                this.Frequency = Frequency;
            }
            public bool TurnOnOff()
            {
                Console.WriteLine("Radio päälle(true) / Radio kiinni(false)? ");
                Power = bool.Parse(Console.ReadLine());
                return Power;
            }
            public int ChangeVolyme()
            {
                Console.WriteLine("Anna uusi äänenvoimakkuus (0-9): ");
                Volyme = int.Parse(Console.ReadLine());
                return Volyme;
            }
            public double ChangeFrequency()
            {
                Console.WriteLine("Anna uusi taajuus (2000,0-26000,0): ");
                Frequency = double.Parse(Console.ReadLine());
                return Frequency;
            }
        }
        public static void TestiRadio()
        {
            Radio grundig = new Radio();
            int valinta = 100;

            grundig.TurnOnOff();

            while (grundig.Power == true)
            {
                Console.WriteLine("RADIO \n 0. Virtakytkin \n 1. Vaihda taajuutta \n 2. Vaihda äänenvoimakkuutta");
                valinta = int.Parse(Console.ReadLine());
                if (valinta == 1)
                {
                    grundig.ChangeFrequency();
                    Console.WriteLine("Olet nyt taajuudella " + grundig.Frequency + "\n");
                }
                else if (valinta == 2)
                {
                    grundig.ChangeVolyme();
                    Console.WriteLine("Äänenvoimakkuus on nyt " + grundig.Volyme + "\n");
                }
                else if (valinta == 0)
                {
                    grundig.TurnOnOff();
                }
            }
        }
    }
}
