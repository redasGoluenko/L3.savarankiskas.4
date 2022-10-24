using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace L3.savarankiskas._4
{
    internal class InOut
    {
        public static Container ReadStudents(string fileName)
        {
            Container container = new Container();
            string[] Lines = File.ReadAllLines(fileName);
            container.Faculty = Lines[0];
            foreach (string line in Lines.Skip(1))
            {
                string[] Values = line.Split(';');
                string surname = Values[0];
                string name = Values[1];
                string group = Values[2];
                int gradeCount = int.Parse(Values[3]);
                int[] grade = new int[gradeCount];           
                for (int i = 0; i < gradeCount; i++)
                {
                    grade[i] = int.Parse(Values[i + 4]);
                }
                Student student = new Student(surname, name, group, gradeCount, grade);
                container.Add(student);
            }
            return container;
        }
        public static void PrintStudents(Container container,string label)
        {
            Console.WriteLine(label);
            Console.WriteLine(new String('-', 114));
            Console.WriteLine("|{0,-112}|",container.Faculty);
            Console.WriteLine(new String('-', 114));
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-19}|{5,8}|", "Pavardė", "Vardas", "Grupė", "Pažymių kiekis", "Pažymiai", "Vidurkis");
            Console.WriteLine(new String('-', 114));
            for(int i=0;i<container.Count;i++)
            {
                Student student = container.Get(i);
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine(new String('-', 114));
            Console.WriteLine();
        }
    }
}




