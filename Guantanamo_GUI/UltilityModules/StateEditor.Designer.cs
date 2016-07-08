namespace Guantanamo_GUI.UltilityModules
{
    partial class StateEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateEditor));
            this.txtStateTable = new System.Windows.Forms.RichTextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.t_Tracker = new System.Windows.Forms.Timer(this.components);
            this.n_Interval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPathTrack = new System.Windows.Forms.Label();
            this.btnPathSingle = new System.Windows.Forms.Button();
            this.btnPathEnd = new System.Windows.Forms.Button();
            this.btnPathStart = new System.Windows.Forms.Button();
            this.txtHex = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtFromVehicle = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbVerification = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.n_Interval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStateTable
            // 
            this.txtStateTable.Location = new System.Drawing.Point(12, 49);
            this.txtStateTable.Name = "txtStateTable";
            this.txtStateTable.Size = new System.Drawing.Size(220, 311);
            this.txtStateTable.TabIndex = 0;
            this.txtStateTable.Text = "";
            this.txtStateTable.TextChanged += new System.EventHandler(this.txtStateTable_TextChanged);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(238, 89);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(129, 24);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Verify Navigation";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(238, 59);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(129, 24);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Write Navigation";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // t_Tracker
            // 
            this.t_Tracker.Interval = 1000;
            this.t_Tracker.Tick += new System.EventHandler(this.t_Tracker_Tick);
            // 
            // n_Interval
            // 
            this.n_Interval.Location = new System.Drawing.Point(15, 21);
            this.n_Interval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.n_Interval.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.n_Interval.Name = "n_Interval";
            this.n_Interval.Size = new System.Drawing.Size(74, 20);
            this.n_Interval.TabIndex = 5;
            this.n_Interval.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ms";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPathTrack);
            this.groupBox1.Controls.Add(this.btnPathSingle);
            this.groupBox1.Controls.Add(this.btnPathEnd);
            this.groupBox1.Controls.Add(this.btnPathStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.n_Interval);
            this.groupBox1.Location = new System.Drawing.Point(242, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 132);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path Track";
            // 
            // lbPathTrack
            // 
            this.lbPathTrack.AutoSize = true;
            this.lbPathTrack.Location = new System.Drawing.Point(28, 53);
            this.lbPathTrack.Name = "lbPathTrack";
            this.lbPathTrack.Size = new System.Drawing.Size(27, 13);
            this.lbPathTrack.TabIndex = 10;
            this.lbPathTrack.Text = "OFF";
            // 
            // btnPathSingle
            // 
            this.btnPathSingle.Location = new System.Drawing.Point(26, 103);
            this.btnPathSingle.Name = "btnPathSingle";
            this.btnPathSingle.Size = new System.Drawing.Size(89, 23);
            this.btnPathSingle.TabIndex = 9;
            this.btnPathSingle.Text = "Single Point";
            this.btnPathSingle.UseVisualStyleBackColor = true;
            this.btnPathSingle.Click += new System.EventHandler(this.btnPathSingle_Click);
            // 
            // btnPathEnd
            // 
            this.btnPathEnd.Location = new System.Drawing.Point(61, 77);
            this.btnPathEnd.Name = "btnPathEnd";
            this.btnPathEnd.Size = new System.Drawing.Size(54, 23);
            this.btnPathEnd.TabIndex = 8;
            this.btnPathEnd.Text = "End";
            this.btnPathEnd.UseVisualStyleBackColor = true;
            this.btnPathEnd.Click += new System.EventHandler(this.btnPathEnd_Click);
            // 
            // btnPathStart
            // 
            this.btnPathStart.Location = new System.Drawing.Point(61, 48);
            this.btnPathStart.Name = "btnPathStart";
            this.btnPathStart.Size = new System.Drawing.Size(54, 23);
            this.btnPathStart.TabIndex = 7;
            this.btnPathStart.Text = "Start";
            this.btnPathStart.UseVisualStyleBackColor = true;
            this.btnPathStart.Click += new System.EventHandler(this.btnPathStart_Click);
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(373, 49);
            this.txtHex.Name = "txtHex";
            this.txtHex.ReadOnly = true;
            this.txtHex.Size = new System.Drawing.Size(207, 143);
            this.txtHex.TabIndex = 8;
            this.txtHex.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(238, 185);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(129, 24);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate Table";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtFromVehicle
            // 
            this.txtFromVehicle.Location = new System.Drawing.Point(373, 209);
            this.txtFromVehicle.Name = "txtFromVehicle";
            this.txtFromVehicle.ReadOnly = true;
            this.txtFromVehicle.Size = new System.Drawing.Size(207, 162);
            this.txtFromVehicle.TabIndex = 10;
            this.txtFromVehicle.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vehicle EEPROM Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Generation State Table";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "State Table";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "State Table Editor";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(602, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(340, 322);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(599, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Function List";
            // 
            // lbVerification
            // 
            this.lbVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVerification.ForeColor = System.Drawing.Color.Red;
            this.lbVerification.Location = new System.Drawing.Point(238, 139);
            this.lbVerification.Name = "lbVerification";
            this.lbVerification.Size = new System.Drawing.Size(119, 43);
            this.lbVerification.TabIndex = 17;
            this.lbVerification.Text = "NOT UPLOADED";
            this.lbVerification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Upload Status";
            // 
            // StateEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 395);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbVerification);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFromVehicle);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtStateTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StateEditor";
            this.Text = "State Table Editor";
            this.Load += new System.EventHandler(this.StateEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n_Interval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtStateTable;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Timer t_Tracker;
        private System.Windows.Forms.NumericUpDown n_Interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPathTrack;
        private System.Windows.Forms.Button btnPathSingle;
        private System.Windows.Forms.Button btnPathEnd;
        private System.Windows.Forms.Button btnPathStart;
        private System.Windows.Forms.RichTextBox txtHex;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox txtFromVehicle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbVerification;
        private System.Windows.Forms.Label label7;
    }
}