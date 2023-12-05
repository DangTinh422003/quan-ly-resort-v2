namespace quan_ly_resort_v2.forms
{
    partial class ForgetPasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.textbox_code = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_getcode = new Guna.UI2.WinForms.Guna2Button();
            this.textbox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_changePassword = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // textbox_email
            // 
            this.textbox_email.BorderRadius = 12;
            this.textbox_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_email.DefaultText = "";
            this.textbox_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_email.Location = new System.Drawing.Point(17, 54);
            this.textbox_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.PasswordChar = '\0';
            this.textbox_email.PlaceholderText = "Vui lòng nhập email đã đăng kí";
            this.textbox_email.SelectedText = "";
            this.textbox_email.Size = new System.Drawing.Size(441, 48);
            this.textbox_email.TabIndex = 3;
            // 
            // textbox_code
            // 
            this.textbox_code.BorderRadius = 12;
            this.textbox_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_code.DefaultText = "";
            this.textbox_code.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_code.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_code.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_code.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_code.Enabled = false;
            this.textbox_code.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_code.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_code.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_code.Location = new System.Drawing.Point(17, 147);
            this.textbox_code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_code.Name = "textbox_code";
            this.textbox_code.PasswordChar = '\0';
            this.textbox_code.PlaceholderText = "Mã xác nhận gồm 6 kí tự!";
            this.textbox_code.SelectedText = "";
            this.textbox_code.Size = new System.Drawing.Size(441, 48);
            this.textbox_code.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã xác nhận";
            // 
            // btn_getcode
            // 
            this.btn_getcode.BorderRadius = 12;
            this.btn_getcode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_getcode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_getcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_getcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_getcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getcode.ForeColor = System.Drawing.Color.White;
            this.btn_getcode.Location = new System.Drawing.Point(17, 305);
            this.btn_getcode.Name = "btn_getcode";
            this.btn_getcode.Size = new System.Drawing.Size(180, 45);
            this.btn_getcode.TabIndex = 6;
            this.btn_getcode.Text = "Lấy mã";
            this.btn_getcode.Click += new System.EventHandler(this.btn_getcode_Click);
            // 
            // textbox_password
            // 
            this.textbox_password.BorderRadius = 12;
            this.textbox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_password.DefaultText = "";
            this.textbox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_password.Enabled = false;
            this.textbox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_password.Location = new System.Drawing.Point(17, 241);
            this.textbox_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '\0';
            this.textbox_password.PlaceholderText = "Vui lòng nhập mật khẩu mới";
            this.textbox_password.SelectedText = "";
            this.textbox_password.Size = new System.Drawing.Size(441, 48);
            this.textbox_password.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mật khẩu mới";
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.BorderRadius = 12;
            this.btn_changePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_changePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_changePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_changePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_changePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changePassword.ForeColor = System.Drawing.Color.White;
            this.btn_changePassword.Location = new System.Drawing.Point(278, 305);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(180, 45);
            this.btn_changePassword.TabIndex = 11;
            this.btn_changePassword.Text = "Xác nhận";
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // ForgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 367);
            this.Controls.Add(this.btn_changePassword);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_getcode);
            this.Controls.Add(this.textbox_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_email);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ForgetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textbox_email;
        private Guna.UI2.WinForms.Guna2TextBox textbox_code;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_getcode;
        private Guna.UI2.WinForms.Guna2TextBox textbox_password;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_changePassword;
    }
}