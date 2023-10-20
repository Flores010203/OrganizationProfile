namespace OrganizationProfile
{
    partial class frmConfirmation
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
            lblStudentNo = new Label();
            lblName = new Label();
            lblProgram = new Label();
            lblAge = new Label();
            lblBirthday = new Label();
            lblGender = new Label();
            lblContactNo = new Label();
            btnSubmit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(12, 9);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(110, 25);
            lblStudentNo.TabIndex = 0;
            lblStudentNo.Text = "Student No.:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 48);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(12, 88);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(85, 25);
            lblProgram.TabIndex = 2;
            lblProgram.Text = "Program:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(12, 128);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(48, 25);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age:";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(12, 173);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(81, 25);
            lblBirthday.TabIndex = 4;
            lblBirthday.Text = "Birthday:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(12, 217);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(73, 25);
            lblGender.TabIndex = 5;
            lblGender.Text = "Gender:";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new Point(12, 263);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(110, 25);
            lblContactNo.TabIndex = 6;
            lblContactNo.Text = "Contact No.:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(136, 312);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 48);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 88);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 128);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 11;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(136, 173);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 12;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(136, 217);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 13;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(136, 263);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 14;
            label7.Text = "label7";
            // 
            // frmConfirmation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 386);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(lblContactNo);
            Controls.Add(lblGender);
            Controls.Add(lblBirthday);
            Controls.Add(lblAge);
            Controls.Add(lblProgram);
            Controls.Add(lblName);
            Controls.Add(lblStudentNo);
            Name = "frmConfirmation";
            Text = "frmConfirmation";
            Load += frmConfirmation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentNo;
        private Label lblName;
        private Label lblProgram;
        private Label lblAge;
        private Label lblBirthday;
        private Label lblGender;
        private Label lblContactNo;
        private Button btnSubmit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}