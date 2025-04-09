using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect01
{
    class Program
    {
        static void Main(string[] args)
        {
            const int r = 5;
            double a,c;
            a = Math.PI * (Math.Pow(r, 2));
            Console.WriteLine("El área del círculo es " + a);
            Console.ReadKey();
        }
    }
}
