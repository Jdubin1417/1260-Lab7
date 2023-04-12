///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Interfaces Lab
//	File Name:         ConsoleOutput.cs
//	Description:       Implements IOutput. Outputs formatting and data to the user
//	Course:            CSCI-1260
//	Author:            Justin Dubin, dubinj@etsu.edu, East Tennessee State University
//	Created:           11/08/2022
//	Modified:          11/11/2022
//	Copyright:         Justin Dubin, 2022
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
    /// Implemets IOutput in the console
    /// </summary>
    public class ConsoleOutput : IOutput
    {
        /// <summary>
        /// Prints line
        /// </summary>
        public void Divider()
        {
            Console.WriteLine("----------------------------------------------------------------------");
        }

        /// <summary>
        /// Prints output without new line
        /// </summary>
        /// <param name="output">Output from IOutput</param>
        public void Out(string output)
        {
            Console.WriteLine(output);
        }

        /// <summary>
        /// Prints Output with new line
        /// </summary>
        /// <param name="output">Output from IOutput</param>
        public void OutNL(string output)
        {
            Console.WriteLine(output);
            Console.WriteLine();
        }
    }
}
