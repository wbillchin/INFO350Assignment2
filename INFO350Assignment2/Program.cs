/*
 * INFO 350 - Assignment 2
 * 
 * <replace with your name>
 * 
 * CHANGE
 * 
 * Write a program in C# that computes and prints the number of quarters,
 * dimes, nickels, and pennies that a customer should get back as change. 
 * 
 * 
 * Modify this code to complete this assignment
 */


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString;

            Console.WriteLine("Type in something: ");

            // reads in a string from the console
            inputString = Console.ReadLine();

            // checks that we got a string back instead of a null
            // note we have not covered null yet
            if (inputString == null)
            {
                Console.WriteLine("Incorrect input, exiting");
                return;
            }

            /*
             * note that below, the " is escaped as \" such that the compiler
             * doesn't mistake it for the end of the string
             */
            Console.WriteLine("You typed in \"" + inputString + "\"");
        }
    }
}