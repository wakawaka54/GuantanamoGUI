namespace Guantanamo_GUI.UltilityModules
{
    partial class StateHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtClear = new System.Windows.Forms.Button();
            this.dgStateChanges = new System.Windows.Forms.DataGridView();
            this.cTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cChangeReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgStateChanges)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle State History";
            // 
            // txtClear
            // 
            this.txtClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClear.Location = new System.Drawing.Point(293, 473);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(96, 23);
            this.txtClear.TabIndex = 2;
            this.txtClear.Text = "Clear History";
            this.txtClear.UseVisualStyleBackColor = true;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // dgStateChanges
            // 
            this.dgStateChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgStateChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStateChanges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTime,
            this.cStateName,
            this.cChangeReason});
            this.dgStateChanges.Location = new System.Drawing.Point(14, 41);
            this.dgStateChanges.Name = "dgStateChanges";
            this.dgStateChanges.ReadOnly = true;
            this.dgStateChanges.Size = new System.Drawing.Size(375, 426);
            this.dgStateChanges.TabIndex = 3;
            // 
            // cTime
            // 
            this.cTime.HeaderText = "Time";
            this.cTime.Name = "cTime";
            // 
            // cStateName
            // 
            this.cStateName.HeaderText = "State Name";
            this.cStateName.Name = "cStateName";
            // 
            // cChangeReason
            // 
            this.cChangeReason.HeaderText = "Change Reason";
            this.cChangeReason.Name = "cChangeReason";
            // 
            // StateHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 512);
            this.Controls.Add(this.dgStateChanges);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.label1);
            this.Name = "StateHistory";
            this.Text = "State History";
            this.Load += new System.EventHandler(this.StateHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStateChanges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtClear;
        private System.Windows.Forms.DataGridView dgStateChanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cChangeReason;
    }
}