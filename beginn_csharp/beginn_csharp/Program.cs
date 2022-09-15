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
            Console.WriteLine("Wie alt bist du? ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Du darfst nicht rein");
            }
            else
            {
                Console.WriteLine("Viel Spaß");

            }




            //            double multiplikator = 3;
            //            Console.WriteLine("du bist " + height + " groß ");

            Console.ReadLine();

            


        }
    }
}
