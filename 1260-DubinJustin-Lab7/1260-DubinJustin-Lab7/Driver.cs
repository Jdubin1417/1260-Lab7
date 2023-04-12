///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Interfaces Lab
//	File Name:         Driver.cs
//	Description:       Creates a new IOTester using the student's defined ConsoleInput and ConsoleOutput classes
//                     and tests their implementations for correctness.
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
    /// Creates a new IOTester using the student's defined ConsoleInput and ConsoleOutput classes
    /// and tests their implementations for correctness.
    /// 
    /// You should have an idea of whether your implementation is correct if you are receiving all success
    /// messages in the output.
    /// See IInput and IOutput for descriptions on the use of their methods.
    /// 
    /// SHOULD NOT BE MODIFIED.
    /// </summary>
    public class Driver
    {
        /// <summary>
        /// Creates a new IOTester using the student's defined ConsoleInput and ConsoleOutput classes
        /// and tests their implementations for correctness.
        /// </summary>
        public static void Main()
        {
            IOTester tester = new IOTester(new ConsoleInput(), new ConsoleOutput());
            tester.Test();
        }
    }
}
