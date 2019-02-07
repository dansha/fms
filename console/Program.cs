using System;
using c1;
using c2;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            string kuku = c1.me();
            Class2 c2 = new Class2();
            string muku = c2.family();
            Console.WriteLine("Hello " + kuku + " " + muku);
            Console.ReadLine();
        }
    }
}
