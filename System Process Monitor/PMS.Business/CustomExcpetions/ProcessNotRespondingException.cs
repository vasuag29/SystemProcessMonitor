//*************************************************************************************
//*********Copyright © Siemens AG 2006-2018. All Rights Reserved.**********************
//*************************************************************************************

using System;

namespace CustomExcpetions
{
    /// <summary>
    /// Custom exception class for catching the exception where a process is not responding
    /// </summary>
    public class ProcessNotRespondingException : Exception
    {
        public ProcessNotRespondingException(string message) : base(message)
        {
        }

        public ProcessNotRespondingException(string message, int id) : base(message)
        {
        }
    }
}
