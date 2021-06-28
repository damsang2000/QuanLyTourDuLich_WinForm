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
    public partial class Frsignin : Form
    {
        public Frsignin()
        {
            InitializeComponent();
        }
        TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
        bool ktkhoa()
        {
            int count = db.TAI_KHOAN.Count(ten => ten.TenDangNhap == txtFirstName.Text + txtLastName.Text);
            if (count >= 1)
                return false;
            return true;
        }
        public void addTK()
        {
            if (txtFirstName.Text.Equals("") || txtLastName.Text.Equals("") || txtPassWord.Text.Equals("") || txtEmail.Text.Equals(""))
                MessageBox.Show("Bạn nhập thiếu dữ liệu");
            else
            {
                if (ktkhoa() == true)
                {
                    db.TAI_KHOAN.Add(new TAI_KHOAN { TenDangNhap = txtFirstName.Text + txtLastName.Text, MatKhau = txtPassWord.Text, Email = txtEmail.Text });
                    db.SaveChanges();
                    MessageBox.Show("Đăng Ký Thành Công");
                }
                else
                    MessageBox.Show("tài khoản đã tồn tại");
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            addTK();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrLoGin login = new FrLoGin();
            login.Show();
        }
    }
}
