namespace ISYS4363_Maintenance
{
    partial class ClassInformation
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
            this.dgvClassInfo = new System.Windows.Forms.DataGridView();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClassInfo
            // 
            this.dgvClassInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassInfo.Location = new System.Drawing.Point(26, 248);
            this.dgvClassInfo.Name = "dgvClassInfo";
            this.dgvClassInfo.Size = new System.Drawing.Size(791, 314);
            this.dgvClassInfo.TabIndex = 0;
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(485, 125);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.ReadOnly = true;
            this.txtProgram.Size = new System.Drawing.Size(277, 20);
            this.txtProgram.TabIndex = 261;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(76, 125);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(277, 20);
            this.txtStudentID.TabIndex = 260;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 259;
            this.label4.Text = "FIRST";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(214, 177);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.ReadOnly = true;
            this.txtFirst.Size = new System.Drawing.Size(139, 20);
            this.txtFirst.TabIndex = 258;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 257;
            this.label3.Text = "SEMESTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 256;
            this.label2.Text = "PROGRAM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 255;
            this.label1.Text = "LAST";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 254;
            this.label5.Text = "STUDENT ID";
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(76, 178);
            this.txtLast.Name = "txtLast";
            this.txtLast.ReadOnly = true;
            this.txtLast.Size = new System.Drawing.Size(132, 20);
            this.txtLast.TabIndex = 252;
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(485, 178);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.ReadOnly = true;
            this.txtSemester.Size = new System.Drawing.Size(277, 20);
            this.txtSemester.TabIndex = 262;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(745, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 264;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 263;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ClassInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 624);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.dgvClassInfo);
            this.Name = "ClassInformation";
            this.Text = "ClassInformation";
            this.Load += new System.EventHandler(this.ClassInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClassInfo;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
    }
}