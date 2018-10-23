using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using ProcessManager;
using ProcessRepo;
using System.Threading;

namespace UI
{
    public partial class processMonitorUIMain : Form
    {
        SystemProcessManager systemProcessManager = new SystemProcessManager();
        List<SystemProcess> processes = null;
        Thread progressBarLoopThread = null;

        public processMonitorUIMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            fileFormatBox.DataSource = systemProcessManager.GetFileTypes();
            processes = systemProcessManager.GetAllSystemProcesses();
            stopBtn.Enabled = false;
            try
            {
                foreach (SystemProcess process in processes)
                {
                    processGrid.Rows.Add(false, process.ProcessId, process.ProcessName, process.CommandLineArgument);
                }
            }
            catch (Exception exception)
            { }
        }

        private void AutoSizeGrid()
        {
            for (int i = 0; i < processGrid.ColumnCount - 1; i++)
            {
                int colw = processGrid.Columns[i].Width;
                processGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                processGrid.Columns[i].Width = colw;
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                outputFileTextBox.Text = folderDlg.SelectedPath;
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            List<SystemProcess> processes = systemProcessManager.GetAllSystemProcesses();
            processGrid.Rows.Clear();
            selectedProcessGrid.Rows.Clear();
            try
            {
                foreach (var process in processes)
                {
                    processGrid.Rows.Add(false, process.ProcessId, process.ProcessName, process.CommandLineArgument);
                }
            }
            catch
            {
                //Intentionally left empty because exceptions occour when access to process is denied
            }
            MessageBox.Show("Processes refreshed");
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != null)
            {
                if (IsOnlyDigit(searchBox.Text))
                {
                    AddMatchingProcesses(searchBox.Text, 1);
                }
                else
                {
                    AddMatchingProcesses(searchBox.Text, 2);
                }
                refreshBtn.Enabled = false;
            }
            if (String.IsNullOrEmpty(searchBox.Text))
            {
                refreshBtn.Enabled = true;
            }
        }

        private void AddMatchingProcesses(string text, int columnNo)
        {
            processGrid.Rows.Clear();
            switch (columnNo)
            {
                case 1:

                    //comparing with the first column i.e. the Process ID column

                    try
                    {
                        foreach (var process in processes)
                        {
                            if (process.ProcessId.ToString().Contains(text))
                            {
                                if (!ExistsInGrids(process.ProcessId))
                                {
                                    processGrid.Rows.Add(false, process.ProcessId, process.ProcessName, process.CommandLineArgument);
                                }
                            }

                        }
                    }
                    catch (Exception exception)
                    { }
                    break;

                case 2:

                    //Comparing with the second column i.e. the Process Name column

                    try
                    {
                        foreach (var process in processes)
                        {
                            if (process.ProcessName.ToLower().Contains(text.ToLower()))
                            {
                                if (!ExistsInGrids(process.ProcessId))
                                {
                                    processGrid.Rows.Add(false, process.ProcessId, process.ProcessName, process.CommandLineArgument);
                                }
                            }

                        }
                    }
                    catch (Exception exception)
                    {
                        //Intentionally left blank as exception occours when access to process is denied
                    }
                    break;
            }

        }

        private bool ExistsInGrids(int id)
        {
            bool exists = false;

            foreach (DataGridViewRow row in selectedProcessGrid.Rows)
            {
                if (Convert.ToInt32(row.Cells[1].Value) == id)
                {
                    exists = true;
                    break;
                }
            }

            return exists;
        }

