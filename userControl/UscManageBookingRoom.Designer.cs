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
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.table_BookingRoomList = new Guna.UI.WinForms.GunaDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysStayCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleStayCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_booking = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_refresh = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_BookingRoomList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.table_BookingRoomList);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(68, 118);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 30;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(1135, 719);
            this.gunaGradient2Panel1.TabIndex = 0;
            // 
            // table_BookingRoomList
            // 
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
            this.id,
            this.create_at,
            this.listRoomId,
            this.customerId,
            this.checkInTime,
            this.daysStayCounter,
            this.peopleStayCounter});
            this.table_BookingRoomList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_BookingRoomList.DefaultCellStyle = dataGridViewCellStyle3;
            this.table_BookingRoomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_BookingRoomList.EnableHeadersVisualStyles = false;
            this.table_BookingRoomList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table_BookingRoomList.Location = new System.Drawing.Point(0, 0);
            this.table_BookingRoomList.Name = "table_BookingRoomList";
            this.table_BookingRoomList.ReadOnly = true;
            this.table_BookingRoomList.RowHeadersVisible = false;
            this.table_BookingRoomList.RowHeadersWidth = 51;
            this.table_BookingRoomList.RowTemplate.Height = 24;
            this.table_BookingRoomList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_BookingRoomList.Size = new System.Drawing.Size(1135, 719);
            this.table_BookingRoomList.TabIndex = 2;
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
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // create_at
            // 
            this.create_at.HeaderText = "Ngày đặt";
            this.create_at.MinimumWidth = 6;
            this.create_at.Name = "create_at";
            this.create_at.ReadOnly = true;
            // 
            // listRoomId
            // 
            this.listRoomId.HeaderText = "Danh sách mã phòng";
            this.listRoomId.MinimumWidth = 6;
            this.listRoomId.Name = "listRoomId";
            this.listRoomId.ReadOnly = true;
            // 
            // customerId
            // 
            this.customerId.HeaderText = "Mã khách hàng";
            this.customerId.MinimumWidth = 6;
            this.customerId.Name = "customerId";
            this.customerId.ReadOnly = true;
            // 
            // checkInTime
            // 
            this.checkInTime.HeaderText = "Ngày check in";
            this.checkInTime.MinimumWidth = 6;
            this.checkInTime.Name = "checkInTime";
            this.checkInTime.ReadOnly = true;
            // 
            // daysStayCounter
            // 
            this.daysStayCounter.HeaderText = "Số ngày thuê";
            this.daysStayCounter.MinimumWidth = 6;
            this.daysStayCounter.Name = "daysStayCounter";
            this.daysStayCounter.ReadOnly = true;
            // 
            // peopleStayCounter
            // 
            this.peopleStayCounter.HeaderText = "Số người thuê";
            this.peopleStayCounter.MinimumWidth = 6;
            this.peopleStayCounter.Name = "peopleStayCounter";
            this.peopleStayCounter.ReadOnly = true;
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
            this.btn_booking.Location = new System.Drawing.Point(958, 49);
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
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::quan_ly_resort_v2.Properties.Resources.icons8_search_403;
            this.gunaPictureBox1.Location = new System.Drawing.Point(477, 49);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(45, 51);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 3;
            this.gunaPictureBox1.TabStop = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 12;
            this.guna2TextBox1.BorderThickness = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(68, 49);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.PlaceholderText = "Tìm kiếm theo tên khách hàng";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(403, 51);
            this.guna2TextBox1.TabIndex = 4;
            this.guna2TextBox1.TextOffset = new System.Drawing.Point(20, 0);
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
            this.btn_refresh.Location = new System.Drawing.Point(634, 49);
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
            // UscManageBookingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.btn_booking);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Name = "UscManageBookingRoom";
            this.Size = new System.Drawing.Size(1279, 903);
            this.Load += new System.EventHandler(this.UscManageBookingRoom_Load);
            this.gunaGradient2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_BookingRoomList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_booking;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI.WinForms.GunaDataGridView table_BookingRoomList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn listRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysStayCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleStayCounter;
        private Guna.UI.WinForms.GunaAdvenceButton btn_refresh;
    }
}
