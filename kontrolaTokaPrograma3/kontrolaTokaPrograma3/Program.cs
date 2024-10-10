using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace kontrolaTokaPrograma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x,y;

            Console.WriteLine("Unesite cijenu sa PDV-om:");
             x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Unesite cijenu bez PDV-a:");
             y = Convert.ToDouble(Console.ReadLine());



            double iznosPDV = x - y;
            double postotakPDV = (iznosPDV / y) * 100;

            Console.WriteLine($"Iznos PDV-a: {iznosPDV}");
            Console.WriteLine($"Postotak PDV-a: {postotakPDV}%");
                
            Console.ReadKey();


        }
    }
}
