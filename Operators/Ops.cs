using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;
            var flt = (float)a / (float)b;
            var pemdas = a + b * c;
            //var pemdasstr = pemdas.ToString();
            Console.WriteLine(flt);
            Console.WriteLine("The value of this operation is " + pemdas); //operator PEMDAS
            Console.WriteLine(c > b && c == a); //false
            Console.WriteLine(!(c > b && c == a)); //true
            Console.WriteLine(c > b || c == a); //true
            Console.ReadKey();
        }
    }
}
