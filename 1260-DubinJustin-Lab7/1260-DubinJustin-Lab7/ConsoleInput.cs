///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Interfaces Lab
//	File Name:         ConsoleInput.cs
//	Description:       Implements IInput. Receives Prompts and asks user for
//                     Strings, Ints, Doubles etc...
//	Course:            CSCI-1260
//	Author:            Justin Dubin, dubinj@etsu.edu, East Tennessee State University
//	Created:           11/08/2022
//  Modified:          11/11/2022
//	Copyright:         Justin Dubin, 2022
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace InterfacesLab
{
    /// <summary>
    /// Impliments Users inputs to IInput
    /// </summary>
    public class ConsoleInput : IInput
    {
        string prompt = null;   //Prompt passed in to GetCommand

        /// <summary>
        /// Allows user to return string to program
        /// </summary>
        /// <returns>prompt (Whatever the user enters as a string) </returns>
        public string GetCommand()
        {
            string prompt = Console.ReadLine();
            return prompt;
        }

        /// <summary>
        /// Allows user to return a string to program, program checks to see if it equals "OK"
        /// </summary>
        /// <param name="prompt">Asks user to type OK</param>
        /// <returns>Prompt (Whatever the user enters as a string) </returns>
        public string GetCommand(string prompt)
        {
            Console.WriteLine(prompt);
            prompt = Console.ReadLine();
            return prompt;
        }

        /// <summary>
        /// Allows user to return a string to program, method ensures
        /// user will enter North, South, East, or West.
        /// </summary>
        /// <param name="prompt">Asks user to type North, South, East, or West</param>
        /// <param name="allowableValues">Checks if value entered is one of the 4 asked in prompt</param>
        /// <returns>Prompt (Whatever the user enters as a string) </returns>
        public string GetCommand(string prompt, string[] allowableValues)
        {
            restartQuestion:
            Console.WriteLine(prompt);
            prompt = Console.ReadLine();
                if (allowableValues.Contains(prompt))
                {
                   return prompt;
                }
                else
                {
                Console.WriteLine("Not a value in the allowableValues, try again.");
                goto restartQuestion;
                }
        }

        /// <summary>
        /// Asks user for integer
        /// </summary>
        /// <returns>Userint with no restrictions</returns>
        public int GetInteger()
        {
            Console.Write("Enter an integer: ");
            int Userint = Convert.ToInt32(Console.ReadLine());
            return Userint;
        }

        /// <summary>
        /// Asks user for integer (must be between 1 and 5)
        /// </summary>
        /// <param name="lowerBound">LowerBound = 1</param>
        /// <param name="upperBound">UpperBound = 5</param>
        /// <returns>Userint between 1 and 5</returns>
        public int GetInteger(int lowerBound, int upperBound)
        {
            restartQuestion:
            Console.Write("Enter an integer within lower and upper bounds: ");
            int Userint = Convert.ToInt32(Console.ReadLine());
                if(Userint > lowerBound && Userint < upperBound)
                {
                    return Userint;
                }
                else
                {
                    Console.WriteLine("Integer not within bounds, try again.");
                    goto restartQuestion;
                }
        }

        /// <summary>
        /// Asks user for double
        /// </summary>
        /// <returns>Userdouble with no restrictions</returns>
        public double GetDouble()
        {
            Console.Write("Enter a double: ");
            double Userdouble = Convert.ToDouble(Console.ReadLine());
            return Userdouble;
        }

        /// <summary>
        /// Asks user for double (must be between 1 and 5)
        /// </summary>
        /// <param name="lowerBound">lowerBound = 1</param>
        /// <param name="upperBound">upperBound = 5</param>
        /// <returns>Userdouble between 1 and 5</returns>
        public double GetDouble(double lowerBound, double upperBound)
        {
        restartQuestion:
            Console.Write("Enter a double within lower and upper bounds: ");
            double Userdouble = Convert.ToDouble(Console.ReadLine());
            if (Userdouble > lowerBound && Userdouble < upperBound)
            {
                return Userdouble;
            }
            else
            {
                Console.WriteLine("Double not within bounds, try again.");
                goto restartQuestion;
            }
        }
    }
}
