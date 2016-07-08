namespace Guantanamo_GUI.Commands
{
    partial class PMTKSend
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
            this.txtEntireSentence = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPMTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEntireSentence
            // 
            this.txtEntireSentence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntireSentence.Location = new System.Drawing.Point(6, 66);
            this.txtEntireSentence.Name = "txtEntireSentence";
            this.txtEntireSentence.ReadOnly = true;
            this.txtEntireSentence.Size = new System.Drawing.Size(192, 20);
            this.txtEntireSentence.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "$PMTK";
            // 
            // txtPMTK
            // 
            this.txtPMTK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPMTK.Location = new System.Drawing.Point(46, 3);
            this.txtPMTK.Name = "txtPMTK";
            this.txtPMTK.Size = new System.Drawing.Size(152, 20);
            this.txtPMTK.TabIndex = 2;
            this.txtPMTK.TextChanged += new System.EventHandler(this.txtPMTK_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PMTK Sentence";
            // 
            // PMTKSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEntireSentence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPMTK);
            this.Controls.Add(this.label2);
            this.Name = "PMTKSend";
            this.Size = new System.Drawing.Size(212, 292);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPMTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntireSentence;
    }
}
