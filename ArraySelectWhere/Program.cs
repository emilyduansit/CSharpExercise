using System;
using System.Linq;
using System.Collections;

namespace ArraySelectWhere
{

    class Program
    {
        public static int[] sort_numbers(int[] arra)
        {
        
            int[] num = arra.Where(x => x != -5).OrderBy(x => x).ToArray();
            int ctr = 0;

            return arra.Select(x => x >= 0 ? num[ctr++] : -5).ToArray();
        }
        static void Main(string[] args)
        {
                // An input data array.
            string[] array = { "cat", "dog", "mouse" };

            // Apply a transformation lambda expression to each element.
            // ... The Select method changes each element in the result.
            var result = array.Select(element => element.ToUpper());

            // Display the result.
            foreach (string value in result)
            {
                Console.WriteLine(value);
            }

                // Input.
            string[] array_many =
            {
                "dot",
                "net",
                "perls"
            };

            // Convert each string in the string array to a character array.
            // ... Then combine those character arrays into one.
            var result_many = array_many.SelectMany(element => element.ToCharArray());

            // Display letters.
            foreach (char letter in result_many)
            {
                Console.WriteLine(letter);
            }

            int[] x = sort_numbers(new int[] {-5, 236, 120, 70, -5, -5, 698, 280 });
            foreach(var item in x)
             {
               Console.WriteLine(item.ToString());
              }

        }
    }
}
