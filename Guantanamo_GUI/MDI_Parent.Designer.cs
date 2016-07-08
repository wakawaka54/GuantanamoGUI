namespace Guantanamo_GUI
{
    partial class MDI_Parent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Parent));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accelerometerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magnetometerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultrasonicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.probeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSensorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utlitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accelerometerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gyroscopeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magnetometerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magGyroVehicleHeadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wPHeadingSteeringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blobAreaCentroidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageCentroidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magnetometerXYZNormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleControlInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logUtilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialHealthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationUtilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandSenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateTableEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d_OpenLog = new System.Windows.Forms.OpenFileDialog();
            this.d_OpenWaypoints = new System.Windows.Forms.OpenFileDialog();
            this.d_SplitLog = new System.Windows.Forms.OpenFileDialog();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d_OpenCameraSettings = new System.Windows.Forms.OpenFileDialog();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.utlitiesToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1334, 24);
            this.msMain.TabIndex = 2;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetUIToolStripMenuItem,
            this.resetWorkspaceToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // resetUIToolStripMenuItem
            // 
            this.resetUIToolStripMenuItem.Name = "resetUIToolStripMenuItem";
            this.resetUIToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.resetUIToolStripMenuItem.Text = "Reset UI";
            this.resetUIToolStripMenuItem.Click += new System.EventHandler(this.resetUIToolStripMenuItem_Click);
            // 
            // resetWorkspaceToolStripMenuItem
            // 
            this.resetWorkspaceToolStripMenuItem.Name = "resetWorkspaceToolStripMenuItem";
            this.resetWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.resetWorkspaceToolStripMenuItem.Text = "Default Workspace";
            this.resetWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.resetWorkspaceToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gPSToolStripMenuItem,
            this.accelerometerToolStripMenuItem,
            this.diagnosticsToolStripMenuItem,
            this.magnetometerToolStripMenuItem,
            this.imageProcessingToolStripMenuItem,
            this.ultrasonicToolStripMenuItem,
            this.probeToolStripMenuItem,
            this.resetSensorsToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.windowToolStripMenuItem.Text = "Sensors";
            this.windowToolStripMenuItem.Click += new System.EventHandler(this.windowToolStripMenuItem_Click);
            // 
            // gPSToolStripMenuItem
            // 
            this.gPSToolStripMenuItem.Name = "gPSToolStripMenuItem";
            this.gPSToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.gPSToolStripMenuItem.Text = "Navigation";
            this.gPSToolStripMenuItem.Click += new System.EventHandler(this.gPSToolStripMenuItem_Click);
            // 
            // accelerometerToolStripMenuItem
            // 
            this.accelerometerToolStripMenuItem.Name = "accelerometerToolStripMenuItem";
            this.accelerometerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.accelerometerToolStripMenuItem.Text = "Accelerometer";
            this.accelerometerToolStripMenuItem.Click += new System.EventHandler(this.accelerometerToolStripMenuItem_Click);
            // 
            // diagnosticsToolStripMenuItem
            // 
            this.diagnosticsToolStripMenuItem.Name = "diagnosticsToolStripMenuItem";
            this.diagnosticsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.diagnosticsToolStripMenuItem.Text = "Diagnostics";
            this.diagnosticsToolStripMenuItem.Click += new System.EventHandler(this.diagnosticsToolStripMenuItem_Click);
            // 
            // magnetometerToolStripMenuItem
            // 
            this.magnetometerToolStripMenuItem.Name = "magnetometerToolStripMenuItem";
            this.magnetometerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.magnetometerToolStripMenuItem.Text = "Magnetometer";
            this.magnetometerToolStripMenuItem.Click += new System.EventHandler(this.magnetometerToolStripMenuItem_Click);
            // 
            // imageProcessingToolStripMenuItem
            // 
            this.imageProcessingToolStripMenuItem.Name = "imageProcessingToolStripMenuItem";
            this.imageProcessingToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.imageProcessingToolStripMenuItem.Text = "Image Processing";
            this.imageProcessingToolStripMenuItem.Click += new System.EventHandler(this.imageProcessingToolStripMenuItem_Click);
            // 
            // ultrasonicToolStripMenuItem
            // 
            this.ultrasonicToolStripMenuItem.Name = "ultrasonicToolStripMenuItem";
            this.ultrasonicToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ultrasonicToolStripMenuItem.Text = "Ultrasonic";
            this.ultrasonicToolStripMenuItem.Click += new System.EventHandler(this.ultrasonicToolStripMenuItem_Click);
            // 
            // probeToolStripMenuItem
            // 
            this.probeToolStripMenuItem.Name = "probeToolStripMenuItem";
            this.probeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.probeToolStripMenuItem.Text = "Probe";
            this.probeToolStripMenuItem.Click += new System.EventHandler(this.probeToolStripMenuItem_Click);
            // 
            // resetSensorsToolStripMenuItem
            // 
            this.resetSensorsToolStripMenuItem.Name = "resetSensorsToolStripMenuItem";
            this.resetSensorsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.resetSensorsToolStripMenuItem.Text = "Reset Sensors";
            this.resetSensorsToolStripMenuItem.Click += new System.EventHandler(this.resetSensorToolStripMenuItem_Click);
            // 
            // utlitiesToolStripMenuItem
            // 
            this.utlitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calibrationToolStripMenuItem,
            this.plotsToolStripMenuItem,
            this.logUtilityToolStripMenuItem,
            this.serialHealthToolStripMenuItem,
            this.navigationUtilityToolStripMenuItem,
            this.serialMonitorToolStripMenuItem,
            this.commandSenderToolStripMenuItem,
            this.stateTableEditorToolStripMenuItem,
            this.stateHistoryToolStripMenuItem});
            this.utlitiesToolStripMenuItem.Name = "utlitiesToolStripMenuItem";
            this.utlitiesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.utlitiesToolStripMenuItem.Text = "Utlities";
            // 
            // calibrationToolStripMenuItem
            // 
            this.calibrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accelerometerToolStripMenuItem1,
            this.gyroscopeToolStripMenuItem,
            this.magnetometerToolStripMenuItem1,
            this.dMPToolStripMenuItem});
            this.calibrationToolStripMenuItem.Name = "calibrationToolStripMenuItem";
            this.calibrationToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.calibrationToolStripMenuItem.Text = "Calibration";
            // 
            // accelerometerToolStripMenuItem1
            // 
            this.accelerometerToolStripMenuItem1.Name = "accelerometerToolStripMenuItem1";
            this.accelerometerToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.accelerometerToolStripMenuItem1.Text = "Accelerometer";
            this.accelerometerToolStripMenuItem1.Click += new System.EventHandler(this.accelerometerToolStripMenuItem1_Click);
            // 
            // gyroscopeToolStripMenuItem
            // 
            this.gyroscopeToolStripMenuItem.Name = "gyroscopeToolStripMenuItem";
            this.gyroscopeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.gyroscopeToolStripMenuItem.Text = "Gyroscope";
            this.gyroscopeToolStripMenuItem.Click += new System.EventHandler(this.gyroscopeToolStripMenuItem_Click);
            // 
            // magnetometerToolStripMenuItem1
            // 
            this.magnetometerToolStripMenuItem1.Name = "magnetometerToolStripMenuItem1";
            this.magnetometerToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.magnetometerToolStripMenuItem1.Text = "Magnetometer";
            this.magnetometerToolStripMenuItem1.Click += new System.EventHandler(this.magnetometerToolStripMenuItem1_Click);
            // 
            // dMPToolStripMenuItem
            // 
            this.dMPToolStripMenuItem.Name = "dMPToolStripMenuItem";
            this.dMPToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dMPToolStripMenuItem.Text = "DMP";
            this.dMPToolStripMenuItem.Click += new System.EventHandler(this.dMPToolStripMenuItem_Click);
            // 
            // plotsToolStripMenuItem
            // 
            this.plotsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magGyroVehicleHeadingToolStripMenuItem,
            this.wPHeadingSteeringToolStripMenuItem,
            this.blobAreaCentroidToolStripMenuItem,
            this.imageCentroidToolStripMenuItem,
            this.magnetometerXYZNormToolStripMenuItem,
            this.vehicleControlInformationToolStripMenuItem});
            this.plotsToolStripMenuItem.Name = "plotsToolStripMenuItem";
            this.plotsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.plotsToolStripMenuItem.Text = "Plots";
            // 
            // magGyroVehicleHeadingToolStripMenuItem
            // 
            this.magGyroVehicleHeadingToolStripMenuItem.Name = "magGyroVehicleHeadingToolStripMenuItem";
            this.magGyroVehicleHeadingToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.magGyroVehicleHeadingToolStripMenuItem.Text = "Mag/Gyro/Vehicle Heading";
            this.magGyroVehicleHeadingToolStripMenuItem.Click += new System.EventHandler(this.magGyroVehicleHeadingToolStripMenuItem_Click);
            // 
            // wPHeadingSteeringToolStripMenuItem
            // 
            this.wPHeadingSteeringToolStripMenuItem.Name = "wPHeadingSteeringToolStripMenuItem";
            this.wPHeadingSteeringToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.wPHeadingSteeringToolStripMenuItem.Text = "WP Heading/Steering";
            this.wPHeadingSteeringToolStripMenuItem.Click += new System.EventHandler(this.wPHeadingSteeringToolStripMenuItem_Click);
            // 
            // blobAreaCentroidToolStripMenuItem
            // 
            this.blobAreaCentroidToolStripMenuItem.Name = "blobAreaCentroidToolStripMenuItem";
            this.blobAreaCentroidToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.blobAreaCentroidToolStripMenuItem.Text = "Blob Area";
            this.blobAreaCentroidToolStripMenuItem.Click += new System.EventHandler(this.blobAreaCentroidToolStripMenuItem_Click);
            // 
            // imageCentroidToolStripMenuItem
            // 
            this.imageCentroidToolStripMenuItem.Name = "imageCentroidToolStripMenuItem";
            this.imageCentroidToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.imageCentroidToolStripMenuItem.Text = "Image Centroid";
            this.imageCentroidToolStripMenuItem.Click += new System.EventHandler(this.imageCentroidToolStripMenuItem_Click);
            // 
            // magnetometerXYZNormToolStripMenuItem
            // 
            this.magnetometerXYZNormToolStripMenuItem.Name = "magnetometerXYZNormToolStripMenuItem";
            this.magnetometerXYZNormToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.magnetometerXYZNormToolStripMenuItem.Text = "Magnetometer XYZ Norm";
            this.magnetometerXYZNormToolStripMenuItem.Click += new System.EventHandler(this.magnetometerXYZNormToolStripMenuItem_Click);
            // 
            // vehicleControlInformationToolStripMenuItem
            // 
            this.vehicleControlInformationToolStripMenuItem.Name = "vehicleControlInformationToolStripMenuItem";
            this.vehicleControlInformationToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.vehicleControlInformationToolStripMenuItem.Text = "Vehicle Control Information";
            this.vehicleControlInformationToolStripMenuItem.Click += new System.EventHandler(this.vehicleControlInformationToolStripMenuItem_Click);
            // 
            // logUtilityToolStripMenuItem
            // 
            this.logUtilityToolStripMenuItem.Name = "logUtilityToolStripMenuItem";
            this.logUtilityToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.logUtilityToolStripMenuItem.Text = "Log Utility";
            this.logUtilityToolStripMenuItem.Click += new System.EventHandler(this.logUtilityToolStripMenuItem_Click);
            // 
            // serialHealthToolStripMenuItem
            // 
            this.serialHealthToolStripMenuItem.Name = "serialHealthToolStripMenuItem";
            this.serialHealthToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.serialHealthToolStripMenuItem.Text = "Serial Health";
            this.serialHealthToolStripMenuItem.Click += new System.EventHandler(this.serialHealthToolStripMenuItem_Click);
            // 
            // navigationUtilityToolStripMenuItem
            // 
            this.navigationUtilityToolStripMenuItem.Name = "navigationUtilityToolStripMenuItem";
            this.navigationUtilityToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.navigationUtilityToolStripMenuItem.Text = "Navigation Utility";
            this.navigationUtilityToolStripMenuItem.Click += new System.EventHandler(this.navigationUtilityToolStripMenuItem_Click);
            // 
            // serialMonitorToolStripMenuItem
            // 
            this.serialMonitorToolStripMenuItem.Name = "serialMonitorToolStripMenuItem";
            this.serialMonitorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.serialMonitorToolStripMenuItem.Text = "Serial Monitor";
            this.serialMonitorToolStripMenuItem.Click += new System.EventHandler(this.serialMonitorToolStripMenuItem_Click);
            // 
            // commandSenderToolStripMenuItem
            // 
            this.commandSenderToolStripMenuItem.Name = "commandSenderToolStripMenuItem";
            this.commandSenderToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.commandSenderToolStripMenuItem.Text = "Command Sender";
            this.commandSenderToolStripMenuItem.Click += new System.EventHandler(this.serialConnectToolStripMenuItem_Click);
            // 
            // stateTableEditorToolStripMenuItem
            // 
            this.stateTableEditorToolStripMenuItem.Name = "stateTableEditorToolStripMenuItem";
            this.stateTableEditorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.stateTableEditorToolStripMenuItem.Text = "State Table Editor";
            this.stateTableEditorToolStripMenuItem.Click += new System.EventHandler(this.stateTableEditorToolStripMenuItem_Click);
            // 
            // stateHistoryToolStripMenuItem
            // 
            this.stateHistoryToolStripMenuItem.Name = "stateHistoryToolStripMenuItem";
            this.stateHistoryToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.stateHistoryToolStripMenuItem.Text = "State History";
            this.stateHistoryToolStripMenuItem.Click += new System.EventHandler(this.stateHistoryToolStripMenuItem_Click);
            // 
            // d_OpenLog
            // 
            this.d_OpenLog.FileOk += new System.ComponentModel.CancelEventHandler(this.d_OpenLog_FileOk);
            // 
            // d_OpenWaypoints
            // 
            this.d_OpenWaypoints.FileOk += new System.ComponentModel.CancelEventHandler(this.d_OpenWaypoints_FileOk);
            // 
            // d_SplitLog
            // 
            this.d_SplitLog.FileOk += new System.ComponentModel.CancelEventHandler(this.d_SplitLog_FileOk);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraSettingsToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // cameraSettingsToolStripMenuItem
            // 
            this.cameraSettingsToolStripMenuItem.Name = "cameraSettingsToolStripMenuItem";
            this.cameraSettingsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cameraSettingsToolStripMenuItem.Text = "Camera Settings";
            this.cameraSettingsToolStripMenuItem.Click += new System.EventHandler(this.cameraSettingsToolStripMenuItem_Click);
            // 
            // d_OpenCameraSettings
            // 
            this.d_OpenCameraSettings.FileOk += new System.ComponentModel.CancelEventHandler(this.d_OpenCameraSettings_FileOk);
            // 
            // MDI_Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1334, 729);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "MDI_Parent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guantanamo GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDI_Parent_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gPSToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog d_OpenLog;
        private System.Windows.Forms.ToolStripMenuItem magnetometerToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog d_OpenWaypoints;
        private System.Windows.Forms.ToolStripMenuItem accelerometerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetWorkspaceToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog d_SplitLog;
        private System.Windows.Forms.ToolStripMenuItem probeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ultrasonicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utlitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialHealthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationUtilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accelerometerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gyroscopeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magnetometerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandSenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSensorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stateTableEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magGyroVehicleHeadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wPHeadingSteeringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blobAreaCentroidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageCentroidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logUtilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stateHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magnetometerXYZNormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleControlInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraSettingsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog d_OpenCameraSettings;

    }
}

