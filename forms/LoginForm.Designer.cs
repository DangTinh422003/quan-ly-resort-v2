namespace quan_ly_resort_v2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.form = new System.Windows.Forms.Panel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.labelRegister = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.formGroup_password = new System.Windows.Forms.Panel();
            this.passwordTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.formGroup_userName = new System.Windows.Forms.Panel();
            this.userNameTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subTitle = new System.Windows.Forms.Label();
            this.mainTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.form.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(822, 753);
            this.panel1.TabIndex = 0;
            // 
            // form
            // 
            this.form.BackColor = System.Drawing.Color.White;
            this.form.Controls.Add(this.gunaPanel1);
            this.form.Controls.Add(this.formGroup_password);
            this.form.Controls.Add(this.formGroup_userName);
            this.form.Controls.Add(this.subTitle);
            this.form.Controls.Add(this.mainTitle);
            this.form.Location = new System.Drawing.Point(95, 122);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(660, 485);
            this.form.TabIndex = 0;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.labelRegister);
            this.gunaPanel1.Controls.Add(this.label3);
            this.gunaPanel1.Controls.Add(this.gunaAdvenceButton1);
            this.gunaPanel1.Location = new System.Drawing.Point(19, 384);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(620, 58);
            this.gunaPanel1.TabIndex = 4;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.Location = new System.Drawing.Point(225, 17);
            this.labelRegister.Margin = new System.Windows.Forms.Padding(0);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(91, 25);
            this.labelRegister.TabIndex = 2;
            this.labelRegister.Text = "Register";
            this.labelRegister.Click += new System.EventHandler(this.labelRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Don’t have an account ?";
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(437, 0);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 15;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(168, 58);
            this.gunaAdvenceButton1.TabIndex = 0;
            this.gunaAdvenceButton1.Text = "Login";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
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
            this.mainTitle.Size = new System.Drawing.Size(237, 91);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(822, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 800);
            this.MinimumSize = new System.Drawing.Size(1400, 800);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.form.ResumeLayout(false);
            this.form.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.formGroup_password.ResumeLayout(false);
            this.formGroup_password.PerformLayout();
            this.formGroup_userName.ResumeLayout(false);
            this.formGroup_userName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel form;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Label subTitle;
        private System.Windows.Forms.Panel formGroup_userName;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox userNameTextBox;
        private System.Windows.Forms.Panel formGroup_password;
        private Guna.UI.WinForms.GunaTextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRegister;
    }
}