        private bool IsOnlyDigit(string text)
        {
            bool isDigit = true;
            foreach (var charInText in text)
            {
                if (charInText < '0' || charInText > '9')
                {
                    isDigit = false;
                }
            }
            return isDigit;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (AllFieldsFilled())
            {
                if (String.IsNullOrEmpty(outputFileTextBox.Text) || String.IsNullOrWhiteSpace(outputFileTextBox.Text))
                {
                    outputFileTextBox.Text = @"C:\Users\" + Environment.UserName + @"\Documents\ProcessMonitoringSystem\MonitorData\";
                }
                List<int> processIDList = new List<int>();
                foreach (DataGridViewRow row in selectedProcessGrid.Rows)
                {
                    processIDList.Add(Convert.ToInt32(row.Cells[1].Value));
                }

                FileType selectedFileType = (FileType)fileFormatBox.SelectedValue;
                Thread startButtonThread = new Thread(() => systemProcessManager.StartWriting(processIDList, Convert.ToInt32(SamplingRate.Value), selectedFileType, outputFileTextBox.Text));
                //systemProcessManager.StartWriting(processIDList, Convert.ToInt32(SamplingRate.Value), (FileType)fileFormatBox.SelectedValue, outputFileTextBox.Text);
                startBtn.Enabled = false;
                stopBtn.Enabled = true;
                refreshBtn.Enabled = false;
                startButtonThread.Start();

                MessageBox.Show("Started monitoring selected threads");
                progressBarLoopThread = new Thread(() => ProgressBarLoop());

            }
            else
            {
                MessageBox.Show("No processes selected for monitoring");
            }
        }

        private bool AllFieldsFilled()
        {
            bool areAllFieldsFilled = true;

            if (selectedProcessGrid.RowCount == 0)
            {
                areAllFieldsFilled = false;
            }
            return areAllFieldsFilled;
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stopped monitoring processes");
            stopBtn.Enabled = false;
            startBtn.Enabled = true;
            refreshBtn.Enabled = true;
            systemProcessManager.StopWriting();
        }

        private void ProcessGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            int index = selectedProcessGrid.Rows.Add();
            for (int i = 0; i < processGrid.ColumnCount; i++)
            {
                selectedProcessGrid.Rows[index].Cells[i].Value = processGrid.Rows[e.RowIndex].Cells[i].Value;
            }
            selectedProcessGrid.Rows[index].Cells[0].Value = true;
            processGrid.Rows.RemoveAt(e.RowIndex);
        }

        private void SelectedProcessGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (!ExistsInGrids(Convert.ToInt32(selectedProcessGrid.Rows[e.RowIndex].Cells[1].Value)) || selectedProcessGrid.Rows[e.RowIndex].Cells[2].Value.ToString().Contains(searchBox.Text))
            {
                int index = processGrid.Rows.Add();
                for (int i = 0; i < selectedProcessGrid.ColumnCount; i++)
                {
                    processGrid.Rows[index].Cells[i].Value = selectedProcessGrid.Rows[e.RowIndex].Cells[i].Value;
                }
                processGrid.Rows[index].Cells[0].Value = false;
            }

            selectedProcessGrid.Rows.RemoveAt(e.RowIndex);
        }
        private void processMonitorUIMain_FormClosing(object sender, EventHandler e)
        {
        }
        private void ProgressBarLoop()
        {
            for (int i = 0; i < 100; i++)
            {
                monitorProcessBar.Value = i;
                if(i==99)
                {
                    i = 0; // for infinite loop
                }
                if (stopBtn.Enabled == false)
                {
                    progressBarLoopThread.Abort();
                }
                Thread.Sleep(400);
            }
        }

        private void processMonitorUIMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            systemProcessManager.StopWriting();
            progressBarLoopThread.Abort();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //systemProcessManager.StopWriting();
            this.Close();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How to use the tool:\n\n1. Check the processes to be monitored\n2. Select sampling rate, output path and type of file\n3. Click start\n4. Click stop when you wish to stop the monitoring process");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Process Monitor System\n\nDeveloped by:\n\nUI Layer:\nSarat Kumar Gundimeda\nAnvitha Karkera\n\nBusiness Layer:\nVasu Agarwal\nPoojashree MR\n\nPersistence Layer:\nNishant Uzir\nShyam Sagar\n\n\nContact deatils:\nvasu2995@gmail.com");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    }


