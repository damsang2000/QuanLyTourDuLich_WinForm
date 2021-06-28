namespace eshop
{
    partial class DuaDonSanBayAD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtgv_datxe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.masb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tudiadiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dendiadiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giodon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSanBay = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbKhuVuc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dt_ngaydon = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_remove = new Guna.UI2.WinForms.Guna2Button();
            this.lb_tongve = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_timkiem = new Guna.UI2.WinForms.Guna2Button();
            this.txt_ten_kh = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cb_sapxep = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_datxe)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(254, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(333, 33);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "DANH SÁCH XE ĐÃ ĐẶT";
            // 
            // dtgv_datxe
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dtgv_datxe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgv_datxe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_datxe.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_datxe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_datxe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_datxe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_datxe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgv_datxe.ColumnHeadersHeight = 40;
            this.dtgv_datxe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masb,
            this.tudiadiem,
            this.dendiadiem,
            this.ngaydon,
            this.giodon,
            this.makh,
            this.tenkh,
            this.tongtien});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_datxe.DefaultCellStyle = dataGridViewCellStyle18;
            this.dtgv_datxe.EnableHeadersVisualStyles = false;
            this.dtgv_datxe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dtgv_datxe.Location = new System.Drawing.Point(13, 81);
            this.dtgv_datxe.Name = "dtgv_datxe";
            this.dtgv_datxe.RowHeadersVisible = false;
            this.dtgv_datxe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_datxe.Size = new System.Drawing.Size(838, 199);
            this.dtgv_datxe.TabIndex = 2;
            this.dtgv_datxe.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald;
            this.dtgv_datxe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dtgv_datxe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_datxe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_datxe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_datxe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_datxe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_datxe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dtgv_datxe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dtgv_datxe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_datxe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgv_datxe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_datxe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv_datxe.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgv_datxe.ThemeStyle.ReadOnly = false;
            this.dtgv_datxe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.dtgv_datxe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_datxe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgv_datxe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv_datxe.ThemeStyle.RowsStyle.Height = 22;
            this.dtgv_datxe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.dtgv_datxe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv_datxe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_datxe_CellContentClick);
            // 
            // masb
            // 
            this.masb.DataPropertyName = "masb";
            this.masb.HeaderText = "Mã Sân Bay";
            this.masb.Name = "masb";
            // 
            // tudiadiem
            // 
            this.tudiadiem.DataPropertyName = "tudiadiem";
            this.tudiadiem.HeaderText = "Từ Địa Điểm";
            this.tudiadiem.Name = "tudiadiem";
            // 
            // dendiadiem
            // 
            this.dendiadiem.DataPropertyName = "dendiadiem";
            this.dendiadiem.HeaderText = "Đến Địa Điểm";
            this.dendiadiem.Name = "dendiadiem";
            // 
            // ngaydon
            // 
            this.ngaydon.DataPropertyName = "ngaydon";
            this.ngaydon.HeaderText = "Ngày Đón";
            this.ngaydon.Name = "ngaydon";
            // 
            // giodon
            // 
            this.giodon.DataPropertyName = "giodon";
            this.giodon.HeaderText = "Giờ Đón";
            this.giodon.Name = "giodon";
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Mã KH";
            this.makh.Name = "makh";
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "tenkh";
            this.tenkh.HeaderText = "Tên KH";
            this.tenkh.Name = "tenkh";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng Tiền";
            this.tongtien.Name = "tongtien";
            // 
            // cbSanBay
            // 
            this.cbSanBay.BackColor = System.Drawing.Color.Transparent;
            this.cbSanBay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSanBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSanBay.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSanBay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSanBay.FocusedState.Parent = this.cbSanBay;
            this.cbSanBay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSanBay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSanBay.HoverState.Parent = this.cbSanBay;
            this.cbSanBay.ItemHeight = 30;
            this.cbSanBay.ItemsAppearance.Parent = this.cbSanBay;
            this.cbSanBay.Location = new System.Drawing.Point(48, 319);
            this.cbSanBay.Name = "cbSanBay";
            this.cbSanBay.ShadowDecoration.Parent = this.cbSanBay;
            this.cbSanBay.Size = new System.Drawing.Size(171, 36);
            this.cbSanBay.TabIndex = 4;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(13, 287);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(113, 24);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Từ (Sân bay)";
            // 
            // cbKhuVuc
            // 
            this.cbKhuVuc.BackColor = System.Drawing.Color.Transparent;
            this.cbKhuVuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhuVuc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbKhuVuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbKhuVuc.FocusedState.Parent = this.cbKhuVuc;
            this.cbKhuVuc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhuVuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbKhuVuc.HoverState.Parent = this.cbKhuVuc;
            this.cbKhuVuc.ItemHeight = 30;
            this.cbKhuVuc.ItemsAppearance.Parent = this.cbKhuVuc;
            this.cbKhuVuc.Location = new System.Drawing.Point(298, 319);
            this.cbKhuVuc.Name = "cbKhuVuc";
            this.cbKhuVuc.ShadowDecoration.Parent = this.cbKhuVuc;
            this.cbKhuVuc.Size = new System.Drawing.Size(175, 36);
            this.cbKhuVuc.TabIndex = 15;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(263, 289);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(125, 24);
            this.guna2HtmlLabel3.TabIndex = 14;
            this.guna2HtmlLabel3.Text = "Đến (Khu vực)";
            // 
            // dt_ngaydon
            // 
            this.dt_ngaydon.CheckedState.Parent = this.dt_ngaydon;
            this.dt_ngaydon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dt_ngaydon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt_ngaydon.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_ngaydon.HoverState.Parent = this.dt_ngaydon;
            this.dt_ngaydon.Location = new System.Drawing.Point(510, 319);
            this.dt_ngaydon.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_ngaydon.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_ngaydon.Name = "dt_ngaydon";
            this.dt_ngaydon.ShadowDecoration.Parent = this.dt_ngaydon;
            this.dt_ngaydon.Size = new System.Drawing.Size(201, 36);
            this.dt_ngaydon.TabIndex = 18;
            this.dt_ngaydon.Value = new System.DateTime(2020, 10, 14, 22, 56, 33, 823);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(510, 289);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(83, 24);
            this.guna2HtmlLabel4.TabIndex = 17;
            this.guna2HtmlLabel4.Text = "Ngày đón";
            // 
            // btn_update
            // 
            this.btn_update.CheckedState.Parent = this.btn_update;
            this.btn_update.CustomImages.Parent = this.btn_update;
            this.btn_update.FillColor = System.Drawing.Color.Black;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_update.HoverState.Parent = this.btn_update;
            this.btn_update.Location = new System.Drawing.Point(112, 441);
            this.btn_update.Name = "btn_update";
            this.btn_update.ShadowDecoration.Parent = this.btn_update;
            this.btn_update.Size = new System.Drawing.Size(94, 33);
            this.btn_update.TabIndex = 27;
            this.btn_update.Text = "UPDATE";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.CheckedState.Parent = this.btn_remove;
            this.btn_remove.CustomImages.Parent = this.btn_remove;
            this.btn_remove.FillColor = System.Drawing.Color.Black;
            this.btn_remove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_remove.HoverState.Parent = this.btn_remove;
            this.btn_remove.Location = new System.Drawing.Point(12, 441);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.ShadowDecoration.Parent = this.btn_remove;
            this.btn_remove.Size = new System.Drawing.Size(94, 33);
            this.btn_remove.TabIndex = 26;
            this.btn_remove.Text = "REMOVE";
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lb_tongve
            // 
            this.lb_tongve.BackColor = System.Drawing.Color.Transparent;
            this.lb_tongve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongve.ForeColor = System.Drawing.Color.Black;
            this.lb_tongve.Location = new System.Drawing.Point(816, 373);
            this.lb_tongve.Name = "lb_tongve";
            this.lb_tongve.Size = new System.Drawing.Size(25, 26);
            this.lb_tongve.TabIndex = 31;
            this.lb_tongve.Text = "11";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(698, 373);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(114, 26);
            this.guna2HtmlLabel8.TabIndex = 30;
            this.guna2HtmlLabel8.Text = "Tổng số vé:";
            // 
            // button2
            // 
            this.button2.Image = global::eshop.Properties.Resources.location_pin;
            this.button2.Location = new System.Drawing.Point(262, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 36);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::eshop.Properties.Resources.location_pin;
            this.button4.Location = new System.Drawing.Point(13, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 36);
            this.button4.TabIndex = 13;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.Color.Black;
            this.btn_timkiem.CheckedState.Parent = this.btn_timkiem;
            this.btn_timkiem.CustomImages.Parent = this.btn_timkiem;
            this.btn_timkiem.FillColor = System.Drawing.Color.Black;
            this.btn_timkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_timkiem.ForeColor = System.Drawing.Color.White;
            this.btn_timkiem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_timkiem.HoverState.Parent = this.btn_timkiem;
            this.btn_timkiem.Location = new System.Drawing.Point(273, 47);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.ShadowDecoration.Parent = this.btn_timkiem;
            this.btn_timkiem.Size = new System.Drawing.Size(82, 28);
            this.btn_timkiem.TabIndex = 33;
            this.btn_timkiem.Text = "TÌM KIẾM";
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_ten_kh
            // 
            this.txt_ten_kh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ten_kh.DefaultText = "";
            this.txt_ten_kh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ten_kh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ten_kh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ten_kh.DisabledState.Parent = this.txt_ten_kh;
            this.txt_ten_kh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ten_kh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ten_kh.FocusedState.Parent = this.txt_ten_kh;
            this.txt_ten_kh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ten_kh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ten_kh.HoverState.Parent = this.txt_ten_kh;
            this.txt_ten_kh.Location = new System.Drawing.Point(13, 47);
            this.txt_ten_kh.Name = "txt_ten_kh";
            this.txt_ten_kh.PasswordChar = '\0';
            this.txt_ten_kh.PlaceholderText = "Nhập tên khách hàng";
            this.txt_ten_kh.SelectedText = "";
            this.txt_ten_kh.ShadowDecoration.Parent = this.txt_ten_kh;
            this.txt_ten_kh.Size = new System.Drawing.Size(253, 28);
            this.txt_ten_kh.TabIndex = 32;
            this.txt_ten_kh.TextChanged += new System.EventHandler(this.txt_ten_kh_TextChanged);
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(12, 364);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(66, 20);
            this.guna2HtmlLabel9.TabIndex = 35;
            this.guna2HtmlLabel9.Text = "Sắp Xếp";
            // 
            // cb_sapxep
            // 
            this.cb_sapxep.BackColor = System.Drawing.Color.Transparent;
            this.cb_sapxep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_sapxep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sapxep.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_sapxep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_sapxep.FocusedState.Parent = this.cb_sapxep;
            this.cb_sapxep.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_sapxep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_sapxep.HoverState.Parent = this.cb_sapxep;
            this.cb_sapxep.ItemHeight = 30;
            this.cb_sapxep.ItemsAppearance.Parent = this.cb_sapxep;
            this.cb_sapxep.Location = new System.Drawing.Point(13, 392);
            this.cb_sapxep.Name = "cb_sapxep";
            this.cb_sapxep.ShadowDecoration.Parent = this.cb_sapxep;
            this.cb_sapxep.Size = new System.Drawing.Size(165, 36);
            this.cb_sapxep.TabIndex = 34;
            this.cb_sapxep.SelectedIndexChanged += new System.EventHandler(this.cb_sapxep_SelectedIndexChanged);
            // 
            // DuaDonSanBayAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(863, 487);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.cb_sapxep);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_ten_kh);
            this.Controls.Add(this.lb_tongve);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.dt_ngaydon);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbKhuVuc);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cbSanBay);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.dtgv_datxe);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DuaDonSanBayAD";
            this.Text = "DuaDonSanBay";
            this.Load += new System.EventHandler(this.DuaDonSanBayAD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_datxe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_datxe;
        private Guna.UI2.WinForms.Guna2ComboBox cbSanBay;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private Guna.UI2.WinForms.Guna2ComboBox cbKhuVuc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_ngaydon;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2Button btn_remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn masb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tudiadiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dendiadiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydon;
        private System.Windows.Forms.DataGridViewTextBoxColumn giodon;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_tongve;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2Button btn_timkiem;
        private Guna.UI2.WinForms.Guna2TextBox txt_ten_kh;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2ComboBox cb_sapxep;
    }
}