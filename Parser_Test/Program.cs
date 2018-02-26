using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Parser_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            //Цикл фор(ейч)
            Console.WriteLine("For");
            string Cycle = "foreach(int i in massive)";
            var searchСycle = new Regex(@"^for(earch)*([^#]+)$");
            Console.WriteLine(searchСycle.Match(Cycle));

            //Выражения 
            Console.WriteLine("Assigment");
            string Assignment = "int level = a + b;";
            //version 2
            var searchAssig = new Regex(@"(?<variable>[A-z 0-9 _]+) = [^#]+;$");
            Console.WriteLine(searchAssig.Match(Assignment));
            Console.WriteLine("Variable: " + searchAssig.Match(Assignment).Groups["variable"]);

            //метод
            Console.WriteLine("\nMethod");
            string Assignment1 = "static void Main(string[] args)";
            //version 3
            var searchAssig1 = new Regex(@"^(?<Accept>[a-z 0-9 _]*) (?<ReturnTypeMethod>[a-z 0-9 _]+) (?<MethodName>[a-z 0-9 _]+)([^#]*)$", RegexOptions.IgnoreCase);
            var searchAssig2 = new Regex(@"^(?<Accept>[A-Z a-z 0-9 _]*) (?<ReturnTypeMethod>[A-Z a-z 0-9 _]+) (?<MethodName>[A-Z a-z 0-9 _]+)(" + "(?<Params>[A-Z a-z 0-9 [,], _]*))");
            Console.WriteLine("String: " + searchAssig1.Match(Assignment1));
            Console.WriteLine("Accept: " + searchAssig1.Match(Assignment1).Groups["Accept"]);
            Console.WriteLine("ReturnTypeMethod: " + searchAssig1.Match(Assignment1).Groups["ReturnTypeMethod"]);
            Console.WriteLine("MethodName: " + searchAssig1.Match(Assignment1).Groups["MethodName"]);
            Console.WriteLine("Params: " + searchAssig1.Match(Assignment1).Groups["Params"]);



        }
    }
}
