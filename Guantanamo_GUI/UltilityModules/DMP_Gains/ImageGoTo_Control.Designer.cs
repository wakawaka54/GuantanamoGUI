namespace Guantanamo_GUI.UltilityModules.DMP_Gains
{
    partial class ImageGoTo_Control
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkD = new System.Windows.Forms.TextBox();
            this.txtkI = new System.Windows.Forms.TextBox();
            this.txtkP = new System.Windows.Forms.TextBox();
            this.txtMaxArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "kD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "kI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "kP";
            // 
            // txtkD
            // 
            this.txtkD.Location = new System.Drawing.Point(38, 70);
            this.txtkD.Name = "txtkD";
            this.txtkD.Size = new System.Drawing.Size(100, 20);
            this.txtkD.TabIndex = 12;
            // 
            // txtkI
            // 
            this.txtkI.Location = new System.Drawing.Point(38, 44);
            this.txtkI.Name = "txtkI";
            this.txtkI.Size = new System.Drawing.Size(100, 20);
            this.txtkI.TabIndex = 11;
            // 
            // txtkP
            // 
            this.txtkP.Location = new System.Drawing.Point(38, 18);
            this.txtkP.Name = "txtkP";
            this.txtkP.Size = new System.Drawing.Size(100, 20);
            this.txtkP.TabIndex = 10;
            // 
            // txtMaxArea
            // 
            this.txtMaxArea.Location = new System.Drawing.Point(229, 18);
            this.txtMaxArea.Name = "txtMaxArea";
            this.txtMaxArea.Size = new System.Drawing.Size(100, 20);
            this.txtMaxArea.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Max Area";
            // 
            // ImageGoTo_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaxArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkD);
            this.Controls.Add(this.txtkI);
            this.Controls.Add(this.txtkP);
            this.Name = "ImageGoTo_Control";
            this.Size = new System.Drawing.Size(384, 185);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkD;
        private System.Windows.Forms.TextBox txtkI;
        private System.Windows.Forms.TextBox txtkP;
        private System.Windows.Forms.TextBox txtMaxArea;
        private System.Windows.Forms.Label label4;
    }
}
