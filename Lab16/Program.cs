using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Lab 16
// Date: 03/01/2015 09:15:19 am
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare some constants for saturday and sunday and temperature of freezing
            const string SAT = "Saturday";
            const string SUN = "Sunday";
            const double FREEZE = 32.0;

            // declare some variables to hold user's input
            string today;
            double temp;

            // prompt the user to enter a day and get the input
            Console.Write("Please enter a day of the week, e.g. Tuesday: ");
            today = Console.ReadLine();

            //prompt user for the temperature in F
            Console.Write("Please enter the current temperature in F:");
            temp = double.Parse(Console.ReadLine());


            // see if it is a work day
            if (temp < FREEZE && !(today == SUN || today == SAT))
            {
                // it is a workday and temperature is below freezing, display the go to work message
                Console.WriteLine("Go to work and dress warmly...");
            }
            else if (temp >= FREEZE && !(today == SUN || today == SAT))
            {
                // it is a workday and temp is above freezing, display go to work message
                Console.WriteLine("Go to work");
            }
            else if (today == SUN || today == SAT)
            {
                // its not a workday, display the weekend message
                Console.WriteLine("Ahh... the weekend. No work!");
            }
            else
            {
                Console.WriteLine("No valid entry was registered");
            }

            Console.ReadLine();
        }
    }
}

//Question #1: The value of X could be many answers however the answer would be greater than 8 but less than 10
//Question #2: The value of X could be many answers however the answer would be greater than 5 but less than 8
