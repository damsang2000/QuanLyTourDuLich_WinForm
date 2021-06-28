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
    public partial class ComBoTietKiem : Form
    {
        public ComBoTietKiem()
        {
            InitializeComponent();
        }
        public void loaddata()
        {
            cbKhoiHanh.Items.Clear();
            cbHangGhe.Items.Clear();
        }
        private void cbKhoiHanh_Click(object sender, EventArgs e)
        {
            string[] ch = { "Hồ Chí Minh", "Hà Nội", "Đà Lạt", "Hà Giang", "Khác" };
            foreach (string s in ch)
            {
                cbKhoiHanh.Items.Add(s);
            }
        }

        private void cbHangGhe_Click(object sender, EventArgs e)
        {
            string[] dt = { "Phổ thông", "Thương gia", "Hạng nhất" };
            foreach (string s in dt)
            {
                cbHangGhe.Items.Add(s);
            }
        }

        private void ComBoTietKiem_Load(object sender, EventArgs e)
        {
            dtKhuHoi.Hide();
        }

        private void cbPhong_Click(object sender, EventArgs e)
        {
            string[] hg = { "1000", "1001", "1002", "1003", "1004" };
            foreach (string s in hg)
            {
                cbPhong.Items.Add(s);
            }
        }

        private void cbDiemDen_Click(object sender, EventArgs e)
        {
            string[] dt = { "Hồ Chí Minh", "Hà Nội", "Đà Lạt", "Hà Giang", "Khác" };
            foreach (string s in dt)
            {
                cbDiemDen.Items.Add(s);
            }
        }

        private void cbTenKhachSan_Click(object sender, EventArgs e)
        {
            string[] dt = { "Hồ Chí Minh", "Hà Nội", "Đà Lạt", "Hà Giang", "Khác" };
            foreach (string s in dt)
            {
                cbTenKhachSan.Items.Add(s);
            }
        }
        private void ComBoTietKiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát", "thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void ckKhuHoi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckKhuHoi.Checked)
                dtKhuHoi.Show();
            else
                dtKhuHoi.Hide();
        }

    }
}
