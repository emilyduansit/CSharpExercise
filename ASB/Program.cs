using System;

namespace ASB
{
    class Program
    {
        public static void solution(int N)
        {
            for(int i=0; i<N-1 ; i++)
            Console.WriteLine("L");
            for(int i=0;i<N ; i++)
            Console.Write("L");
        }

        static void Main(string[] args)
        {
            solution(4);
        }
    }
}
