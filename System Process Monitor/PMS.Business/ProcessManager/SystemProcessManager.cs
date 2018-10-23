//*************************************************************************************
//*********Copyright © Siemens AG 2006-2018. All Rights Reserved.**********************
//*************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Management;
using System.Diagnostics;
using ProcessRepo;
using ProcessMonitor;
using CustomExcpetions;
using PMS.DAL;

namespace ProcessManager
{
    /// <summary>
    /// Manager class containing all the methods for performing the monitoring task for the processes
    /// </summary>
    public class SystemProcessManager
    {
        public bool isWriterRunning;
        DataWriter writer = new DataWriter();
        public string FileName { get; set; }
        DAL dal = new DAL();

        #region Constructor
        public SystemProcessManager()
        {
            this.isWriterRunning = false;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Method for getting command line arguments of a <paramref name="process"/>
        /// </summary>
        /// <param name="process"></param>
        /// <returns>COmmandLineArguments</returns>
        private string GetCommandLine(Process process)
        {
            if (process.Responding)
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + process.Id))
                using (ManagementObjectCollection objects = searcher.Get())
                {
                    return objects.Cast<ManagementBaseObject>().SingleOrDefault()?["CommandLine"]?.ToString();
                }
            }
            else throw new ProcessNotRespondingException("The process with process ID " + process.Id + " was unresponsive");
        }

        /// <summary>
        /// Method for getting the list of file types that a file can have
        /// </summary>
        /// <returns>Get List of File Types</returns>
        public List<FileType> GetFileTypes()
        {
            List<FileType> fileTypes = new List<FileType>();
            foreach (FileType file in Enum.GetValues(typeof(FileType)))
            {
                fileTypes.Add(file);
            }
            return fileTypes;
        }

        /// <summary>
        /// Method for creating the thread flow for writing process data to a file at specified sampling rate.
        /// After the sampling interval, the write method is called and the data is written to a file.
        /// </summary>
        /// <param name="processIds"></param>
        /// <param name="samplingRate"></param>
        /// <param name="fileType"></param>
        /// <param name="fileName"></param>
        /// <param name="outputPath"></param>
        /// <returns></returns>
        public bool StartWriting(List<int> processIds, int samplingRate, FileType fileType, string outputPath)
        {
            bool isWritten = false;
            isWriterRunning = true;
            FileName = DateTime.Now.ToString("dd-MM-yy--hh-mm-ss");

            while (isWriterRunning)
            {
                List<SystemProcess> systemProcesses = new List<SystemProcess>();
                systemProcesses = GetAllProcessesById(processIds);
                Thread writeThread = new Thread(() => WriteProcessDetails(systemProcesses, fileType, outputPath, FileName, ref dal));
                writeThread.Start();
                //writeThread.Join();
                Thread.Sleep(samplingRate * 1000);
                //writeThread.Join();
            }
            isWritten = true;
            return isWritten;
        }

        /// <summary>
        /// Method for starting the task for writing process data into file using the DataWriter object
        /// </summary>
        /// <param name="systemProcesses"></param>
        /// <param name="fileType"></param>
        /// <param name="outputPath"></param>
        private void WriteProcessDetails(List<SystemProcess> systemProcesses, FileType fileType, string outputPath, string fileName, ref DAL dal)
        {
            writer.WriteData(systemProcesses, fileType, outputPath, fileName, ref dal);
        }

        /// <summary>
        /// Method for stopping the writing process by making the 'isWriterRunning' boolean false
        /// </summary>
        public void StopWriting()
        {
            dal.DeleteCSV();
            isWriterRunning = false;
        }

        /// <summary>
        /// Method for getting a list of all the processes that have specific process IDs stored in a list of process IDs
        /// </summary>
        /// <param name="processIds"></param>
        /// <returns></returns>
        private List<SystemProcess> GetAllProcessesById(List<int> processIds)
        {
            List<SystemProcess> systemProcesses = new List<SystemProcess>();
            Process process = new Process();
            foreach (int processId in processIds)
            {
                try { process = Process.GetProcessById(processId); }
                catch (ProcessIDNotFoundException) { }
                if (process.Responding)
                {
                    systemProcesses.Add(GetSystemProcess(process));
                }
                else throw new ProcessNotRespondingException("The process with process ID({0}) was unresponsive", process.Id);
            }
            return systemProcesses;
        }

        /// <summary>
        /// Method for getting a SystemProcess object with all the attributes injected
        /// </summary>
        /// <param name="process"></param>
        /// <returns></returns>
        private SystemProcess GetSystemProcess(Process process)
        {
            if (process.Responding)
            {
                process.Refresh();
                SystemProcess systemProcess = new SystemProcess(process.Id, process.ProcessName, GetCommandLine(process));
                systemProcess.memoryElements.Add(new MemoryElement("Private Memory", process.PrivateMemorySize64));
                systemProcess.memoryElements.Add(new MemoryElement("Virtual Memory", process.VirtualMemorySize64));
                systemProcess.memoryElements.Add(new MemoryElement("Working Set", process.WorkingSet64));
                systemProcess.memoryElements.Add(new MemoryElement("Working Set - Private", GetWorkingSetPrivate(process)));
                systemProcess.memoryElements.Add(new MemoryElement("Paged Memory", process.PagedMemorySize64));
                systemProcess.memoryElements.Add(new MemoryElement("Paged System Memory", process.PagedSystemMemorySize64));
                systemProcess.memoryElements.Add(new MemoryElement("Non-paged System Memory", process.NonpagedSystemMemorySize64));
                return systemProcess;
            }
            else throw new ProcessNotRespondingException("The process with process ID({0}) was unresponsive", process.Id);
        }

        /// <summary>
        /// Method for getting the working set - private for a process
        /// </summary>
        /// <param name="process"></param>
        /// <returns></returns>
        private long GetWorkingSetPrivate(Process process)
        {
            var counter = new PerformanceCounter("Process", "Working Set - Private", process.ProcessName);
            return (counter.RawValue / 1024);
        }

        /// <summary>
        /// Method for getting all the system processes running at present.
        /// It can be used for populating the data grid of processes.
        /// </summary>
        /// <returns></returns>
        public List<SystemProcess> GetAllSystemProcesses()
        {
            List<SystemProcess> systemProcesses = new List<SystemProcess>();
            foreach (Process process in Process.GetProcesses())
            {
                systemProcesses.Add(new SystemProcess(process.Id, process.ProcessName, GetCommandLine(process)));
            }
            return systemProcesses;
        }
        #endregion
    }
}

