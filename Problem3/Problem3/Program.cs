using System;

namespace Problem3
{
    class Program3
    {
        static void Main()
        {
            String s1 = ReadInput("prefix");
            String s2 = ReadInput("old");

            Console.WriteLine();
            Console.WriteLine("The old word is {0}.", s2);
            Console.WriteLine("The new word is {0}.", MakeWord(s1, s2));
        }
        static string ReadInput(string inputType)
        {
            Console.Write("Enter the {0} word:", inputType);
            string s = Console.ReadLine();
            return s;

        }
         static string MakeWord(string myChar, string myWord)
        { 
            string s = myChar + myWord;
            return s;





        }
        

    }
}
