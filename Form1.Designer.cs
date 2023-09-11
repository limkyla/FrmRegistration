namespace FrmRegistration
{
    partial class Form1
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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            studentNo = new TextBox();
            program = new ComboBox();
            lastName = new TextBox();
            firstName = new TextBox();
            middleName = new TextBox();
            age = new TextBox();
            contactNo = new TextBox();
            address = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 18);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 0;
            label1.Text = "Student No:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(222, 18);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 1;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(38, 93);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(202, 93);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 3;
            label4.Text = "First Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(394, 93);
            label5.Name = "label5";
            label5.Size = new Size(118, 21);
            label5.TabIndex = 4;
            label5.Text = "Middle Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(38, 164);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 5;
            label6.Text = "Age:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(198, 164);
            label7.Name = "label7";
            label7.Size = new Size(100, 21);
            label7.TabIndex = 6;
            label7.Text = "Contact No:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(38, 228);
            label8.Name = "label8";
            label8.Size = new Size(74, 21);
            label8.TabIndex = 7;
            label8.Text = "Address:";
            // 
            // studentNo
            // 
            studentNo.BackColor = Color.FromArgb(255, 192, 192);
            studentNo.Location = new Point(38, 42);
            studentNo.Name = "studentNo";
            studentNo.Size = new Size(145, 23);
            studentNo.TabIndex = 8;
            studentNo.TextChanged += textBox1_TextChanged;
            // 
            // program
            // 
            program.BackColor = Color.FromArgb(255, 192, 192);
            program.FormattingEnabled = true;
            program.Location = new Point(222, 42);
            program.Name = "program";
            program.Size = new Size(272, 23);
            program.TabIndex = 9;
            // 
            // lastName
            // 
            lastName.BackColor = Color.FromArgb(255, 192, 192);
            lastName.Location = new Point(38, 117);
            lastName.Name = "lastName";
            lastName.Size = new Size(145, 23);
            lastName.TabIndex = 10;
            // 
            // firstName
            // 
            firstName.BackColor = Color.FromArgb(255, 192, 192);
            firstName.Location = new Point(202, 117);
            firstName.Name = "firstName";
            firstName.Size = new Size(149, 23);
            firstName.TabIndex = 11;
            // 
            // middleName
            // 
            middleName.BackColor = Color.FromArgb(255, 192, 192);
            middleName.Location = new Point(394, 117);
            middleName.Name = "middleName";
            middleName.Size = new Size(157, 23);
            middleName.TabIndex = 12;
            // 
            // age
            // 
            age.BackColor = Color.FromArgb(255, 192, 192);
            age.Location = new Point(38, 188);
            age.Name = "age";
            age.Size = new Size(74, 23);
            age.TabIndex = 13;
            // 
            // contactNo
            // 
            contactNo.BackColor = Color.FromArgb(255, 192, 192);
            contactNo.Location = new Point(198, 188);
            contactNo.Name = "contactNo";
            contactNo.Size = new Size(133, 23);
            contactNo.TabIndex = 14;
            // 
            // address
            // 
            address.BackColor = Color.FromArgb(255, 192, 192);
            address.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            address.Location = new Point(38, 252);
            address.Multiline = true;
            address.Name = "address";
            address.Size = new Size(348, 57);
            address.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(128, 341);
            button1.Name = "button1";
            button1.Size = new Size(127, 45);
            button1.TabIndex = 16;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(address);
            Controls.Add(contactNo);
            Controls.Add(age);
            Controls.Add(middleName);
            Controls.Add(firstName);
            Controls.Add(lastName);
            Controls.Add(program);
            Controls.Add(studentNo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox studentNo;
        private ComboBox program;
        private TextBox lastName;
        private TextBox firstName;
        private TextBox middleName;
        private TextBox age;
        private TextBox contactNo;
        private TextBox address;
        private Button button1;
    }
}