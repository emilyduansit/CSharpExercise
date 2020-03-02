using System;

namespace create_a_new_string_of_four_copies__taking_last_four_characters_from_a_given_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string:");
            String str= Console.ReadLine();

            String substr = str.Substring(str.Length-4);
            Console.WriteLine("Output:{0}{0}{0}{0}",substr);
        }
    }
}
