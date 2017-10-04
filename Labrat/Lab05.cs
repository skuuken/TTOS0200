using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab05
    {
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string AsioID { get; set; }

            public Student()
            {

            }
            public Student(string fname, string lname)
            {
                FirstName = fname;
                LastName = lname;
            }
            public override string ToString()
            {
                return FirstName + " " + LastName + " asio: " + AsioID;
            }
        }

        public class Group
        {
            public string Name { get; set; }
            public List<Student> Students;
            //konstruktori
            public Group()
            {
                Students = new List<Student>();
                //luettaisiin esim tietokannasta ne oppilaihe tiedot
                Students.Add(new Student("Pelle", "Hermanni"));
                Students.Add(new Student("Arja", "Koriseva"));
                Students.Add(new Student("Valle", "Valkoroska"));
            }
            public override string ToString()
            {
                string retval = "Luokka " + Name + " sisältää oppilaat\n";
                foreach (Student item in Students)
                {
                    retval += item.ToString() + "\n";
                }
                return retval;
            }
        }
        public static void TestaaStudent()
        {
            Student s = new Student();
            s.FirstName = "Sakke";
            s.LastName = "Sakuttaja";
            Student s2 = new Student("Irma", "Cocksucka");
            //luodaan kokoelma Student-olioita, käytetään List
            List<Student> students = new List<Student>();
            students.Add(s);
            students.Add(s2);
            students.Add(new Student("Isä", "Aurinkoinen"));
            //näytettään oppillaat
            Console.WriteLine("Luokan jengi: ");
            foreach (Student item in students)
            {
                Console.WriteLine(item.ToString());
            }
            //testataan Group-luokka
            Group luokka = new Group();
            luokka.Name = "TTV16S1";
            luokka.Students.Add(new Student("Anna", "Pilua"));
            Console.WriteLine(luokka.ToString());
        }
    }
}
