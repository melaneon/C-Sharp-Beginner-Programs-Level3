using System;

namespace SecondConverter
{
    class SecondConverter
    {
        const int SECONDS_PER_MINUTE = 60;
        const int SECONDS_PER_HOUR = 3600;
        static void Main()
        {
            int totalSeconds = GetSeconds();
            int minutes = Mins(totalSeconds);
            int hours = Hours(totalSeconds);
            int seconds = LastSeconds(totalSeconds);

            Console.Clear();
            DisplayResults(totalSeconds, seconds, minutes, hours);

        }

        static int GetSeconds()
        {
            Console.Write("Enter the total seconds:");
            int totalSeconds = int.Parse(Console.ReadLine());
            return totalSeconds;
        }

        
        static int Hours(int totalSeconds)
        {
            int hours = totalSeconds / SECONDS_PER_HOUR;
            return hours;
        }

        static int Mins(int totalSeconds)
        {
            int minutes = totalSeconds / SECONDS_PER_MINUTE % SECONDS_PER_MINUTE;
            return minutes;
        }

        static int LastSeconds(int totalSeconds)
        {
            int seconds = totalSeconds % SECONDS_PER_MINUTE;
            return seconds;
        }
        

        static void DisplayResults(int totalSeconds, int seconds, int minutes, int hours)
        {
            Console.WriteLine("{0,-20}", "Time Converter");
            Console.WriteLine(" ");
            Console.WriteLine("Total Seconds: {0,11:f0}", totalSeconds);
            Console.WriteLine("Minutes: {0,17:f0}", minutes);
            Console.WriteLine("Hours: {0,19:f0}", hours);
            Console.WriteLine("Seconds: {0,17:f0}", seconds);
        }
    }
}
