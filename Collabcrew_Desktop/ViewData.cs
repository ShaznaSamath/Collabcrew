using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Collabcrew_Desktop
{
    public partial class ViewData : Form
    {
        string connectionString = "SERVER=localhost;DATABASE=collabcrew;UID=root;PASSWORD=root;";
        public ViewData()
        {
            InitializeComponent();
        }

        private void ViewData_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tempTable"; // set query to fetch data "Select * from  tabelname"; 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }


            }
        }
    }
}
