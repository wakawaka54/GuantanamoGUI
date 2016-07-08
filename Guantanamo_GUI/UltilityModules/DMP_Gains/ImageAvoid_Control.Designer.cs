namespace Guantanamo_GUI.UltilityModules.DMP_Gains
{
    partial class ImageAvoid_Control
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
            this.txtkP = new System.Windows.Forms.TextBox();
            this.txtkI = new System.Windows.Forms.TextBox();
            this.txtkD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinArea = new System.Windows.Forms.TextBox();
            this.txtMaxArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJump = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtkP
            // 
            this.txtkP.Location = new System.Drawing.Point(42, 26);
            this.txtkP.Name = "txtkP";
            this.txtkP.Size = new System.Drawing.Size(100, 20);
            this.txtkP.TabIndex = 0;
            // 
            // txtkI
            // 
            this.txtkI.Location = new System.Drawing.Point(42, 52);
            this.txtkI.Name = "txtkI";
            this.txtkI.Size = new System.Drawing.Size(100, 20);
            this.txtkI.TabIndex = 1;
            // 
            // txtkD
            // 
            this.txtkD.Location = new System.Drawing.Point(42, 78);
            this.txtkD.Name = "txtkD";
            this.txtkD.Size = new System.Drawing.Size(100, 20);
            this.txtkD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "kP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "kI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "kD";
            // 
            // txtMinArea
            // 
            this.txtMinArea.Location = new System.Drawing.Point(203, 23);
            this.txtMinArea.Name = "txtMinArea";
            this.txtMinArea.Size = new System.Drawing.Size(100, 20);
            this.txtMinArea.TabIndex = 6;
            // 
            // txtMaxArea
            // 
            this.txtMaxArea.Location = new System.Drawing.Point(203, 52);
            this.txtMaxArea.Name = "txtMaxArea";
            this.txtMaxArea.Size = new System.Drawing.Size(100, 20);
            this.txtMaxArea.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Min Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Max Area";
            // 
            // txtJump
            // 
            this.txtJump.Location = new System.Drawing.Point(203, 81);
            this.txtJump.Name = "txtJump";
            this.txtJump.Size = new System.Drawing.Size(100, 20);
            this.txtJump.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Jump";
            // 
            // ImageAvoid_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtJump);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaxArea);
            this.Controls.Add(this.txtMinArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkD);
            this.Controls.Add(this.txtkI);
            this.Controls.Add(this.txtkP);
            this.Name = "ImageAvoid_Control";
            this.Size = new System.Drawing.Size(383, 185);
            this.Load += new System.EventHandler(this.ImageAvoid_Control_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkP;
        private System.Windows.Forms.TextBox txtkI;
        private System.Windows.Forms.TextBox txtkD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinArea;
        private System.Windows.Forms.TextBox txtMaxArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJump;
        private System.Windows.Forms.Label label6;
    }
}
