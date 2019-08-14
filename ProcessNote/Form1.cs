using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessNote
{
    public partial class Form1 : Form
    {
        public Process[] Processes { get; set; }

        public Form1()
        {
            InitializeComponent();
            Processes = Process.GetProcesses();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Process process in Process.GetProcesses())
            {
                string[] items = new string[] { process.ProcessName };
                listView.Items.Add(new ListViewItem(items));
            }
        }

        private void EndTaskButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = SelectedProcess();
                process.Kill();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void runNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(runTask form = new runTask())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private Process SelectedProcess()
        {
            if (listView.SelectedItems.Count > 0 && listView.SelectedItems[0] != null)
            {
                foreach (Process process in Processes)
                {
                    if (process.ProcessName == listView.SelectedItems[0].Text)
                    {
                        return process;
                    }
                }
            }
            return null;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.RemoveAt(0);
            }         

            Process process = SelectedProcess();

            if (process != null)
            {                
                PerformanceCounter cpuPerform = new PerformanceCounter("Process", "% Processor Time", process.ProcessName, true);
                PerformanceCounter ramCounter = new PerformanceCounter("Process", "Private Bytes", process.ProcessName, true);
                double cpu = Math.Round(cpuPerform.NextValue());
                double ram = Math.Round(ramCounter.NextValue() / 1024 / 1024, 2);

                DateTime startTime = process.StartTime;
                TimeSpan runTime = DateTime.Now - startTime;

                string performance =  "cpu time: " + cpu + "%" + '\n' + "ram usage: " + ram + "MB" + '\n' + "start time: " + startTime.ToString() + '\n' + "runtime: " + runTime.ToString();

                listView1.Items.Add(new ListViewItem(performance));                
            }
        }

        private void threadsBtn_Click(object sender, EventArgs e)
        {
            Process selectedProcess = SelectedProcess();
            Form threadsList = new Threads(selectedProcess);
            threadsList.ShowDialog();
        }

        private void alwaysOnTop_Click(object sender, EventArgs e)
        {
            TopMost = true;
        }
    }
}
