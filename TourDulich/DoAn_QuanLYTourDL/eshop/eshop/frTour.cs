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
    public partial class frTour : Form
    {
        public frTour()
        {
            InitializeComponent();
        }
        public static string tendd = "";
        public static string tien = "";
        public static string textdd = "";
        public static string loait = "Tour Du Lịch";
        private void pn_codohue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_codohue_Click(object sender, EventArgs e)
        {
            tien = guna2HtmlLabel9.Text;
            textdd = "Tour";
            DialogResult r;
            r = MessageBox.Show("Bạn đã có tài khoản", "Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                tendd = lb_phoco.Text;
                XacNhanKH xn = new XacNhanKH();
                xn.Show();
            }
        }

        private void pn_tamcoc_Click(object sender, EventArgs e)
        {
            tien = guna2HtmlLabel9.Text;
            textdd = "Tour";
            DialogResult r;
            r = MessageBox.Show("Bạn đã có tài khoản", "Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                tendd = lb_tamcoc.Text;
                XacNhanKH xn = new XacNhanKH();
                xn.Show();
            }
        }

        private void pn_vinhhalong_Click(object sender, EventArgs e)
        {
            tien = guna2HtmlLabel9.Text;
            textdd = "Tour";
            DialogResult r;
            r = MessageBox.Show("Bạn đã có tài khoản", "Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                tendd = lb_vinhhalong.Text;
                XacNhanKH xn = new XacNhanKH();
                xn.Show();
            }
        }

        private void pn_langkhaidinh_Click(object sender, EventArgs e)
        {
            tien = guna2HtmlLabel9.Text;
            textdd = "Tour";
            DialogResult r;
            r = MessageBox.Show("Bạn đã có tài khoản", "Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                tendd = lb_langkhaidinh.Text;
                XacNhanKH xn = new XacNhanKH();
                xn.Show();
            }
        }

        private void pn_phocohoian_Click(object sender, EventArgs e)
        {
            tien = guna2HtmlLabel9.Text;
            textdd = "Tour";
            DialogResult r;
            r = MessageBox.Show("Bạn đã có tài khoản", "Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                tendd = lb_phoco.Text;
                XacNhanKH xn = new XacNhanKH();
                xn.Show();
            }
        }

        private void pn_landmark_Click(object sender, EventArgs e)
        {
            tien = guna2HtmlLabel9.Text;
            textdd = "Tour";
            DialogResult r;
            r = MessageBox.Show("Bạn đã có tài khoản", "Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                tendd = lb_langmark.Text;
                XacNhanKH xn = new XacNhanKH();
                xn.Show();
            }
        }

        private void pn_phuquoc_Click(object sender, EventArgs e)
        {
            tien = guna2HtmlLabel9.Text;
            textdd = "Tour";
            DialogResult r;
            r = MessageBox.Show("Bạn đã có tài khoản", "Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                tendd = lb_phuquoc.Text;
                XacNhanKH xn = new XacNhanKH();
                xn.Show();
            }
        }

        private void pn_ddcuchi_Click(object sender, EventArgs e)
        {
            tien = guna2HtmlLabel9.Text;
            textdd = "Tour";
            DialogResult r;
            r = MessageBox.Show("Bạn đã có tài khoản", "Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                tendd = lb_diadao.Text;
                XacNhanKH xn = new XacNhanKH();
                xn.Show();
            }
        }
    }
}
