namespace Guantanamo_GUI.UltilityModules
{
    partial class Calibration_DMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calibration_DMP));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReadHeadingGains = new System.Windows.Forms.Button();
            this.btnSetHeadingGains = new System.Windows.Forms.Button();
            this.txtYaw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeadingComp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGyroAngular = new System.Windows.Forms.TextBox();
            this.txtMagAngularGain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSetPID = new System.Windows.Forms.Button();
            this.btnReadPID = new System.Windows.Forms.Button();
            this.tc_PIDTabs = new System.Windows.Forms.TabControl();
            this.tp_WP = new System.Windows.Forms.TabPage();
            this.waypoint_Control1 = new Guantanamo_GUI.UltilityModules.DMP_Gains.Waypoint_Control();
            this.tp_Avoid = new System.Windows.Forms.TabPage();
            this.imageAvoid_Control3 = new Guantanamo_GUI.UltilityModules.DMP_Gains.ImageAvoid_Control();
            this.tb_GoTo = new System.Windows.Forms.TabPage();
            this.imageGoTo_Control1 = new Guantanamo_GUI.UltilityModules.DMP_Gains.ImageGoTo_Control();
            this.piD_GainControl_WP = new Guantanamo_GUI.UltilityModules.DMP_Gains.DMP_GainControl();
            this.piD_GainControl_Image = new Guantanamo_GUI.UltilityModules.DMP_Gains.DMP_GainControl();
            this.tb_Follow = new System.Windows.Forms.TabPage();
            this.imageFollow_Control1 = new Guantanamo_GUI.UltilityModules.DMP_Gains.ImageFollow_Control();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tc_PIDTabs.SuspendLayout();
            this.tp_WP.SuspendLayout();
            this.tp_Avoid.SuspendLayout();
            this.tb_GoTo.SuspendLayout();
            this.tb_Follow.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReadHeadingGains);
            this.groupBox1.Controls.Add(this.btnSetHeadingGains);
            this.groupBox1.Controls.Add(this.txtYaw);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHeadingComp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGyroAngular);
            this.groupBox1.Controls.Add(this.txtMagAngularGain);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Heading Filter";
            // 
            // btnReadHeadingGains
            // 
            this.btnReadHeadingGains.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadHeadingGains.Location = new System.Drawing.Point(201, 124);
            this.btnReadHeadingGains.Name = "btnReadHeadingGains";
            this.btnReadHeadingGains.Size = new System.Drawing.Size(75, 23);
            this.btnReadHeadingGains.TabIndex = 7;
            this.btnReadHeadingGains.Text = "Read Gains";
            this.btnReadHeadingGains.UseVisualStyleBackColor = true;
            this.btnReadHeadingGains.Click += new System.EventHandler(this.btnReadHeadingGains_Click);
            // 
            // btnSetHeadingGains
            // 
            this.btnSetHeadingGains.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetHeadingGains.Location = new System.Drawing.Point(280, 124);
            this.btnSetHeadingGains.Name = "btnSetHeadingGains";
            this.btnSetHeadingGains.Size = new System.Drawing.Size(75, 23);
            this.btnSetHeadingGains.TabIndex = 6;
            this.btnSetHeadingGains.Text = "Set Gains";
            this.btnSetHeadingGains.UseVisualStyleBackColor = true;
            this.btnSetHeadingGains.Click += new System.EventHandler(this.btnSetHeadingGains_Click);
            // 
            // txtYaw
            // 
            this.txtYaw.Location = new System.Drawing.Point(83, 22);
            this.txtYaw.Name = "txtYaw";
            this.txtYaw.ReadOnly = true;
            this.txtYaw.Size = new System.Drawing.Size(65, 20);
            this.txtYaw.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vehicle Yaw:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Magnetometer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Error Gain";
            // 
            // txtHeadingComp
            // 
            this.txtHeadingComp.Location = new System.Drawing.Point(201, 77);
            this.txtHeadingComp.Name = "txtHeadingComp";
            this.txtHeadingComp.Size = new System.Drawing.Size(73, 20);
            this.txtHeadingComp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gyroscope";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Magnetometer";
            // 
            // txtGyroAngular
            // 
            this.txtGyroAngular.Location = new System.Drawing.Point(11, 77);
            this.txtGyroAngular.Name = "txtGyroAngular";
            this.txtGyroAngular.Size = new System.Drawing.Size(73, 20);
            this.txtGyroAngular.TabIndex = 3;
            // 
            // txtMagAngularGain
            // 
            this.txtMagAngularGain.Location = new System.Drawing.Point(11, 103);
            this.txtMagAngularGain.Name = "txtMagAngularGain";
            this.txtMagAngularGain.Size = new System.Drawing.Size(73, 20);
            this.txtMagAngularGain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Angular Change Gain";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSetPID);
            this.groupBox2.Controls.Add(this.btnReadPID);
            this.groupBox2.Controls.Add(this.tc_PIDTabs);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PIDs";
            // 
            // btnSetPID
            // 
            this.btnSetPID.Location = new System.Drawing.Point(280, 184);
            this.btnSetPID.Name = "btnSetPID";
            this.btnSetPID.Size = new System.Drawing.Size(75, 23);
            this.btnSetPID.TabIndex = 2;
            this.btnSetPID.Text = "Set Gains";
            this.btnSetPID.UseVisualStyleBackColor = true;
            this.btnSetPID.Click += new System.EventHandler(this.btnSetPID_Click);
            // 
            // btnReadPID
            // 
            this.btnReadPID.Location = new System.Drawing.Point(199, 184);
            this.btnReadPID.Name = "btnReadPID";
            this.btnReadPID.Size = new System.Drawing.Size(75, 23);
            this.btnReadPID.TabIndex = 1;
            this.btnReadPID.Text = "Read Gains";
            this.btnReadPID.UseVisualStyleBackColor = true;
            this.btnReadPID.Click += new System.EventHandler(this.btnReadPID_Click);
            // 
            // tc_PIDTabs
            // 
            this.tc_PIDTabs.Controls.Add(this.tp_WP);
            this.tc_PIDTabs.Controls.Add(this.tp_Avoid);
            this.tc_PIDTabs.Controls.Add(this.tb_GoTo);
            this.tc_PIDTabs.Controls.Add(this.tb_Follow);
            this.tc_PIDTabs.Location = new System.Drawing.Point(11, 19);
            this.tc_PIDTabs.Name = "tc_PIDTabs";
            this.tc_PIDTabs.SelectedIndex = 0;
            this.tc_PIDTabs.Size = new System.Drawing.Size(344, 159);
            this.tc_PIDTabs.TabIndex = 0;
            this.tc_PIDTabs.SelectedIndexChanged += new System.EventHandler(this.tc_PIDTabs_SelectedIndexChanged);
            // 
            // tp_WP
            // 
            this.tp_WP.Controls.Add(this.waypoint_Control1);
            this.tp_WP.Location = new System.Drawing.Point(4, 22);
            this.tp_WP.Name = "tp_WP";
            this.tp_WP.Size = new System.Drawing.Size(336, 133);
            this.tp_WP.TabIndex = 0;
            this.tp_WP.Text = "Waypoint";
            // 
            // waypoint_Control1
            // 
            this.waypoint_Control1.Location = new System.Drawing.Point(12, 0);
            this.waypoint_Control1.Name = "waypoint_Control1";
            this.waypoint_Control1.Size = new System.Drawing.Size(294, 127);
            this.waypoint_Control1.TabIndex = 0;
            // 
            // tp_Avoid
            // 
            this.tp_Avoid.BackColor = System.Drawing.SystemColors.Control;
            this.tp_Avoid.Controls.Add(this.imageAvoid_Control3);
            this.tp_Avoid.Location = new System.Drawing.Point(4, 22);
            this.tp_Avoid.Name = "tp_Avoid";
            this.tp_Avoid.Size = new System.Drawing.Size(336, 133);
            this.tp_Avoid.TabIndex = 1;
            this.tp_Avoid.Text = "Avoid Image";
            // 
            // imageAvoid_Control3
            // 
            this.imageAvoid_Control3.Location = new System.Drawing.Point(3, 3);
            this.imageAvoid_Control3.Name = "imageAvoid_Control3";
            this.imageAvoid_Control3.Size = new System.Drawing.Size(319, 127);
            this.imageAvoid_Control3.TabIndex = 0;
            // 
            // tb_GoTo
            // 
            this.tb_GoTo.BackColor = System.Drawing.SystemColors.Control;
            this.tb_GoTo.Controls.Add(this.imageGoTo_Control1);
            this.tb_GoTo.Location = new System.Drawing.Point(4, 22);
            this.tb_GoTo.Name = "tb_GoTo";
            this.tb_GoTo.Size = new System.Drawing.Size(336, 133);
            this.tb_GoTo.TabIndex = 2;
            this.tb_GoTo.Text = "GoTo Image";
            // 
            // imageGoTo_Control1
            // 
            this.imageGoTo_Control1.Location = new System.Drawing.Point(3, 3);
            this.imageGoTo_Control1.Name = "imageGoTo_Control1";
            this.imageGoTo_Control1.Size = new System.Drawing.Size(330, 127);
            this.imageGoTo_Control1.TabIndex = 0;
            // 
            // piD_GainControl_WP
            // 
            this.piD_GainControl_WP.BackColor = System.Drawing.Color.Transparent;
            this.piD_GainControl_WP.Location = new System.Drawing.Point(0, 0);
            this.piD_GainControl_WP.Name = "piD_GainControl_WP";
            this.piD_GainControl_WP.Size = new System.Drawing.Size(340, 133);
            this.piD_GainControl_WP.TabIndex = 0;
            // 
            // piD_GainControl_Image
            // 
            this.piD_GainControl_Image.BackColor = System.Drawing.Color.Transparent;
            this.piD_GainControl_Image.Location = new System.Drawing.Point(0, 0);
            this.piD_GainControl_Image.Name = "piD_GainControl_Image";
            this.piD_GainControl_Image.Size = new System.Drawing.Size(340, 133);
            this.piD_GainControl_Image.TabIndex = 1;
            // 
            // tb_Follow
            // 
            this.tb_Follow.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Follow.Controls.Add(this.imageFollow_Control1);
            this.tb_Follow.Location = new System.Drawing.Point(4, 22);
            this.tb_Follow.Name = "tb_Follow";
            this.tb_Follow.Size = new System.Drawing.Size(336, 133);
            this.tb_Follow.TabIndex = 3;
            this.tb_Follow.Text = "Follow Image";
            // 
            // imageFollow_Control1
            // 
            this.imageFollow_Control1.Location = new System.Drawing.Point(3, 3);
            this.imageFollow_Control1.Name = "imageFollow_Control1";
            this.imageFollow_Control1.Size = new System.Drawing.Size(330, 119);
            this.imageFollow_Control1.TabIndex = 0;
            // 
            // Calibration_DMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calibration_DMP";
            this.Text = "Filter_Configuration";
            this.Load += new System.EventHandler(this.Filter_Configuration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tc_PIDTabs.ResumeLayout(false);
            this.tp_WP.ResumeLayout(false);
            this.tp_Avoid.ResumeLayout(false);
            this.tb_GoTo.ResumeLayout(false);
            this.tb_Follow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYaw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHeadingComp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGyroAngular;
        private System.Windows.Forms.TextBox txtMagAngularGain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadHeadingGains;
        private System.Windows.Forms.Button btnSetHeadingGains;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSetPID;
        private System.Windows.Forms.Button btnReadPID;
        private System.Windows.Forms.TabControl tc_PIDTabs;
        private System.Windows.Forms.TabPage tp_WP;
        private DMP_Gains.DMP_GainControl piD_GainControl_WP;
        private DMP_Gains.DMP_GainControl piD_GainControl_Image;
        private System.Windows.Forms.TabPage tp_Avoid;
        private DMP_Gains.Waypoint_Control waypoint_Control1;
        private DMP_Gains.ImageAvoid_Control imageAvoid_Control3;
        private System.Windows.Forms.TabPage tb_GoTo;
        private DMP_Gains.ImageGoTo_Control imageGoTo_Control1;
        private System.Windows.Forms.TabPage tb_Follow;
        private DMP_Gains.ImageFollow_Control imageFollow_Control1;
    }
}