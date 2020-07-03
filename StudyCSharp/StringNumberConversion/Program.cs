using System;

namespace StringNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            string b = a.ToString();
            Console.WriteLine(b);

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine(d);

            string e = "123456";
            int f = Convert.ToInt32(e);
            Console.WriteLine(f);

            string g = "12345";
            int i;
            bool result = int.TryParse(g, out i); // if transration mission succeed diaplay true and false
            if (int.TryParse(g,out i))
            {
                Console.WriteLine($"i = {i}");
            }
            else
            {
                Console.WriteLine("We couldn't translate the string to integer, Im Sorry");
            }
            
        }
    }
}
