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

            if (age > 18)
            {
                if (age < 29)
                {
                    Console.WriteLine("Zeige mir deinen Ausweis");
                }
                else
                {
                    Console.WriteLine("Du darfst rein");
                }

            }
            else
            {
                Console.WriteLine("Du darfst nicht rein");
                

            }
            
            Console.ReadLine();

            


        }
    }
}
