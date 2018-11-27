using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classing
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
            Console.ReadKey();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var tokwa = new Person();
            tokwa.FirstName = "Peklat";
            tokwa.LastName = "Bakokang";
            tokwa.Introduce();
        }
    }
}
