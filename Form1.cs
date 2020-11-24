using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Come_usare_StopWatch
{
    public partial class frmMain : Form
    {
        Stopwatch stopwatch;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnRestart.Enabled = false;
            btnStop.Enabled = false;

            txtMin.ReadOnly = true;
            txtSec.ReadOnly = true;
            txtMs.ReadOnly = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnRestart.Enabled = true;
            btnStop.Enabled = true;

            stopwatch = new Stopwatch();
            stopwatch.Start();

            txtMin.Text = "0";
            txtSec.Text = "0";
            txtMs.Text = "0";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnRestart.Enabled = false;
            btnStop.Enabled = false;

            stopwatch.Stop();
            txtMin.Text = stopwatch.Elapsed.Minutes.ToString();
            txtSec.Text = stopwatch.Elapsed.Seconds.ToString();
            txtMs.Text = stopwatch.Elapsed.Milliseconds.ToString();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            stopwatch.Restart();
        }



    }
}
