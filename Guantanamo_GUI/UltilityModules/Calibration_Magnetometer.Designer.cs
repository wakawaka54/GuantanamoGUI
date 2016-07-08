namespace Guantanamo_GUI.UltilityModules
{
    partial class Calibration_Magnetometer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calibration_Magnetometer));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDeclination = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtZOff = new System.Windows.Forms.TextBox();
            this.txtYOff = new System.Windows.Forms.TextBox();
            this.txtXOff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.txtZMin = new System.Windows.Forms.TextBox();
            this.txtYMin = new System.Windows.Forms.TextBox();
            this.txtXMin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtZMax = new System.Windows.Forms.TextBox();
            this.txtYMax = new System.Windows.Forms.TextBox();
            this.txtXMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnCalAll = new System.Windows.Forms.Button();
            this.btnReInit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 243);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(297, 55);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "Calibration Instructions:\nAll Axis Calibration - Rotate the vehicle in as many po" +
    "sitions as possible to scope out compass data. Press the End Calibration button " +
    "when finished.";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtDeclination);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.txtZOff);
            this.groupBox2.Controls.Add(this.txtYOff);
            this.groupBox2.Controls.Add(this.txtXOff);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(174, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 157);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calibration Results";
            // 
            // txtDeclination
            // 
            this.txtDeclination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeclination.Location = new System.Drawing.Point(79, 93);
            this.txtDeclination.Name = "txtDeclination";
            this.txtDeclination.ReadOnly = true;
            this.txtDeclination.Size = new System.Drawing.Size(50, 20);
            this.txtDeclination.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Declination";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(56, 125);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 26);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtZOff
            // 
            this.txtZOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZOff.Location = new System.Drawing.Point(64, 67);
            this.txtZOff.Name = "txtZOff";
            this.txtZOff.ReadOnly = true;
            this.txtZOff.Size = new System.Drawing.Size(65, 20);
            this.txtZOff.TabIndex = 5;
            // 
            // txtYOff
            // 
            this.txtYOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYOff.Location = new System.Drawing.Point(64, 44);
            this.txtYOff.Name = "txtYOff";
            this.txtYOff.ReadOnly = true;
            this.txtYOff.Size = new System.Drawing.Size(65, 20);
            this.txtYOff.TabIndex = 4;
            // 
            // txtXOff
            // 
            this.txtXOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXOff.Location = new System.Drawing.Point(64, 19);
            this.txtXOff.Name = "txtXOff";
            this.txtXOff.ReadOnly = true;
            this.txtXOff.Size = new System.Drawing.Size(65, 20);
            this.txtXOff.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Z-Offset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y-Offset";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X-Offset";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnEnd);
            this.groupBox1.Controls.Add(this.txtZMin);
            this.groupBox1.Controls.Add(this.txtYMin);
            this.groupBox1.Controls.Add(this.txtXMin);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtZMax);
            this.groupBox1.Controls.Add(this.txtYMax);
            this.groupBox1.Controls.Add(this.txtXMax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnStore);
            this.groupBox1.Controls.Add(this.btnCalAll);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 226);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calibration Commands";
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(6, 131);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(144, 26);
            this.btnEnd.TabIndex = 18;
            this.btnEnd.Text = "End Calibration";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // txtZMin
            // 
            this.txtZMin.Location = new System.Drawing.Point(123, 105);
            this.txtZMin.Name = "txtZMin";
            this.txtZMin.ReadOnly = true;
            this.txtZMin.Size = new System.Drawing.Size(27, 20);
            this.txtZMin.TabIndex = 17;
            // 
            // txtYMin
            // 
            this.txtYMin.Location = new System.Drawing.Point(123, 79);
            this.txtYMin.Name = "txtYMin";
            this.txtYMin.ReadOnly = true;
            this.txtYMin.Size = new System.Drawing.Size(27, 20);
            this.txtYMin.TabIndex = 16;
            // 
            // txtXMin
            // 
            this.txtXMin.Location = new System.Drawing.Point(123, 53);
            this.txtXMin.Name = "txtXMin";
            this.txtXMin.ReadOnly = true;
            this.txtXMin.Size = new System.Drawing.Size(27, 20);
            this.txtXMin.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Z-Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Y-Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "X-Min";
            // 
            // txtZMax
            // 
            this.txtZMax.Location = new System.Drawing.Point(49, 105);
            this.txtZMax.Name = "txtZMax";
            this.txtZMax.ReadOnly = true;
            this.txtZMax.Size = new System.Drawing.Size(27, 20);
            this.txtZMax.TabIndex = 11;
            // 
            // txtYMax
            // 
            this.txtYMax.Location = new System.Drawing.Point(49, 79);
            this.txtYMax.Name = "txtYMax";
            this.txtYMax.ReadOnly = true;
            this.txtYMax.Size = new System.Drawing.Size(27, 20);
            this.txtYMax.TabIndex = 10;
            // 
            // txtXMax
            // 
            this.txtXMax.Location = new System.Drawing.Point(49, 53);
            this.txtXMax.Name = "txtXMax";
            this.txtXMax.ReadOnly = true;
            this.txtXMax.Size = new System.Drawing.Size(27, 20);
            this.txtXMax.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Z-Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Y-Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "X-Max";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.Location = new System.Drawing.Point(6, 194);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(144, 26);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load Calibration";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnStore
            // 
            this.btnStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStore.Location = new System.Drawing.Point(6, 162);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(144, 26);
            this.btnStore.TabIndex = 3;
            this.btnStore.Text = "Store Calibration";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnCalAll
            // 
            this.btnCalAll.Location = new System.Drawing.Point(6, 21);
            this.btnCalAll.Name = "btnCalAll";
            this.btnCalAll.Size = new System.Drawing.Size(144, 26);
            this.btnCalAll.TabIndex = 0;
            this.btnCalAll.Text = "Calibrate All Axes";
            this.btnCalAll.UseVisualStyleBackColor = true;
            this.btnCalAll.Click += new System.EventHandler(this.btnCalAll_Click);
            // 
            // btnReInit
            // 
            this.btnReInit.Location = new System.Drawing.Point(219, 173);
            this.btnReInit.Name = "btnReInit";
            this.btnReInit.Size = new System.Drawing.Size(90, 25);
            this.btnReInit.TabIndex = 19;
            this.btnReInit.Text = "ReInit Heading";
            this.btnReInit.UseVisualStyleBackColor = true;
            this.btnReInit.Click += new System.EventHandler(this.btnReInit_Click);
            // 
            // Calibration_Magnetometer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 309);
            this.Controls.Add(this.btnReInit);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calibration_Magnetometer";
            this.Text = "Calibration_Magnetometer";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDeclination;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtZOff;
        private System.Windows.Forms.TextBox txtYOff;
        private System.Windows.Forms.TextBox txtXOff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtZMin;
        private System.Windows.Forms.TextBox txtYMin;
        private System.Windows.Forms.TextBox txtXMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtZMax;
        private System.Windows.Forms.TextBox txtYMax;
        private System.Windows.Forms.TextBox txtXMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnCalAll;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnReInit;
    }
}