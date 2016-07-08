namespace Guantanamo_GUI.Commands
{
    partial class SetSteering
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
            this.txtQueued = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThrottle = new System.Windows.Forms.Button();
            this.btnSteering = new System.Windows.Forms.Button();
            this.txtThrottle = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSteering = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtQueued
            // 
            this.txtQueued.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueued.Location = new System.Drawing.Point(3, 30);
            this.txtQueued.Name = "txtQueued";
            this.txtQueued.ReadOnly = true;
            this.txtQueued.Size = new System.Drawing.Size(234, 20);
            this.txtQueued.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Queued Command";
            // 
            // btnThrottle
            // 
            this.btnThrottle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThrottle.Location = new System.Drawing.Point(17, 141);
            this.btnThrottle.Name = "btnThrottle";
            this.btnThrottle.Size = new System.Drawing.Size(75, 23);
            this.btnThrottle.TabIndex = 7;
            this.btnThrottle.Text = "Throttle";
            this.btnThrottle.UseVisualStyleBackColor = true;
            this.btnThrottle.Click += new System.EventHandler(this.btnThrottle_Click);
            // 
            // btnSteering
            // 
            this.btnSteering.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSteering.Location = new System.Drawing.Point(98, 141);
            this.btnSteering.Name = "btnSteering";
            this.btnSteering.Size = new System.Drawing.Size(75, 23);
            this.btnSteering.TabIndex = 7;
            this.btnSteering.Text = "Steering";
            this.btnSteering.UseVisualStyleBackColor = true;
            this.btnSteering.Click += new System.EventHandler(this.btnSteering_Click);
            // 
            // txtThrottle
            // 
            this.txtThrottle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThrottle.Location = new System.Drawing.Point(72, 82);
            this.txtThrottle.Name = "txtThrottle";
            this.txtThrottle.Size = new System.Drawing.Size(165, 20);
            this.txtThrottle.TabIndex = 6;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(21, 89);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(43, 13);
            this.lb.TabIndex = 5;
            this.lb.Text = "Throttle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Steering";
            // 
            // txtSteering
            // 
            this.txtSteering.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSteering.Location = new System.Drawing.Point(72, 115);
            this.txtSteering.Name = "txtSteering";
            this.txtSteering.Size = new System.Drawing.Size(165, 20);
            this.txtSteering.TabIndex = 3;
            // 
            // SetSteering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtQueued);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThrottle);
            this.Controls.Add(this.btnSteering);
            this.Controls.Add(this.txtThrottle);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSteering);
            this.Name = "SetSteering";
            this.Size = new System.Drawing.Size(216, 176);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSteering;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtThrottle;
        private System.Windows.Forms.Button btnSteering;
        private System.Windows.Forms.Button btnThrottle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQueued;
    }
}
