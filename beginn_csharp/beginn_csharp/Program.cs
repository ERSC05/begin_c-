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
            Console.WriteLine("Wie heißt du?");
            string username = Console.ReadLine();
//            string name = "Erwin";
            Console.WriteLine("hello Wold! " + username);
            Console.WriteLine("Wie alt bist du? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dein Alter ist " + age);

            Console.ReadLine();

            


        }
    }
}
