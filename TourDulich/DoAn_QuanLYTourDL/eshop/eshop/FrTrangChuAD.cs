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
    public partial class FrTrangChuAD : Form
    {
        public FrTrangChuAD()
        {
            InitializeComponent();
        }
        vemaybayadmin vembad = new vemaybayadmin();
        KhachHangAD khad = new KhachHangAD();
        HoaDonAD hd = new HoaDonAD();
        KhachSanAD ks = new KhachSanAD();
        FrLoGin login = new FrLoGin();
        DuaDonSanBayAD ddsb = new DuaDonSanBayAD();
        TourAD t = new TourAD();
        public static string sodem = "";
        public static string sokp = "";
        private void btVeMayBay_Click(object sender, EventArgs e)
        {
            khad.Hide();
            hd.Hide();
            ks.Hide();
            ddsb.Hide();
            t.Hide();
            btVeMayBay.Checked = true;
            btKhachSan.Checked = false;
            btDuaDonSanBay.Checked = false;
            btn_kh.Checked = false;
            btn_hoadon.Checked = false;
            btn_Tour.Checked = false;
            vembad.TopLevel = false;
            vembad.TopMost = true;
            vembad.Top = 52;
            vembad.Left = 20;
            guna2PictureBox1.Controls.Add(vembad);
            vembad.Show();
        }
        private void btKhachSan_Click(object sender, EventArgs e)
        {
            khad.Hide();
            hd.Hide();
            vembad.Hide();
            ddsb.Hide();
            t.Hide();
            btVeMayBay.Checked = false;
            btKhachSan.Checked = true;
            btDuaDonSanBay.Checked = false;
            btn_kh.Checked = false;
            btn_hoadon.Checked = false;
            btn_Tour.Checked = false;
            ks.TopLevel = false;
            ks.TopMost = true;
            ks.Top = 50;
            ks.Left = 5;
            guna2PictureBox1.Controls.Add(ks);
            ks.Show();
        }

        private void btComBoTietKiem_Click(object sender, EventArgs e)
        {
            btVeMayBay.Checked = false;
            btKhachSan.Checked = false;
            btDuaDonSanBay.Checked = false;
            btn_kh.Checked = false;
            btn_hoadon.Checked = false;
        }

        private void btDuaDonSanBay_Click(object sender, EventArgs e)
        {
            vembad.Hide();
            khad.Hide();
            hd.Hide();
            ks.Hide();
            t.Hide();
            btVeMayBay.Checked = false;
            btKhachSan.Checked = false;
            btDuaDonSanBay.Checked = true;
            btn_kh.Checked = false;
            btn_hoadon.Checked = false;
            btn_Tour.Checked = false;
            ddsb.TopLevel = false;
            ddsb.TopMost = true;
            ddsb.Top = 100;
            ddsb.Left = 50;
            guna2PictureBox1.Controls.Add(ddsb);
            ddsb.Show();
        }

        private void btXperience_Click(object sender, EventArgs e)
        {
            vembad.Hide();
            hd.Hide();
            ks.Hide();
            ddsb.Hide();
            t.Hide();
            btVeMayBay.Checked = false;
            btKhachSan.Checked = false;
            btDuaDonSanBay.Checked = false;
            btn_kh.Checked = true;
            btn_hoadon.Checked = false;
            khad.TopLevel = false;
            btn_Tour.Checked = false;
            khad.TopMost = true;
            khad.Top = 70;
            khad.Left = 70;
            guna2PictureBox1.Controls.Add(khad);
            khad.Show();
        }

        private void btThueXe_Click(object sender, EventArgs e)
        {
            btVeMayBay.Checked = false;
            btKhachSan.Checked = false;
            btDuaDonSanBay.Checked = false;
            btn_kh.Checked = false;
            btn_hoadon.Checked = false;
        }

        private void btJPass_Click(object sender, EventArgs e)
        {
            btVeMayBay.Checked = false;
            btKhachSan.Checked = false;
            btDuaDonSanBay.Checked = false;
            btn_kh.Checked = false;
            btn_hoadon.Checked = true;
        }
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng Xuất Thành Công");
            this.Hide();
            login.Show();
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            sodem = KhachSanAD.sodem;
            sokp = KhachSanAD.sokp;
            vembad.Hide();
            khad.Hide();
            ks.Hide();
            t.Hide();
            ddsb.Hide();
            btVeMayBay.Checked = false;
            btKhachSan.Checked = false;
            btDuaDonSanBay.Checked = false;
            btn_kh.Checked = false;
            btn_hoadon.Checked = true;
            btn_Tour.Checked = false;
            hd.TopLevel = false;
            hd.TopMost = true;
            hd.Top = 110;
            hd.Left = 120;
            guna2PictureBox1.Controls.Add(hd);
            hd.Show();
        }

        private void btn_Tour_Click(object sender, EventArgs e)
        {
            khad.Hide();
            hd.Hide();
            ks.Hide();
            ddsb.Hide();
            vembad.Hide();
            btVeMayBay.Checked = false;
            btKhachSan.Checked = false;
            btDuaDonSanBay.Checked = false;
            btn_kh.Checked = false;
            btn_hoadon.Checked = false;
            btn_Tour.Checked = true;
            t.TopLevel = false;
            t.TopMost = true;
            t.Top = 100;
            t.Left = 100;
            guna2PictureBox1.Controls.Add(t);
            t.Show();
        }

    }
}
