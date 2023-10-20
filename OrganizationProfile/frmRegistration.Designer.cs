namespace OrganizationProfile
{
    partial class frmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            datePickerBirthday = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            cbPrograms = new ComboBox();
            cbGender = new ComboBox();
            txtFirstName = new TextBox();
            txtMiddleInitial = new TextBox();
            txtContactNo = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 45);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 175);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 231);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(124, 72);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(196, 31);
            txtStudentNo.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(124, 123);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(196, 31);
            txtLastName.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(124, 172);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(107, 31);
            txtAge.TabIndex = 7;
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(124, 226);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(313, 31);
            datePickerBirthday.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(462, 231);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 9;
            label6.Text = "Contact No.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(372, 72);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 10;
            label7.Text = "Program";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(356, 126);
            label8.Name = "label8";
            label8.Size = new Size(97, 25);
            label8.TabIndex = 11;
            label8.Text = "First Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(394, 175);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 12;
            label9.Text = "Gender";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(632, 126);
            label10.Name = "label10";
            label10.Size = new Size(41, 25);
            label10.TabIndex = 13;
            label10.Text = "M.I.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(459, 126);
            label11.Name = "label11";
            label11.Size = new Size(0, 25);
            label11.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(679, 123);
            label12.Name = "label12";
            label12.Size = new Size(0, 25);
            label12.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(574, 231);
            label13.Name = "label13";
            label13.Size = new Size(0, 25);
            label13.TabIndex = 16;
            // 
            // cbPrograms
            // 
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(462, 72);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(323, 33);
            cbPrograms.TabIndex = 17;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(461, 173);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(182, 33);
            cbGender.TabIndex = 18;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(459, 126);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(167, 31);
            txtFirstName.TabIndex = 19;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(679, 126);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(106, 31);
            txtMiddleInitial.TabIndex = 20;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(574, 228);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(181, 31);
            txtContactNo.TabIndex = 21;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(339, 292);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(184, 34);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 450);
            Controls.Add(btnRegister);
            Controls.Add(txtContactNo);
            Controls.Add(txtMiddleInitial);
            Controls.Add(txtFirstName);
            Controls.Add(cbGender);
            Controls.Add(cbPrograms);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(datePickerBirthday);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegistration";
            Text = "frmRegistration";
            Load += frmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private DateTimePicker datePickerBirthday;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox cbPrograms;
        private ComboBox cbGender;
        private TextBox txtFirstName;
        private TextBox txtMiddleInitial;
        private TextBox txtContactNo;
        private Button btnRegister;
    }
}