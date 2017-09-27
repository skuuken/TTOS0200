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
    }
}
