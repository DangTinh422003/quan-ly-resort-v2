namespace quan_ly_resort_v2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sidebar = new Guna.UI.WinForms.GunaElipsePanel();
            this.currentUser = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_manageBill = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_manageStatistic = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_manageService = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_manageAccountant = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_manageCustomer = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_manageRoom = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.sidebar.BaseColor = System.Drawing.Color.Transparent;
            this.sidebar.Controls.Add(this.currentUser);
            this.sidebar.Controls.Add(this.btn_manageBill);
            this.sidebar.Controls.Add(this.btn_manageStatistic);
            this.sidebar.Controls.Add(this.btn_manageService);
            this.sidebar.Controls.Add(this.btn_manageAccountant);
            this.sidebar.Controls.Add(this.btn_manageCustomer);
            this.sidebar.Controls.Add(this.btn_manageRoom);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.ForeColor = System.Drawing.Color.White;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(308, 803);
            this.sidebar.TabIndex = 0;
            // 
            // currentUser
            // 
            this.currentUser.AnimationHoverSpeed = 0.07F;
            this.currentUser.AnimationSpeed = 0.03F;
            this.currentUser.BaseColor = System.Drawing.Color.Transparent;
            this.currentUser.BorderColor = System.Drawing.Color.Black;
            this.currentUser.CheckedBaseColor = System.Drawing.Color.Gray;
            this.currentUser.CheckedBorderColor = System.Drawing.Color.Black;
            this.currentUser.CheckedForeColor = System.Drawing.Color.White;
            this.currentUser.CheckedImage = ((System.Drawing.Image)(resources.GetObject("currentUser.CheckedImage")));
            this.currentUser.CheckedLineColor = System.Drawing.Color.DimGray;
            this.currentUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currentUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.currentUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.currentUser.FocusedColor = System.Drawing.Color.Empty;
            this.currentUser.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUser.ForeColor = System.Drawing.Color.White;
            this.currentUser.Image = ((System.Drawing.Image)(resources.GetObject("currentUser.Image")));
            this.currentUser.ImageOffsetX = 5;
            this.currentUser.ImageSize = new System.Drawing.Size(70, 70);
            this.currentUser.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.currentUser.Location = new System.Drawing.Point(0, 720);
            this.currentUser.Name = "currentUser";
            this.currentUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.currentUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.currentUser.OnHoverForeColor = System.Drawing.Color.White;
            this.currentUser.OnHoverImage = null;
            this.currentUser.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.currentUser.OnPressedColor = System.Drawing.Color.Black;
            this.currentUser.Size = new System.Drawing.Size(308, 83);
            this.currentUser.TabIndex = 14;
            this.currentUser.Text = "Tên người dùng";
            this.toolTip1.SetToolTip(this.currentUser, "Bấm vào để đăng xuất");
            this.currentUser.Click += new System.EventHandler(this.currentUser_Click);
            // 
            // btn_manageBill
            // 
            this.btn_manageBill.AnimationHoverSpeed = 0.07F;
            this.btn_manageBill.AnimationSpeed = 0.03F;
            this.btn_manageBill.BaseColor = System.Drawing.Color.Transparent;
            this.btn_manageBill.BorderColor = System.Drawing.Color.Black;
            this.btn_manageBill.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_manageBill.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_manageBill.CheckedForeColor = System.Drawing.Color.White;
            this.btn_manageBill.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_manageBill.CheckedImage")));
            this.btn_manageBill.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_manageBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manageBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_manageBill.FocusedColor = System.Drawing.Color.Empty;
            this.btn_manageBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageBill.ForeColor = System.Drawing.Color.White;
            this.btn_manageBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageBill.Image")));
            this.btn_manageBill.ImageOffsetX = 10;
            this.btn_manageBill.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_manageBill.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_manageBill.Location = new System.Drawing.Point(0, 391);
            this.btn_manageBill.Name = "btn_manageBill";
            this.btn_manageBill.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_manageBill.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_manageBill.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_manageBill.OnHoverImage = null;
            this.btn_manageBill.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_manageBill.OnPressedColor = System.Drawing.Color.Black;
            this.btn_manageBill.Size = new System.Drawing.Size(308, 60);
            this.btn_manageBill.TabIndex = 13;
            this.btn_manageBill.Text = "Quản lý hóa đơn";
            this.btn_manageBill.TextOffsetX = 10;
            this.btn_manageBill.Click += new System.EventHandler(this.btn_manageBill_Click);
            // 
            // btn_manageStatistic
            // 
            this.btn_manageStatistic.AnimationHoverSpeed = 0.07F;
            this.btn_manageStatistic.AnimationSpeed = 0.03F;
            this.btn_manageStatistic.BaseColor = System.Drawing.Color.Transparent;
            this.btn_manageStatistic.BorderColor = System.Drawing.Color.Black;
            this.btn_manageStatistic.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_manageStatistic.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_manageStatistic.CheckedForeColor = System.Drawing.Color.White;
            this.btn_manageStatistic.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_manageStatistic.CheckedImage")));
            this.btn_manageStatistic.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_manageStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manageStatistic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_manageStatistic.FocusedColor = System.Drawing.Color.Empty;
            this.btn_manageStatistic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageStatistic.ForeColor = System.Drawing.Color.White;
            this.btn_manageStatistic.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageStatistic.Image")));
            this.btn_manageStatistic.ImageOffsetX = 10;
            this.btn_manageStatistic.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_manageStatistic.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_manageStatistic.Location = new System.Drawing.Point(0, 335);
            this.btn_manageStatistic.Name = "btn_manageStatistic";
            this.btn_manageStatistic.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_manageStatistic.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_manageStatistic.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_manageStatistic.OnHoverImage = null;
            this.btn_manageStatistic.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_manageStatistic.OnPressedColor = System.Drawing.Color.Black;
            this.btn_manageStatistic.Size = new System.Drawing.Size(308, 60);
            this.btn_manageStatistic.TabIndex = 12;
            this.btn_manageStatistic.Text = "Thống kê";
            this.btn_manageStatistic.TextOffsetX = 10;
            this.btn_manageStatistic.Click += new System.EventHandler(this.btn_manageStatistic_Click);
            // 
            // btn_manageService
            // 
            this.btn_manageService.AnimationHoverSpeed = 0.07F;
            this.btn_manageService.AnimationSpeed = 0.03F;
            this.btn_manageService.BaseColor = System.Drawing.Color.Transparent;
            this.btn_manageService.BorderColor = System.Drawing.Color.Black;
            this.btn_manageService.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_manageService.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_manageService.CheckedForeColor = System.Drawing.Color.White;
            this.btn_manageService.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_manageService.CheckedImage")));
            this.btn_manageService.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_manageService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manageService.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_manageService.FocusedColor = System.Drawing.Color.Empty;
            this.btn_manageService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageService.ForeColor = System.Drawing.Color.White;
            this.btn_manageService.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageService.Image")));
            this.btn_manageService.ImageOffsetX = 10;
            this.btn_manageService.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_manageService.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_manageService.Location = new System.Drawing.Point(0, 278);
            this.btn_manageService.Name = "btn_manageService";
            this.btn_manageService.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_manageService.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_manageService.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_manageService.OnHoverImage = null;
            this.btn_manageService.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_manageService.OnPressedColor = System.Drawing.Color.Black;
            this.btn_manageService.Size = new System.Drawing.Size(308, 60);
            this.btn_manageService.TabIndex = 11;
            this.btn_manageService.Text = "Quản lý dịch vụ";
            this.btn_manageService.TextOffsetX = 10;
            this.btn_manageService.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixel;
            this.btn_manageService.Click += new System.EventHandler(this.btn_manageService_Click);
            // 
            // btn_manageAccountant
            // 
            this.btn_manageAccountant.AnimationHoverSpeed = 0.07F;
            this.btn_manageAccountant.AnimationSpeed = 0.03F;
            this.btn_manageAccountant.BaseColor = System.Drawing.Color.Transparent;
            this.btn_manageAccountant.BorderColor = System.Drawing.Color.Black;
            this.btn_manageAccountant.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_manageAccountant.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_manageAccountant.CheckedForeColor = System.Drawing.Color.White;
            this.btn_manageAccountant.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_manageAccountant.CheckedImage")));
            this.btn_manageAccountant.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_manageAccountant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manageAccountant.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_manageAccountant.FocusedColor = System.Drawing.Color.Empty;
            this.btn_manageAccountant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageAccountant.ForeColor = System.Drawing.Color.White;
            this.btn_manageAccountant.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageAccountant.Image")));
            this.btn_manageAccountant.ImageOffsetX = 10;
            this.btn_manageAccountant.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_manageAccountant.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_manageAccountant.Location = new System.Drawing.Point(0, 221);
            this.btn_manageAccountant.Name = "btn_manageAccountant";
            this.btn_manageAccountant.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_manageAccountant.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_manageAccountant.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_manageAccountant.OnHoverImage = null;
            this.btn_manageAccountant.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_manageAccountant.OnPressedColor = System.Drawing.Color.Black;
            this.btn_manageAccountant.Size = new System.Drawing.Size(308, 60);
            this.btn_manageAccountant.TabIndex = 10;
            this.btn_manageAccountant.Text = "Quản lý nhân viên";
            this.btn_manageAccountant.TextOffsetX = 10;
            this.btn_manageAccountant.Click += new System.EventHandler(this.btn_manageAccountant_Click);
            // 
            // btn_manageCustomer
            // 
            this.btn_manageCustomer.AnimationHoverSpeed = 0.07F;
            this.btn_manageCustomer.AnimationSpeed = 0.03F;
            this.btn_manageCustomer.BaseColor = System.Drawing.Color.Transparent;
            this.btn_manageCustomer.BorderColor = System.Drawing.Color.Black;
            this.btn_manageCustomer.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_manageCustomer.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_manageCustomer.CheckedForeColor = System.Drawing.Color.White;
            this.btn_manageCustomer.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_manageCustomer.CheckedImage")));
            this.btn_manageCustomer.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_manageCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manageCustomer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_manageCustomer.FocusedColor = System.Drawing.Color.Empty;
            this.btn_manageCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_manageCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageCustomer.Image")));
            this.btn_manageCustomer.ImageOffsetX = 10;
            this.btn_manageCustomer.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_manageCustomer.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_manageCustomer.Location = new System.Drawing.Point(0, 165);
            this.btn_manageCustomer.Name = "btn_manageCustomer";
            this.btn_manageCustomer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_manageCustomer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_manageCustomer.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_manageCustomer.OnHoverImage = null;
            this.btn_manageCustomer.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_manageCustomer.OnPressedColor = System.Drawing.Color.Black;
            this.btn_manageCustomer.Size = new System.Drawing.Size(308, 60);
            this.btn_manageCustomer.TabIndex = 9;
            this.btn_manageCustomer.Text = "Quản lý khách hàng";
            this.btn_manageCustomer.TextOffsetX = 10;
            this.btn_manageCustomer.Click += new System.EventHandler(this.btn_manageCustomer_Click);
            // 
            // btn_manageRoom
            // 
            this.btn_manageRoom.AnimationHoverSpeed = 0.07F;
            this.btn_manageRoom.AnimationSpeed = 0.03F;
            this.btn_manageRoom.BaseColor = System.Drawing.Color.Transparent;
            this.btn_manageRoom.BorderColor = System.Drawing.Color.Black;
            this.btn_manageRoom.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_manageRoom.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_manageRoom.CheckedForeColor = System.Drawing.Color.White;
            this.btn_manageRoom.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_manageRoom.CheckedImage")));
            this.btn_manageRoom.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_manageRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manageRoom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_manageRoom.FocusedColor = System.Drawing.Color.Empty;
            this.btn_manageRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageRoom.ForeColor = System.Drawing.Color.White;
            this.btn_manageRoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageRoom.Image")));
            this.btn_manageRoom.ImageOffsetX = 10;
            this.btn_manageRoom.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_manageRoom.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_manageRoom.Location = new System.Drawing.Point(0, 108);
            this.btn_manageRoom.Name = "btn_manageRoom";
            this.btn_manageRoom.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_manageRoom.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_manageRoom.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_manageRoom.OnHoverImage = null;
            this.btn_manageRoom.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_manageRoom.OnPressedColor = System.Drawing.Color.Black;
            this.btn_manageRoom.Size = new System.Drawing.Size(308, 60);
            this.btn_manageRoom.TabIndex = 8;
            this.btn_manageRoom.Text = "Quản lý phòng";
            this.btn_manageRoom.TextOffsetX = 10;
            this.btn_manageRoom.Click += new System.EventHandler(this.btn_manageRoom_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gunaPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 108);
            this.panel2.TabIndex = 7;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(308, 108);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(308, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1074, 803);
            this.mainPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 803);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 850);
            this.MinimumSize = new System.Drawing.Size(1400, 850);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel sidebar;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_manageRoom;
        private Guna.UI.WinForms.GunaAdvenceButton btn_manageBill;
        private Guna.UI.WinForms.GunaAdvenceButton btn_manageStatistic;
        private Guna.UI.WinForms.GunaAdvenceButton btn_manageService;
        private Guna.UI.WinForms.GunaAdvenceButton btn_manageAccountant;
        private Guna.UI.WinForms.GunaAdvenceButton btn_manageCustomer;
        private Guna.UI.WinForms.GunaAdvenceButton currentUser;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

