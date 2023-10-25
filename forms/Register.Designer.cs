namespace quan_ly_resort_v2.forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.form = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.confirmPasswordTextbox = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btn_backToLogin = new Guna.UI.WinForms.GunaButton();
            this.btnRegister = new Guna.UI.WinForms.GunaAdvenceButton();
            this.formGroup_password = new System.Windows.Forms.Panel();
            this.passwordTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.formGroup_userName = new System.Windows.Forms.Panel();
            this.userNameTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subTitle = new System.Windows.Forms.Label();
            this.mainTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.form.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.formGroup_password.SuspendLayout();
            this.formGroup_userName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.form);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 753);
            this.panel1.TabIndex = 0;
            // 
            // form
            // 
            this.form.BackColor = System.Drawing.Color.White;
            this.form.Controls.Add(this.panel2);
            this.form.Controls.Add(this.gunaPanel1);
            this.form.Controls.Add(this.formGroup_password);
            this.form.Controls.Add(this.formGroup_userName);
            this.form.Controls.Add(this.subTitle);
            this.form.Controls.Add(this.mainTitle);
            this.form.Location = new System.Drawing.Point(96, 121);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(660, 586);
            this.form.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.confirmPasswordTextbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(22, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 99);
            this.panel2.TabIndex = 4;
            // 
            // confirmPasswordTextbox
            // 
            this.confirmPasswordTextbox.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordTextbox.BaseColor = System.Drawing.Color.White;
            this.confirmPasswordTextbox.BorderColor = System.Drawing.Color.Silver;
            this.confirmPasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPasswordTextbox.FocusedBaseColor = System.Drawing.Color.White;
            this.confirmPasswordTextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.confirmPasswordTextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmPasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextbox.Location = new System.Drawing.Point(0, 32);
            this.confirmPasswordTextbox.Name = "confirmPasswordTextbox";
            this.confirmPasswordTextbox.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.confirmPasswordTextbox.PasswordChar = '*';
            this.confirmPasswordTextbox.Radius = 12;
            this.confirmPasswordTextbox.SelectedText = "";
            this.confirmPasswordTextbox.Size = new System.Drawing.Size(606, 58);
            this.confirmPasswordTextbox.TabIndex = 1;
            this.confirmPasswordTextbox.TextOffsetX = 15;
            this.confirmPasswordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.confirmPasswordTextbox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "confirm password";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.btn_backToLogin);
            this.gunaPanel1.Controls.Add(this.btnRegister);
            this.gunaPanel1.Location = new System.Drawing.Point(27, 470);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(620, 58);
            this.gunaPanel1.TabIndex = 4;
            // 
            // btn_backToLogin
            // 
            this.btn_backToLogin.AnimationHoverSpeed = 0.07F;
            this.btn_backToLogin.AnimationSpeed = 0.03F;
            this.btn_backToLogin.BackColor = System.Drawing.Color.Transparent;
            this.btn_backToLogin.BaseColor = System.Drawing.Color.White;
            this.btn_backToLogin.BorderColor = System.Drawing.Color.Black;
            this.btn_backToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_backToLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_backToLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btn_backToLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backToLogin.ForeColor = System.Drawing.Color.Black;
            this.btn_backToLogin.Image = ((System.Drawing.Image)(resources.GetObject("btn_backToLogin.Image")));
            this.btn_backToLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_backToLogin.Location = new System.Drawing.Point(3, 3);
            this.btn_backToLogin.Name = "btn_backToLogin";
            this.btn_backToLogin.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_backToLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_backToLogin.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_backToLogin.OnHoverImage = null;
            this.btn_backToLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btn_backToLogin.Radius = 20;
            this.btn_backToLogin.Size = new System.Drawing.Size(195, 52);
            this.btn_backToLogin.TabIndex = 1;
            this.btn_backToLogin.Text = "Đăng nhập";
            this.btn_backToLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_backToLogin.Click += new System.EventHandler(this.btn_backToLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.AnimationHoverSpeed = 0.07F;
            this.btnRegister.AnimationSpeed = 0.03F;
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRegister.BorderColor = System.Drawing.Color.Black;
            this.btnRegister.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnRegister.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnRegister.CheckedForeColor = System.Drawing.Color.White;
            this.btnRegister.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.CheckedImage")));
            this.btnRegister.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegister.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Image = null;
            this.btnRegister.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegister.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRegister.Location = new System.Drawing.Point(437, 0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRegister.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegister.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegister.OnHoverImage = null;
            this.btnRegister.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRegister.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegister.Radius = 15;
            this.btnRegister.Size = new System.Drawing.Size(168, 58);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // formGroup_password
            // 
            this.formGroup_password.Controls.Add(this.passwordTextBox);
            this.formGroup_password.Controls.Add(this.label2);
            this.formGroup_password.Location = new System.Drawing.Point(19, 269);
            this.formGroup_password.Name = "formGroup_password";
            this.formGroup_password.Size = new System.Drawing.Size(620, 99);
            this.formGroup_password.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.BaseColor = System.Drawing.Color.White;
            this.passwordTextBox.BorderColor = System.Drawing.Color.Silver;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.passwordTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.passwordTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(0, 32);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Radius = 12;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(606, 58);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.TextOffsetX = 15;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "password";
            // 
            // formGroup_userName
            // 
            this.formGroup_userName.Controls.Add(this.userNameTextBox);
            this.formGroup_userName.Controls.Add(this.label1);
            this.formGroup_userName.Location = new System.Drawing.Point(19, 156);
            this.formGroup_userName.Name = "formGroup_userName";
            this.formGroup_userName.Size = new System.Drawing.Size(620, 109);
            this.formGroup_userName.TabIndex = 2;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.userNameTextBox.BaseColor = System.Drawing.Color.White;
            this.userNameTextBox.BorderColor = System.Drawing.Color.Silver;
            this.userNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.userNameTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.userNameTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.userNameTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(0, 49);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.userNameTextBox.PasswordChar = '\0';
            this.userNameTextBox.Radius = 12;
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.Size = new System.Drawing.Size(606, 58);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.TextOffsetX = 15;
            this.userNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userNameTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "username";
            // 
            // subTitle
            // 
            this.subTitle.AutoSize = true;
            this.subTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitle.Location = new System.Drawing.Point(59, 91);
            this.subTitle.Name = "subTitle";
            this.subTitle.Size = new System.Drawing.Size(306, 25);
            this.subTitle.TabIndex = 1;
            this.subTitle.Text = "Welcome to Doan Gia\'s Resort";
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(11, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(343, 91);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Register";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(821, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(883, 0);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1400, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1400, 800);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.form.ResumeLayout(false);
            this.form.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.formGroup_password.ResumeLayout(false);
            this.formGroup_password.PerformLayout();
            this.formGroup_userName.ResumeLayout(false);
            this.formGroup_userName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel form;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnRegister;
        private System.Windows.Forms.Panel formGroup_password;
        private Guna.UI.WinForms.GunaTextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel formGroup_userName;
        private Guna.UI.WinForms.GunaTextBox userNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subTitle;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaTextBox confirmPasswordTextbox;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton btn_backToLogin;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}