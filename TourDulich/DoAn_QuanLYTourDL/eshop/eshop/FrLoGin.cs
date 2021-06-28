using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace eshop
{
    public partial class FrLoGin : Form
    {
        public FrLoGin()
        {
            InitializeComponent();
            txtLoGinName.Focus();
        }
        TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
        bool ktTK()
        {
            int count = db.TAI_KHOAN.Where(ten => ten.TenDangNhap == txtLoGinName.Text).Where(pas => pas.MatKhau == txtLoginPassword.Text).Count();
            int count1 = db.TAI_KHOAN.Where(email => email.Email == txtLoGinName.Text).Where(pas => pas.MatKhau == txtLoginPassword.Text).Count();
            if (count >= 1 || count1 >= 1)
                return true;
            return false;
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int count3 = db.ADMINs.Where(ten => ten.username == txtLoGinName.Text).Where(ma => ma.password == txtLoginPassword.Text).Count();
            if (txtLoGinName.Text.Equals("") || txtLoginPassword.Text.Equals(""))
                MessageBox.Show("Bạn Nhập Thiếu Dữ Liệu");
            else if (count3 == 1)
            {
                MessageBox.Show("Bạn Đang Đăng Nhập Bằng Tài Khoản Admin");
                FrTrangChuAD trangchuad = new FrTrangChuAD();
                this.Hide();
                trangchuad.Show();
            }
            else
            {
                if (ktTK() == true)
                {
                    MessageBox.Show("Bạn Đang Đăng Nhập Bằng Tài Khoản User");
                    FrTrangChu trangchu = new FrTrangChu();
                    this.Hide();
                    trangchu.Show();
                }
                else
                    MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu");
            }
        }
    }
}
