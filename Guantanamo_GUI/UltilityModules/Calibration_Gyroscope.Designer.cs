namespace Guantanamo_GUI.UltilityModules
{
    partial class Calibration_Gyroscope
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calibration_Gyroscope));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDrift = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtZOff = new System.Windows.Forms.TextBox();
            this.txtYOff = new System.Windows.Forms.TextBox();
            this.txtXOff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnCalX = new System.Windows.Forms.Button();
            this.btnCalZ = new System.Windows.Forms.Button();
            this.btnCalOffset = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(15, 244);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(321, 59);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "Calibration Instructions:\nZero Offset - Ensure that vehicle has no rotation durin" +
    "g calibration";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDrift);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.txtZOff);
            this.groupBox2.Controls.Add(this.txtYOff);
            this.groupBox2.Controls.Add(this.txtXOff);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(173, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 226);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calibration Results";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "mdeg/s";
            // 
            // txtDrift
            // 
            this.txtDrift.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDrift.Location = new System.Drawing.Point(9, 122);
            this.txtDrift.Name = "txtDrift";
            this.txtDrift.ReadOnly = true;
            this.txtDrift.Size = new System.Drawing.Size(103, 20);
            this.txtDrift.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Avg Drift";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(88, 194);
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
            this.txtZOff.Location = new System.Drawing.Point(67, 73);
            this.txtZOff.Name = "txtZOff";
            this.txtZOff.ReadOnly = true;
            this.txtZOff.Size = new System.Drawing.Size(84, 20);
            this.txtZOff.TabIndex = 5;
            // 
            // txtYOff
            // 
            this.txtYOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYOff.Location = new System.Drawing.Point(67, 50);
            this.txtYOff.Name = "txtYOff";
            this.txtYOff.ReadOnly = true;
            this.txtYOff.Size = new System.Drawing.Size(84, 20);
            this.txtYOff.TabIndex = 4;
            // 
            // txtXOff
            // 
            this.txtXOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXOff.Location = new System.Drawing.Point(67, 25);
            this.txtXOff.Name = "txtXOff";
            this.txtXOff.ReadOnly = true;
            this.txtXOff.Size = new System.Drawing.Size(84, 20);
            this.txtXOff.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Z-Offset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drift Offset";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X-Offset";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnStore);
            this.groupBox1.Controls.Add(this.btnCalX);
            this.groupBox1.Controls.Add(this.btnCalZ);
            this.groupBox1.Controls.Add(this.btnCalOffset);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 226);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calibration Commands";
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
            // btnCalX
            // 
            this.btnCalX.Enabled = false;
            this.btnCalX.Location = new System.Drawing.Point(6, 21);
            this.btnCalX.Name = "btnCalX";
            this.btnCalX.Size = new System.Drawing.Size(140, 26);
            this.btnCalX.TabIndex = 0;
            this.btnCalX.Text = "Calibrate Zero Offset - X";
            this.btnCalX.UseVisualStyleBackColor = true;
            // 
            // btnCalZ
            // 
            this.btnCalZ.Location = new System.Drawing.Point(6, 85);
            this.btnCalZ.Name = "btnCalZ";
            this.btnCalZ.Size = new System.Drawing.Size(140, 26);
            this.btnCalZ.TabIndex = 2;
            this.btnCalZ.Text = "Calibrate Zero Offset - Z";
            this.btnCalZ.UseVisualStyleBackColor = true;
            this.btnCalZ.Click += new System.EventHandler(this.btnCalZ_Click);
            // 
            // btnCalOffset
            // 
            this.btnCalOffset.Location = new System.Drawing.Point(6, 53);
            this.btnCalOffset.Name = "btnCalOffset";
            this.btnCalOffset.Size = new System.Drawing.Size(140, 26);
            this.btnCalOffset.TabIndex = 1;
            this.btnCalOffset.Text = "Calibrate Drift Offset";
            this.btnCalOffset.UseVisualStyleBackColor = true;
            this.btnCalOffset.Click += new System.EventHandler(this.btnCalOffset_Click);
            // 
            // Calibration_Gyroscope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 307);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calibration_Gyroscope";
            this.Text = "Calibration Gyroscope";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDrift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtZOff;
        private System.Windows.Forms.TextBox txtYOff;
        private System.Windows.Forms.TextBox txtXOff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnCalX;
        private System.Windows.Forms.Button btnCalZ;
        private System.Windows.Forms.Button btnCalOffset;
        private System.Windows.Forms.Label label5;
    }
}