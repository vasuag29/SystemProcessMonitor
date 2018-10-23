//*************************************************************************************
//*********Copyright © Siemens AG 2006-2018. All Rights Reserved.**********************
//*************************************************************************************

using ProcessRepo;
using System;
using System.Collections.Generic;
using PMS.DAL;
using System.Threading;

namespace ProcessMonitor
{
    /// <summary>
    /// DataWriter class gets realized from the interface IDataProcessor
    /// It handles functions required to write the process data to a file
    /// </summary>
    public class DataWriter //: IDataProcessor
    {
        /// <summary>
        /// Method for writing the process data into a file.
        /// The filetype and output path can be specified.
        /// </summary>
        /// <param name="processes"></param>
        /// <param name="fileType"></param>
        /// <param name="outputPath"></param>
        /// <returns></returns>
        /// 
        public bool WriteData(List<SystemProcess> processes, FileType fileType, string outputPath, string fileName, ref DAL dal)
        {


            //*****************************
            //Change this implementation
            //We already have a list of SystemProcesses and there is no need to create a new list of long
            //*****************************
            List<long> processData = new List<long>();
            List<string> processName = null;
            foreach (var process in processes)
            {
                processData.Add(process.ProcessId);
                foreach (MemoryElement element in process.memoryElements)
                {
                    processData.Add(element.MemorySize);
                }

                //pIds.Add(.);
            }
            //DAL initialized previously - SS
            //dal = new DAL(pIds);
            dal.WriteMemoryData(fileType, processData, outputPath, fileName);
            return true;
        }
    }
}
