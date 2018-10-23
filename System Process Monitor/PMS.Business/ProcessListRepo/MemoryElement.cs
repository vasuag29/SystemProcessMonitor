//*************************************************************************************
//*********Copyright © Siemens AG 2006-2018. All Rights Reserved.**********************
//*************************************************************************************

namespace ProcessRepo
{
    /// <summary>
    /// Memory element class holds the memory attribute of a process: the type of memory and its size
    /// </summary>
    public class MemoryElement
    {
        #region Property
        public string  MemoryType { get; set; }
        public long MemorySize { get; set; }
        #endregion

        #region Constructor

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="memoryType">Tpe of Process Memory</param>
        /// <param name="memorySize">Size of Process Memory</param>
        public MemoryElement(string memoryType, long memorySize)
        {
            MemoryType = memoryType;
            MemorySize = memorySize;
        }
        #endregion
    }
}
