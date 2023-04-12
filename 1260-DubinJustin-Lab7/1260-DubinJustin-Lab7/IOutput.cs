///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Interfaces Lab
//	File Name:         IOutput.cs
//	Description:       Defines an interface for output of strings
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
    /// Defines a contract for the output of strings as-is, followed by a newline, and for a divider
    /// 
    /// SHOULD NOT BE MODIFIED.
    /// </summary>
    public interface IOutput
    {
        /// <summary>
        /// Prints the desired string to the appropriate source
        /// </summary>
        /// <param name="output">the string to output</param>
        public void Out(string output);

        /// <summary>
        /// Prints the desired string to the appropriate source, followed by a newline
        /// </summary>
        /// <param name="output">the string to output</param>
        public void OutNL(string output);

        /// <summary>
        /// Prints ----------------------------------------------------------------------
        /// </summary>
        public void Divider();
    }
}
