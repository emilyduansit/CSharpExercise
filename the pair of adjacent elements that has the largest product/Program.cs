using System;

namespace the_pair_of_adjacent_elements_that_has_the_largest_product
{
    class Program
    {
        public static int GetProduct(int[] array)
        {
            int product = array[0]*array[1] ;
            for (int i=1; i< array.Length-1 ;i++)
            {
                if( (array[i]*array[i+1]) > product)
                {
                    product=array[i]*array[i+1];
                };                
            }
            return product;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetProduct(new int[]{2, 4, 2, 6, 9, 3}));
            Console.WriteLine(GetProduct(new int[]{0, -1,-1, -2}) );
             Console.WriteLine(GetProduct(new int[]{6, 1, 12, 3, 1, 4}) );
              Console.WriteLine(GetProduct(new int[]{1, 4, 3, 0}) );

        }
    }
}
