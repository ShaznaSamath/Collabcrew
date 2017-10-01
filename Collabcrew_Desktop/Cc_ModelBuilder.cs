using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Collabcrew_Desktop
{
    public partial class Cc_ModelBuilder : MetroFramework.Forms.MetroForm
    {
        string result;
        string KNVal;
        string SVMVal;
        string RFVal;
        
        public Cc_ModelBuilder()
        {
            InitializeComponent();
            //pnlMS.BringToFront();
            pnlMS.Visible = true;
            pnlAC.Visible = false;
            pnlAS.Visible = false;
            pnlRstls.Visible = false;
            lnkMS.BackColor = Color.WhiteSmoke;
            lnkMS.ForeColor = Color.Black;




        }

        struct DataParameter
        {
            public int process;
            public int delay;
        }

        private DataParameter _inpuparameter;


        public string RFAccuracy()
        {
           
            try
            {
                ProcessStartInfo pythonInfo = new ProcessStartInfo();
                Process python;
                pythonInfo.FileName = "C:/Users/shazna/Anaconda3/python.exe";
                pythonInfo.Arguments = "RFAccuracy.py";
                pythonInfo.CreateNoWindow = true;
                pythonInfo.UseShellExecute = false;
                pythonInfo.RedirectStandardOutput = true;
                pythonInfo.RedirectStandardError = true;

                using (Process process = Process.Start(pythonInfo))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string stderr = process.StandardError.ReadToEnd(); // Here are the exceptions from our Python script
                        result = reader.ReadToEnd(); // Here is the result of StdOut(for example: print "test")

                        Debug.WriteLine(result);
                    }
                }

                /*MessageBox.Show("Python Starting");
                python = Process.Start(pythonInfo);
                python.WaitForExit();
                python.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return result;
        }


        public string KNNccuracy()
        {

            try
            {
                ProcessStartInfo pythonInfo = new ProcessStartInfo();
                Process python;
                pythonInfo.FileName = "C:/Users/shazna/Anaconda3/python.exe";
                pythonInfo.Arguments = "KNNAccuracy.py";
                pythonInfo.CreateNoWindow = true;
                pythonInfo.UseShellExecute = false;
                pythonInfo.RedirectStandardOutput = true;
                pythonInfo.RedirectStandardError = true;

                using (Process process = Process.Start(pythonInfo))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string stderr = process.StandardError.ReadToEnd(); // Here are the exceptions from our Python script
                        result = reader.ReadToEnd(); // Here is the result of StdOut(for example: print "test")

                        Debug.WriteLine(result);
                    }
                }

                /*MessageBox.Show("Python Starting");
                python = Process.Start(pythonInfo);
                python.WaitForExit();
                python.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return result;
        }

        public string SVMAccuracy()
        {

            try
            {
                ProcessStartInfo pythonInfo = new ProcessStartInfo();
                Process python;
                pythonInfo.FileName = "C:/Users/shazna/Anaconda3/python.exe";
                pythonInfo.Arguments = "SVMAccuracy.py";
                pythonInfo.CreateNoWindow = true;
                pythonInfo.UseShellExecute = false;
                pythonInfo.RedirectStandardOutput = true;
                pythonInfo.RedirectStandardError = true;

                using (Process process = Process.Start(pythonInfo))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string stderr = process.StandardError.ReadToEnd(); // Here are the exceptions from our Python script
                        result = reader.ReadToEnd(); // Here is the result of StdOut(for example: print "test")

                        Debug.WriteLine(result);
                    }
                }

                /*MessageBox.Show("Python Starting");
                python = Process.Start(pythonInfo);
                python.WaitForExit();
                python.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return result;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void NxtMS_Click(object sender, EventArgs e)
        {
            if (rbtnmethodAuto.Checked)
            {
                pnlAC.Visible = true;
                pnlMS.Visible = false;
                pnlAS.Visible = false;
                lnkAC.BackColor = Color.WhiteSmoke;
                lnkAC.ForeColor = Color.Black;

            }

            else if (rbtnmethodMan.Checked)
            {
                pnlAC.Visible = false;
                pnlMS.Visible = false;
                pnlAS.Visible = true;
                lnkAS.BackColor = Color.WhiteSmoke;
                lnkAS.ForeColor = Color.Black;

            }

            else
                MessageBox.Show("Please select a method");
        }

        private void btnNxtAS_Click(object sender, EventArgs e)
        {
            //backgroundWorker.DoWork = backgroundWorker_DoWork;
            backgroundWorker.RunWorkerAsync();
            metroProgressBar1.ProgressBarStyle = ProgressBarStyle.Marquee;
            metroProgressBar1.MarqueeAnimationSpeed = 50;

            pnlAC.Visible = true;
            pnlMS.Visible = false;
            pnlAS.Visible = false;
            lnkAC.BackColor = Color.WhiteSmoke;
            lnkAC.ForeColor = Color.Black;
        }

        private void btnBackAS_Click(object sender, EventArgs e)
        {


            pnlMS.Visible = true;
            pnlAC.Visible = false;
            pnlAS.Visible = false;
            lnkMS.BackColor = Color.WhiteSmoke;
            lnkMS.ForeColor = Color.Black;


        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //metroProgressBar1.Value = e.ProgressPercentage;
            //lblBarStatus.Text = string.Format("Processing ...{0}%", e.ProgressPercentage);
            //metroProgressBar1.Update();



        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //int Process = ((DataParameter)e.Argument).process;
            //int Delay = ((DataParameter)e.Argument).delay;
            //int index = 1;
            //try {

            //    for(int i=0;i<Process;i++)
            //    {
            //        if(!backgroundWorker.CancellationPending)
            //        {
            //            backgroundWorker.ReportProgress(index++*100/Process,string.Format("Process Data {0}",i));
            //            Thread.Sleep(Delay);


            //        }
            //    }


            //}
            //catch (Exception ex)
            //{
            //    backgroundWorker.CancelAsync();
            //    MessageBox.Show(ex.Message);
            //}


            KNVal = KNNccuracy();
            RFVal = RFAccuracy();
            SVMVal = SVMAccuracy();

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Visible = false;
            // metroProgressBar1
            //System.Windows.Forms.ProgressBarStyle.Marquee;
            //metroProgressBar1.Style= MetroFramework.Forms.Pro;
            metroProgressBar1.MarqueeAnimationSpeed = 0;
            metroProgressBar1.ProgressBarStyle= ProgressBarStyle.Continuous;

            lblKNNRslt.Text = KNVal;
            lblRFRstls.Text = RFVal;
            lblSVMRslt.Text = SVMVal;

            pnlRstls.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            //if (!backgroundWorker.IsBusy)
            //{
            //   // _inpuparameter.delay = 100;
            //    //_inpuparameter.process = 1200;
            //    backgroundWorker.RunWorkerAsync(_inpuparameter);
            //}



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ConfusionMatrix cm = new ConfusionMatrix();
            cm.Show();
        }

        private void pnlAC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cc_ModelBuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
