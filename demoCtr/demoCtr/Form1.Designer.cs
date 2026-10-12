namespace demoCtr
{
    partial class Form1
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
            this.btFCFS = new System.Windows.Forms.Button();
            this.btSJF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btFCFS
            // 
            this.btFCFS.Location = new System.Drawing.Point(172, 118);
            this.btFCFS.Name = "btFCFS";
            this.btFCFS.Size = new System.Drawing.Size(134, 50);
            this.btFCFS.TabIndex = 0;
            this.btFCFS.Text = "FCFS";
            this.btFCFS.UseVisualStyleBackColor = true;
            this.btFCFS.Click += new System.EventHandler(this.btFCFS_Click);
            // 
            // btSJF
            // 
            this.btSJF.Location = new System.Drawing.Point(419, 118);
            this.btSJF.Name = "btSJF";
            this.btSJF.Size = new System.Drawing.Size(126, 50);
            this.btSJF.TabIndex = 1;
            this.btSJF.Text = "SJF";
            this.btSJF.UseVisualStyleBackColor = true;
            this.btSJF.Click += new System.EventHandler(this.btSJF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSJF);
            this.Controls.Add(this.btFCFS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFCFS;
        private System.Windows.Forms.Button btSJF;
    }
}

