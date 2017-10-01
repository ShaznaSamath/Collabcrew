namespace Collabcrew_Desktop
{
    partial class SelectMethod
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectMethod));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMethod = new System.Windows.Forms.Panel();
            this.NxtMethodSel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panelAlgo = new System.Windows.Forms.Panel();
            this.NxtAlgoSelection = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkKNN = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkSVM = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkNB = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBackMAccuracies = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.percentage = new System.Windows.Forms.Label();
            this.lblPgrs = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.KNNlbl = new System.Windows.Forms.Label();
            this.SVMlbl = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.NBlbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fetchingResults = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMethod.SuspendLayout();
            this.panelAlgo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Collabcrew_Desktop.Properties.Resources.CCd_desktopbanner2_copy;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 155);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(280, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predictive Model Builder";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Collabcrew_Desktop.Properties.Resources.Ccd_verticalbanner_copy;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(1, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 513);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(3, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Confusion Matrix";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(3, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelMethod
            // 
            this.panelMethod.BackColor = System.Drawing.Color.White;
            this.panelMethod.Controls.Add(this.NxtMethodSel);
            this.panelMethod.Controls.Add(this.label6);
            this.panelMethod.Controls.Add(this.label7);
            this.panelMethod.Controls.Add(this.label2);
            this.panelMethod.Controls.Add(this.label8);
            this.panelMethod.Controls.Add(this.label4);
            this.panelMethod.Controls.Add(this.radioButton1);
            this.panelMethod.Controls.Add(this.checkBox1);
            this.panelMethod.Controls.Add(this.radioButton3);
            this.panelMethod.Location = new System.Drawing.Point(538, 18);
            this.panelMethod.Name = "panelMethod";
            this.panelMethod.Size = new System.Drawing.Size(551, 412);
            this.panelMethod.TabIndex = 15;
            // 
            // NxtMethodSel
            // 
            this.NxtMethodSel.BackColor = System.Drawing.Color.OrangeRed;
            this.NxtMethodSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NxtMethodSel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NxtMethodSel.Location = new System.Drawing.Point(413, 342);
            this.NxtMethodSel.Name = "NxtMethodSel";
            this.NxtMethodSel.Size = new System.Drawing.Size(105, 36);
            this.NxtMethodSel.TabIndex = 29;
            this.NxtMethodSel.Text = "Next";
            this.NxtMethodSel.UseVisualStyleBackColor = false;
            this.NxtMethodSel.Click += new System.EventHandler(this.NxtMethodSel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Method Selection";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(101, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Select the prefered algorithm to build the model and create classification rules";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(99, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Automatically select the best algorithm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(100, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Manually select the algorithm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(100, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "The best algorithm for the model training will selected based on the efficiency";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(69, 76);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(76, 243);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(178, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Increase accuracy of the model.";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton3.Location = new System.Drawing.Point(69, 154);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panelAlgo
            // 
            this.panelAlgo.BackColor = System.Drawing.Color.White;
            this.panelAlgo.Controls.Add(this.panelMethod);
            this.panelAlgo.Controls.Add(this.NxtAlgoSelection);
            this.panelAlgo.Controls.Add(this.button3);
            this.panelAlgo.Controls.Add(this.checkKNN);
            this.panelAlgo.Controls.Add(this.label3);
            this.panelAlgo.Controls.Add(this.label5);
            this.panelAlgo.Controls.Add(this.checkSVM);
            this.panelAlgo.Controls.Add(this.label13);
            this.panelAlgo.Controls.Add(this.checkNB);
            this.panelAlgo.Controls.Add(this.label9);
            this.panelAlgo.Controls.Add(this.label10);
            this.panelAlgo.Controls.Add(this.label11);
            this.panelAlgo.Controls.Add(this.label12);
            this.panelAlgo.Location = new System.Drawing.Point(-1, 1);
            this.panelAlgo.Name = "panelAlgo";
            this.panelAlgo.Size = new System.Drawing.Size(550, 412);
            this.panelAlgo.TabIndex = 19;
            // 
            // NxtAlgoSelection
            // 
            this.NxtAlgoSelection.BackColor = System.Drawing.Color.OrangeRed;
            this.NxtAlgoSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NxtAlgoSelection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NxtAlgoSelection.Location = new System.Drawing.Point(412, 360);
            this.NxtAlgoSelection.Name = "NxtAlgoSelection";
            this.NxtAlgoSelection.Size = new System.Drawing.Size(105, 36);
            this.NxtAlgoSelection.TabIndex = 27;
            this.NxtAlgoSelection.Text = "Next";
            this.NxtAlgoSelection.UseVisualStyleBackColor = false;
            this.NxtAlgoSelection.Click += new System.EventHandler(this.NxtAlgoSelection_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(301, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 36);
            this.button3.TabIndex = 26;
            this.button3.Text = "Previous";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkKNN
            // 
            this.checkKNN.AutoSize = true;
            this.checkKNN.Location = new System.Drawing.Point(69, 264);
            this.checkKNN.Name = "checkKNN";
            this.checkKNN.Size = new System.Drawing.Size(15, 14);
            this.checkKNN.TabIndex = 25;
            this.checkKNN.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(100, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "K-Nearest-Neighbors Algorithm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(81, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 39);
            this.label5.TabIndex = 24;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // checkSVM
            // 
            this.checkSVM.AutoSize = true;
            this.checkSVM.Location = new System.Drawing.Point(68, 176);
            this.checkSVM.Name = "checkSVM";
            this.checkSVM.Size = new System.Drawing.Size(15, 14);
            this.checkSVM.TabIndex = 22;
            this.checkSVM.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(99, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(289, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Support Vector Machine  Algorithm";
            // 
            // checkNB
            // 
            this.checkNB.AutoSize = true;
            this.checkNB.Location = new System.Drawing.Point(68, 77);
            this.checkNB.Name = "checkNB";
            this.checkNB.Size = new System.Drawing.Size(15, 14);
            this.checkNB.TabIndex = 19;
            this.checkNB.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(101, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(318, 52);
            this.label9.TabIndex = 4;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(99, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(326, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Random Forest Classification Algorithm";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(104, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(320, 39);
            this.label11.TabIndex = 21;
            this.label11.Text = "More formally, a support vector machine constructs a hyperplane\r\nor set of hyperp" +
    "lanes in a high- or infinite-dimensional space, which\r\ncan be used for classific" +
    "ation, regression, or other tasks.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(147, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "Algorithm Selection";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Location = new System.Drawing.Point(426, 352);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 36);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBackMAccuracies
            // 
            this.btnBackMAccuracies.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBackMAccuracies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMAccuracies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackMAccuracies.Location = new System.Drawing.Point(315, 352);
            this.btnBackMAccuracies.Name = "btnBackMAccuracies";
            this.btnBackMAccuracies.Size = new System.Drawing.Size(105, 36);
            this.btnBackMAccuracies.TabIndex = 13;
            this.btnBackMAccuracies.Text = "Previous";
            this.btnBackMAccuracies.UseVisualStyleBackColor = false;
            this.btnBackMAccuracies.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panelAlgo);
            this.panel3.Controls.Add(this.percentage);
            this.panel3.Controls.Add(this.lblPgrs);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnBackMAccuracies);
            this.panel3.Controls.Add(this.KNNlbl);
            this.panel3.Controls.Add(this.SVMlbl);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.NBlbl);
            this.panel3.Location = new System.Drawing.Point(205, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 412);
            this.panel3.TabIndex = 19;
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.Location = new System.Drawing.Point(469, 122);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(15, 13);
            this.percentage.TabIndex = 17;
            this.percentage.Text = "%";
            // 
            // lblPgrs
            // 
            this.lblPgrs.AutoSize = true;
            this.lblPgrs.Location = new System.Drawing.Point(442, 122);
            this.lblPgrs.Name = "lblPgrs";
            this.lblPgrs.Size = new System.Drawing.Size(0, 13);
            this.lblPgrs.TabIndex = 16;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(76, 81);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(408, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // KNNlbl
            // 
            this.KNNlbl.AutoSize = true;
            this.KNNlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KNNlbl.Location = new System.Drawing.Point(152, 255);
            this.KNNlbl.Name = "KNNlbl";
            this.KNNlbl.Size = new System.Drawing.Size(56, 20);
            this.KNNlbl.TabIndex = 13;
            this.KNNlbl.Text = "KNNlbl";
            // 
            // SVMlbl
            // 
            this.SVMlbl.AutoSize = true;
            this.SVMlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SVMlbl.Location = new System.Drawing.Point(152, 210);
            this.SVMlbl.Name = "SVMlbl";
            this.SVMlbl.Size = new System.Drawing.Size(59, 20);
            this.SVMlbl.TabIndex = 12;
            this.SVMlbl.Text = "SVMlbl";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(170, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(199, 25);
            this.label20.TabIndex = 10;
            this.label20.Text = "Model Accuracies";
            // 
            // NBlbl
            // 
            this.NBlbl.AutoSize = true;
            this.NBlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NBlbl.Location = new System.Drawing.Point(154, 167);
            this.NBlbl.Name = "NBlbl";
            this.NBlbl.Size = new System.Drawing.Size(46, 20);
            this.NBlbl.TabIndex = 11;
            this.NBlbl.Text = "NBlbl";
            // 
            // fetchingResults
            // 
            this.fetchingResults.WorkerReportsProgress = true;
            this.fetchingResults.DoWork += new System.ComponentModel.DoWorkEventHandler(this.fetchingResults_DoWork);
            this.fetchingResults.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.fetchingResults_ProgressChanged);
            this.fetchingResults.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.fetchingResults_RunWorkerCompleted);
            // 
            // SelectMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(822, 647);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "SelectMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectMethod";
            this.Load += new System.EventHandler(this.SelectMethod_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelMethod.ResumeLayout(false);
            this.panelMethod.PerformLayout();
            this.panelAlgo.ResumeLayout(false);
            this.panelAlgo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMethod;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBackMAccuracies;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelAlgo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkSVM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkNB;
        private System.Windows.Forms.CheckBox checkKNN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label NBlbl;
        private System.Windows.Forms.Label KNNlbl;
        private System.Windows.Forms.Label SVMlbl;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button NxtAlgoSelection;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button NxtMethodSel;
        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.Label lblPgrs;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker fetchingResults;
        private System.Windows.Forms.Button button2;
    }
}