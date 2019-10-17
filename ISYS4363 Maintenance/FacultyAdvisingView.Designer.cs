namespace ISYS4363_Maintenance
{
    partial class FacultyAdvisingView
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
            this.cmbStudentID = new System.Windows.Forms.ComboBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstCompleted = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.lstPending = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbStudentID
            // 
            this.cmbStudentID.FormattingEnabled = true;
            this.cmbStudentID.Location = new System.Drawing.Point(70, 89);
            this.cmbStudentID.Name = "cmbStudentID";
            this.cmbStudentID.Size = new System.Drawing.Size(277, 21);
            this.cmbStudentID.TabIndex = 76;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(70, 143);
            this.txtLast.Name = "txtLast";
            this.txtLast.ReadOnly = true;
            this.txtLast.Size = new System.Drawing.Size(132, 20);
            this.txtLast.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "STUDENT ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "LAST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "PROGRAM";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(208, 142);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.ReadOnly = true;
            this.txtFirst.Size = new System.Drawing.Size(139, 20);
            this.txtFirst.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "FIRST";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(744, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 250;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(9, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 249;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstCompleted
            // 
            this.lstCompleted.FormattingEnabled = true;
            this.lstCompleted.Location = new System.Drawing.Point(70, 270);
            this.lstCompleted.Name = "lstCompleted";
            this.lstCompleted.Size = new System.Drawing.Size(277, 251);
            this.lstCompleted.TabIndex = 251;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(664, 403);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 252;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(520, 405);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(138, 21);
            this.cmbStatus.TabIndex = 253;
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(70, 203);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.ReadOnly = true;
            this.txtProgram.Size = new System.Drawing.Size(277, 20);
            this.txtProgram.TabIndex = 254;
            // 
            // lstPending
            // 
            this.lstPending.FormattingEnabled = true;
            this.lstPending.Location = new System.Drawing.Point(492, 89);
            this.lstPending.Name = "lstPending";
            this.lstPending.Size = new System.Drawing.Size(277, 238);
            this.lstPending.TabIndex = 255;
            // 
            // FacultyAdvisingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 601);
            this.Controls.Add(this.lstPending);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lstCompleted);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.cmbStudentID);
            this.Name = "FacultyAdvisingView";
            this.Text = "FacultyAdvisingView";
            this.Load += new System.EventHandler(this.FacultyAdivingView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStudentID;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstCompleted;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.ListBox lstPending;
    }
}