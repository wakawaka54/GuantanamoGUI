namespace Guantanamo_GUI.SensorModules
{
    partial class Accelerometer_Module
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accelerometer_Module));
            this.chData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccX = new System.Windows.Forms.TextBox();
            this.txtAccY = new System.Windows.Forms.TextBox();
            this.txtAclZ = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chData)).BeginInit();
            this.SuspendLayout();
            // 
            // chData
            // 
            chartArea1.Name = "MainData";
            this.chData.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chData.Legends.Add(legend1);
            this.chData.Location = new System.Drawing.Point(12, 12);
            this.chData.Name = "chData";
            series1.BorderWidth = 2;
            series1.ChartArea = "MainData";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "X";
            series2.BorderWidth = 2;
            series2.ChartArea = "MainData";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Y";
            series3.BorderWidth = 2;
            series3.ChartArea = "MainData";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.Legend = "Legend1";
            series3.Name = "Z";
            this.chData.Series.Add(series1);
            this.chData.Series.Add(series2);
            this.chData.Series.Add(series3);
            this.chData.Size = new System.Drawing.Size(272, 250);
            this.chData.TabIndex = 0;
            this.chData.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Z:";
            // 
            // txtAccX
            // 
            this.txtAccX.Enabled = false;
            this.txtAccX.Location = new System.Drawing.Point(35, 268);
            this.txtAccX.Name = "txtAccX";
            this.txtAccX.Size = new System.Drawing.Size(59, 20);
            this.txtAccX.TabIndex = 4;
            // 
            // txtAccY
            // 
            this.txtAccY.Enabled = false;
            this.txtAccY.Location = new System.Drawing.Point(123, 268);
            this.txtAccY.Name = "txtAccY";
            this.txtAccY.Size = new System.Drawing.Size(60, 20);
            this.txtAccY.TabIndex = 5;
            // 
            // txtAclZ
            // 
            this.txtAclZ.Enabled = false;
            this.txtAclZ.Location = new System.Drawing.Point(213, 268);
            this.txtAclZ.Name = "txtAclZ";
            this.txtAclZ.Size = new System.Drawing.Size(60, 20);
            this.txtAclZ.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(35, 294);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Accelerometer_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 342);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtAclZ);
            this.Controls.Add(this.txtAccY);
            this.Controls.Add(this.txtAccX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accelerometer_Module";
            this.Text = "Accelerometer";
            this.Load += new System.EventHandler(this.Accelerometer_Module_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccX;
        private System.Windows.Forms.TextBox txtAccY;
        private System.Windows.Forms.TextBox txtAclZ;
        private System.Windows.Forms.Button btnReset;
    }
}