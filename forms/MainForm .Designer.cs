﻿namespace quan_ly_resort_v2
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
            this.btn_manageAccount = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_bookingRoom = new Guna.UI.WinForms.GunaAdvenceButton();
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
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.btnVoucher = new Guna.UI.WinForms.GunaAdvenceButton();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.White;
            this.sidebar.BaseColor = System.Drawing.Color.Transparent;
            this.sidebar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sidebar.Controls.Add(this.btnVoucher);
            this.sidebar.Controls.Add(this.btn_manageAccount);
            this.sidebar.Controls.Add(this.btn_bookingRoom);
            this.sidebar.Controls.Add(this.currentUser);
            this.sidebar.Controls.Add(this.btn_manageBill);
            this.sidebar.Controls.Add(this.btn_manageStatistic);
            this.sidebar.Controls.Add(this.btn_manageService);
            this.sidebar.Controls.Add(this.btn_manageAccountant);
            this.sidebar.Controls.Add(this.btn_manageCustomer);
            this.sidebar.Controls.Add(this.btn_manageRoom);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(107)))), ((int)(((byte)(159)))));
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(308, 903);
            this.sidebar.TabIndex = 0;
            // 
            // btn_manageAccount
            // 
            this.btn_manageAccount.AnimationHoverSpeed = 0.07F;
            this.btn_manageAccount.AnimationSpeed = 0.03F;
            this.btn_manageAccount.BackColor = System.Drawing.Color.Transparent;
            this.btn_manageAccount.BaseColor = System.Drawing.Color.Transparent;
            this.btn_manageAccount.BorderColor = System.Drawing.Color.Transparent;
            this.btn_manageAccount.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btn_manageAccount.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btn_manageAccount.CheckedForeColor = System.Drawing.Color.White;
            this.btn_manageAccount.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_manageAccount.CheckedImage")));
            this.btn_manageAccount.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btn_manageAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manageAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_manageAccount.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_manageAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(107)))), ((int)(((byte)(159)))));
            this.btn_manageAccount.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageAccount.Image")));
            this.btn_manageAccount.ImageOffsetX = 10;
            this.btn_manageAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_manageAccount.LineColor = System.Drawing.Color.Transparent;
            this.btn_manageAccount.Location = new System.Drawing.Point(0, 607);
            this.btn_manageAccount.Name = "btn_manageAccount";
            this.btn_manageAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_manageAccount.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_manageAccount.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_manageAccount.OnHoverImage = null;
            this.btn_manageAccount.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btn_manageAccount.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_manageAccount.Size = new System.Drawing.Size(308, 56);
            this.btn_manageAccount.TabIndex = 16;
            this.btn_manageAccount.Text = "Quản lý tài khoản";
            this.btn_manageAccount.TextOffsetX = 10;
            this.btn_manageAccount.Click += new System.EventHandler(this.btn_manageAccount_Click);
            // btn_manageVoucher
            // 
            //this.btn_managevoucher.animationhoverspeed = 0.07f;
            //this.btn_managevoucher.animationspeed = 0.03f;
            //this.btn_managevoucher.backcolor = system.drawing.color.transparent;
            //this.btn_managevoucher.basecolor = system.drawing.color.transparent;
            //this.btn_managevoucher.bordercolor = system.drawing.color.transparent;
            //this.btn_managevoucher.checkedbasecolor = system.drawing.color.transparent;
            //this.btn_managevoucher.checkedbordercolor = system.drawing.color.transparent;
            //this.btn_managevoucher.checkedforecolor = system.drawing.color.white;
            //this.btn_managevoucher.checkedimage = ((system.drawing.image)(resources.getobject("btn_managevoucher.checkedimage")));
            //this.btn_managevoucher.checkedlinecolor = system.drawing.color.transparent;
            //this.btn_managevoucher.cursor = system.windows.forms.cursors.hand;
            //this.btn_managevoucher.dialogresult = system.windows.forms.dialogresult.none;
            //this.btn_managevoucher.focusedcolor = system.drawing.color.transparent;
            //this.btn_managevoucher.font = new system.drawing.font("segoe ui", 12f, system.drawing.fontstyle.bold, system.drawing.graphicsunit.point, ((byte)(0)));
            //this.btn_managevoucher.forecolor = system.drawing.color.fromargb(((int)(((byte)(82)))), ((int)(((byte)(107)))), ((int)(((byte)(159)))));
            //this.btn_managevoucher.image = ((system.drawing.image)(resources.getobject("btn_managevoucher.image")));
            //this.btn_managevoucher.imageoffsetx = 10;
            //this.btn_managevoucher.imagesize = new system.drawing.size(30, 30);
            //this.btn_managevoucher.linecolor = system.drawing.color.transparent;
            //this.btn_managevoucher.location = new system.drawing.point(3, 545);
            //this.btn_managevoucher.name = "btn_managevoucher";
            //this.btn_managevoucher.onhoverbasecolor = system.drawing.color.fromargb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            //this.btn_managevoucher.onhoverbordercolor = system.drawing.color.transparent;
            //this.btn_managevoucher.onhoverforecolor = system.drawing.color.white;
            //this.btn_managevoucher.onhoverimage = null;
            //this.btn_managevoucher.onhoverlinecolor = system.drawing.color.transparent;
            //this.btn_managevoucher.onpressedcolor = system.drawing.color.transparent;
            //this.btn_managevoucher.size = new system.drawing.size(308, 56);
            //this.btn_managevoucher.tabindex = 16;
            //this.btn_managevoucher.text = "quản lý tài khoản";
            //this.btn_managevoucher.textoffsetx = 10;
            //this.btn_managevoucher.click += new system.eventhandler(this.btn_managevoucher_click);
            // 
            // btn_bookingRoom
            // 
            this.btn_bookingRoom.AnimationHoverSpeed = 0.07F;
            this.btn_bookingRoom.AnimationSpeed = 0.03F;
            this.btn_bookingRoom.BackColor = System.Drawing.Color.Transparent;
            this.btn_bookingRoom.BaseColor = System.Drawing.Color.Transparent;
            this.btn_bookingRoom.BorderColor = System.Drawing.Color.Transparent;
            this.btn_bookingRoom.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btn_bookingRoom.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btn_bookingRoom.CheckedForeColor = System.Drawing.Color.White;
            this.btn_bookingRoom.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_bookingRoom.CheckedImage")));
            this.btn_bookingRoom.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btn_bookingRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bookingRoom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_bookingRoom.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_bookingRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bookingRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(107)))), ((int)(((byte)(159)))));
            this.btn_bookingRoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_bookingRoom.Image")));
            this.btn_bookingRoom.ImageOffsetX = 10;
            this.btn_bookingRoom.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_bookingRoom.LineColor = System.Drawing.Color.Transparent;
            this.btn_bookingRoom.Location = new System.Drawing.Point(-2, 238);
            this.btn_bookingRoom.Name = "btn_bookingRoom";
            this.btn_bookingRoom.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_bookingRoom.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_bookingRoom.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_bookingRoom.OnHoverImage = null;
            this.btn_bookingRoom.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btn_bookingRoom.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_bookingRoom.Size = new System.Drawing.Size(308, 56);
            this.btn_bookingRoom.TabIndex = 15;
            this.btn_bookingRoom.Text = "Đặt phòng";
            this.btn_bookingRoom.TextOffsetX = 10;
            this.btn_bookingRoom.Click += new System.EventHandler(this.btn_bookingRoom_Click);
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
            this.currentUser.Location = new System.Drawing.Point(0, 816);
            this.currentUser.Name = "currentUser";
            this.currentUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.currentUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.currentUser.OnHoverForeColor = System.Drawing.Color.White;
            this.currentUser.OnHoverImage = null;
            this.currentUser.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.currentUser.OnPressedColor = System.Drawing.Color.Black;
            this.currentUser.Size = new System.Drawing.Size(304, 83);
            this.currentUser.TabIndex = 14;
            this.currentUser.Text = "Tên người dùng";
            this.toolTip1.SetToolTip(this.currentUser, "Bấm vào để đăng xuất");
            this.currentUser.Click += new System.EventHandler(this.currentUser_Click);
            // 
            // btn_manageBill
            // 
            this.btn_manageBill.AnimationHoverSpeed = 0.07F;
            this.btn_manageBill.AnimationSpeed = 0.03F;
            this.btn_manageBill.BackColor = System.Drawing.Color.Transparent;
            this.btn_manageBill.BaseColor = System.Drawing.Color.Transparent;
            this.btn_manageBill.BorderColor = System.Drawing.Color.Transparent;
            this.btn_manageBill.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btn_manageBill.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btn_manageBill.CheckedForeColor = System.Drawing.Color.White;
            this.btn_manageBill.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_manageBill.CheckedImage")));
            this.btn_manageBill.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btn_manageBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manageBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_manageBill.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_manageBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(107)))), ((int)(((byte)(159)))));
            this.btn_manageBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageBill.Image")));
            this.btn_manageBill.ImageOffsetX = 10;
            this.btn_manageBill.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_manageBill.LineColor = System.Drawing.Color.Transparent;
            this.btn_manageBill.Location = new System.Drawing.Point(0, 483);
            this.btn_manageBill.Name = "btn_manageBill";
            this.btn_manageBill.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_manageBill.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_manageBill.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_manageBill.OnHoverImage = null;
            this.btn_manageBill.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btn_manageBill.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_manageBill.Size = new System.Drawing.Size(308, 56);
            this.btn_manageBill.TabIndex = 13;
            this.btn_manageBill.Text = "Quản lý hóa đơn";
            this.btn_manageBill.TextOffsetX = 10;
            this.btn_manageBill.Click += new System.EventHandler(this.btn_manageBill_Click);
            // 
            // btn_manageStatistic
            // 
            this.btn_manageStatistic.AnimationHoverSpeed = 0.07F;
            this.btn_manageStatistic.AnimationSpeed = 0.03F;
            this.btn_manageStatistic.BackColor = System.Drawing.Color.Transparent;
            this.btn_manageStatistic.BaseColor = System.Drawing.Color.Transparent;
            this.btn_manageStatistic.BorderColor = System.Drawing.Color.Transparent;
            this.btn_manageStatistic.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btn_manageStatistic.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btn_manageStatistic.CheckedForeColor = System.Drawing.Color.White;
            this.btn_manageStatistic.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_manageStatistic.CheckedImage")));
            this.btn_manageStatistic.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btn_manageStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manageStatistic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_manageStatistic.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_manageStatistic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageStatistic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(107)))), ((int)(((byte)(159)))));
            this.btn_manageStatistic.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageStatistic.Image")));
            this.btn_manageStatistic.ImageOffsetX = 10;
            this.btn_manageStatistic.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_manageStatistic.LineColor = System.Drawing.Color.Transparent;
            this.btn_manageStatistic.Location = new System.Drawing.Point(2, 421);
            this.btn_manageStatistic.Name = "btn_manageStatistic";
            this.btn_manageStatistic.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_manageStatistic.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_manageStatistic.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_manageStatistic.OnHoverImage = null;
            this.btn_manageStatistic.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btn_manageStatistic.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_manageStatistic.Size = new System.Drawing.Size(308, 56);
            this.btn_manageStatistic.TabIndex = 12;
            this.btn_manageStatistic.Text = "Thống kê";
            this.btn_manageStatistic.TextOffsetX = 10;
            this.btn_manageStatistic.Click += new System.EventHandler(this.btn_manageStatistic_Click);
            // 
            // btn_manageService
            // 
            this.btn_manageService.AnimationHoverSpeed = 0.07F;
            this.btn_manageService.AnimationSpeed = 0.03F;
            this.btn_manageService.BackColor = System.Drawing.Color.Transparent;
            this.btn_manageService.BaseColor = System.Drawing.Color.Transparent;
            this.btn_manageService.BorderColor = System.Drawing.Color.Transparent;
            this.btn_manageService.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btn_manageService.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btn_manageService.CheckedForeColor = System.Drawing.Color.White;
            this.btn_manageService.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_manageService.CheckedImage")));
            this.btn_manageService.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btn_manageService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manageService.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_manageService.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_manageService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(107)))), ((int)(((byte)(159)))));
            this.btn_manageService.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageService.Image")));
            this.btn_manageService.ImageOffsetX = 10;
            this.btn_manageService.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_manageService.LineColor = System.Drawing.Color.Transparent;
            this.btn_manageService.Location = new System.Drawing.Point(0, 362);
            this.btn_manageService.Name = "btn_manageService";
            this.btn_manageService.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_manageService.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_manageService.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_manageService.OnHoverImage = null;
            this.btn_manageService.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btn_manageService.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_manageService.Size = new System.Drawing.Size(308, 56);
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
            this.btn_manageAccountant.BackColor = System.Drawing.Color.Transparent;
            this.btn_manageAccountant.BaseColor = System.Drawing.Color.Transparent;
            this.btn_manageAccountant.BorderColor = System.Drawing.Color.Transparent;
            this.btn_manageAccountant.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btn_manageAccountant.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btn_manageAccountant.CheckedForeColor = System.Drawing.Color.White;
            this.btn_manageAccountant.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_manageAccountant.CheckedImage")));
            this.btn_manageAccountant.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btn_manageAccountant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manageAccountant.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_manageAccountant.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_manageAccountant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageAccountant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(107)))), ((int)(((byte)(159)))));
            this.btn_manageAccountant.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageAccountant.Image")));
            this.btn_manageAccountant.ImageOffsetX = 10;
            this.btn_manageAccountant.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_manageAccountant.LineColor = System.Drawing.Color.Transparent;
            this.btn_manageAccountant.Location = new System.Drawing.Point(0, 300);
            this.btn_manageAccountant.Name = "btn_manageAccountant";
            this.btn_manageAccountant.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_manageAccountant.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_manageAccountant.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_manageAccountant.OnHoverImage = null;
            this.btn_manageAccountant.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btn_manageAccountant.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_manageAccountant.Size = new System.Drawing.Size(308, 56);
            this.btn_manageAccountant.TabIndex = 10;
            this.btn_manageAccountant.Text = "Quản lý nhân viên";
            this.btn_manageAccountant.TextOffsetX = 10;
            this.btn_manageAccountant.Click += new System.EventHandler(this.btn_manageAccountant_Click);
            // 
            // btn_manageCustomer
            // 
            this.btn_manageCustomer.AnimationHoverSpeed = 0.07F;
            this.btn_manageCustomer.AnimationSpeed = 0.03F;
            this.btn_manageCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btn_manageCustomer.BaseColor = System.Drawing.Color.Transparent;
            this.btn_manageCustomer.BorderColor = System.Drawing.Color.Transparent;
            this.btn_manageCustomer.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btn_manageCustomer.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btn_manageCustomer.CheckedForeColor = System.Drawing.Color.White;
            this.btn_manageCustomer.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_manageCustomer.CheckedImage")));
            this.btn_manageCustomer.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btn_manageCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manageCustomer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_manageCustomer.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_manageCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(107)))), ((int)(((byte)(159)))));
            this.btn_manageCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageCustomer.Image")));
            this.btn_manageCustomer.ImageOffsetX = 10;
            this.btn_manageCustomer.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_manageCustomer.LineColor = System.Drawing.Color.Transparent;
            this.btn_manageCustomer.Location = new System.Drawing.Point(-2, 114);
            this.btn_manageCustomer.Name = "btn_manageCustomer";
            this.btn_manageCustomer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_manageCustomer.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_manageCustomer.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_manageCustomer.OnHoverImage = null;
            this.btn_manageCustomer.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btn_manageCustomer.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_manageCustomer.Size = new System.Drawing.Size(308, 56);
            this.btn_manageCustomer.TabIndex = 9;
            this.btn_manageCustomer.Text = "Quản lý khách hàng";
            this.btn_manageCustomer.TextOffsetX = 10;
            this.btn_manageCustomer.Click += new System.EventHandler(this.btn_manageCustomer_Click);
            // 
            // btn_manageRoom
            // 
            this.btn_manageRoom.AnimationHoverSpeed = 0.07F;
            this.btn_manageRoom.AnimationSpeed = 0.03F;
            this.btn_manageRoom.BackColor = System.Drawing.Color.Transparent;
            this.btn_manageRoom.BaseColor = System.Drawing.Color.Transparent;
            this.btn_manageRoom.BorderColor = System.Drawing.Color.Transparent;
            this.btn_manageRoom.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btn_manageRoom.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btn_manageRoom.CheckedForeColor = System.Drawing.Color.White;
            this.btn_manageRoom.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_manageRoom.CheckedImage")));
            this.btn_manageRoom.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btn_manageRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manageRoom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_manageRoom.FocusedColor = System.Drawing.Color.Transparent;
            this.btn_manageRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(107)))), ((int)(((byte)(159)))));
            this.btn_manageRoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageRoom.Image")));
            this.btn_manageRoom.ImageOffsetX = 10;
            this.btn_manageRoom.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_manageRoom.LineColor = System.Drawing.Color.Transparent;
            this.btn_manageRoom.Location = new System.Drawing.Point(-2, 176);
            this.btn_manageRoom.Name = "btn_manageRoom";
            this.btn_manageRoom.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_manageRoom.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_manageRoom.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_manageRoom.OnHoverImage = null;
            this.btn_manageRoom.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btn_manageRoom.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_manageRoom.Size = new System.Drawing.Size(308, 56);
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
            this.panel2.Size = new System.Drawing.Size(304, 108);
            this.panel2.TabIndex = 7;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(304, 108);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(308, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1279, 903);
            this.mainPanel.TabIndex = 2;
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // btnVoucher
            // 
            this.btnVoucher.AnimationHoverSpeed = 0.07F;
            this.btnVoucher.AnimationSpeed = 0.03F;
            this.btnVoucher.BackColor = System.Drawing.Color.Transparent;
            this.btnVoucher.BaseColor = System.Drawing.Color.Transparent;
            this.btnVoucher.BorderColor = System.Drawing.Color.Transparent;
            this.btnVoucher.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btnVoucher.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnVoucher.CheckedForeColor = System.Drawing.Color.White;
            this.btnVoucher.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnVoucher.CheckedImage")));
            this.btnVoucher.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnVoucher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoucher.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVoucher.FocusedColor = System.Drawing.Color.Transparent;
            this.btnVoucher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(107)))), ((int)(((byte)(159)))));
            this.btnVoucher.Image = ((System.Drawing.Image)(resources.GetObject("btnVoucher.Image")));
            this.btnVoucher.ImageOffsetX = 10;
            this.btnVoucher.ImageSize = new System.Drawing.Size(30, 30);
            this.btnVoucher.LineColor = System.Drawing.Color.Transparent;
            this.btnVoucher.Location = new System.Drawing.Point(-2, 545);
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnVoucher.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnVoucher.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVoucher.OnHoverImage = null;
            this.btnVoucher.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnVoucher.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnVoucher.Size = new System.Drawing.Size(308, 56);
            this.btnVoucher.TabIndex = 17;
            this.btnVoucher.Text = "Quản lý voucher";
            this.btnVoucher.TextOffsetX = 10;
            this.btnVoucher.Click += new System.EventHandler(this.btnVoucher_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 903);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebar);
            this.MaximizeBox = false;
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
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_bookingRoom;
        private Guna.UI.WinForms.GunaAdvenceButton btn_manageAccount;
        private Guna.UI.WinForms.GunaAdvenceButton btnVoucher;
    }
}

