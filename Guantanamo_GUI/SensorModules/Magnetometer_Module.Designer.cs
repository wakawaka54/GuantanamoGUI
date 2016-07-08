namespace Guantanamo_GUI.SensorModules
{
    partial class Magnetometer_Module
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
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Magnetometer_Module));
            this.chData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.lbZ = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNorm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNormXY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMagHeading = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chData)).BeginInit();
            this.SuspendLayout();
            // 
            // chData
            // 
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.Name = "MainArea";
            this.chData.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chData.Legends.Add(legend1);
            this.chData.Location = new System.Drawing.Point(17, 12);
            this.chData.Name = "chData";
            this.chData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "MainArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series1.CustomProperties = "PolarDrawingStyle=Marker";
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.DarkRed;
            series1.MarkerBorderWidth = 4;
            series1.Name = "Heading";
            series2.BorderWidth = 2;
            series2.ChartArea = "MainArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series2.Color = System.Drawing.Color.Black;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "PathSeries";
            series2.ShadowColor = System.Drawing.Color.Black;
            series3.ChartArea = "MainArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series3.Color = System.Drawing.Color.Blue;
            series3.CustomProperties = "PolarDrawingStyle=Marker";
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.Blue;
            series3.MarkerBorderWidth = 2;
            series3.MarkerColor = System.Drawing.Color.Transparent;
            series3.MarkerSize = 9;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series3.Name = "WP Heading";
            series4.ChartArea = "MainArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series4.CustomProperties = "PolarDrawingStyle=Marker";
            series4.Legend = "Legend1";
            series4.MarkerColor = System.Drawing.Color.Silver;
            series4.Name = "Mag Heading";
            this.chData.Series.Add(series1);
            this.chData.Series.Add(series2);
            this.chData.Series.Add(series3);
            this.chData.Series.Add(series4);
            this.chData.Size = new System.Drawing.Size(265, 246);
            this.chData.TabIndex = 0;
            this.chData.Text = "Heading";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(25, 267);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(17, 13);
            this.lbX.TabIndex = 2;
            this.lbX.Text = "X:";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(110, 267);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(17, 13);
            this.lbY.TabIndex = 3;
            this.lbY.Text = "Y:";
            // 
            // lbZ
            // 
            this.lbZ.AutoSize = true;
            this.lbZ.Location = new System.Drawing.Point(195, 267);
            this.lbZ.Name = "lbZ";
            this.lbZ.Size = new System.Drawing.Size(17, 13);
            this.lbZ.TabIndex = 4;
            this.lbZ.Text = "Z:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(48, 264);
            this.txtX.Name = "txtX";
            this.txtX.ReadOnly = true;
            this.txtX.Size = new System.Drawing.Size(56, 20);
            this.txtX.TabIndex = 5;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(133, 264);
            this.txtY.Name = "txtY";
            this.txtY.ReadOnly = true;
            this.txtY.Size = new System.Drawing.Size(56, 20);
            this.txtY.TabIndex = 6;
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(218, 264);
            this.txtZ.Name = "txtZ";
            this.txtZ.ReadOnly = true;
            this.txtZ.Size = new System.Drawing.Size(56, 20);
            this.txtZ.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Heading:";
            // 
            // txtHeading
            // 
            this.txtHeading.Location = new System.Drawing.Point(74, 291);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.ReadOnly = true;
            this.txtHeading.Size = new System.Drawing.Size(64, 20);
            this.txtHeading.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Norm MV:";
            // 
            // txtNorm
            // 
            this.txtNorm.Location = new System.Drawing.Point(74, 317);
            this.txtNorm.Name = "txtNorm";
            this.txtNorm.ReadOnly = true;
            this.txtNorm.Size = new System.Drawing.Size(64, 20);
            this.txtNorm.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Norm MV_XY:";
            // 
            // txtNormXY
            // 
            this.txtNormXY.Location = new System.Drawing.Point(218, 316);
            this.txtNormXY.Name = "txtNormXY";
            this.txtNormXY.ReadOnly = true;
            this.txtNormXY.Size = new System.Drawing.Size(64, 20);
            this.txtNormXY.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mag Heading:";
            // 
            // txtMagHeading
            // 
            this.txtMagHeading.Location = new System.Drawing.Point(218, 291);
            this.txtMagHeading.Name = "txtMagHeading";
            this.txtMagHeading.ReadOnly = true;
            this.txtMagHeading.Size = new System.Drawing.Size(64, 20);
            this.txtMagHeading.TabIndex = 16;
            // 
            // Magnetometer_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 342);
            this.Controls.Add(this.txtMagHeading);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNormXY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNorm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHeading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lbZ);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.chData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Magnetometer_Module";
            this.Text = "Magnetometer";
            ((System.ComponentModel.ISupportInitialize)(this.chData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chData;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbZ;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNorm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNormXY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMagHeading;
    }
}