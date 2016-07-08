namespace Guantanamo_GUI.Commands
{
    partial class ImageProcessing
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
            this.cbVariableID = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.cbCommands = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbVariableID
            // 
            this.cbVariableID.FormattingEnabled = true;
            this.cbVariableID.Items.AddRange(new object[] {
            "CAMERA EFFECT",
            "AUTO EXPOSURE MODE",
            "AUTO EXPOSURE METERING MODE",
            "AUTO EXPOSURE BIAS",
            "SHUTTER SPEED",
            "BRIGHTNESS",
            "CONTRAST",
            "SATURATION",
            "WHITE BALANCE AUTO-PRESET",
            "ISO",
            "SCENE MODE",
            "RED BALANCE",
            "BLUE BALANCE",
            "SHARPNESS",
            "BLUE ROI TOP_Y",
            "GREEN ROI BOTTOM_Y",
            "HOOP RECT % MATCH"});
            this.cbVariableID.Location = new System.Drawing.Point(22, 92);
            this.cbVariableID.Name = "cbVariableID";
            this.cbVariableID.Size = new System.Drawing.Size(121, 21);
            this.cbVariableID.TabIndex = 7;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(22, 147);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(121, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change Variable";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Value";
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(86, 121);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(57, 20);
            this.txtVal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Variable ID";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(22, 40);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send Command";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cbCommands
            // 
            this.cbCommands.FormattingEnabled = true;
            this.cbCommands.Items.AddRange(new object[] {
            "Start",
            "Stop",
            "Avoid Red",
            "Avoid Blue",
            "Avoid Green",
            "Terminate",
            "Goto Red",
            "Goto Blue",
            "Goto Green",
            "VR",
            "DV",
            "Avoid Yellow",
            "Goto Yellow",
            "HSV1",
            "HSV2",
            "PR",
            "VRE",
            "PE",
            "Retrieve Image",
            "Reset Default",
            "Shutdown"});
            this.cbCommands.Location = new System.Drawing.Point(22, 13);
            this.cbCommands.Name = "cbCommands";
            this.cbCommands.Size = new System.Drawing.Size(121, 21);
            this.cbCommands.TabIndex = 0;
            this.cbCommands.SelectedIndexChanged += new System.EventHandler(this.cbCommands_SelectedIndexChanged);
            // 
            // ImageProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbVariableID);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cbCommands);
            this.Name = "ImageProcessing";
            this.Size = new System.Drawing.Size(158, 228);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCommands;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ComboBox cbVariableID;

    }
}
