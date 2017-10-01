namespace Collabcrew_Desktop
{
    partial class Prediction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnTask = new MetroFramework.Controls.MetroButton();
            this.cmbVersion = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cmbComp = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtSP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtEst = new MetroFramework.Controls.MetroTextBox();
            this.cmBType = new MetroFramework.Controls.MetroComboBox();
            this.cmbPriority = new MetroFramework.Controls.MetroComboBox();
            this.cmbProject = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblproj = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cmbAlgo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtSummery = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.txtSummery);
            this.metroPanel1.Controls.Add(this.btnTask);
            this.metroPanel1.Controls.Add(this.cmbVersion);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.cmbComp);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.txtSP);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txtEst);
            this.metroPanel1.Controls.Add(this.cmBType);
            this.metroPanel1.Controls.Add(this.cmbPriority);
            this.metroPanel1.Controls.Add(this.cmbProject);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.lblproj);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(34, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(776, 291);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnTask
            // 
            this.btnTask.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTask.Location = new System.Drawing.Point(580, 238);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(118, 41);
            this.btnTask.TabIndex = 18;
            this.btnTask.Text = "Add Task";
            this.btnTask.UseCustomBackColor = true;
            this.btnTask.UseCustomForeColor = true;
            this.btnTask.UseSelectable = true;
            this.btnTask.UseStyleColors = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // cmbVersion
            // 
            this.cmbVersion.FormattingEnabled = true;
            this.cmbVersion.ItemHeight = 23;
            this.cmbVersion.Items.AddRange(new object[] {
            "23",
            "234",
            "12",
            "121"});
            this.cmbVersion.Location = new System.Drawing.Point(526, 133);
            this.cmbVersion.Name = "cmbVersion";
            this.cmbVersion.Size = new System.Drawing.Size(172, 29);
            this.cmbVersion.TabIndex = 16;
            this.cmbVersion.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(384, 143);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(51, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Version";
            // 
            // cmbComp
            // 
            this.cmbComp.FormattingEnabled = true;
            this.cmbComp.ItemHeight = 23;
            this.cmbComp.Items.AddRange(new object[] {
            "test",
            "server",
            "document",
            "java-client"});
            this.cmbComp.Location = new System.Drawing.Point(526, 76);
            this.cmbComp.Name = "cmbComp";
            this.cmbComp.Size = new System.Drawing.Size(172, 29);
            this.cmbComp.TabIndex = 14;
            this.cmbComp.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(384, 86);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(84, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Components";
            // 
            // txtSP
            // 
            // 
            // 
            // 
            this.txtSP.CustomButton.Image = null;
            this.txtSP.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtSP.CustomButton.Name = "";
            this.txtSP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSP.CustomButton.TabIndex = 1;
            this.txtSP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSP.CustomButton.UseSelectable = true;
            this.txtSP.CustomButton.Visible = false;
            this.txtSP.Lines = new string[0];
            this.txtSP.Location = new System.Drawing.Point(526, 32);
            this.txtSP.MaxLength = 32767;
            this.txtSP.Name = "txtSP";
            this.txtSP.PasswordChar = '\0';
            this.txtSP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSP.SelectedText = "";
            this.txtSP.SelectionLength = 0;
            this.txtSP.SelectionStart = 0;
            this.txtSP.ShortcutsEnabled = true;
            this.txtSP.Size = new System.Drawing.Size(172, 23);
            this.txtSP.TabIndex = 12;
            this.txtSP.UseSelectable = true;
            this.txtSP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(384, 32);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Story Points";
            // 
            // txtEst
            // 
            // 
            // 
            // 
            this.txtEst.CustomButton.Image = null;
            this.txtEst.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtEst.CustomButton.Name = "";
            this.txtEst.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEst.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEst.CustomButton.TabIndex = 1;
            this.txtEst.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEst.CustomButton.UseSelectable = true;
            this.txtEst.CustomButton.Visible = false;
            this.txtEst.Lines = new string[0];
            this.txtEst.Location = new System.Drawing.Point(155, 190);
            this.txtEst.MaxLength = 32767;
            this.txtEst.Name = "txtEst";
            this.txtEst.PasswordChar = '\0';
            this.txtEst.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEst.SelectedText = "";
            this.txtEst.SelectionLength = 0;
            this.txtEst.SelectionStart = 0;
            this.txtEst.ShortcutsEnabled = true;
            this.txtEst.Size = new System.Drawing.Size(193, 23);
            this.txtEst.TabIndex = 10;
            this.txtEst.UseSelectable = true;
            this.txtEst.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEst.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEst.Click += new System.EventHandler(this.txtEst_Click);
            // 
            // cmBType
            // 
            this.cmBType.FormattingEnabled = true;
            this.cmBType.ItemHeight = 23;
            this.cmBType.Items.AddRange(new object[] {
            "New Feature",
            "Improvement",
            "Task",
            "Sub-Task",
            "Text"});
            this.cmBType.Location = new System.Drawing.Point(526, 184);
            this.cmBType.Name = "cmBType";
            this.cmBType.Size = new System.Drawing.Size(172, 29);
            this.cmBType.TabIndex = 9;
            this.cmBType.UseSelectable = true;
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.ItemHeight = 23;
            this.cmbPriority.Items.AddRange(new object[] {
            "Blocker",
            "Critical",
            "Major",
            "Minor",
            "Trivial"});
            this.cmbPriority.Location = new System.Drawing.Point(155, 133);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(193, 29);
            this.cmbPriority.TabIndex = 8;
            this.cmbPriority.UseSelectable = true;
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.ItemHeight = 23;
            this.cmbProject.Items.AddRange(new object[] {
            "ZOOKEEPER",
            "HADOOP YARN"});
            this.cmbProject.Location = new System.Drawing.Point(155, 26);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(193, 29);
            this.cmbProject.TabIndex = 7;
            this.cmbProject.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(384, 194);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(36, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Type";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 190);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(111, 38);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Estimated \r\nCompletion Time";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 143);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Task Priority";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Summery";
            // 
            // lblproj
            // 
            this.lblproj.AutoSize = true;
            this.lblproj.Location = new System.Drawing.Point(13, 26);
            this.lblproj.Name = "lblproj";
            this.lblproj.Size = new System.Drawing.Size(50, 19);
            this.lblproj.TabIndex = 2;
            this.lblproj.Text = "Project";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.OrangeRed;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton1.Location = new System.Drawing.Point(537, 370);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(196, 41);
            this.metroButton1.TabIndex = 19;
            this.metroButton1.Text = "Predict";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cmbAlgo
            // 
            this.cmbAlgo.FormattingEnabled = true;
            this.cmbAlgo.ItemHeight = 23;
            this.cmbAlgo.Items.AddRange(new object[] {
            "Random Forest",
            "K-Nearest Neighbors",
            "Support Vector Machines"});
            this.cmbAlgo.Location = new System.Drawing.Point(304, 370);
            this.cmbAlgo.Name = "cmbAlgo";
            this.cmbAlgo.Size = new System.Drawing.Size(193, 29);
            this.cmbAlgo.TabIndex = 20;
            this.cmbAlgo.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(216, 380);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(68, 19);
            this.metroLabel8.TabIndex = 19;
            this.metroLabel8.Text = "Algorithm";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroGrid1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(182, 417);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(551, 192);
            this.metroPanel2.TabIndex = 21;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(73, 20);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(440, 150);
            this.metroGrid1.TabIndex = 2;
            // 
            // txtSummery
            // 
            // 
            // 
            // 
            this.txtSummery.CustomButton.Image = null;
            this.txtSummery.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtSummery.CustomButton.Name = "";
            this.txtSummery.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSummery.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSummery.CustomButton.TabIndex = 1;
            this.txtSummery.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSummery.CustomButton.UseSelectable = true;
            this.txtSummery.CustomButton.Visible = false;
            this.txtSummery.Lines = new string[0];
            this.txtSummery.Location = new System.Drawing.Point(155, 86);
            this.txtSummery.MaxLength = 32767;
            this.txtSummery.Name = "txtSummery";
            this.txtSummery.PasswordChar = '\0';
            this.txtSummery.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSummery.SelectedText = "";
            this.txtSummery.SelectionLength = 0;
            this.txtSummery.SelectionStart = 0;
            this.txtSummery.ShortcutsEnabled = true;
            this.txtSummery.Size = new System.Drawing.Size(193, 23);
            this.txtSummery.TabIndex = 19;
            this.txtSummery.UseSelectable = true;
            this.txtSummery.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSummery.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Prediction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 666);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.cmbAlgo);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Prediction";
            this.Text = "Prediction";
            this.Load += new System.EventHandler(this.Prediction_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnTask;
        private MetroFramework.Controls.MetroComboBox cmbVersion;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cmbComp;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtSP;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtEst;
        private MetroFramework.Controls.MetroComboBox cmBType;
        private MetroFramework.Controls.MetroComboBox cmbPriority;
        private MetroFramework.Controls.MetroComboBox cmbProject;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblproj;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cmbAlgo;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroTextBox txtSummery;
    }
}