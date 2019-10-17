namespace ISYS4363_Maintenance
{
    partial class SelectionMenu
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
            this.btnViewApplicants = new System.Windows.Forms.Button();
            this.btnEnrollment = new System.Windows.Forms.Button();
            this.btnClassInformation = new System.Windows.Forms.Button();
            this.btnStudentInformation = new System.Windows.Forms.Button();
            this.btnYourInformation = new System.Windows.Forms.Button();
            this.btnAdvising = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewApplicants
            // 
            this.btnViewApplicants.Location = new System.Drawing.Point(74, 289);
            this.btnViewApplicants.Name = "btnViewApplicants";
            this.btnViewApplicants.Size = new System.Drawing.Size(163, 27);
            this.btnViewApplicants.TabIndex = 9;
            this.btnViewApplicants.Text = "View Applicants";
            this.btnViewApplicants.UseVisualStyleBackColor = true;
            this.btnViewApplicants.Click += new System.EventHandler(this.btnViewApplicants_Click);
            // 
            // btnEnrollment
            // 
            this.btnEnrollment.Location = new System.Drawing.Point(74, 186);
            this.btnEnrollment.Name = "btnEnrollment";
            this.btnEnrollment.Size = new System.Drawing.Size(163, 26);
            this.btnEnrollment.TabIndex = 8;
            this.btnEnrollment.Text = "Enrollment";
            this.btnEnrollment.UseVisualStyleBackColor = true;
            this.btnEnrollment.Click += new System.EventHandler(this.btnEnrollment_Click);
            // 
            // btnClassInformation
            // 
            this.btnClassInformation.Location = new System.Drawing.Point(74, 253);
            this.btnClassInformation.Name = "btnClassInformation";
            this.btnClassInformation.Size = new System.Drawing.Size(163, 30);
            this.btnClassInformation.TabIndex = 7;
            this.btnClassInformation.Text = "Class Information";
            this.btnClassInformation.UseVisualStyleBackColor = true;
            this.btnClassInformation.Click += new System.EventHandler(this.btnClassInformation_Click);
            // 
            // btnStudentInformation
            // 
            this.btnStudentInformation.Location = new System.Drawing.Point(74, 151);
            this.btnStudentInformation.Name = "btnStudentInformation";
            this.btnStudentInformation.Size = new System.Drawing.Size(163, 29);
            this.btnStudentInformation.TabIndex = 6;
            this.btnStudentInformation.Text = "Student Information";
            this.btnStudentInformation.UseVisualStyleBackColor = true;
            this.btnStudentInformation.Click += new System.EventHandler(this.btnStudentInformation_Click);
            // 
            // btnYourInformation
            // 
            this.btnYourInformation.Location = new System.Drawing.Point(74, 116);
            this.btnYourInformation.Name = "btnYourInformation";
            this.btnYourInformation.Size = new System.Drawing.Size(163, 29);
            this.btnYourInformation.TabIndex = 10;
            this.btnYourInformation.Text = "Your Information";
            this.btnYourInformation.UseVisualStyleBackColor = true;
            this.btnYourInformation.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAdvising
            // 
            this.btnAdvising.Location = new System.Drawing.Point(74, 218);
            this.btnAdvising.Name = "btnAdvising";
            this.btnAdvising.Size = new System.Drawing.Size(163, 29);
            this.btnAdvising.TabIndex = 11;
            this.btnAdvising.Text = "Advising";
            this.btnAdvising.UseVisualStyleBackColor = true;
            this.btnAdvising.Click += new System.EventHandler(this.btnAdvising_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(471, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 250;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(-236, 205);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 249;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 251;
            this.button7.Text = "Back";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(223, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 252;
            this.button8.Text = "Exit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // SelectionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 433);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdvising);
            this.Controls.Add(this.btnYourInformation);
            this.Controls.Add(this.btnViewApplicants);
            this.Controls.Add(this.btnEnrollment);
            this.Controls.Add(this.btnClassInformation);
            this.Controls.Add(this.btnStudentInformation);
            this.Name = "SelectionMenu";
            this.Text = "SelectionMenu";
            this.Load += new System.EventHandler(this.SelectionMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewApplicants;
        private System.Windows.Forms.Button btnEnrollment;
        private System.Windows.Forms.Button btnClassInformation;
        private System.Windows.Forms.Button btnStudentInformation;
        private System.Windows.Forms.Button btnYourInformation;
        private System.Windows.Forms.Button btnAdvising;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}