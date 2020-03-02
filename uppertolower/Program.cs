using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Exercise42
{
    public static void Main( )
    {
        Console.Write("Input a string: ");
        string str = Console.ReadLine();
         if (str.Length < 4) 
           Console.WriteLine(str.ToUpper());
         else
           Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4, str.Length -4).ToUpper());
    }
}
