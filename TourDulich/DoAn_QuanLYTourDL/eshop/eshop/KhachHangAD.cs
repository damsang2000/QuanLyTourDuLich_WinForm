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
    public partial class KhachHangAD : Form
    {
        public KhachHangAD()
        {
            InitializeComponent();
        }
        TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
        public void loaddata()
        {
            var result = from c in db.KHACH_HANG
                         select new { makh = c.MaKH, tenkh = c.TenKH, diachi = c.DiaChi, gioitinh = c.GioiTinh, sodienthoai=c.SDT };
            dtgv_kh.DataSource = result.ToList();

        }
        public void binding()
        {
            string makh = dtgv_kh.SelectedCells[0].OwningRow.Cells["makh"].Value.ToString();
            string tenkh = dtgv_kh.SelectedCells[0].OwningRow.Cells["tenkh"].Value.ToString();
            string diachi = dtgv_kh.SelectedCells[0].OwningRow.Cells["diachi"].Value.ToString();
            string gioitinh = dtgv_kh.SelectedCells[0].OwningRow.Cells["gioitinh"].Value.ToString();
            string sdt = dtgv_kh.SelectedCells[0].OwningRow.Cells["sdt"].Value.ToString();
            txt_tenkh.Text = tenkh;
            txt_diachi.Text = diachi;
            cb_gioitinh.SelectedItem = gioitinh;
            txt_sodienthoai.Text = sdt;
           
        }
        private void KhachHangAD_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void remove()
        {
            string makh = dtgv_kh.SelectedCells[0].OwningRow.Cells["makh"].Value.ToString();
            int count = db.VE_MAY_BAY.Count(ma => ma.MaKH == makh);
            int count1 = db.KHACH_SAN.Count(ma => ma.MaKH == makh);
            int count3 = db.DATTOURs.Count(ma => ma.MaKH == makh);
            if (count >= 1 ||count1>=1||count3>=1)
                MessageBox.Show("Khách Hàng Đang Đặt Vé");
            else
            {
                KHACH_HANG h = db.KHACH_HANG.Where(p => p.MaKH == makh).SingleOrDefault();
                db.KHACH_HANG.Remove(h);
                db.SaveChanges();
                MessageBox.Show("Đã xóa");
                loaddata();
            }
        }
        public void update()
        {
            if (txt_diachi.Text.Equals("") || cb_gioitinh.SelectedItem == null || txt_sodienthoai.Text.Equals(""))
                MessageBox.Show("Chưa Chọn Đủ");
            else
            {
                string makh = dtgv_kh.SelectedCells[0].OwningRow.Cells["makh"].Value.ToString();
                KHACH_HANG ve = db.KHACH_HANG.Find(makh);
                ve.DiaChi = txt_diachi.Text;
                ve.GioiTinh = cb_gioitinh.SelectedItem.ToString();
                ve.SDT = int.Parse(txt_sodienthoai.Text);
                db.SaveChanges();
                MessageBox.Show("Đã Sửa");
                loaddata();
            }
        }
        private void dtgv_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            binding();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            remove();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            var result = from c in db.KHACH_HANG
                         where c.TenKH.Contains(txt_ten_kh.Text)
                         select new { makh = c.MaKH, tenkh = c.TenKH, diachi = c.DiaChi, gioitinh = c.GioiTinh, sodienthoai = c.SDT };       
            dtgv_kh.DataSource = result.ToList();
            if (dtgv_kh.RowCount == 0)
            {
                MessageBox.Show("không tìm thấy khách hàng");
            }
        }

        private void txt_ten_kh_TextChanged(object sender, EventArgs e)
        {
            if (txt_ten_kh.Text.Equals(""))
            {
                loaddata();
            }
        }
    }
}
