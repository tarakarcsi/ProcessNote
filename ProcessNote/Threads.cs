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
    public partial class Threads : Form
    {
        public Process process { get; set; }
        public ProcessThreadCollection threads { get; }

        public Threads(Process process)
        {
            InitializeComponent();
            this.process = process;
            this.threads = process.Threads;
        }

        private void Threads_Load(object sender, EventArgs e)
        {
            foreach(ProcessThread thread in threads)
            {
                threadListView.Items.Add(thread.Id.ToString());
            }
        }
    }
}
