using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_AB1_Aufgabe1_Jerome_Folger_21b
{
    internal class Umfrage
    {
        public void StelleFrage(string id, string frage)
        {
            Console.WriteLine(id);
            Console.WriteLine(frage);
        }
        public void StelleFrage(string id, string frage, bool required)
        {
            Console.WriteLine(id);
            Console.WriteLine(frage);
            if(required) Console.WriteLine("Pflichtfeld");
        }
        public void StelleFrage(string id, string frage, string instruction, string regexpr)
        {
            Console.WriteLine(id);
            Console.WriteLine(frage);
            Console.WriteLine(instruction);
            string antwort = Console.ReadLine() ?? "";
            var m = Regex.Match(antwort, regexpr);
            if (m.Success)
            {
                Console.WriteLine("Antwort: " + antwort);
            }
            else
            {
                Console.WriteLine("Fehler: Eingabe nicht erkannts");
            }
        }
    }
}
