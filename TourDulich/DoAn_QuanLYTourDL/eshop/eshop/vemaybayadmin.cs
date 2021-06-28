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
    public partial class vemaybayadmin : Form
    {
        public vemaybayadmin()
        {
            InitializeComponent();
        }
        TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
        public void loaddata()
        {
            var result = from c in db.VE_MAY_BAY
                         select new { mave = c.MaVe, makh = c.MaKH, tenkh = c.TenKH, diemkh = c.DiemKhoiHanh, diemden = c.DiemDen, ngaydi = c.NgayDi, ngayve = c.NgayVe, sohanhkhach = c.SoHanhKhach, hangghe = c.HangGhe, Tongtien = c.Tongtien };
            dtgv_vemaybay.DataSource = result.ToList();

        }
        public void loaddata1()
        {
            cbDiemDenMotChieu.Items.Clear();
            cbKhoiHanhMotChieu.Items.Clear();
            cbSoHanhKhach.Items.Clear();
            cbHangGhe.Items.Clear();
            string[] dt = { "Hồ Chí Minh", "Hà Nội", "Đà Lạt", "Hà Giang", "Khác" };
            string[] hg = { "Thương Gia", "Phổ Thông", "Hạng Nhất", "Đặc Biệt" };
            string[] sx = { "Sắp xếp theo tên", "Sắp xếp theo giá" };
            foreach (string s in dt)
            {
                cbKhoiHanhMotChieu.Items.Add(s);
            }
            foreach (string s in dt)
            {
                cbDiemDenMotChieu.Items.Add(s);
            }
            for (int i = 1; i < 10; i++)
            {
                cbSoHanhKhach.Items.Add(i);
            }
            foreach (string s in hg)
            {
                cbHangGhe.Items.Add(s);
            }
            foreach (string  s in sx)
            {
                cb_sapxep.Items.Add(s);
            }
        }
        public void binding()
        {
            string mave = dtgv_vemaybay.SelectedCells[0].OwningRow.Cells["mave"].Value.ToString();
            string makh = dtgv_vemaybay.SelectedCells[0].OwningRow.Cells["makh"].Value.ToString();
            string tenkh = dtgv_vemaybay.SelectedCells[0].OwningRow.Cells["tenkh"].Value.ToString();
            string diemkh = dtgv_vemaybay.SelectedCells[0].OwningRow.Cells["diemkh"].Value.ToString();
            string diemden = dtgv_vemaybay.SelectedCells[0].OwningRow.Cells["diemden"].Value.ToString();
            string ngaydi = dtgv_vemaybay.SelectedCells[0].OwningRow.Cells["ngaydi"].Value.ToString();
            string sohanhkhach = dtgv_vemaybay.SelectedCells[0].OwningRow.Cells["sohanhkhach"].Value.ToString();
            string hangghe = dtgv_vemaybay.SelectedCells[0].OwningRow.Cells["hangghe"].Value.ToString();
            string ngayve = dtgv_vemaybay.SelectedCells[0].OwningRow.Cells["ngayve"].Value.ToString();
            cbKhoiHanhMotChieu.SelectedItem = diemkh;
            cbDiemDenMotChieu.SelectedItem = diemden;
            guna2DateTimePicker3.Value = Convert.ToDateTime(ngaydi);
            cbSoHanhKhach.SelectedItem = int.Parse(sohanhkhach);
            cbHangGhe.SelectedItem = hangghe;
        }
        public void remove()
        {
            string mave = dtgv_vemaybay.SelectedCells[0].OwningRow.Cells["mave"].Value.ToString();
            VE_MAY_BAY h = db.VE_MAY_BAY.Where(p => p.MaVe == mave).SingleOrDefault();
            db.VE_MAY_BAY.Remove(h);
            db.SaveChanges();
            MessageBox.Show("Đã xóa");
            loaddata();
            tongsove();
        }
        public void update()
        {
            if (cbDiemDenMotChieu.SelectedItem == null || cbKhoiHanhMotChieu.SelectedItem == null || cbHangGhe.SelectedItem == null || cbSoHanhKhach.SelectedItem == null)
                MessageBox.Show("Chưa Chọn Đủ");
            else if (cbDiemDenMotChieu.SelectedItem==cbKhoiHanhMotChieu.SelectedItem)
                MessageBox.Show("Điểm đi và đến bị trùng");
            else if (guna2DateTimePicker3.Value.Date > dt_ngayve.Value.Date && guna2DateTimePicker3.Value.Month==dt_ngayve.Value.Month && guna2DateTimePicker3.Value.Year==dt_ngayve.Value.Year)
                MessageBox.Show("Ngày đi lớn hơn ngày về");
            else
            {
                string mave = dtgv_vemaybay.SelectedCells[0].OwningRow.Cells["mave"].Value.ToString();
                VE_MAY_BAY ve = db.VE_MAY_BAY.Find(mave);
                ve.DiemKhoiHanh = cbKhoiHanhMotChieu.SelectedItem.ToString();
                ve.DiemDen = cbDiemDenMotChieu.SelectedItem.ToString();
                ve.NgayDi = guna2DateTimePicker3.Value.Date;
                ve.NgayVe = dt_ngayve.Value.Date;
                ve.SoHanhKhach = int.Parse(cbSoHanhKhach.SelectedItem.ToString());
                ve.HangGhe = cbHangGhe.SelectedItem.ToString();
                if (ve.HangGhe.Equals("Thương Gia"))
                {
                    ve.Tongtien = 2000000 * ve.SoHanhKhach;
                }
                else if (ve.HangGhe.Equals("Phổ Thông"))
                {
                    ve.Tongtien = 700000 * ve.SoHanhKhach;
                }
                else if (ve.HangGhe.Equals("Đặc Biệt"))
                {
                    ve.Tongtien = 900000 * ve.SoHanhKhach;
                }
                else
                {
                    ve.Tongtien = 1000000 * ve.SoHanhKhach;
                }
                db.SaveChanges();
                MessageBox.Show("Đã Sửa");
                loaddata();
            }
        }
        public void tongsove()
        {
            int cout = db.VE_MAY_BAY.Count();
            lb_tongve.Text = cout.ToString();
        }
        private void vemaybayadmin_Load(object sender, EventArgs e)
        {
            loaddata();
            loaddata1();
            tongsove();
        }

        private void dtgv_vemaybay_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            var result = from c in db.VE_MAY_BAY
                         where c.KHACH_HANG.TenKH.Contains(txt_ten_kh.Text)
                         select new { mave = c.MaVe, makh = c.MaKH, tenkh = c.TenKH, diemkh = c.DiemKhoiHanh, diemden = c.DiemDen, ngaydi = c.NgayDi, ngayve = c.NgayVe, sohanhkhach = c.SoHanhKhach, hangghe = c.HangGhe, Tongtien = c.Tongtien };
            dtgv_vemaybay.DataSource = result.ToList();
            if (dtgv_vemaybay.RowCount == 0)
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

        private void cb_sapxep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_sapxep.SelectedIndex ==0)
            {
                var result = from c in db.VE_MAY_BAY
                             orderby c.TenKH
                             select new { mave = c.MaVe, makh = c.MaKH, tenkh = c.TenKH, diemkh = c.DiemKhoiHanh, diemden = c.DiemDen, ngaydi = c.NgayDi, ngayve = c.NgayVe, sohanhkhach = c.SoHanhKhach, hangghe = c.HangGhe, Tongtien = c.Tongtien };
                dtgv_vemaybay.DataSource = result.ToList();
            }
            else
            {
                var result = from c in db.VE_MAY_BAY
                             orderby c.Tongtien
                             select new { mave = c.MaVe, makh = c.MaKH, tenkh = c.TenKH, diemkh = c.DiemKhoiHanh, diemden = c.DiemDen, ngaydi = c.NgayDi, ngayve = c.NgayVe, sohanhkhach = c.SoHanhKhach, hangghe = c.HangGhe, Tongtien = c.Tongtien };
                dtgv_vemaybay.DataSource = result.ToList();
            }
        }
    }
}
