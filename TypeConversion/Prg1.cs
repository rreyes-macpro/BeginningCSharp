using System;


namespace TypeConversion
{
    class Prg1
    {
        static void Main()
        {
            try
            {
                //var number = "1234";
                //byte b = Convert.ToByte(number);
                //Console.WriteLine(b);

                string str = "false";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
                Console.WriteLine("Press Any Key To Continue ...");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Number could not be converted to a byte");
                Console.WriteLine("Press Any Key To Continue ...");
                Console.ReadKey();
            }
            
        }
    }
}
