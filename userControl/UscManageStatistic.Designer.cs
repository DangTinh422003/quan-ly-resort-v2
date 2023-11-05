namespace quan_ly_resort_v2.userControl
{
    partial class UscManageStatistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.ccbSelectMonth = new Guna.UI.WinForms.GunaComboBox();
            this.TextBox = new Guna.UI.WinForms.GunaTextBox();
            this.btnFilter = new Guna.UI.WinForms.GunaButton();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.labelTotalRevenue = new Guna.UI.WinForms.GunaLabel();
            this.LabelTitle = new Guna.UI.WinForms.GunaLabel();
            this.cbbYears = new Guna.UI.WinForms.GunaComboBox();
            this.TextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStatistic
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatistic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistic.Legends.Add(legend1);
            this.chartStatistic.Location = new System.Drawing.Point(3, 216);
            this.chartStatistic.Name = "chartStatistic";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            this.chartStatistic.Series.Add(series1);
            this.chartStatistic.Size = new System.Drawing.Size(1282, 651);
            this.chartStatistic.TabIndex = 0;
            this.chartStatistic.Text = "chart1";
            this.chartStatistic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartStatistic_MouseMove);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel1.Location = new System.Drawing.Point(495, 100);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(66, 28);
            this.gunaLabel1.TabIndex = 17;
            this.gunaLabel1.Text = "Tháng";
            // 
            // ccbSelectMonth
            // 
            this.ccbSelectMonth.BackColor = System.Drawing.Color.Transparent;
            this.ccbSelectMonth.BaseColor = System.Drawing.Color.White;
            this.ccbSelectMonth.BorderColor = System.Drawing.Color.Silver;
            this.ccbSelectMonth.BorderSize = 0;
            this.ccbSelectMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ccbSelectMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbSelectMonth.FocusedColor = System.Drawing.Color.Empty;
            this.ccbSelectMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ccbSelectMonth.ForeColor = System.Drawing.Color.Black;
            this.ccbSelectMonth.FormattingEnabled = true;
            this.ccbSelectMonth.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12",
            "Quý 1",
            "Quý 2",
            "Quý 3",
            "Quý 4"});
            this.ccbSelectMonth.Location = new System.Drawing.Point(578, 100);
            this.ccbSelectMonth.Name = "ccbSelectMonth";
            this.ccbSelectMonth.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ccbSelectMonth.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ccbSelectMonth.Size = new System.Drawing.Size(435, 31);
            this.ccbSelectMonth.TabIndex = 20;
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.Transparent;
            this.TextBox.BaseColor = System.Drawing.Color.White;
            this.TextBox.BorderColor = System.Drawing.Color.Silver;
            this.TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox.Location = new System.Drawing.Point(567, 91);
            this.TextBox.Name = "TextBox";
            this.TextBox.PasswordChar = '\0';
            this.TextBox.Radius = 8;
            this.TextBox.SelectedText = "";
            this.TextBox.Size = new System.Drawing.Size(461, 49);
            this.TextBox.TabIndex = 19;
            // 
            // btnFilter
            // 
            this.btnFilter.AnimationHoverSpeed = 0.07F;
            this.btnFilter.AnimationSpeed = 0.03F;
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnFilter.BorderColor = System.Drawing.Color.Black;
            this.btnFilter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFilter.FocusedColor = System.Drawing.Color.Empty;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Image = null;
            this.btnFilter.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFilter.Location = new System.Drawing.Point(1034, 91);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFilter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFilter.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFilter.OnHoverImage = null;
            this.btnFilter.OnPressedColor = System.Drawing.Color.Black;
            this.btnFilter.Radius = 8;
            this.btnFilter.Size = new System.Drawing.Size(135, 49);
            this.btnFilter.TabIndex = 21;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // labelTotalRevenue
            // 
            this.labelTotalRevenue.AutoSize = true;
            this.labelTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTotalRevenue.Location = new System.Drawing.Point(495, 166);
            this.labelTotalRevenue.Name = "labelTotalRevenue";
            this.labelTotalRevenue.Size = new System.Drawing.Size(48, 28);
            this.labelTotalRevenue.TabIndex = 22;
            this.labelTotalRevenue.Text = "Tiền";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.Location = new System.Drawing.Point(73, 32);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(112, 28);
            this.LabelTitle.TabIndex = 26;
            this.LabelTitle.Text = "Doanh thu";
            // 
            // cbbYears
            // 
            this.cbbYears.BackColor = System.Drawing.Color.Transparent;
            this.cbbYears.BaseColor = System.Drawing.Color.White;
            this.cbbYears.BorderColor = System.Drawing.Color.Silver;
            this.cbbYears.BorderSize = 0;
            this.cbbYears.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYears.FocusedColor = System.Drawing.Color.Empty;
            this.cbbYears.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbYears.ForeColor = System.Drawing.Color.Black;
            this.cbbYears.FormattingEnabled = true;
            this.cbbYears.Items.AddRange(new object[] {
            "Năm 2023",
            "Năm 2024",
            "Năm 2025"});
            this.cbbYears.Location = new System.Drawing.Point(146, 100);
            this.cbbYears.Name = "cbbYears";
            this.cbbYears.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbYears.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbYears.Size = new System.Drawing.Size(331, 31);
            this.cbbYears.TabIndex = 29;
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.TextBox1.BaseColor = System.Drawing.Color.White;
            this.TextBox1.BorderColor = System.Drawing.Color.Silver;
            this.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox1.Location = new System.Drawing.Point(133, 91);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.Radius = 8;
            this.TextBox1.SelectedText = "";
            this.TextBox1.Size = new System.Drawing.Size(356, 49);
            this.TextBox1.TabIndex = 28;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel2.Location = new System.Drawing.Point(73, 98);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(54, 28);
            this.gunaLabel2.TabIndex = 27;
            this.gunaLabel2.Text = "Năm";
            // 
            // UscManageStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.cbbYears);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.labelTotalRevenue);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.ccbSelectMonth);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.chartStatistic);
            this.Name = "UscManageStatistic";
            this.Size = new System.Drawing.Size(1285, 984);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistic;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox ccbSelectMonth;
        private Guna.UI.WinForms.GunaTextBox TextBox;
        private Guna.UI.WinForms.GunaButton btnFilter;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Guna.UI.WinForms.GunaLabel labelTotalRevenue;
        private Guna.UI.WinForms.GunaLabel LabelTitle;
        private Guna.UI.WinForms.GunaComboBox cbbYears;
        private Guna.UI.WinForms.GunaTextBox TextBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}
