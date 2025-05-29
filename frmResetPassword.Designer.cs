namespace VietLaptop
{
    partial class frmResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResetPassword));
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblResetPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtReEnterPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.lblAtLeast12Charaters = new System.Windows.Forms.Label();
            this.lblCapitalLetter = new System.Windows.Forms.Label();
            this.lblLowerCase = new System.Windows.Forms.Label();
            this.lblSpecialChar = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBox_NewPassword = new System.Windows.Forms.CheckBox();
            this.checkBox_ReEnterPassword = new System.Windows.Forms.CheckBox();
            this.lblDoesntMatchPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(285, 36);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(112, 20);
            this.lblNewPassword.TabIndex = 0;
            this.lblNewPassword.Text = "New password";
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPassword.Location = new System.Drawing.Point(285, 117);
            this.lblResetPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(145, 20);
            this.lblResetPassword.TabIndex = 0;
            this.lblResetPassword.Text = "Re-enter Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(289, 61);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.Size = new System.Drawing.Size(259, 26);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // txtReEnterPassword
            // 
            this.txtReEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReEnterPassword.Location = new System.Drawing.Point(289, 142);
            this.txtReEnterPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReEnterPassword.Name = "txtReEnterPassword";
            this.txtReEnterPassword.PasswordChar = '●';
            this.txtReEnterPassword.Size = new System.Drawing.Size(259, 26);
            this.txtReEnterPassword.TabIndex = 3;
            this.txtReEnterPassword.TextChanged += new System.EventHandler(this.txtReEnterPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter a new password has...";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResetPassword.Location = new System.Drawing.Point(391, 213);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(156, 47);
            this.btnResetPassword.TabIndex = 5;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // lblAtLeast12Charaters
            // 
            this.lblAtLeast12Charaters.AutoSize = true;
            this.lblAtLeast12Charaters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtLeast12Charaters.Location = new System.Drawing.Point(39, 43);
            this.lblAtLeast12Charaters.Name = "lblAtLeast12Charaters";
            this.lblAtLeast12Charaters.Size = new System.Drawing.Size(134, 16);
            this.lblAtLeast12Charaters.TabIndex = 4;
            this.lblAtLeast12Charaters.Text = "At least 12 characters";
            // 
            // lblCapitalLetter
            // 
            this.lblCapitalLetter.AutoSize = true;
            this.lblCapitalLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitalLetter.Location = new System.Drawing.Point(39, 74);
            this.lblCapitalLetter.Name = "lblCapitalLetter";
            this.lblCapitalLetter.Size = new System.Drawing.Size(147, 16);
            this.lblCapitalLetter.TabIndex = 4;
            this.lblCapitalLetter.Text = "Capital letters (A, B, C...)\r\n";
            // 
            // lblLowerCase
            // 
            this.lblLowerCase.AutoSize = true;
            this.lblLowerCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowerCase.Location = new System.Drawing.Point(39, 104);
            this.lblLowerCase.Name = "lblLowerCase";
            this.lblLowerCase.Size = new System.Drawing.Size(167, 16);
            this.lblLowerCase.TabIndex = 4;
            this.lblLowerCase.Text = "Lowercase letters (a, b, c...)";
            // 
            // lblSpecialChar
            // 
            this.lblSpecialChar.AutoSize = true;
            this.lblSpecialChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialChar.Location = new System.Drawing.Point(38, 134);
            this.lblSpecialChar.Name = "lblSpecialChar";
            this.lblSpecialChar.Size = new System.Drawing.Size(236, 16);
            this.lblSpecialChar.TabIndex = 4;
            this.lblSpecialChar.Text = "Special characters (!, @, #, $, %, ^, &, *...)\n";
            this.lblSpecialChar.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(38, 165);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(91, 16);
            this.lblNumbers.TabIndex = 4;
            this.lblNumbers.Text = "Numbers (0-9)";
            this.lblNumbers.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(17, 213);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 47);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkBox_NewPassword
            // 
            this.checkBox_NewPassword.AutoSize = true;
            this.checkBox_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_NewPassword.Location = new System.Drawing.Point(493, 91);
            this.checkBox_NewPassword.Name = "checkBox_NewPassword";
            this.checkBox_NewPassword.Size = new System.Drawing.Size(53, 17);
            this.checkBox_NewPassword.TabIndex = 2;
            this.checkBox_NewPassword.Text = "Show";
            this.checkBox_NewPassword.UseVisualStyleBackColor = true;
            this.checkBox_NewPassword.CheckedChanged += new System.EventHandler(this.checkBox_NewPassword_CheckedChanged);
            // 
            // checkBox_ReEnterPassword
            // 
            this.checkBox_ReEnterPassword.AutoSize = true;
            this.checkBox_ReEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ReEnterPassword.Location = new System.Drawing.Point(492, 171);
            this.checkBox_ReEnterPassword.Name = "checkBox_ReEnterPassword";
            this.checkBox_ReEnterPassword.Size = new System.Drawing.Size(53, 17);
            this.checkBox_ReEnterPassword.TabIndex = 4;
            this.checkBox_ReEnterPassword.Text = "Show";
            this.checkBox_ReEnterPassword.UseVisualStyleBackColor = true;
            this.checkBox_ReEnterPassword.CheckedChanged += new System.EventHandler(this.checkBox_ReEnterPassword_CheckedChanged);
            // 
            // lblDoesntMatchPassword
            // 
            this.lblDoesntMatchPassword.AutoSize = true;
            this.lblDoesntMatchPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoesntMatchPassword.Location = new System.Drawing.Point(286, 172);
            this.lblDoesntMatchPassword.Name = "lblDoesntMatchPassword";
            this.lblDoesntMatchPassword.Size = new System.Drawing.Size(118, 13);
            this.lblDoesntMatchPassword.TabIndex = 7;
            this.lblDoesntMatchPassword.Text = "Does not match above!";
            this.lblDoesntMatchPassword.Visible = false;
            // 
            // frmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 286);
            this.Controls.Add(this.lblDoesntMatchPassword);
            this.Controls.Add(this.checkBox_ReEnterPassword);
            this.Controls.Add(this.checkBox_NewPassword);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.lblSpecialChar);
            this.Controls.Add(this.lblLowerCase);
            this.Controls.Add(this.lblCapitalLetter);
            this.Controls.Add(this.lblAtLeast12Charaters);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReEnterPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblResetPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(576, 325);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(576, 325);
            this.Name = "frmResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblResetPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtReEnterPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Label lblAtLeast12Charaters;
        private System.Windows.Forms.Label lblCapitalLetter;
        private System.Windows.Forms.Label lblLowerCase;
        private System.Windows.Forms.Label lblSpecialChar;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBox_NewPassword;
        private System.Windows.Forms.CheckBox checkBox_ReEnterPassword;
        private System.Windows.Forms.Label lblDoesntMatchPassword;
    }
}