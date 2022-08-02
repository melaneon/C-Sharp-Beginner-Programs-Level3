using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace RectangularApp
{
    class RectangularApp
    {
        static void Main(string[] args)
        {
            double heigh = GetSize("heigh");
            double width = GetSize("width");
            double area = ComputeArea(heigh, width);
            double perimeter = ComputePerimeter(heigh, width);
            Console.Clear();
            
            Console.WriteLine();
            DisplayResults(heigh, width, area, perimeter);
            

            Console.ReadKey();

            
        }
        static double GetSize(string inputType)
        {
            Console.Write("Enter the {0}", inputType);
            double size = double.Parse(Console.ReadLine());
            return size;
        }

        static double ComputeArea(double heigh, double width)
        {
            return width * heigh;
        }

        static double ComputePerimeter(double heigh, double width)
        {
            return heigh + heigh + width + width;
        }

        static void DisplayResults(double heigh, double width, double area, double perimeter)
        {
            Console.WriteLine("Summary of Rectangle Measurements");
            Console.WriteLine("{0,-20}{1,8:N2}","Height:", heigh);
            Console.WriteLine("{0,-20}{1,8:N2}", "Width:", width);
            Console.WriteLine("{0,-20}{1,8:N2}", "Area:", area);
            Console.WriteLine("{0,-20}{1,8:N2}", "Perimeter:", perimeter);
        }

        
    }



}
