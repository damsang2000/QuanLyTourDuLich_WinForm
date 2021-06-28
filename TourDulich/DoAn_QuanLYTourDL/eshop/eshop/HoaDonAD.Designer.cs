namespace eshop
{
    partial class HoaDonAD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtgv_hoadon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_remove = new Guna.UI2.WinForms.Guna2Button();
            this.btn_inhoadon = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(149, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(406, 33);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "HÓA ĐƠN CỦA KHÁCH HÀNG";
            // 
            // dtgv_hoadon
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dtgv_hoadon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgv_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_hoadon.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_hoadon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_hoadon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_hoadon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_hoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgv_hoadon.ColumnHeadersHeight = 21;
            this.dtgv_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.makh,
            this.loaive,
            this.soluongve,
            this.tongtien});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_hoadon.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgv_hoadon.EnableHeadersVisualStyles = false;
            this.dtgv_hoadon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dtgv_hoadon.Location = new System.Drawing.Point(12, 64);
            this.dtgv_hoadon.Name = "dtgv_hoadon";
            this.dtgv_hoadon.RowHeadersVisible = false;
            this.dtgv_hoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_hoadon.Size = new System.Drawing.Size(677, 208);
            this.dtgv_hoadon.TabIndex = 2;
            this.dtgv_hoadon.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dtgv_hoadon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dtgv_hoadon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_hoadon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_hoadon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_hoadon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_hoadon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_hoadon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dtgv_hoadon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dtgv_hoadon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_hoadon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgv_hoadon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_hoadon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv_hoadon.ThemeStyle.HeaderStyle.Height = 21;
            this.dtgv_hoadon.ThemeStyle.ReadOnly = false;
            this.dtgv_hoadon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dtgv_hoadon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_hoadon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgv_hoadon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv_hoadon.ThemeStyle.RowsStyle.Height = 22;
            this.dtgv_hoadon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dtgv_hoadon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv_hoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_hoadon_CellContentClick);
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "mahd";
            this.mahd.HeaderText = "Mã Hóa Đơn";
            this.mahd.Name = "mahd";
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Mã KH";
            this.makh.Name = "makh";
            // 
            // loaive
            // 
            this.loaive.DataPropertyName = "loaive";
            this.loaive.HeaderText = "Loại Vé";
            this.loaive.Name = "loaive";
            // 
            // soluongve
            // 
            this.soluongve.DataPropertyName = "soluongve";
            this.soluongve.HeaderText = "Số Lượng Vé";
            this.soluongve.Name = "soluongve";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng Tiền";
            this.tongtien.Name = "tongtien";
            // 
            // btn_remove
            // 
            this.btn_remove.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_remove.CheckedState.Parent = this.btn_remove;
            this.btn_remove.CustomImages.Parent = this.btn_remove;
            this.btn_remove.FillColor = System.Drawing.Color.Black;
            this.btn_remove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_remove.HoverState.Parent = this.btn_remove;
            this.btn_remove.Location = new System.Drawing.Point(12, 294);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.ShadowDecoration.Parent = this.btn_remove;
            this.btn_remove.Size = new System.Drawing.Size(121, 35);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "REMOVE";
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_inhoadon
            // 
            this.btn_inhoadon.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_inhoadon.CheckedState.Parent = this.btn_inhoadon;
            this.btn_inhoadon.CustomImages.Parent = this.btn_inhoadon;
            this.btn_inhoadon.FillColor = System.Drawing.Color.Black;
            this.btn_inhoadon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_inhoadon.ForeColor = System.Drawing.Color.White;
            this.btn_inhoadon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_inhoadon.HoverState.Parent = this.btn_inhoadon;
            this.btn_inhoadon.Location = new System.Drawing.Point(139, 294);
            this.btn_inhoadon.Name = "btn_inhoadon";
            this.btn_inhoadon.ShadowDecoration.Parent = this.btn_inhoadon;
            this.btn_inhoadon.Size = new System.Drawing.Size(121, 35);
            this.btn_inhoadon.TabIndex = 5;
            this.btn_inhoadon.Text = "IN HÓA ĐƠN";
            this.btn_inhoadon.Click += new System.EventHandler(this.btn_inhoadon_Click);
            // 
            // HoaDonAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(701, 351);
            this.Controls.Add(this.btn_inhoadon);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.dtgv_hoadon);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoaDonAD";
            this.Text = "HoaDonAD";
            this.Load += new System.EventHandler(this.HoaDonAD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_hoadon;
        private Guna.UI2.WinForms.Guna2Button btn_remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaive;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongve;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private Guna.UI2.WinForms.Guna2Button btn_inhoadon;
    }
}