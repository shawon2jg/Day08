using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4App
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<Student> students = new Stack<Student>();

            Student student1 = new Student();
            student1.regNo = "123";
            student1.firstName = "Nurul";
            student1.lastName = "Alam";

            Student student2 = new Student();
            student2.regNo = "456";
            student2.firstName = "Abdur";
            student2.lastName = "Rahim";

            Student student3 = new Student();
            student3.regNo = "789";
            student3.firstName = "Saida";
            student3.lastName = "Alam";

            students.Push(student1);
            students.Push(student2);
            students.Push(student3);

            foreach (Student aStudent in students)
            {
                Console.WriteLine(aStudent.GetFullName() + " your regNo is: " + aStudent.regNo);
            }
            Console.ReadKey();
        }
    }
}
