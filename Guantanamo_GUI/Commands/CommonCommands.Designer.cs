namespace Guantanamo_GUI.Commands
{
    partial class CommonCommands
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGPS = new System.Windows.Forms.Button();
            this.btnVehicleStateReset = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetEEPROM = new System.Windows.Forms.Button();
            this.btnHijack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGPS
            // 
            this.btnGPS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGPS.Location = new System.Drawing.Point(24, 115);
            this.btnGPS.Name = "btnGPS";
            this.btnGPS.Size = new System.Drawing.Size(120, 23);
            this.btnGPS.TabIndex = 0;
            this.btnGPS.Text = "Toggle GPS Output";
            this.btnGPS.UseVisualStyleBackColor = true;
            this.btnGPS.Click += new System.EventHandler(this.btnGPS_Click);
            // 
            // btnVehicleStateReset
            // 
            this.btnVehicleStateReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVehicleStateReset.Location = new System.Drawing.Point(24, 51);
            this.btnVehicleStateReset.Name = "btnVehicleStateReset";
            this.btnVehicleStateReset.Size = new System.Drawing.Size(120, 23);
            this.btnVehicleStateReset.TabIndex = 1;
            this.btnVehicleStateReset.Text = "Vehicle State Reset";
            this.btnVehicleStateReset.UseVisualStyleBackColor = true;
            this.btnVehicleStateReset.Click += new System.EventHandler(this.btnNavigation_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommand.Location = new System.Drawing.Point(15, 25);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.ReadOnly = true;
            this.txtCommand.Size = new System.Drawing.Size(141, 20);
            this.txtCommand.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Queued Command";
            // 
            // btnResetEEPROM
            // 
            this.btnResetEEPROM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetEEPROM.Location = new System.Drawing.Point(24, 80);
            this.btnResetEEPROM.Name = "btnResetEEPROM";
            this.btnResetEEPROM.Size = new System.Drawing.Size(120, 23);
            this.btnResetEEPROM.TabIndex = 4;
            this.btnResetEEPROM.Text = "Begin State Table";
            this.btnResetEEPROM.UseVisualStyleBackColor = true;
            this.btnResetEEPROM.Click += new System.EventHandler(this.btnResetEEPROM_Click);
            // 
            // btnHijack
            // 
            this.btnHijack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHijack.Location = new System.Drawing.Point(24, 144);
            this.btnHijack.Name = "btnHijack";
            this.btnHijack.Size = new System.Drawing.Size(120, 23);
            this.btnHijack.TabIndex = 5;
            this.btnHijack.Text = "Stop Hijack";
            this.btnHijack.UseVisualStyleBackColor = true;
            this.btnHijack.Click += new System.EventHandler(this.btnHijack_Click);
            // 
            // CommonCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHijack);
            this.Controls.Add(this.btnResetEEPROM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnVehicleStateReset);
            this.Controls.Add(this.btnGPS);
            this.Name = "CommonCommands";
            this.Size = new System.Drawing.Size(173, 222);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGPS;
        private System.Windows.Forms.Button btnVehicleStateReset;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResetEEPROM;
        private System.Windows.Forms.Button btnHijack;
    }
}
