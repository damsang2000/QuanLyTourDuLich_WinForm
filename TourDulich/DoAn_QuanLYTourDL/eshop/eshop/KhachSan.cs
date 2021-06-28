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
    public partial class KhachSan : Form
    {
        TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
        public KhachSan()
        {
            InitializeComponent();
        }
        public static string vitri = "";
        public static string sodem = "";
        public static DateTime ngaynhan;
        public static DateTime ngaytra;
        public static string nguoitrenphong ="";
        public static int tongtien = 0;
        public static string sophong ="";
        public static string textks = "";
        public static string loaive = "Vé Khách Sạn";
        public void loaddata()
        {
            cbViTri.Items.Clear();
            cbSoDem.Items.Clear();
            cb_khachtrenphong.Items.Clear();
            cb_sophong.Items.Clear();
            for (int i = 1; i <= 30; i++)
            {
                cbSoDem.Items.Add(i);
            }
            for (int i = 1; i <=4; i++)
            {
                cb_khachtrenphong.Items.Add(i);
            }
            for (int i = 1000; i <= 1050; i++)
            {
                cb_sophong.Items.Add(i);
            }
        }
        public void loadcombo()
        {
            var result = from c in db.KS
                         select c;
            cbViTri.DataSource = result.ToList();
            cbViTri.DisplayMember = "TENKS";
            cbViTri.ValueMember = "TENKS";
        }
        private void KhachSan_Load(object sender, EventArgs e)
        {
            loaddata();
            loadcombo();
        }
        public void datphong()
        {
            if (cbViTri.SelectedItem == null || cbSoDem.SelectedItem == null || cb_khachtrenphong.SelectedItem == null || cb_sophong.SelectedItem == null)
                MessageBox.Show("Bạn Chọn Chưa Đủ");
            else if (dt_nhanphong.Value.Day >= dt_traphong.Value.Day)
            {
                MessageBox.Show("Ngày Nhận Phòng Trùng Hoặc Lớn Hơn Ngày Trả Phòng");
            }
            else
            {
                vitri = cbViTri.SelectedValue.ToString();
                sodem = cbSoDem.SelectedItem.ToString();
                ngaynhan = dt_nhanphong.Value.Date;
                ngaytra = dt_traphong.Value.Date;
                nguoitrenphong = cb_khachtrenphong.SelectedItem.ToString();
                sophong = cb_sophong.SelectedItem.ToString();

                if (int.Parse(sodem) <= 3)
                {
                    tongtien = int.Parse(nguoitrenphong) * 700000;
                }
                else
                {
                    tongtien = int.Parse(nguoitrenphong) * 1000000;
                }
                DialogResult r;
                r = MessageBox.Show("Bạn đã có tài khoản", "Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    textks = btn_datphong.Text;
                    XacNhanKH xn = new XacNhanKH();
                    xn.Show();
                }
            }
        }
        private void btn_datphong_Click(object sender, EventArgs e)
        {
            datphong();
        }

        private void cbSoDem_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sodem = int.Parse(cbSoDem.SelectedItem.ToString());
            dt_traphong.Value = dt_nhanphong.Value.AddDays(sodem);
        }

    }
}
