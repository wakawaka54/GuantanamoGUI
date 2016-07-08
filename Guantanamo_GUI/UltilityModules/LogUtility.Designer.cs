namespace Guantanamo_GUI.UltilityModules
{
    partial class LogUtility
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
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbFilename = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.d_OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOpenSimulate = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnS_Play = new System.Windows.Forms.Button();
            this.btnS_Stop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbLines = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(12, 12);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 0;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(93, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnNewFile
            // 
            this.btnNewFile.Location = new System.Drawing.Point(12, 41);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(75, 23);
            this.btnNewFile.TabIndex = 2;
            this.btnNewFile.Text = "New File";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filename";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbFilename);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 77);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Info";
            // 
            // lbFilename
            // 
            this.lbFilename.AutoSize = true;
            this.lbFilename.Location = new System.Drawing.Point(16, 39);
            this.lbFilename.Name = "lbFilename";
            this.lbFilename.Size = new System.Drawing.Size(27, 13);
            this.lbFilename.TabIndex = 6;
            this.lbFilename.Text = "N/A";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(93, 46);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(76, 13);
            this.lbStatus.TabIndex = 5;
            this.lbStatus.Text = "Not Recording";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSplit);
            this.groupBox2.Location = new System.Drawing.Point(175, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 52);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log Splitter";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(104, 19);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 0;
            this.btnSplit.Text = "Split Log";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // d_OpenFile
            // 
            this.d_OpenFile.FileOk += new System.ComponentModel.CancelEventHandler(this.d_OpenFile_FileOk);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbLines);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnS_Stop);
            this.groupBox3.Controls.Add(this.btnS_Play);
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Controls.Add(this.btnOpenSimulate);
            this.groupBox3.Location = new System.Drawing.Point(175, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 114);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Simulator";
            // 
            // btnOpenSimulate
            // 
            this.btnOpenSimulate.Location = new System.Drawing.Point(116, 10);
            this.btnOpenSimulate.Name = "btnOpenSimulate";
            this.btnOpenSimulate.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSimulate.TabIndex = 0;
            this.btnOpenSimulate.Text = "Open Log";
            this.btnOpenSimulate.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 63);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(185, 45);
            this.trackBar1.TabIndex = 1;
            // 
            // btnS_Play
            // 
            this.btnS_Play.Location = new System.Drawing.Point(6, 15);
            this.btnS_Play.Name = "btnS_Play";
            this.btnS_Play.Size = new System.Drawing.Size(44, 23);
            this.btnS_Play.TabIndex = 2;
            this.btnS_Play.Text = "Play";
            this.btnS_Play.UseVisualStyleBackColor = true;
            // 
            // btnS_Stop
            // 
            this.btnS_Stop.Location = new System.Drawing.Point(56, 15);
            this.btnS_Stop.Name = "btnS_Stop";
            this.btnS_Stop.Size = new System.Drawing.Size(42, 23);
            this.btnS_Stop.TabIndex = 3;
            this.btnS_Stop.Text = "Stop";
            this.btnS_Stop.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbLines
            // 
            this.lbLines.AutoSize = true;
            this.lbLines.Location = new System.Drawing.Point(113, 43);
            this.lbLines.Name = "lbLines";
            this.lbLines.Size = new System.Drawing.Size(24, 13);
            this.lbLines.TabIndex = 5;
            this.lbLines.Text = "0/0";
            // 
            // LogUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 197);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNewFile);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnBegin);
            this.Name = "LogUtility";
            this.Text = "Log";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbFilename;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.OpenFileDialog d_OpenFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbLines;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnS_Stop;
        private System.Windows.Forms.Button btnS_Play;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnOpenSimulate;
    }
}