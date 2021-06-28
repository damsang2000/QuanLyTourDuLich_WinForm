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
    public partial class DuaDoanSanBay : Form
    {
        public DuaDoanSanBay()
        {
            InitializeComponent();
        }
        TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
        public static string masb = "";
        public static string tudiadiem = "";
        public static string dendiadiem = "";
        public static DateTime ngaydon;
        public static string giodon = "";
        public static string textsb = "";
        public static int tienthue = 700000;
        public static string loaive = "Vé Đặt Xe";
        public void loadata()
        {
            cbKhuVuc.Items.Clear();
            cbGioDoan.Items.Clear();
            cb_phut.Items.Clear();
            cb_muigio.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cbGioDoan.Items.Add(i);
            }
            for (int i = 1; i <= 60; i++)
            {
                cb_phut.Items.Add(i);

            }
            string[] muih = { "AM", "PM" };
            foreach (string s in muih)
            {
                cb_muigio.Items.Add(s);
            }
            string[] hg = { "Hồ Chí Minh", "Hà Nội", "Đà Lạt", "Hà Giang", "Khác" };
            foreach (string s in hg)
            {
                cbKhuVuc.Items.Add(s);
            }
            var result = from c in db.SAN_BAY
                         select c;
            cbSanBay.DataSource = result.ToList();
            cbSanBay.DisplayMember = "TenSB";
            cbSanBay.ValueMember = "MaSB";
        }
        private void cbGioDoan_Click(object sender, EventArgs e)
        {

        }

        private void cbSanBay_Click(object sender, EventArgs e)
        {

        }

        private void DuaDoanSanBay_Load(object sender, EventArgs e)
        {
            loadata();
        }

        private void btn_datxe_Click(object sender, EventArgs e)
        {
            if (cbKhuVuc.SelectedItem == null || cbSanBay.SelectedItem == null || cbGioDoan.SelectedItem == null || cb_muigio.SelectedItem == null)
                MessageBox.Show("Bạn Chọn Chưa Đủ");
            else
            {
                masb = cbSanBay.SelectedValue.ToString();
                SAN_BAY s=db.SAN_BAY.Find(masb);
                tudiadiem = s.TenSB;
                dendiadiem = cbKhuVuc.SelectedItem.ToString();
                ngaydon = dt_ngaydon.Value.Date;
               
                if (cb_phut.SelectedItem == null)
                {
                    giodon = cbGioDoan.SelectedItem.ToString() + ":" + cb_muigio.SelectedItem.ToString();
                }
                else
                {
                    giodon = cbGioDoan.SelectedItem.ToString() + ":" + cb_phut.SelectedItem.ToString() + ":" + cb_muigio.SelectedItem.ToString();
                }
                DialogResult r;
                r = MessageBox.Show("Bạn đã có tài khoản", "Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    textsb = btn_datxe.Text;
                    XacNhanKH xn = new XacNhanKH();
                    xn.Show();
                }
            }
        }

    }
}
