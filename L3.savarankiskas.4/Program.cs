using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3.savarankiskas._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Container container = InOut.ReadStudents("Fakultetas.txt");
            InOut.PrintStudents(container,"Pradiniai duomenys:");
            container.Sort();
            InOut.PrintStudents(container,"Surikiuoti duomenys:");
        }
    }
}
