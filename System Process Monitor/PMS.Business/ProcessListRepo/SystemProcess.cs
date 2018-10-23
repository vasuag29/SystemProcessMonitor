//*************************************************************************************
//*********Copyright © Siemens AG 2006-2018. All Rights Reserved.**********************
//*************************************************************************************

using System;
using System.Collections.Generic;

namespace ProcessRepo
{
    /// <summary>
    /// A class that holds the properties of a process, like process ID, process name, memory usage
    /// </summary>
    public class SystemProcess
    {
        #region Property
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public string CommandLineArgument { get; set; }
        public List<MemoryElement> memoryElements;
        #endregion

        #region Constructor
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="processName"></param>
        /// <param name="commandLineArgument"></param>
        public SystemProcess(int processId, string processName, string commandLineArgument) : this()
        {
            ProcessId = processId;
            ProcessName = processName;
            CommandLineArgument = commandLineArgument;
        }
        
        public SystemProcess()
        {
            memoryElements = new List<MemoryElement>();
        }
        #endregion
    }
}
