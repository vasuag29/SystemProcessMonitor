//*************************************************************************************
//*********Copyright © Siemens AG 2006-2018. All Rights Reserved.**********************
//*************************************************************************************

using System.Collections.Generic;
using ProcessRepo;

namespace ProcessMonitor
{
    /// <summary>
    /// Abstract class that realizes the interface IDataProcessor and holds the abstractions for possible operations
    /// </summary>
    public abstract class DataProcessor : IDataProcessor
    {
        /// <summary>
        /// Abstract method for writing process data to a file
        /// </summary>
        /// <param name="processes"></param>
        /// <param name="fileType"></param>
        /// <param name="outputPath"></param>
        /// <returns></returns>
        public abstract bool WriteData(List<SystemProcess> processes, FileType fileType, string outputPath);
    }
}
