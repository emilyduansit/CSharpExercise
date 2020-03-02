using System;

namespace split_a_sentence_to_strings
{
    class Program
    {
        static void Main(string[] args)
        {
                    string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
                    string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
                    
                    for (int i=0; i< words.Length ;i++)
                    {
                        Console.WriteLine(words[i]);
                    }
                    Console.WriteLine("wordslength: {0} ",words.Length);

                    for (int i = words.Length-1 ; i>=0 ; i--)
                    {
                        Console.Write(words[i]+" ");
                    }
        }
    }
}
