
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotaM
{
    class Student
    {
        public string FirstName;
        public string Surname;
        public int age;
        public double gpa;

        public Student(string FirstName, string Surname, int age, double gpa)
        {
            this.FirstName = FirstName;
            this.Surname = Surname;
            this.age = age;
            this.gpa = gpa;
        }

        public override string ToString()
        {
            return "FirstName:" + FirstName + "\n" + "Surname:" + Surname + "\n" + "age:" + age + "\n"+ "gpa:" + gpa; 
        }
}
    class Sample
    {
        static void Main()
        {
            Student s = new Student("Bota", "Mautkazy", 18, 4.0);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }

}


