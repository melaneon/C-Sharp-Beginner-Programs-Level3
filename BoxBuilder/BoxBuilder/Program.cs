using System;

namespace BoxBuilder
{
    class BoxBuilder
    {
        static void Main(string[] args)
        {
            string TheSmallBox = MakeSmallBox("0");
            Console.WriteLine(TheSmallBox);
            Console.WriteLine();

            string TheMediumBox = MakeMediumBox("0");
            Console.WriteLine(TheMediumBox);
            Console.WriteLine();

            string TheBigBox = MakeBigBox("0");
            Console.WriteLine(TheBigBox);
        }
        static string MakeSmallBox(string theChar)
        {
            const string blank = " ";
            const string newLine = "\n";
            string theBox = theChar + theChar + theChar + newLine
                   + theChar + blank + theChar + newLine
                   + theChar + theChar + theChar;
            return theBox;
        }


        static string MakeMediumBox(string theChar)
        {
            const string blank = " ";
            const string newLine = "\n";
            string theBox = theChar + theChar + theChar + theChar + newLine
                  + theChar + blank + blank + theChar + newLine
                  + theChar + blank + blank + theChar + newLine
                  + theChar + theChar + theChar + theChar;
            return theBox;
        }



            static string MakeBigBox(string theChar)
            {
                const string blank = " ";
                const string newLine = "\n";
                string theBox = theChar + theChar + theChar + theChar + theChar + newLine
                      + theChar + blank + blank + blank + theChar + newLine
                      + theChar + blank + blank + blank + theChar + newLine
                      + theChar + blank + blank + blank + theChar + newLine
                      + theChar + theChar + theChar + theChar + theChar;
                return theBox;

            }


        
    }


}
