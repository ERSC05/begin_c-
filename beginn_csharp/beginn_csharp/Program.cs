using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginn_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gib mir ein Wort! ");
            string entry = Console.ReadLine();
            string trimmed_entry = entry.Trim(' ', 'a');
            Console.WriteLine("Old String " + entry + ":");
            Console.WriteLine("New String " + trimmed_entry + ":");
            Console.ReadLine();

            


        }
    }
}
