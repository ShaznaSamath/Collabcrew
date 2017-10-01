namespace Collabcrew_Desktop
{
    partial class ConfusionMatrix
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
            this.lblCM = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCM
            // 
            this.lblCM.AutoSize = true;
            this.lblCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCM.Location = new System.Drawing.Point(64, 305);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(52, 18);
            this.lblCM.TabIndex = 0;
            this.lblCM.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Collabcrew_Desktop.Properties.Resources.Picture_8__1_;
            this.pictureBox1.Location = new System.Drawing.Point(53, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 251);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ConfusionMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 408);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCM);
            this.Name = "ConfusionMatrix";
            this.Text = "ConfusionMatrix";
            this.Load += new System.EventHandler(this.ConfusionMatrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCM;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}