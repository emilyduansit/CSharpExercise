using System;

namespace console_write_true
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int16.Parse(Console.ReadLine());

            Console.WriteLine(num % 3 ==0 || num % 7 == 0);
        }
    }
}
