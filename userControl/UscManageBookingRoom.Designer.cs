namespace quan_ly_resort_v2.userControl
{
    partial class UscManageBookingRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UscManageBookingRoom));
            this.textbox_seatchCustomerId = new Guna.UI2.WinForms.Guna2TextBox();
            this.table_BookingRoomList = new Guna.UI.WinForms.GunaDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoiThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_modify = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_refresh = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btn_booking = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.table_BookingRoomList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_seatchCustomerId
            // 
            this.textbox_seatchCustomerId.BorderRadius = 12;
            this.textbox_seatchCustomerId.BorderThickness = 2;
            this.textbox_seatchCustomerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_seatchCustomerId.DefaultText = "";
            this.textbox_seatchCustomerId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_seatchCustomerId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_seatchCustomerId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_seatchCustomerId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_seatchCustomerId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_seatchCustomerId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_seatchCustomerId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_seatchCustomerId.Location = new System.Drawing.Point(12, 49);
            this.textbox_seatchCustomerId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_seatchCustomerId.Name = "textbox_seatchCustomerId";
            this.textbox_seatchCustomerId.PasswordChar = '\0';
            this.textbox_seatchCustomerId.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textbox_seatchCustomerId.PlaceholderText = "Tìm kiếm theo căn cước công dân";
            this.textbox_seatchCustomerId.SelectedText = "";
            this.textbox_seatchCustomerId.Size = new System.Drawing.Size(403, 51);
            this.textbox_seatchCustomerId.TabIndex = 4;
            this.textbox_seatchCustomerId.TextOffset = new System.Drawing.Point(20, 0);
            this.textbox_seatchCustomerId.TextChanged += new System.EventHandler(this.textbox_seatchCustomerId_TextChanged);
            // 
            // table_BookingRoomList
            // 
            this.table_BookingRoomList.AllowDrop = true;
            this.table_BookingRoomList.AllowUserToAddRows = false;
            this.table_BookingRoomList.AllowUserToDeleteRows = false;
            this.table_BookingRoomList.AllowUserToOrderColumns = true;
            this.table_BookingRoomList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.table_BookingRoomList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table_BookingRoomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_BookingRoomList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table_BookingRoomList.BackgroundColor = System.Drawing.Color.White;
            this.table_BookingRoomList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.table_BookingRoomList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table_BookingRoomList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_BookingRoomList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table_BookingRoomList.ColumnHeadersHeight = 40;
            this.table_BookingRoomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ngaydat,
            this.DsMaPhong,
            this.MaKH,
            this.checkin,
            this.SoNgayThue,
            this.SoNguoiThue,
            this.state,
            this.btn_delete,
            this.btn_modify});
            this.table_BookingRoomList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_BookingRoomList.DefaultCellStyle = dataGridViewCellStyle3;
            this.table_BookingRoomList.EnableHeadersVisualStyles = false;
            this.table_BookingRoomList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table_BookingRoomList.Location = new System.Drawing.Point(3, 133);
            this.table_BookingRoomList.Name = "table_BookingRoomList";
            this.table_BookingRoomList.ReadOnly = true;
            this.table_BookingRoomList.RowHeadersVisible = false;
            this.table_BookingRoomList.RowHeadersWidth = 51;
            this.table_BookingRoomList.RowTemplate.Height = 24;
            this.table_BookingRoomList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_BookingRoomList.Size = new System.Drawing.Size(1273, 767);
            this.table_BookingRoomList.TabIndex = 6;
            this.table_BookingRoomList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.table_BookingRoomList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.table_BookingRoomList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.table_BookingRoomList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.table_BookingRoomList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.table_BookingRoomList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.table_BookingRoomList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.table_BookingRoomList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table_BookingRoomList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.table_BookingRoomList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.table_BookingRoomList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_BookingRoomList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.table_BookingRoomList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.table_BookingRoomList.ThemeStyle.HeaderStyle.Height = 40;
            this.table_BookingRoomList.ThemeStyle.ReadOnly = true;
            this.table_BookingRoomList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.table_BookingRoomList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table_BookingRoomList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.table_BookingRoomList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.table_BookingRoomList.ThemeStyle.RowsStyle.Height = 24;
            this.table_BookingRoomList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table_BookingRoomList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.table_BookingRoomList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_BookingRoomList_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 80;
            // 
            // ngaydat
            // 
            this.ngaydat.HeaderText = "Ngày Đặt Phòng";
            this.ngaydat.MinimumWidth = 6;
            this.ngaydat.Name = "ngaydat";
            this.ngaydat.ReadOnly = true;
            // 
            // DsMaPhong
            // 
            this.DsMaPhong.HeaderText = "Danh sách Mã Phòng";
            this.DsMaPhong.MinimumWidth = 6;
            this.DsMaPhong.Name = "DsMaPhong";
            this.DsMaPhong.ReadOnly = true;
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // checkin
            // 
            this.checkin.HeaderText = "Ngày checkin";
            this.checkin.MinimumWidth = 6;
            this.checkin.Name = "checkin";
            this.checkin.ReadOnly = true;
            // 
            // SoNgayThue
            // 
            this.SoNgayThue.HeaderText = "Số ngày thuê";
            this.SoNgayThue.MinimumWidth = 6;
            this.SoNgayThue.Name = "SoNgayThue";
            this.SoNgayThue.ReadOnly = true;
            // 
            // SoNguoiThue
            // 
            this.SoNguoiThue.HeaderText = "Số người thuê";
            this.SoNguoiThue.MinimumWidth = 6;
            this.SoNguoiThue.Name = "SoNguoiThue";
            this.SoNguoiThue.ReadOnly = true;
            // 
            // state
            // 
            this.state.HeaderText = "Trạng thái";
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btn_delete.HeaderText = "";
            this.btn_delete.Image = global::quan_ly_resort_v2.Properties.Resources.icons8_cancel_483;
            this.btn_delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btn_delete.MinimumWidth = 6;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ReadOnly = true;
            this.btn_delete.Width = 50;
            // 
            // btn_modify
            // 
            this.btn_modify.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btn_modify.HeaderText = "";
            this.btn_modify.Image = global::quan_ly_resort_v2.Properties.Resources.icons8_pencil_481;
            this.btn_modify.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btn_modify.MinimumWidth = 6;
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.ReadOnly = true;
            this.btn_modify.Width = 50;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::quan_ly_resort_v2.Properties.Resources.icons8_cancel_482;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::quan_ly_resort_v2.Properties.Resources.icons8_pencil_48;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 140;
            // 
            // btn_refresh
            // 
            this.btn_refresh.AnimationHoverSpeed = 0.07F;
            this.btn_refresh.AnimationSpeed = 0.03F;
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btn_refresh.BorderColor = System.Drawing.Color.Black;
            this.btn_refresh.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_refresh.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_refresh.CheckedForeColor = System.Drawing.Color.White;
            this.btn_refresh.CheckedImage = null;
            this.btn_refresh.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_refresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_refresh.FocusedColor = System.Drawing.Color.Empty;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_refresh.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_refresh.Location = new System.Drawing.Point(702, 49);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_refresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_refresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_refresh.OnHoverImage = null;
            this.btn_refresh.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_refresh.OnPressedColor = System.Drawing.Color.Black;
            this.btn_refresh.Radius = 12;
            this.btn_refresh.Size = new System.Drawing.Size(303, 51);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Làm mới danh sách";
            this.btn_refresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::quan_ly_resort_v2.Properties.Resources.icons8_search_403;
            this.gunaPictureBox1.Location = new System.Drawing.Point(431, 49);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(45, 51);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 3;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btn_booking
            // 
            this.btn_booking.AnimationHoverSpeed = 0.07F;
            this.btn_booking.AnimationSpeed = 0.03F;
            this.btn_booking.BackColor = System.Drawing.Color.Transparent;
            this.btn_booking.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_booking.BorderColor = System.Drawing.Color.Black;
            this.btn_booking.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_booking.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_booking.CheckedForeColor = System.Drawing.Color.White;
            this.btn_booking.CheckedImage = null;
            this.btn_booking.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_booking.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_booking.FocusedColor = System.Drawing.Color.Empty;
            this.btn_booking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_booking.ForeColor = System.Drawing.Color.White;
            this.btn_booking.Image = ((System.Drawing.Image)(resources.GetObject("btn_booking.Image")));
            this.btn_booking.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_booking.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_booking.Location = new System.Drawing.Point(1020, 49);
            this.btn_booking.Name = "btn_booking";
            this.btn_booking.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_booking.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_booking.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_booking.OnHoverImage = null;
            this.btn_booking.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_booking.OnPressedColor = System.Drawing.Color.Black;
            this.btn_booking.Radius = 12;
            this.btn_booking.Size = new System.Drawing.Size(245, 51);
            this.btn_booking.TabIndex = 1;
            this.btn_booking.Text = "Đặt phòng";
            this.btn_booking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_booking.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // UscManageBookingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.table_BookingRoomList);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.textbox_seatchCustomerId);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.btn_booking);
            this.Name = "UscManageBookingRoom";
            this.Size = new System.Drawing.Size(1279, 903);
            this.Load += new System.EventHandler(this.UscManageBookingRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_BookingRoomList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton btn_booking;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox textbox_seatchCustomerId;
        private Guna.UI.WinForms.GunaAdvenceButton btn_refresh;
        private Guna.UI.WinForms.GunaDataGridView table_BookingRoomList;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoiThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewImageColumn btn_delete;
        private System.Windows.Forms.DataGridViewImageColumn btn_modify;
    }
}
