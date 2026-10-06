using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //part1
            String Name = "Sami Ali";
            int Age = 20;
            int Grade = 12;
            double Average = 85.5;
            char Gender = 'M';
            bool Active = true;
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine("Average: " + Average);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Active: " + Active);
            Console.WriteLine("");
            Console.WriteLine("");

            //part2 & part3
            String[] Names = new String[] { "Yasmeen", "Saja", "Deyaa", "Marwa" };
            Console.WriteLine("Array Length: " + Names.Length);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("First Student: " +  Names[0]);
            Console.WriteLine("Last Student: "+ Names[3]);
            Console.WriteLine("");
            Console.WriteLine("");

            Names[1] = "Noor";

            Console.WriteLine("After Change: ");
            Console.WriteLine("Student 1: " + Names[0]);
            Console.WriteLine("Student 2: " + Names[1]);
            Console.WriteLine("Student 3: " + Names[2]);
            Console.WriteLine("Student 4: " + Names[3]);

            //part3


        }
    }
}
