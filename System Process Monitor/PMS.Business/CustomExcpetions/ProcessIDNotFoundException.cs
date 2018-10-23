//*************************************************************************************
//*********Copyright © Siemens AG 2006-2018. All Rights Reserved.**********************
//*************************************************************************************

using System;

namespace CustomExcpetions
{
    /// <summary>
    /// Custom exception class for catching the exception where a process with a specific process ID could not be found in the system
    /// </summary>
    public class ProcessIDNotFoundException: Exception
    {
        string message = "Process ID not found";
        public override string Message
        {
            get
            {
                return message;
            }
        }
    }
}
