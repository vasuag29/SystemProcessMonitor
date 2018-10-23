//*************************************************************************************
//*********Copyright © Siemens AG 2006-2018. All Rights Reserved.**********************
//*************************************************************************************

using System.Collections.Generic;
using ProcessRepo;

namespace ProcessMonitor
{
    /// <summary>
    /// A generic interface that holds abstractions for data processing tasks like writing/reading data to/from a file 
    /// </summary>
    public interface IDataProcessor
    {
        /// <summary>
        /// Abstraction of method for writing process data into a file
        /// </summary>
        /// <param name="processes"></param>
        /// <param name="fileType"></param>
        /// <param name="outputPath"></param>
        /// <returns></returns>
        bool WriteData(List<SystemProcess> processes, FileType fileType, string outputPath);
    }
}
