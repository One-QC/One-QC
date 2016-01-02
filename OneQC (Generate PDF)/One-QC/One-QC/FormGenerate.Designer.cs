namespace One_QC
{
    partial class FormGenerate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerate));
            this.ButtonGenerateBRD = new System.Windows.Forms.Button();
            this.ButtonGenerateFSD = new System.Windows.Forms.Button();
            this.ButtonGenerateCDS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonGenerateBRD
            // 
            this.ButtonGenerateBRD.Location = new System.Drawing.Point(12, 12);
            this.ButtonGenerateBRD.Name = "ButtonGenerateBRD";
            this.ButtonGenerateBRD.Size = new System.Drawing.Size(260, 23);
            this.ButtonGenerateBRD.TabIndex = 0;
            this.ButtonGenerateBRD.Text = "Generate BRD";
            this.ButtonGenerateBRD.UseVisualStyleBackColor = true;
            this.ButtonGenerateBRD.Click += new System.EventHandler(this.ButtonGenerateBRD_Click);
            // 
            // ButtonGenerateFSD
            // 
            this.ButtonGenerateFSD.Location = new System.Drawing.Point(12, 41);
            this.ButtonGenerateFSD.Name = "ButtonGenerateFSD";
            this.ButtonGenerateFSD.Size = new System.Drawing.Size(260, 23);
            this.ButtonGenerateFSD.TabIndex = 1;
            this.ButtonGenerateFSD.Text = "Generate FSD";
            this.ButtonGenerateFSD.UseVisualStyleBackColor = true;
            this.ButtonGenerateFSD.Click += new System.EventHandler(this.ButtonGenerateFSD_Click);
            // 
            // ButtonGenerateCDS
            // 
            this.ButtonGenerateCDS.Location = new System.Drawing.Point(12, 70);
            this.ButtonGenerateCDS.Name = "ButtonGenerateCDS";
            this.ButtonGenerateCDS.Size = new System.Drawing.Size(260, 23);
            this.ButtonGenerateCDS.TabIndex = 2;
            this.ButtonGenerateCDS.Text = "Generate CDS";
            this.ButtonGenerateCDS.UseVisualStyleBackColor = true;
            this.ButtonGenerateCDS.Click += new System.EventHandler(this.ButtonGenerateCDS_Click);
            // 
            // FormGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 106);
            this.Controls.Add(this.ButtonGenerateCDS);
            this.Controls.Add(this.ButtonGenerateFSD);
            this.Controls.Add(this.ButtonGenerateBRD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGenerate";
            this.Text = "Form Generate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonGenerateBRD;
        private System.Windows.Forms.Button ButtonGenerateFSD;
        private System.Windows.Forms.Button ButtonGenerateCDS;
    }
}

