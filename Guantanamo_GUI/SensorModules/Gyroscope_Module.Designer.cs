namespace Guantanamo_GUI.SensorModules
{
    partial class Gyroscope_Module
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gyroscope_Module));
            this.chData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGyroX = new System.Windows.Forms.TextBox();
            this.txtGyroY = new System.Windows.Forms.TextBox();
            this.txtGyroZ = new System.Windows.Forms.TextBox();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDrift = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            // txtGyroX
            // 
            this.txtGyroX.Enabled = false;
            this.txtGyroX.Location = new System.Drawing.Point(35, 268);
            this.txtGyroX.Name = "txtGyroX";
            this.txtGyroX.Size = new System.Drawing.Size(59, 20);
            this.txtGyroX.TabIndex = 4;
            // 
            // txtGyroY
            // 
            this.txtGyroY.Enabled = false;
            this.txtGyroY.Location = new System.Drawing.Point(123, 268);
            this.txtGyroY.Name = "txtGyroY";
            this.txtGyroY.Size = new System.Drawing.Size(60, 20);
            this.txtGyroY.TabIndex = 5;
            // 
            // txtGyroZ
            // 
            this.txtGyroZ.Enabled = false;
            this.txtGyroZ.Location = new System.Drawing.Point(213, 268);
            this.txtGyroZ.Name = "txtGyroZ";
            this.txtGyroZ.Size = new System.Drawing.Size(60, 20);
            this.txtGyroZ.TabIndex = 6;
            // 
            // txtHeading
            // 
            this.txtHeading.Enabled = false;
            this.txtHeading.Location = new System.Drawing.Point(92, 294);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(60, 20);
            this.txtHeading.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gyro Heading:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Drift:";
            // 
            // txtDrift
            // 
            this.txtDrift.Enabled = false;
            this.txtDrift.Location = new System.Drawing.Point(193, 294);
            this.txtDrift.Name = "txtDrift";
            this.txtDrift.Size = new System.Drawing.Size(60, 20);
            this.txtDrift.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "mdeg/s";
            // 
            // Gyroscope_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 342);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDrift);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHeading);
            this.Controls.Add(this.txtGyroZ);
            this.Controls.Add(this.txtGyroY);
            this.Controls.Add(this.txtGyroX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gyroscope_Module";
            this.Text = "Gyroscope";
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
        private System.Windows.Forms.TextBox txtGyroX;
        private System.Windows.Forms.TextBox txtGyroY;
        private System.Windows.Forms.TextBox txtGyroZ;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDrift;
        private System.Windows.Forms.Label label6;
    }
}