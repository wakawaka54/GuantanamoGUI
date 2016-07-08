namespace Guantanamo_GUI.SensorModules
{
    partial class GPS_Module
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPS_Module));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPoll = new System.Windows.Forms.Button();
            this.txtSettings = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNMEA = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.txtSatellites = new System.Windows.Forms.TextBox();
            this.txtHDOP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtSentences = new System.Windows.Forms.TextBox();
            this.txtCS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFixage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClearBuff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HDOP";
            // 
            // btnPoll
            // 
            this.btnPoll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPoll.Location = new System.Drawing.Point(180, 148);
            this.btnPoll.Name = "btnPoll";
            this.btnPoll.Size = new System.Drawing.Size(80, 22);
            this.btnPoll.TabIndex = 1;
            this.btnPoll.Text = "Poll Settings";
            this.btnPoll.UseVisualStyleBackColor = true;
            this.btnPoll.Click += new System.EventHandler(this.btnPoll_Click);
            // 
            // txtSettings
            // 
            this.txtSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSettings.Location = new System.Drawing.Point(12, 176);
            this.txtSettings.Name = "txtSettings";
            this.txtSettings.ReadOnly = true;
            this.txtSettings.Size = new System.Drawing.Size(239, 45);
            this.txtSettings.TabIndex = 2;
            this.txtSettings.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Satellites";
            // 
            // txtNMEA
            // 
            this.txtNMEA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNMEA.Location = new System.Drawing.Point(12, 256);
            this.txtNMEA.Name = "txtNMEA";
            this.txtNMEA.ReadOnly = true;
            this.txtNMEA.Size = new System.Drawing.Size(239, 43);
            this.txtNMEA.TabIndex = 4;
            this.txtNMEA.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "GPS Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "NMEA Output";
            // 
            // btnToggle
            // 
            this.btnToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggle.Location = new System.Drawing.Point(88, 227);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(85, 23);
            this.btnToggle.TabIndex = 7;
            this.btnToggle.Text = "Toggle Output";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // txtSatellites
            // 
            this.txtSatellites.Location = new System.Drawing.Point(64, 12);
            this.txtSatellites.Name = "txtSatellites";
            this.txtSatellites.ReadOnly = true;
            this.txtSatellites.Size = new System.Drawing.Size(40, 20);
            this.txtSatellites.TabIndex = 10;
            // 
            // txtHDOP
            // 
            this.txtHDOP.Location = new System.Drawing.Point(64, 38);
            this.txtHDOP.Name = "txtHDOP";
            this.txtHDOP.ReadOnly = true;
            this.txtHDOP.Size = new System.Drawing.Size(40, 20);
            this.txtHDOP.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Failed CS";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(64, 64);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.ReadOnly = true;
            this.txtSpeed.Size = new System.Drawing.Size(40, 20);
            this.txtSpeed.TabIndex = 13;
            // 
            // txtSentences
            // 
            this.txtSentences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSentences.Location = new System.Drawing.Point(188, 64);
            this.txtSentences.Name = "txtSentences";
            this.txtSentences.ReadOnly = true;
            this.txtSentences.Size = new System.Drawing.Size(63, 20);
            this.txtSentences.TabIndex = 15;
            // 
            // txtCS
            // 
            this.txtCS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCS.Location = new System.Drawing.Point(188, 38);
            this.txtCS.Name = "txtCS";
            this.txtCS.ReadOnly = true;
            this.txtCS.Size = new System.Drawing.Size(63, 20);
            this.txtCS.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sentences";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Speed";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fix Age";
            // 
            // txtFixage
            // 
            this.txtFixage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixage.Location = new System.Drawing.Point(188, 12);
            this.txtFixage.Name = "txtFixage";
            this.txtFixage.ReadOnly = true;
            this.txtFixage.Size = new System.Drawing.Size(63, 20);
            this.txtFixage.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Latitude";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Longitude";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(64, 90);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.ReadOnly = true;
            this.txtCourse.Size = new System.Drawing.Size(40, 20);
            this.txtCourse.TabIndex = 24;
            // 
            // txtLat
            // 
            this.txtLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLat.Location = new System.Drawing.Point(187, 90);
            this.txtLat.Name = "txtLat";
            this.txtLat.ReadOnly = true;
            this.txtLat.Size = new System.Drawing.Size(64, 20);
            this.txtLat.TabIndex = 25;
            // 
            // txtLong
            // 
            this.txtLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLong.Location = new System.Drawing.Point(187, 115);
            this.txtLong.Name = "txtLong";
            this.txtLong.ReadOnly = true;
            this.txtLong.Size = new System.Drawing.Size(64, 20);
            this.txtLong.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Heading";
            // 
            // btnClearBuff
            // 
            this.btnClearBuff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearBuff.Location = new System.Drawing.Point(179, 227);
            this.btnClearBuff.Name = "btnClearBuff";
            this.btnClearBuff.Size = new System.Drawing.Size(81, 23);
            this.btnClearBuff.TabIndex = 28;
            this.btnClearBuff.Text = "Clear Buffer";
            this.btnClearBuff.UseVisualStyleBackColor = true;
            this.btnClearBuff.Click += new System.EventHandler(this.btnClearBuff_Click);
            // 
            // GPS_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 311);
            this.Controls.Add(this.btnClearBuff);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFixage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCS);
            this.Controls.Add(this.txtSentences);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHDOP);
            this.Controls.Add(this.txtSatellites);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNMEA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSettings);
            this.Controls.Add(this.btnPoll);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GPS_Module";
            this.Text = "GPS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPoll;
        private System.Windows.Forms.RichTextBox txtSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtNMEA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.TextBox txtSatellites;
        private System.Windows.Forms.TextBox txtHDOP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtSentences;
        private System.Windows.Forms.TextBox txtCS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFixage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClearBuff;
    }
}