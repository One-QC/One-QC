﻿namespace One_QC
{
    partial class CreateProjectTabForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Detail1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvProjectMember = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dtCreate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProjectType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLOB = new System.Windows.Forms.ComboBox();
            this.txbDivision = new System.Windows.Forms.TextBox();
            this.txbProjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbProjectID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCDS = new System.Windows.Forms.ComboBox();
            this.cmbFSD = new System.Windows.Forms.ComboBox();
            this.cmbBRD = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtCDS = new System.Windows.Forms.DateTimePicker();
            this.CbCDS = new System.Windows.Forms.CheckBox();
            this.dtFSD = new System.Windows.Forms.DateTimePicker();
            this.cbFSD = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtBRD = new System.Windows.Forms.DateTimePicker();
            this.cbBRD = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Detail1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectMember)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Detail1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 474);
            this.tabControl1.TabIndex = 0;
            // 
            // Detail1
            // 
            this.Detail1.Controls.Add(this.button1);
            this.Detail1.Controls.Add(this.dgvProjectMember);
            this.Detail1.Controls.Add(this.label8);
            this.Detail1.Controls.Add(this.dtCreate);
            this.Detail1.Controls.Add(this.label7);
            this.Detail1.Controls.Add(this.cmbProjectType);
            this.Detail1.Controls.Add(this.label6);
            this.Detail1.Controls.Add(this.label5);
            this.Detail1.Controls.Add(this.label4);
            this.Detail1.Controls.Add(this.cmbLOB);
            this.Detail1.Controls.Add(this.txbDivision);
            this.Detail1.Controls.Add(this.txbProjectName);
            this.Detail1.Controls.Add(this.label3);
            this.Detail1.Controls.Add(this.txbProjectID);
            this.Detail1.Controls.Add(this.label2);
            this.Detail1.Location = new System.Drawing.Point(4, 22);
            this.Detail1.Name = "Detail1";
            this.Detail1.Padding = new System.Windows.Forms.Padding(3);
            this.Detail1.Size = new System.Drawing.Size(633, 448);
            this.Detail1.TabIndex = 0;
            this.Detail1.Text = "Detail 1";
            this.Detail1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Add New Member";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvProjectMember
            // 
            this.dgvProjectMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectMember.Location = new System.Drawing.Point(24, 271);
            this.dgvProjectMember.Name = "dgvProjectMember";
            this.dgvProjectMember.Size = new System.Drawing.Size(584, 150);
            this.dgvProjectMember.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Project Member :";
            // 
            // dtCreate
            // 
            this.dtCreate.Location = new System.Drawing.Point(161, 205);
            this.dtCreate.Name = "dtCreate";
            this.dtCreate.Size = new System.Drawing.Size(448, 20);
            this.dtCreate.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Project Creation Date :";
            // 
            // cmbProjectType
            // 
            this.cmbProjectType.FormattingEnabled = true;
            this.cmbProjectType.Location = new System.Drawing.Point(120, 97);
            this.cmbProjectType.Name = "cmbProjectType";
            this.cmbProjectType.Size = new System.Drawing.Size(488, 21);
            this.cmbProjectType.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Project Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Division :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "LOB :";
            // 
            // cmbLOB
            // 
            this.cmbLOB.FormattingEnabled = true;
            this.cmbLOB.Location = new System.Drawing.Point(120, 133);
            this.cmbLOB.Name = "cmbLOB";
            this.cmbLOB.Size = new System.Drawing.Size(488, 21);
            this.cmbLOB.TabIndex = 27;
            // 
            // txbDivision
            // 
            this.txbDivision.Location = new System.Drawing.Point(120, 170);
            this.txbDivision.Name = "txbDivision";
            this.txbDivision.Size = new System.Drawing.Size(488, 20);
            this.txbDivision.TabIndex = 26;
            // 
            // txbProjectName
            // 
            this.txbProjectName.Location = new System.Drawing.Point(120, 60);
            this.txbProjectName.Name = "txbProjectName";
            this.txbProjectName.Size = new System.Drawing.Size(489, 20);
            this.txbProjectName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Project Name :";
            // 
            // txbProjectID
            // 
            this.txbProjectID.Location = new System.Drawing.Point(120, 26);
            this.txbProjectID.Name = "txbProjectID";
            this.txbProjectID.Size = new System.Drawing.Size(489, 20);
            this.txbProjectID.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Project ID :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(633, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detail 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbCDS);
            this.panel1.Controls.Add(this.cmbFSD);
            this.panel1.Controls.Add(this.cmbBRD);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dtCDS);
            this.panel1.Controls.Add(this.CbCDS);
            this.panel1.Controls.Add(this.dtFSD);
            this.panel1.Controls.Add(this.cbFSD);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dtBRD);
            this.panel1.Controls.Add(this.cbBRD);
            this.panel1.Location = new System.Drawing.Point(22, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 129);
            this.panel1.TabIndex = 3;
            // 
            // cmbCDS
            // 
            this.cmbCDS.FormattingEnabled = true;
            this.cmbCDS.Location = new System.Drawing.Point(442, 80);
            this.cmbCDS.Name = "cmbCDS";
            this.cmbCDS.Size = new System.Drawing.Size(130, 21);
            this.cmbCDS.TabIndex = 10;
            // 
            // cmbFSD
            // 
            this.cmbFSD.FormattingEnabled = true;
            this.cmbFSD.Location = new System.Drawing.Point(442, 48);
            this.cmbFSD.Name = "cmbFSD";
            this.cmbFSD.Size = new System.Drawing.Size(130, 21);
            this.cmbFSD.TabIndex = 9;
            // 
            // cmbBRD
            // 
            this.cmbBRD.FormattingEnabled = true;
            this.cmbBRD.Location = new System.Drawing.Point(442, 11);
            this.cmbBRD.Name = "cmbBRD";
            this.cmbBRD.Size = new System.Drawing.Size(130, 21);
            this.cmbBRD.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Deadline :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(96, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Deadline :";
            // 
            // dtCDS
            // 
            this.dtCDS.Location = new System.Drawing.Point(160, 81);
            this.dtCDS.Name = "dtCDS";
            this.dtCDS.Size = new System.Drawing.Size(259, 20);
            this.dtCDS.TabIndex = 6;
            // 
            // CbCDS
            // 
            this.CbCDS.AutoSize = true;
            this.CbCDS.Location = new System.Drawing.Point(12, 84);
            this.CbCDS.Name = "CbCDS";
            this.CbCDS.Size = new System.Drawing.Size(48, 17);
            this.CbCDS.TabIndex = 5;
            this.CbCDS.Text = "CDS";
            this.CbCDS.UseVisualStyleBackColor = true;
            // 
            // dtFSD
            // 
            this.dtFSD.Location = new System.Drawing.Point(160, 45);
            this.dtFSD.Name = "dtFSD";
            this.dtFSD.Size = new System.Drawing.Size(259, 20);
            this.dtFSD.TabIndex = 6;
            // 
            // cbFSD
            // 
            this.cbFSD.AutoSize = true;
            this.cbFSD.Location = new System.Drawing.Point(12, 48);
            this.cbFSD.Name = "cbFSD";
            this.cbFSD.Size = new System.Drawing.Size(47, 17);
            this.cbFSD.TabIndex = 5;
            this.cbFSD.Text = "FSD";
            this.cbFSD.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Deadline :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dtBRD
            // 
            this.dtBRD.Location = new System.Drawing.Point(160, 10);
            this.dtBRD.Name = "dtBRD";
            this.dtBRD.Size = new System.Drawing.Size(259, 20);
            this.dtBRD.TabIndex = 3;
            // 
            // cbBRD
            // 
            this.cbBRD.AutoSize = true;
            this.cbBRD.Location = new System.Drawing.Point(12, 13);
            this.cbBRD.Name = "cbBRD";
            this.cbBRD.Size = new System.Drawing.Size(49, 17);
            this.cbBRD.TabIndex = 2;
            this.cbBRD.Text = "BRD";
            this.cbBRD.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Documents";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(481, 527);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(574, 526);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 37;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(497, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Welcome ,----------";
            // 
            // CreateProjectTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 557);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "CreateProjectTabForm";
            this.Text = "CreateProjectTabForm";
            this.Load += new System.EventHandler(this.Create_Project_Tab_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.Detail1.ResumeLayout(false);
            this.Detail1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectMember)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Detail1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProjectMember;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtCreate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProjectType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLOB;
        private System.Windows.Forms.TextBox txbDivision;
        private System.Windows.Forms.TextBox txbProjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbProjectID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtBRD;
        private System.Windows.Forms.CheckBox cbBRD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCDS;
        private System.Windows.Forms.ComboBox cmbFSD;
        private System.Windows.Forms.ComboBox cmbBRD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtCDS;
        private System.Windows.Forms.CheckBox CbCDS;
        private System.Windows.Forms.DateTimePicker dtFSD;
        private System.Windows.Forms.CheckBox cbFSD;
    }
}