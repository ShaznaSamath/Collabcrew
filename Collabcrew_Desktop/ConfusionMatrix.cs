using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Collabcrew_Desktop
{
    public partial class ConfusionMatrix : Form
    {
        string result;
        public ConfusionMatrix()
        {
            InitializeComponent();
            showConfusionMatrix();
        }

        private void ConfusionMatrix_Load(object sender, EventArgs e)
        {
             
        }


        public void showConfusionMatrix()
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
                        string result = reader.ReadToEnd(); // Here is the result of StdOut(for example: print "test")
                        lblCM.Text = result;
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
            //return result;
        }
    }
}
