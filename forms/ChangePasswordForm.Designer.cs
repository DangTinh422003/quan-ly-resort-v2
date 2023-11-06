namespace quan_ly_resort_v2.forms
{
    partial class ChangePasswordForm
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
            this.input_pwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.input_rpwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_submit = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the password you want to change for: account";
            // 
            // input_pwd
            // 
            this.input_pwd.BorderRadius = 10;
            this.input_pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_pwd.DefaultText = "";
            this.input_pwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.input_pwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.input_pwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.input_pwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.input_pwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.input_pwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.input_pwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.input_pwd.Location = new System.Drawing.Point(162, 102);
            this.input_pwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_pwd.Name = "input_pwd";
            this.input_pwd.PasswordChar = '●';
            this.input_pwd.PlaceholderText = "";
            this.input_pwd.SelectedText = "";
            this.input_pwd.Size = new System.Drawing.Size(439, 48);
            this.input_pwd.TabIndex = 1;
            this.input_pwd.UseSystemPasswordChar = true;
            // 
            // input_rpwd
            // 
            this.input_rpwd.BorderRadius = 10;
            this.input_rpwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_rpwd.DefaultText = "";
            this.input_rpwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.input_rpwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.input_rpwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.input_rpwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.input_rpwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.input_rpwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.input_rpwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.input_rpwd.Location = new System.Drawing.Point(162, 210);
            this.input_rpwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_rpwd.Name = "input_rpwd";
            this.input_rpwd.PasswordChar = '●';
            this.input_rpwd.PlaceholderText = "";
            this.input_rpwd.SelectedText = "";
            this.input_rpwd.Size = new System.Drawing.Size(439, 48);
            this.input_rpwd.TabIndex = 2;
            this.input_rpwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm password";
            // 
            // btn_submit
            // 
            this.btn_submit.BorderRadius = 10;
            this.btn_submit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_submit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_submit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_submit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_submit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(162, 296);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(180, 45);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Change";
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_rpwd);
            this.Controls.Add(this.input_pwd);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ChangePasswordForm";
            this.Text = "Change password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox input_pwd;
        private Guna.UI2.WinForms.Guna2TextBox input_rpwd;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_submit;
    }
}