///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Interfaces Lab
//	File Name:         IOTester.cs
//	Description:       Tests implementations of the IInput and IOutput interfaces to see if they are implemented
//	                   properly.
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
    /// Tests implementations of the IInput and IOutput interfaces to see if they are implemented properly
    /// 
    /// SHOULD NOT BE MODIFIED.
    /// </summary>
    public class IOTester
    {
        private IInput Input;
        private IOutput Output;

        /// <summary>
        /// Constructor - handles injection of IInput and IOutput instances
        /// </summary>
        /// <param name="input">an object that implements IInput</param>
        /// <param name="output">an object that implements IOutput</param>
        public IOTester(IInput input, IOutput output)
        {
            Input = input;
            Output = output;
        }

        /// <summary>
        /// Tests implementations of the IInput and IOutput interfaces to see if they are implemented properly
        /// </summary>
        public void Test()
        {
            string command = "";
            int integerVal = 0;
            double doubleVal = 0.0;

            //GetCommand()
            Output.Divider();
            Output.OutNL("Please enter a command");
            command = Input.GetCommand();
            if(command != null)
            {
                Output.OutNL("GetCommand - no parameters - success!");
            }
            else
            {
                Output.OutNL("GetCommand - no parameters - fail");
            }
            Output.Divider();

            //GetCommand(prompt)
            command = Input.GetCommand("Please type OK");
            if(command == "OK")
            {
                Output.OutNL("GetCommand - prompt - success!");
            }
            else
            {
                Output.OutNL("GetCommand - prompt - fail");
            }
            Output.Divider();

            //GetCommand(prompt, allowable)
            command = Input.GetCommand("Please enter North, South, East, or West", new string[] { "North", "South", "East", "West" });
            if(command == "North" || command == "South" || command == "East" || command == "West")
            {
                Output.OutNL("GetCommand - prompt + allowable - success!");
            }
            else
            {
                Output.OutNL("GetCommand - prompt + allowable - fail");
            }
            Output.Divider();

            //GetInteger()
            Output.OutNL("Please enter an integer");
            integerVal = Input.GetInteger();
            Output.OutNL($"GetInteger - got {integerVal}");
            Output.Divider();

            //GetInteger(lower, upper)
            Output.OutNL("Please enter an integer between 1 and 5");
            integerVal = Input.GetInteger(1, 5);
            if(integerVal >= 1 && integerVal <= 5)
            {
                Output.OutNL("GetInteger - between 1 and 5 - success");
            }
            else
            {
                Output.OutNL("GetInteger - between 1 and 5 - fail");
            }
            Output.Divider();

            //GetDouble()
            Output.OutNL("Please enter a double");
            doubleVal = Input.GetDouble();
            Output.OutNL($"GetDouble - got {doubleVal}");
            Output.Divider();

            //GetDouble(lower, upper)
            Output.OutNL("Please enter a double between 1.0 and 5.0");
            doubleVal = Input.GetDouble(1, 5);
            if (doubleVal >= 1.0 && doubleVal <= 5.0)
            {
                Output.OutNL("GetDouble - between 1.0 and 5.0 - success");
            }
            else
            {
                Output.OutNL("GetDouble - between 1.0 and 5.0 - fail");
            }
            Output.Divider();
        }
    }
}
