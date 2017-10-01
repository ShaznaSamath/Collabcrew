using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collabcrew_Desktop
{
    public partial class Ccd_login : Form
    {
        public Ccd_login()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new Ccd_SplshScreen());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ccd_HomeScreen Ccd_HomeScreen1 = new Ccd_HomeScreen();
            Ccd_HomeScreen1.Show();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
