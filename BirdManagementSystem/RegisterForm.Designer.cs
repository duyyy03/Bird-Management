namespace Bird.APP
{
    partial class RegisterForm
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
            label1 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtFullname = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
            label8 = new Label();
            rbMale = new RadioButton();
            rdFemale = new RadioButton();
            txtAddress = new TextBox();
            label9 = new Label();
            btnRegister = new Button();
            btnReset = new Button();
            txtCfPassword = new TextBox();
            label10 = new Label();
            datePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(327, 21);
            label1.Name = "label1";
            label1.Size = new Size(117, 38);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 95);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(115, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(168, 27);
            txtEmail.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 154);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 5;
            label4.Text = "Fullname";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(115, 147);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(168, 27);
            txtFullname.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 214);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 7;
            label5.Text = "Yob";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(115, 273);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(168, 27);
            txtPhone.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 280);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 9;
            label6.Text = "Phone";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(426, 154);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(189, 27);
            txtPassword.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(327, 157);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 11;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(327, 92);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 13;
            label8.Text = "Gender";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(426, 86);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 14;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(518, 86);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(78, 24);
            rdFemale.TabIndex = 15;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(426, 261);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(265, 85);
            txtAddress.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(327, 264);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 17;
            label9.Text = "Address";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(229, 384);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(426, 384);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 20;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // txtCfPassword
            // 
            txtCfPassword.Location = new Point(426, 207);
            txtCfPassword.Name = "txtCfPassword";
            txtCfPassword.Size = new Size(189, 27);
            txtCfPassword.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(327, 214);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 21;
            label10.Text = "Confirm Pwd";
            // 
            // datePicker
            // 
            datePicker.Location = new Point(115, 214);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(168, 27);
            datePicker.TabIndex = 23;
            // 
            // formRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(datePicker);
            Controls.Add(txtCfPassword);
            Controls.Add(label10);
            Controls.Add(btnReset);
            Controls.Add(btnRegister);
            Controls.Add(txtAddress);
            Controls.Add(label9);
            Controls.Add(rdFemale);
            Controls.Add(rbMale);
            Controls.Add(label8);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtFullname);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "formRegister";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtFullname;
        private Label label5;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtPassword;
        private Label label7;
        private Label label8;
        private RadioButton rbMale;
        private RadioButton rdFemale;
        private TextBox txtAddress;
        private Label label9;
        private Button btnRegister;
        private Button btnReset;
        private TextBox txtCfPassword;
        private Label label10;
        private DateTimePicker datePicker;
    }
}