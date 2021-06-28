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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
        bool ktrakhoa()
        {
            int count = db.KHACH_HANG.Count(ma => ma.MaKH == txt_makh.Text);
            if (count >= 1)
                return false;
            return true;
        }
        public void addkh()
        {
            if (txt_makh.Text.Equals("") || txt_hoten.Text.Equals("") || txt_diachi.Text.Equals("") || txt_sdt.Text.Equals("") || cb_gioitinh.SelectedIndex == -1)
                MessageBox.Show("Bạn Nhập Thiếu Dữ Liệu");
            else
            {
                if (ktrakhoa() == true)
                {
                    db.KHACH_HANG.Add(new KHACH_HANG { MaKH = txt_makh.Text, TenKH = txt_hoten.Text, DiaChi = txt_diachi.Text, GioiTinh = cb_gioitinh.SelectedItem.ToString(), SDT = int.Parse(txt_sdt.Text) });
                    db.SaveChanges();
                    MessageBox.Show("Đăng Ký Thành Công");
                    FrTrangChu.tenkh = txt_hoten.Text;
                }
                else
                    MessageBox.Show("Khách hàng đã tồn tại!!");
            }
        }
        private void btn_dangki_Click(object sender, EventArgs e)
        {
            addkh();
        }
    }
}
