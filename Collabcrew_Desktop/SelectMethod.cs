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
    public partial class SelectMethod : Form
    {
        List<Panel> panellist = new List<Panel>();
        int index;
        string result;
        public SelectMethod()
        {
            InitializeComponent();
            Debug.WriteLine(KNNccuracy());
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panelAlgo.Visible = true;
            panelMethod.Visible = false;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            /*if (index < panellist.Count-1)
            {
                panellist[++index].BringToFront();
            }

            if (checkNB.Checked && checkSVM.Checked && checkBox1.Checked)
            {
                KNNlbl.Text = KNNccuracy();
                SVMlbl.Text = SVMAccuracy();
                NBlbl.Text = NBAccuracy();
                
            }*/

        }

        private void SelectMethod_Load(object sender, EventArgs e)
        {
            panellist.Add(panelMethod);
            panellist.Add(panelAlgo);
            panellist.Add(panel3);
            panellist[index].BringToFront();
            button2.Enabled = false;

        }

        public string NBAccuracy()
        {

            try
            {
                ProcessStartInfo pythonInfo = new ProcessStartInfo();
                Process python;
                pythonInfo.FileName = "C:/Users/shazna/Anaconda3/python.exe";
                pythonInfo.Arguments = "NBAccuracy.py";
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

        public string showConfusionMatrix()
        {

            try
            {
                ProcessStartInfo pythonInfo = new ProcessStartInfo();
                Process python;
                pythonInfo.FileName = "C:/Users/shazna/Anaconda3/python.exe";
                pythonInfo.Arguments = "CMatrix.py";
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

        private void cmLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConfusionMatrix cm = new ConfusionMatrix();
            cm.Show();
            
        }

        private void NxtAlgoSelection_Click(object sender, EventArgs e)
        {

            panel3.Visible = true;
            button2.Enabled = true;
            
            panelAlgo.Visible = false;
            panelMethod.Visible = false;
            /*if (index < panellist.Count - 1)
            {
                panellist[++index].BringToFront();
            }*/

            fetchingResults.RunWorkerAsync();
            fetchingAccurcies();

            }        
        private void NxtMethodSel_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panelAlgo.Visible = true;
            panelMethod.Visible = false;

        }

        private void fetchingResults_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i=0; i < 100; i++) {
                //fetchingAccurcies();
                Thread.Sleep(100);
                fetchingResults.ReportProgress(i);
            }

            //fetchingAccurcies();
            

        }

        private void fetchingResults_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            percentage.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void fetchingResults_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            percentage.Text = "100 %";

        }

        

        private void fetchingAccurcies()
        {
            //Thread.Sleep(1000);
            KNNlbl.Text = KNNccuracy();
            SVMlbl.Text = SVMAccuracy();
            NBlbl.Text = NBAccuracy();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfusionMatrix cm = new ConfusionMatrix();
            cm.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ConfusionMatrix cm = new ConfusionMatrix();
            cm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelMethod.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
