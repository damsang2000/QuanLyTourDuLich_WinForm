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
    public partial class FrTrangChu : Form
    {
        public FrTrangChu()
        {
            InitializeComponent();
            guna2PictureBox1.Show();
        }
        public static string tenkh ="";
        VeMayBay vemb = new VeMayBay();
        KhachSan ks = new KhachSan();
        ComBoTietKiem cb = new ComBoTietKiem();
        DuaDoanSanBay ddsb = new DuaDoanSanBay();
        ThueXe tx = new ThueXe();
        FrLoGin lg = new FrLoGin();
        HoaDon hd = new HoaDon();
        KhachHang kh = new KhachHang();
        frTour t = new frTour();
        public static int sove()
        {
            TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
            int count = db.VE_MAY_BAY.Count();
            return count++;
        }
        public static int sohd()
        {
            TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
            int count = db.HOA_DON.Count();
            return count++;
        }
        public static int maks()
        {
            TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
            int count = db.KHACH_SAN.Count();
            return count++;
        }
        public static int mavt()
        {
            TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
            int count = db.DATTOURs.Count();
            return count++;
        }
        private void btVeMayBay_Click(object sender, EventArgs e)
        {
            ks.Hide();
            cb.Hide();
            ddsb.Hide();
            tx.Hide();
            hd.Hide();
            kh.Hide();
            t.Hide();
            btVeMayBay.Checked = true;
            btKhachSan.Checked = false;
            btXperience.Checked = false;
            btJPass.Checked = false;
            btn_taikhoan.Checked = false;
            btDuaDonSanBay.Checked = false;
            vemb.TopLevel = false;
            vemb.TopMost = true;
            vemb.Top = 120;
            vemb.Left = 30;
            guna2PictureBox1.Controls.Add(vemb);
            vemb.Show();
        }

        private void btKhachSan_Click(object sender, EventArgs e)
        {
            vemb.Hide();
            cb.Hide();
            ddsb.Hide();
            tx.Hide();
            hd.Hide();
            kh.Hide();
            t.Hide();
            btVeMayBay.Checked = false;
            btKhachSan.Checked = true;
            btDuaDonSanBay.Checked = false;
            btXperience.Checked = false;
            btJPass.Checked = false;
            btn_taikhoan.Checked = false;
            ks.TopLevel = false;
            ks.TopMost = true;
            ks.Top = 120;
            ks.Left = 140;
            guna2PictureBox1.Controls.Add(ks);
            ks.Show();
        }

        private void btComBoTietKiem_Click(object sender, EventArgs e)
        {
            vemb.Hide();
            ks.Hide();
            ddsb.Hide();
            tx.Hide();
            hd.Hide();
            kh.Hide();
            t.Hide();
            btVeMayBay.Checked = false;
            btKhachSan.Checked = false;
            btDuaDonSanBay.Checked = false;
            btXperience.Checked = false;
            btJPass.Checked = false;
            cb.TopLevel = false;
            cb.TopMost = true;
            cb.Top = 30;
            cb.Left = 50;
            guna2PictureBox1.Controls.Add(cb);
            cb.Show();
        }

        private void btDuaDonSanBay_Click(object sender, EventArgs e)
        {
            vemb.Hide();
            ks.Hide();
            cb.Hide();
            tx.Hide();
            hd.Hide();
            kh.Hide();
            t.Hide();
            btVeMayBay.Checked = false;
            btKhachSan.Checked = false;
            btDuaDonSanBay.Checked = true;
            btXperience.Checked = false;
            btn_taikhoan.Checked = false;
            btJPass.Checked = false;
            ddsb.TopLevel = false;
            ddsb.TopMost = true;
            ddsb.Top = 170;
            ddsb.Left = 50;
            guna2PictureBox1.Controls.Add(ddsb);
            ddsb.Show();
        }

        private void btXperience_Click(object sender, EventArgs e)
        {
            vemb.Hide();
            ks.Hide();
            cb.Hide();
            tx.Hide();
            hd.Hide();
            kh.Hide();
            ddsb.Hide();
            btVeMayBay.Checked = false;
            btKhachSan.Checked = false;
            btDuaDonSanBay.Checked = false;
            btXperience.Checked = true;
            btJPass.Checked = false;
            t.TopLevel = false;
            t.TopMost = true;
            t.Top = 70;
            t.Left = 20;
            guna2PictureBox1.Controls.Add(t);
            t.Show();
        }

        private void btThueXe_Click(object sender, EventArgs e)
        {
            ks.Hide();
            cb.Hide();
            ddsb.Hide();
            vemb.Hide();
            kh.Hide();
            hd.Hide();
            t.Hide();
            btVeMayBay.Checked = false;
            btKhachSan.Checked = false;
            btDuaDonSanBay.Checked = false;
            btXperience.Checked = false;
            btn_taikhoan.Checked = false;
            btJPass.Checked = false;
            tx.TopLevel = false;
            tx.TopMost = true;
            tx.Top = 100;
            tx.Left = 60;
            guna2PictureBox1.Controls.Add(tx);
            tx.Show();
        }

        private void btJPass_Click(object sender, EventArgs e)
        {
            ks.Hide();
            cb.Hide();
            ddsb.Hide();
            vemb.Hide();
            tx.Hide();
            kh.Hide();
            t.Hide();
            btVeMayBay.Checked = false;
            btKhachSan.Checked = false;
            btDuaDonSanBay.Checked = false;
            btXperience.Checked = false;
            btn_taikhoan.Checked = false;
            btJPass.Checked = true;
            JRPASS jrpass = new JRPASS();
            hd.TopLevel = false;
            hd.TopMost = true;
            hd.Top = 140;
            hd.Left = 50;
            guna2PictureBox1.Controls.Add(hd);
            hd.Show();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng Xuất Thành Công");
            this.Hide();
            lg.Show();
        }

        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            ks.Hide();
            cb.Hide();
            ddsb.Hide();
            vemb.Hide();
            tx.Hide();
            t.Hide();
            btVeMayBay.Checked = false;
            btKhachSan.Checked = false;
            btDuaDonSanBay.Checked = false;
            btXperience.Checked = false;
            btJPass.Checked = false;
            btn_taikhoan.Checked = true;
            kh.Show();
        }

    }
}
