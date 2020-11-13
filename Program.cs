/* 
Josh Bartlett
23June2019
Assignment 1.3
Prompt user for and accepts estimates for the number of hours for a job and 
the number of miles involved in the move and displays the total moving fee.
*/

using System;
using static System.Console;

namespace MoveEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            // The named constants for the base rate, cost per hour, and cost per mile
            const int baseRate = 200;
            const int perHour = 150;
            const int perMile = 2;

            // Variables for the user inpputs as strings
            string hoursString;
            string milesString;

            // Variables to convert the user input strings into intergers
            int estHours = 0;
            int estMiles = 0;

            // Variable to hold the calculated total 
            int total = 0;

            // Ask user for input for estimated number of hours, read that into the hoursString variable, and then convert to an integer in the estHours variable
            Write("Estimated Number of Hours: ");
            hoursString = ReadLine();
            estHours = Convert.ToInt16(hoursString);

            // Ask user for input for estimated number of miles, read that into the milesString variable, and then convert to an integer in the estMiles variable
            Write("Estimated Number of Miles: ");
            milesString = ReadLine();
            estMiles = Convert.ToInt16(milesString);

            // Calculate the estimated total moving fee
            total = baseRate + (perHour * estHours) + (perMile * estMiles);

            // Displays the estimated total moving fee
            WriteLine("The Estimated Total Moving Fee Is $" + total);

            // Keeps the console open until user presses a key
            Write("Press any key to contunue...");
            ReadKey(true);

        }
    }
}
