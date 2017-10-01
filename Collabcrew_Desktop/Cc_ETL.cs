using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Threading;

namespace Collabcrew_Desktop
{
    public partial class Cc_ETL : MetroFramework.Forms.MetroForm
    {
        string path;
        string fileType;
        string connectionString = "SERVER=localhost;DATABASE=collabcrew;UID=root;PASSWORD=root;";
        public Cc_ETL()
        {
            InitializeComponent();
            lnkViewData.Visible = false;
            pnlExtData.Visible = true;
            pnlSelectflds.Visible = false;
            pnlAR.Visible = false;
            pnlMA.Visible = false;
        }

        private void Cc_ETL_Load(object sender, EventArgs e)
        {
            //MySqlConnection connection = new MySqlConnection(connectionString); // Response.Redirect("Workplanner.aspx");
            //MySqlCommand cmd;
            //connection.Open();

            //cmd = connection.CreateCommand();
            //cmd.CommandText = "SELECT distinct TABLE_SCHEMA FROM INFORMATION_SCHEMA.TABLES WHERE CREATE_TIME < '2016-10-10 00:00:00' ORDER BY `TABLES`.`TABLE_SCHEMA` ASC";
            //MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //adp.Fill(ds);
            //cmbDatabase.DataSource = ds.Tables[0];
            //cmbDatabase.DisplayMember = "TABLE_SCHEMA";
            //cmbDatabase.DisplayMember = "TABLE_SCHEMA";
            //// comboBox1.DataBinding();
            //cmd.ExecuteNonQuery();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            pnlExtData.Visible = false;
            pnlSelectflds.Visible = true;
            if(cmbFileType.SelectedItem.ToString() == "CSV")
            {
                StreamReader sr = new StreamReader(@"issues3.csv");
                // for set encoding
                // StreamReader sr = new StreamReader(@"file.csv", Encoding.GetEncoding(1250));

                string strline = "";
                string[] _values = null;
                int x = 0;
                //while (!sr.EndOfStream)
                //{
                // x++;
                strline = sr.ReadLine();
                _values = strline.Split(',');
                //if (_values.Length >= 6)
                //{


                foreach (var v in _values)
                {
                    listBox1.Items.Add(v);
                    //var v = listBox1.SelectedIndex;
                    //listBox1.SelectedItems.Remove(v);


                }
            }

            else if(cmbFileType.SelectedItem.ToString() == "XML")
            {
                string connectionString = "SERVER=localhost;DATABASE=collabcrew;UID=root;PASSWORD=root;"; //Set your MySQL connection string here.
                string query = "select Column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_Name='temptable' order by ORDINAL_POSITION"; // set query to fetch data "Select * from  tabelname"; 
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        //dataGridView1.DataSource = ds.Tables[0];

                        //foreach (var v in adapter.Fill(ds.Tables[0]))
                        //{
                        listBox1.DataSource = ds.Tables[0];
                        listBox1.DisplayMember = "Column_name";
                        listBox1.ValueMember = "Column_name";
                        //var v = listBox1.SelectedIndex;
                        //listBox1.SelectedItems.Remove(v);


                        //}

                    }


                }
            }



        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
            //delectExtTable();
            Thread.Sleep(100);
            runLoadDataScript();
        }


        public void delectExtTable()
        {
            Boolean status = false;
            MySqlConnection conn = new MySqlConnection(connectionString);
            string query1 = @"DELETE FROM tempTable;";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query1, conn);
            cmd.ExecuteNonQuery();


        }

        public void runLoadDataScript()
        {
            string myPythonApp = "LoadData.py";
            string a = cmbFileType.SelectedItem.ToString();
            string csvfile = txtFilesource.Text;
            csvfile = csvfile.Replace(@"\", @"/");
            Debug.WriteLine(csvfile);



            //string file = "Book1.csv";

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:/Users/shazna/AppData/Local/Programs/Python/Python36-32/python.exe";
            // Console.Write(args.Length);
            // arg[0] = Path to your python script (example : "C:\\add_them.py")
            // arg[1] = first arguement taken from  C#'s main method's args variable (here i'm passing a number : 5)
            // arg[2] = second arguement taken from  C#'s main method's args variable ( here i'm passing a number : 6)
            // pass these to your Arguements property of your ProcessStartInfo instance

            start.Arguments = string.Format("{0} {1} {2}", "LoadData.py", csvfile, a);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    string stderr = process.StandardError.ReadToEnd();
                    // this prints 11
                    Debug.WriteLine(stderr);
                    Debug.WriteLine(result);



                }
            }
            Console.Read();

        }

        public void runApplyRulesScript()
        {


            //string file = "Book1.csv";
            string x = txtSelectedFld.Text;
            string y = cmbRule.SelectedItem.ToString();
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:/Users/shazna/AppData/Local/Programs/Python/Python36-32/python.exe";
            // Console.Write(args.Length);
            // arg[0] = Path to your python script (example : "C:\\add_them.py")
            // arg[1] = first arguement taken from  C#'s main method's args variable (here i'm passing a number : 5)
            // arg[2] = second arguement taken from  C#'s main method's args variable ( here i'm passing a number : 6)
            // pass these to your Arguements property of your ProcessStartInfo instance

            start.Arguments = string.Format("{0} {1} {2}", "ApplyRules.py", x, y);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    string stderr = process.StandardError.ReadToEnd();
                    // this prints 11
                    Debug.WriteLine(stderr);
                    Debug.WriteLine(result);



                }
            }
            Console.Read();


        }

        private void btnBrowsFile_Click(object sender, EventArgs e)
        {
            metroLink3.BackColor = Color.WhiteSmoke;
            metroLink3.ForeColor = Color.Black;


            OpenFileDialog of = new OpenFileDialog();
            if (cmbFileType.SelectedItem.ToString() == "TEXT")
            {
                of.Filter = "txt files (*.txt)|*.txt";
                of.InitialDirectory = @"C:\";
                of.Title = "Please select a text data file";
            }

            if (cmbFileType.SelectedItem.ToString() == "CSV")
            {
                of.Filter = "csv files (*.csv)|*.csv";
                of.InitialDirectory = @"C:\";
                of.Title = "Please select a csv data file";
            }

            if (cmbFileType.SelectedItem.ToString() == "XML")
            {
                of.Filter = "xml files (*.xml)|*.xml";
                of.InitialDirectory = @"C:\";
                of.Title = "Please select a csv data file";
            }

            if (of.ShowDialog() == DialogResult.OK)
            {
                txtFilesource.Text = Path.GetFullPath(of.FileName);
                path = txtFilesource.Text;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnMANxt_Click(object sender, EventArgs e)
        {
            pnlMA.Visible = false;
            pnlAR.Visible = true;



        }

        private void btnMABack_Click(object sender, EventArgs e)
        {
            pnlMA.Visible = false;
            pnlSelectflds.Visible = true;
        }

        private void btnSFNxt_Click(object sender, EventArgs e)
        {
            pnlAR.Visible = true;
            pnlSelectflds.Visible = false;

            //here
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox3.Items.Add(listBox2.Items[i].ToString());
            }
            listBox2.Items.Clear();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            pnlAR.Visible = false;
            pnlSelectflds.Visible = true;
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {


                    stimulateExt();
                    backgroundWorker.ReportProgress(i);


                           }

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lnkViewData.Visible = true;

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgrsExtract.Value = e.ProgressPercentage;
            metroLabel16.Text = e.ProgressPercentage.ToString() + " %";

        }

        private void lstRuleField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void stimulateExt()
        {
            Thread.Sleep(100);
        }

        private void lnkViewData_Click(object sender, EventArgs e)
        {
            ViewData vd = new ViewData();
            vd.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (cmbFileType.SelectedItem.ToString() == "XML")
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    //listBox2.Items.Add(listBox1.Items[i].ToString());
                    DataRowView drv = (DataRowView)listBox1.Items[i];

                    String valueOfItem = drv["Column_name"].ToString();
                    listBox2.Items.Add(valueOfItem);

                }
            }
            else
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox2.Items.Add(listBox1.Items[i].ToString());
                }
                listBox1.Items.Clear();
            }
            // listBox1.Items.Clear();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i].ToString());
                //listBox1.SelectedItems.Remove(listBox1.SelectedItems);
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.SelectedItems.Count; i++)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i].ToString());
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox1.Items.Add(listBox2.Items[i].ToString());
            }
            listBox2.Items.Clear();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_Click(object sender, EventArgs e)
        {
            txtSelectedFld.Text = listBox3.SelectedItem.ToString();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            ViewData vd = new ViewData();
            vd.Show();
        }

        private void btnApplyRule_Click(object sender, EventArgs e)
        {
            runApplyRulesScript();
        }

        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MySqlConnection connection = new MySqlConnection(connectionString); // Response.Redirect("Workplanner.aspx");
            //MySqlCommand cmd;
            //connection.Open();
            //string type;
            //cmd = connection.CreateCommand();
            //type = cmbDatabase.Text;
            ////  type = comboBox1.SelectedText;
            ////type = "ovata4";
            //cmd.CommandText = "SELECT distinct `TABLE_NAME` FROM INFORMATION_SCHEMA.TABLES	 where `TABLE_SCHEMA`='" + type + "'";
            //// cmd.CommandText = "SELECT TABLE_SCHEMA FROM INFORMATION_SCHEMA.TABLES WHERE CREATE_TIME < '2016-10-10 00:00:00' ORDER BY `TABLES`.`TABLE_SCHEMA` ASC";
            //MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            //DataSet combotables = new DataSet();
            //adp.Fill(combotables);

            //cmbTableName.DataSource = combotables.Tables[0];
            //cmbTableName.DisplayMember = "TABLE_NAME";
            //cmbTableName.DisplayMember = "TABLE_NAME";
            //// cmd.ExecuteNonQuery();


            //cmd.ExecuteNonQuery();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data Saved in Database");
            this.Dispose();
        }
    }
}
