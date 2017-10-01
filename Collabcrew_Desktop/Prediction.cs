using MySql.Data.MySqlClient;
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
    public partial class Prediction : MetroFramework.Forms.MetroForm
    {
        int id;
        string connectionString = "SERVER=localhost;DATABASE=collabcrew;UID=root;PASSWORD=root;";
        public Prediction()
        {
            InitializeComponent();
        }

        private void Prediction_Load(object sender, EventArgs e)
        {

        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            string proj = cmbProject.SelectedItem.ToString();
            string summ = txtSummery.Text;
            string priority = cmbPriority.SelectedItem.ToString();
            string type = cmBType.SelectedItem.ToString();
            int est = Convert.ToInt32(txtEst.Text);
            int stp = Convert.ToInt32(txtSP.Text);
            Random rnd = new Random();
            id = rnd.Next();


            int pt = 2;

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmnd;
            connection.Open();



           // try
           // {

                cmnd = connection.CreateCommand();
                cmnd.CommandText = "Insert into `clb_tasks`(`task_id`,`project`,`priority`,`estimated_time`,`spent_time`,`story_points`,`no_of_bugs`)VALUES(@id,@Project,@Priority,@estTime,@timeSpent,@StoryPoints,@Nobugs);";
                cmnd.Parameters.AddWithValue("@id", id);
                cmnd.Parameters.AddWithValue("@Project", proj);
                cmnd.Parameters.AddWithValue("@Priority", pt);
                cmnd.Parameters.AddWithValue("@estTime", est);
                cmnd.Parameters.AddWithValue("@timeSpent", 342);
                cmnd.Parameters.AddWithValue("@StoryPoints", stp);
                cmnd.Parameters.AddWithValue("@Nobugs", 3);
                cmnd.ExecuteNonQuery();


            cmnd = connection.CreateCommand();
            cmnd.CommandText = "Insert into `tasks`(`Id`,`Task`,`Resources`,`Priority`,`Duration`,`ProjectID`,`Precedenceactivities`,`BudgetedAllocation`,`IsDelet`)VALUES(@id,@Summery,@Recources,@Priority,@estTime,@projID,@Prec,@Buget,@IsDel);";
            cmnd.Parameters.AddWithValue("@id", id);
            cmnd.Parameters.AddWithValue("@Summery", summ);
            cmnd.Parameters.AddWithValue("@Recources", 15);
            cmnd.Parameters.AddWithValue("@Priority", pt);
            cmnd.Parameters.AddWithValue("@estTime", est);
            cmnd.Parameters.AddWithValue("@projID", 1);
            cmnd.Parameters.AddWithValue("@Prec", 0);
            cmnd.Parameters.AddWithValue("@Buget", 345);
            cmnd.Parameters.AddWithValue("@IsDel", 0);

            cmnd.ExecuteNonQuery();

            MessageBox.Show("Task Successfully Added!");
           // }

          //  catch (Exception)
           // {
                //throw;
           // }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string algo = cmbAlgo.SelectedItem.ToString();
            Debug.WriteLine(algo);
            if (algo == "Random Forest")
            {

                Cursor cursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                // metroProgressSpinner1.Spinning = true;
                callPredScript(id);

                loadPred();
                Cursor.Current = Cursors.Default;
                //metroProgressSpinner1.Spinning = false;}

            }
            else
            {
                MessageBox.Show("Model Not Built");
            }
        }

        public void callPredScript(int id)
        {

            ProcessStartInfo pythonInfo = new ProcessStartInfo();
            Process python;
            pythonInfo.FileName = "C:/Users/shazna/Anaconda3/python.exe";
            pythonInfo.Arguments = string.Format("{0} {1} ", "Random_Forest_Prediction.py", id);
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

                    Debug.WriteLine(result);
                }
            }

            /*MessageBox.Show("Python Starting");
            python = Process.Start(pythonInfo);
            python.WaitForExit();
            python.Close();*/
        }

        public void loadPred()
        {
            string query = "SELECT m.member_name,p.RfProb,p.Pred_class FROM clb_prediction p INNER JOIN clb_members m ON p.memberId = m.member_id WHERE p.taskid ="+id+" ; "; // set query to fetch data "Select * from  tabelname"; 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    metroGrid1.DataSource = ds.Tables[0];
                }


            }

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtEst_Click(object sender, EventArgs e)
        {

        }
    }
}
