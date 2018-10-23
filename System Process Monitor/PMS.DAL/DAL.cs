using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using ClosedXML.Excel;
using System.Threading;
using ProcessRepo;

namespace PMS.DAL
{
    public class DAL
    {
        public string FileName { get; set; }
        //Removed parameter - SS
        public DAL()
        {
        }

        public void WriteMemoryData(FileType fileType, List<long> processes, string outputPath, string fileName)
        {
            this.FileName = outputPath + fileName; 
            switch (fileType)
            {
                case FileType.XLSX: //Excel file
                    {
                        WriteFile(processes, ",");
                        ConvertWithClosedXml();
                        //if (File.Exists(FileName+".csv"))
                        //{
                        //    File.Delete(FileName + ".csv");
                        //}
                        break;
                    }
                //CSV File
                case FileType.CSV:
                    {
                        WriteFile(processes, ",");
                        break;
                    }
                //TSV File
                case FileType.TSV:  
                    {
                        WriteFile(processes, "\t");
                        break;
                    }

            }
        }

        private void WriteFile(List<long> processes, string delimitter)
        {
            string tempFileName;
            if (delimitter == ",")
                tempFileName = FileName + ".csv";
            else
                tempFileName = FileName + ".tsv";


            string gap = "\n";


            //Check if file exisits, otherwise create it with headers
            if (!(File.Exists(tempFileName)))
            {
                List<string> titles = new List<string> { "Process Id", "Private Memory",
                    "Virtual Memory", "Working Set", "Working Set - Private",
                    "Paged Memory", "Paged System Memory", "Non-paged System Memory"};
                string title = titles[0] + delimitter + titles[1] + delimitter
                    + titles[2] + delimitter + titles[3] + delimitter +
                    titles[4] + delimitter + titles[5] + delimitter + titles[6] +
                    delimitter + titles[7];

                //Write to CSV file
                File.WriteAllText(tempFileName, title);
                File.AppendAllText(tempFileName, gap);

            }
            for (int i = 0; i < processes.Count; i+=8)
            {


                //Create data structure to hold datato be written
                Dictionary<long, List<long>> data = new Dictionary<long, List<long>>();
             
                data.Add(processes[i], new List<long> { processes[i + 1], processes[i + 2],
                    processes[i + 3], processes[i + 4], processes[i + 5],
                    processes[i + 6], processes[i+7] });

                //String to be written
                string date = "Sample Time: " + DateTime.Now.ToString("hh:mm:ss--dd-MM-yy") + "\n";
                string val = String.Join(Environment.NewLine, data.Select(d => d.Key + delimitter
                    + d.Value[0] + delimitter + d.Value[1] + delimitter + d.Value[2] + delimitter + d.Value[3] + delimitter
                    + d.Value[4] + delimitter + d.Value[5] + delimitter + d.Value[6]));
                

              
                //Write timestamp only if it is first process
                if (processes[0] == processes[i])
                    File.AppendAllText(tempFileName, date);

                File.AppendAllText(tempFileName, val);
                //Goto next line for next data
                File.AppendAllText(tempFileName, gap);
            }
            File.AppendAllText(tempFileName, gap);

        }

        private void ConvertWithClosedXml()
        {
            var csvLines = System.IO.File.ReadAllLines(FileName + ".csv", Encoding.UTF8).Select(a => a.Split(','));

            int rowCount = 0;
            int colCount = 0;

            using (var workbook = new XLWorkbook())
            {
                using (var worksheet = workbook.Worksheets.Add("ProcessMemoryInfo"))
                {
                    rowCount = 1;
                    foreach (var line in csvLines)
                    {
                        colCount = 1;
                        foreach (var col in line)
                        {
                            worksheet.Cell(rowCount, colCount).Value = TryConvert(col);
                            colCount++;
                        }
                        rowCount++;
                    }

                }
                workbook.SaveAs(FileName + ".xlsx");
            }
        }

        public static object TryConvert(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return (string.Empty);
            }
            
            double doubleValue = 0;
            if (double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture.NumberFormat, out doubleValue))
            {
                return (doubleValue);
            }

            float floatValue = 0;
            if (float.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture.NumberFormat, out floatValue))
            {
                return (floatValue);
            }

            long longValue = 0;
            if (long.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture.NumberFormat, out longValue))
            {
                return (longValue);
            }

            int intValue = 0;
            if (int.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture.NumberFormat, out intValue))
            {
                return (intValue);
            }

            bool boolValue = false;
            if (bool.TryParse(value, out boolValue))
            {
                return (boolValue);
            }

            DateTime dateTimeValue = DateTime.MinValue;
            if (DateTime.TryParse(value, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dateTimeValue))
            {
                return (dateTimeValue);
            }

            return (value);
        }

        public bool DeleteCSV()
        {
            if (File.Exists(FileName + ".xlsx"))
            {
                if (File.Exists(FileName + ".csv"))
                {
                    File.Delete(FileName + ".csv");
                }
            }
            return true;
        }

    }
}
