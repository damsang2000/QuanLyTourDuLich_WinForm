using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eshop
{
    public partial class VeMayBay : Form
    {
        public VeMayBay()
        {
            InitializeComponent();
        }
        public static string diemdi = "";
        public static string diemden = "";
        public static string soluongkhach = "";
        public static  DateTime ngaydi;
        public static DateTime ngayve;
        public static int tongtien = 0;
        public static string hangghe = "";
        public static string loaive = "Máy Bay";
        public static string textve = "";
        public void loaddata()
        {
            cbDiemDenMotChieu.Items.Clear();
            cbKhoiHanhMotChieu.Items.Clear();
            cbSoHanhKhach.Items.Clear();
            cbHangGhe.Items.Clear();
            dtKhuHoi.Visible = false;
            string[] dt = { "Hồ Chí Minh", "Hà Nội", "Đà Lạt", "Hà Giang", "Khác" };
            string[] hg = { "Thương Gia", "Phổ Thông", "Hạng Nhất", "Đặc Biệt" };
            foreach (string s in dt)
            {
                cbKhoiHanhMotChieu.Items.Add(s);
            }
            foreach (string s in dt)
            {
                cbDiemDenMotChieu.Items.Add(s);
            }
            for (int i = 1; i < 10; i++)
            {
                cbSoHanhKhach.Items.Add(i);
            }
            foreach (string s in hg)
            {
                cbHangGhe.Items.Add(s);
            }
        }


        private void cbKhuHoi01_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKhuHoi01.Checked)
                dtKhuHoi.Show();
            else
                dtKhuHoi.Hide();

        }

        private void dtKhuHoi_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_datve_Click(object sender, EventArgs e)
        {
            if (cbKhoiHanhMotChieu.SelectedItem == null || cbDiemDenMotChieu.SelectedItem == null || cbSoHanhKhach.SelectedItem == null || cbHangGhe.SelectedItem == null)
                MessageBox.Show("Bạn chọn Thiếu dữ liệu");
            else if (cbKhoiHanhMotChieu.SelectedItem == cbDiemDenMotChieu.SelectedItem)
                MessageBox.Show("Điểm Khởi Hành Và Điểm Đến Bị Trùng");
            else if (cbKhuHoi01.Checked == true && guna2DateTimePicker3.Value.Day >= dtKhuHoi.Value.Day)
                MessageBox.Show("Ngày đi lớn hơn ngày về");
            else if (cbKhuHoi01.Checked == true)
            {
                diemdi = cbKhoiHanhMotChieu.SelectedItem.ToString();
                diemden = cbDiemDenMotChieu.SelectedItem.ToString();
                soluongkhach = cbSoHanhKhach.SelectedItem.ToString();
                ngaydi = guna2DateTimePicker3.Value.Date;
                hangghe = cbHangGhe.SelectedItem.ToString();
                ngayve = dtKhuHoi.Value.Date;
                if (hangghe.Equals("Thương Gia"))
                    tongtien = int.Parse(cbSoHanhKhach.SelectedItem.ToString()) * 2000000;
                else if (hangghe.Equals("Phổ Thông"))
                    tongtien = int.Parse(cbSoHanhKhach.SelectedItem.ToString()) * 700000;
                else if (hangghe.Equals("Đặc Biệt"))
                    tongtien = int.Parse(cbSoHanhKhach.SelectedItem.ToString()) * 900000;
                else if (hangghe.Equals("Hạng Nhất"))
                    tongtien = int.Parse(cbSoHanhKhach.SelectedItem.ToString()) * 1000000;
                DialogResult r;
                r = MessageBox.Show("Bạn đã có tài khoản", "Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    textve = btn_datve.Text;
                    XacNhanKH xn = new XacNhanKH();
                    xn.Show();
                }
            }
            else
            {
                string date=null;
                diemdi = cbKhoiHanhMotChieu.SelectedItem.ToString();
                diemden = cbDiemDenMotChieu.SelectedItem.ToString();
                soluongkhach = cbSoHanhKhach.SelectedItem.ToString();
                ngaydi = guna2DateTimePicker3.Value.Date;
                hangghe = cbHangGhe.SelectedItem.ToString();
                ngayve = Convert.ToDateTime(date);
                textve = btn_datve.Text;
                if (hangghe.Equals("Thương Gia"))
                    tongtien = int.Parse(cbSoHanhKhach.SelectedItem.ToString()) * 2000000;
                else if (hangghe.Equals("Phổ Thông"))
                    tongtien = int.Parse(cbSoHanhKhach.SelectedItem.ToString()) * 700000;
                else if (hangghe.Equals("Đặc Biệt"))
                    tongtien = int.Parse(cbSoHanhKhach.SelectedItem.ToString()) * 900000;
                else if (hangghe.Equals("Hạng Nhất"))
                    tongtien = int.Parse(cbSoHanhKhach.SelectedItem.ToString()) * 1000000;
                DialogResult r;
                r = MessageBox.Show("Bạn đã có tài khoản", "Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {

                    XacNhanKH xn = new XacNhanKH();
                    xn.Show();
                }
            }
        }

        private void VeMayBay_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dtKhuHoi_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
