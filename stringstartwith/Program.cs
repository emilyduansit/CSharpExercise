using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Exercise34 {
  static void Main(string[] args)
        {
           string str; 
           Console.Write("Input a string : ");
           str = Console.ReadLine();

           if (str.Substring(1,2) == "HP")
           {
               Console.WriteLine(str.Substring(0,1)+str.Substring(3));
           }
           
        }
}
