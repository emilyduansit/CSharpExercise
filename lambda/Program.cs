using System;
using System.Linq;

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));
            // Output:
            // 25

            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            Console.WriteLine(e);
            // Output:
            // x => (x * x)

            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));
            // Output:
            // 4 9 16 25

            String str = "adflskajlfkjdl123safdfas";
            int count=str.Count();
            Console.WriteLine(count);

            count=str.Count(s=>s=='a');
            Console.WriteLine(count);

            Func<string> greet = () => "Hello, World!";
            Console.WriteLine(greet());

            Func<int, int, bool> testForEquality = (x, y) => x == y;
            Console.WriteLine(testForEquality(1,2));

            Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;
            Console.WriteLine(isTooLong(5,"hello world"));

            Action<string> greetword = name => 
            { 
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };
            greetword("World");
            // Output:
            // Hello World!
            

        }
    }
}
