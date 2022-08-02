using System;

namespace TakeHomePayApp
{
    class TakeHomePayApp
    {
        const int COMMISSIONRATE = 7;//!
        const int FEDERALTAXES = 8;
        const int EI = 9;

        static void Main(string[] args)
        {
            Console.WriteLine("You will be ask to enter the name of an employee");
            Console.WriteLine("and his weekly sales. Calculations will be performed to");
            Console.WriteLine("determine his deductions and take home pay.");
            Console.WriteLine("");
            string Name = GetaName();
            double Sales = GetSales();
            double TotalGrossPay = CalculateGrossPay(COMMISSIONRATE, Sales);
            double TotalFedTaxes = CalculateFedTaxes(FEDERALTAXES, TotalGrossPay);
            double TotalEI = CalculateEI(EI, TotalGrossPay);
            double TotalDeducations = CulculateDecuctions(TotalFedTaxes, TotalEI);
            double TakeHomePay = CalculateHomePay(Sales, TotalDeducations);



            Console.Clear();
            DisplayResults(Name, Sales, TotalGrossPay,
                TotalDeducations, TotalFedTaxes, TotalEI, TakeHomePay);
            Console.ReadKey();

            static string GetaName()
            {
                Console.Write("Please enter an employee name: ");
                string EmployeeName = Console.ReadLine();
                return EmployeeName;
            }
            static double GetSales()
            {
                Console.Write("Please enter this employee's weekly sales: ");
                double EmployeeSales = double.Parse(Console.ReadLine());
                return EmployeeSales;
            }
            static double CalculateGrossPay(double commissionrate, double Sales)
            {
                double gross = (Sales / 100) * commissionrate;
                return gross;
            }
            static double CalculateFedTaxes(double federaltaxes, double TotalGrossPay)
            {
                double fed = TotalGrossPay / 100 * federaltaxes;
                return fed;
            }
            static double CalculateEI(int EI, double TotalGrossPay)
            {
                double ei = TotalGrossPay / 100 * EI;
                return ei;
            }
            static double CulculateDecuctions(double TotalFedTaxes, double TotalEI)
            {
                double deds = TotalFedTaxes + TotalEI;
                return deds;
            }
            static double CalculateHomePay(double Sales, double TotalDeducations)
            {
                double homepay = Sales - TotalDeducations;
                return homepay;
            }

            static void DisplayResults(string Name, double Sales, double TotalGrossPay,
                double TotalDeducations, double TotalFedTaxes, double TotalEI, double TakeHomePay)
            {
                Console.WriteLine("{0,-20}", "Weekly Payroll App"); //"{0,-20}{1,8:N2}","Height:", heigh);
                Console.WriteLine("Employee Name: {0}\n", Name);

                Console.WriteLine("{0,-35}{1,10:c}", "This week's Sales:", Sales);
                Console.WriteLine("omission Rate: ({0}%)\n", COMMISSIONRATE);

                Console.WriteLine("{0,-35}{1,10:c}", "Gross Pay:", TotalGrossPay);
                Console.Write("Federal Taxes Withheld:   ({0}%)", FEDERALTAXES);
                Console.WriteLine("{0,25:c}\n", TotalFedTaxes);
                Console.Write("EI Withheld:  ({0}%)", EI);
                Console.WriteLine("{0,25:c}\n", TotalEI);

                Console.WriteLine("{0,-35}{1,10:c}", "Total Deductions:", TotalDeducations);

                Console.WriteLine("{0,-35}{1,10:c}", "Total Home Pay:", TakeHomePay);


            }
        }
    }
}