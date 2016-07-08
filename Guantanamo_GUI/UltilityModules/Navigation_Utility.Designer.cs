namespace Guantanamo_GUI.UltilityModules
{
    partial class Navigation_Utility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navigation_Utility));
            this.txtWaypoints = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCurrentWaypoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNavigateEnabled = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbWaypointLoop = new System.Windows.Forms.ComboBox();
            this.d_openWaypoints = new System.Windows.Forms.OpenFileDialog();
            this.btnTrack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEndTrack = new System.Windows.Forms.Button();
            this.txtTracking = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._trackTimer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWaypoints
            // 
            this.txtWaypoints.Location = new System.Drawing.Point(12, 34);
            this.txtWaypoints.Name = "txtWaypoints";
            this.txtWaypoints.Size = new System.Drawing.Size(185, 295);
            this.txtWaypoints.TabIndex = 0;
            this.txtWaypoints.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 335);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(118, 22);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open Waypoints";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBegin.Location = new System.Drawing.Point(205, 12);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(119, 23);
            this.btnBegin.TabIndex = 2;
            this.btnBegin.Text = "Begin Navigation";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Waypoints";
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(205, 41);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(119, 23);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "End Navigation";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCurrentWaypoint);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNavigateEnabled);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(205, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 128);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // txtCurrentWaypoint
            // 
            this.txtCurrentWaypoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentWaypoint.Location = new System.Drawing.Point(9, 89);
            this.txtCurrentWaypoint.Name = "txtCurrentWaypoint";
            this.txtCurrentWaypoint.ReadOnly = true;
            this.txtCurrentWaypoint.Size = new System.Drawing.Size(102, 20);
            this.txtCurrentWaypoint.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Waypoint:";
            // 
            // txtNavigateEnabled
            // 
            this.txtNavigateEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNavigateEnabled.Location = new System.Drawing.Point(9, 41);
            this.txtNavigateEnabled.Name = "txtNavigateEnabled";
            this.txtNavigateEnabled.ReadOnly = true;
            this.txtNavigateEnabled.Size = new System.Drawing.Size(102, 20);
            this.txtNavigateEnabled.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Navigate Enabled:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Waypoint Loop:";
            // 
            // cbWaypointLoop
            // 
            this.cbWaypointLoop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWaypointLoop.FormattingEnabled = true;
            this.cbWaypointLoop.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbWaypointLoop.Location = new System.Drawing.Point(235, 83);
            this.cbWaypointLoop.Name = "cbWaypointLoop";
            this.cbWaypointLoop.Size = new System.Drawing.Size(89, 21);
            this.cbWaypointLoop.TabIndex = 7;
            this.cbWaypointLoop.SelectedIndexChanged += new System.EventHandler(this.cbWaypointLoop_SelectedIndexChanged);
            // 
            // d_openWaypoints
            // 
            this.d_openWaypoints.FileName = "openFileDialog1";
            this.d_openWaypoints.FileOk += new System.ComponentModel.CancelEventHandler(this.d_openWaypoints_FileOk);
            // 
            // btnTrack
            // 
            this.btnTrack.Location = new System.Drawing.Point(36, 59);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(75, 23);
            this.btnTrack.TabIndex = 8;
            this.btnTrack.Text = "Track Path";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lbStatus);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTracking);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnEndTrack);
            this.groupBox2.Controls.Add(this.btnTrack);
            this.groupBox2.Location = new System.Drawing.Point(205, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 114);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Path Track";
            // 
            // btnEndTrack
            // 
            this.btnEndTrack.Location = new System.Drawing.Point(36, 87);
            this.btnEndTrack.Name = "btnEndTrack";
            this.btnEndTrack.Size = new System.Drawing.Size(75, 23);
            this.btnEndTrack.TabIndex = 10;
            this.btnEndTrack.Text = "End";
            this.btnEndTrack.UseVisualStyleBackColor = true;
            this.btnEndTrack.Click += new System.EventHandler(this.btnEndTrack_Click);
            // 
            // txtTracking
            // 
            this.txtTracking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTracking.Location = new System.Drawing.Point(9, 32);
            this.txtTracking.Name = "txtTracking";
            this.txtTracking.Size = new System.Drawing.Size(75, 20);
            this.txtTracking.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tracking Interval:";
            // 
            // _trackTimer
            // 
            this._trackTimer.Tick += new System.EventHandler(this._trackTimer_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ms";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(6, 64);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(27, 13);
            this.lbStatus.TabIndex = 14;
            this.lbStatus.Text = "OFF";
            // 
            // Navigation_Utility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbWaypointLoop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtWaypoints);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Navigation_Utility";
            this.Text = "Navigation_Utility";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtWaypoints;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCurrentWaypoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNavigateEnabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbWaypointLoop;
        private System.Windows.Forms.OpenFileDialog d_openWaypoints;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTracking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEndTrack;
        private System.Windows.Forms.Timer _trackTimer;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label6;
    }
}