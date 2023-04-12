///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Interfaces Lab
//	File Name:         IInput.cs
//	Description:       Defines an interface for input of strings, integers, and doubles
//	Course:            CSCI-1260
//	Author:            Katie Wilson, wilsonkl4@etsu.edu, East Tennessee State University
//	Created:           11/8/2022
//	Copyright:         Katie Wilson, 2022
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLab
{
    /// <summary>
    /// Defines a contract for allowing string, integer, and double input
    /// 
    /// SHOULD NOT BE MODIFIED.
    /// </summary>
    public interface IInput
    {
        /// <summary>
        /// Retrieves a string from the user
        /// </summary>
        /// <returns>the string the user enters</returns>
        public string GetCommand();

        /// <summary>
        /// Prompts the user with the given prompt and retrieves a string from them
        /// </summary>
        /// <param name="prompt">a message to display to the user to prompt them for information</param>
        /// <returns>the string the user enters</returns>
        public string GetCommand(string prompt);

        /// <summary>
        /// Prompts the user with the given prompt and retrieves a string from them;
        /// ensures that the user can only enter one of the values in the list of allowable values
        /// </summary>
        /// <param name="prompt">a message to display to the user to prompt them for information</param>
        /// <param name="allowableValues">a collection of values that the user is allowed the enter</param>
        /// <returns>the string the user enters</returns>
        public string GetCommand(string prompt, string[] allowableValues);

        /// <summary>
        /// Retrieves an integer from the user
        /// </summary>
        /// <returns>the integer the user enters</returns>
        public int GetInteger();

        /// <summary>
        /// Retrieves an integer from the user, only allowing a value that falls within the given upper and 
        /// lower bounds
        /// </summary>
        /// <param name="lowerBound">the lower limit of allowable values, inclusive</param>
        /// <param name="upperBound">the upper limit of allowable values, inclusive</param>
        /// <returns>the integer the user enters</returns>
        public int GetInteger(int lowerBound, int upperBound);

        /// <summary>
        /// Retrieves a double from the user
        /// </summary>
        /// <returns>the double the user enters</returns>
        public double GetDouble();

        /// <summary>
        /// Retrieves a double from the user, only allowing a value that falls within the given upper and 
        /// lower bounds
        /// </summary>
        /// <param name="lowerBound">the lower limit of allowable values, inclusive</param>
        /// <param name="upperBound">the upper limit of allowable values, inclusive</param>
        /// <returns>the double the user enters</returns>
        public double GetDouble(double lowerBound, double upperBound);
    }
}
