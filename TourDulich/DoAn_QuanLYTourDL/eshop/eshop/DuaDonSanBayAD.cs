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
    public partial class DuaDonSanBayAD : Form
    {
        public DuaDonSanBayAD()
        {
            InitializeComponent();
        }
        TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
        public void loaddata()
        {
            var result = from c in db.DUA_DOAN_SAN_BAY
                         select new { masb = c.MaSB, tudiadiem = c.TuDiaDiem, dendiadiem = c.DenDiaDiem, ngaydon = c.NgayDon, giodon = c.GioDoan, makh = c.MaKH, tenkh = c.KHACH_HANG.TenKH, tongtien = c.tongtien };
            dtgv_datxe.DataSource = result.ToList();
        }
        public void loadata1()
        {
            string[] sx = { "Sắp xếp theo tên", "Sắp xếp theo giá" };
            string[] hg = { "Hồ Chí Minh", "Hà Nội", "Đà Lạt", "Hà Giang", "Khác" };
            foreach (string s in hg)
            {
                cbKhuVuc.Items.Add(s);
            }
            foreach (string s in sx)
            {
                cb_sapxep.Items.Add(s);
            }
            var result = from c in db.SAN_BAY
                         select c;
            cbSanBay.DataSource = result.ToList();
            cbSanBay.DisplayMember = "TenSB";
            cbSanBay.ValueMember = "MaSB";
        }
        public void binding()
        {
            string masb = dtgv_datxe.SelectedCells[0].OwningRow.Cells["masb"].Value.ToString();
            string tudiadiem = dtgv_datxe.SelectedCells[0].OwningRow.Cells["tudiadiem"].Value.ToString();
            SAN_BAY sb = db.SAN_BAY.Find(masb);
            string dendiadiem = dtgv_datxe.SelectedCells[0].OwningRow.Cells["dendiadiem"].Value.ToString();
            string ngaydon = dtgv_datxe.SelectedCells[0].OwningRow.Cells["ngaydon"].Value.ToString();
            cbKhuVuc.SelectedItem = dendiadiem;
            cbSanBay.SelectedValue = sb.MaSB;
            dt_ngaydon.Value = Convert.ToDateTime(ngaydon);

        }
        public void remove()
        {
            string masb = dtgv_datxe.SelectedCells[0].OwningRow.Cells["masb"].Value.ToString();
            string makh = dtgv_datxe.SelectedCells[0].OwningRow.Cells["makh"].Value.ToString();
            DUA_DOAN_SAN_BAY h = db.DUA_DOAN_SAN_BAY.Where(p => p.MaSB == masb).Where(ma=>ma.MaKH==makh).SingleOrDefault();
            db.DUA_DOAN_SAN_BAY.Remove(h);
            db.SaveChanges();
            MessageBox.Show("Đã xóa");
            loaddata();
            tongsove();
        }
        public void update()
        {
            string masb = dtgv_datxe.SelectedCells[0].OwningRow.Cells["masb"].Value.ToString();
            string makh = dtgv_datxe.SelectedCells[0].OwningRow.Cells["makh"].Value.ToString();
            string masb1 = cbSanBay.SelectedValue.ToString();
            DUA_DOAN_SAN_BAY ddsb= db.DUA_DOAN_SAN_BAY.Find(masb,makh);
            SAN_BAY s = db.SAN_BAY.Find(masb1);
            ddsb.TuDiaDiem= s.TenSB;
            ddsb.DenDiaDiem = cbKhuVuc.SelectedItem.ToString();
            ddsb.NgayDon = dt_ngaydon.Value.Date;
            db.SaveChanges();
            MessageBox.Show("Đã Sửa");
            loaddata();
        }
        public void tongsove()
        {
            int cout = db.DUA_DOAN_SAN_BAY.Count();
            lb_tongve.Text = cout.ToString();
        }
        private void DuaDonSanBayAD_Load(object sender, EventArgs e)
        {
            loaddata();
            loadata1();
            tongsove();
        }

        private void dtgv_datxe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            binding();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            remove();
            tongsove();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            var result = from c in db.DUA_DOAN_SAN_BAY
                         where c.KHACH_HANG.TenKH.Contains(txt_ten_kh.Text)
                         select new { masb = c.MaSB, tudiadiem = c.TuDiaDiem, dendiadiem = c.DenDiaDiem, ngaydon = c.NgayDon, giodon = c.GioDoan, makh = c.MaKH, tenkh = c.KHACH_HANG.TenKH, tongtien = c.tongtien };
            dtgv_datxe.DataSource = result.ToList();
            if (dtgv_datxe.RowCount == 0)
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
            if (cb_sapxep.SelectedIndex == 0)
            {
                var result = from c in db.DUA_DOAN_SAN_BAY
                             orderby c.KHACH_HANG.TenKH
                             select new { masb = c.MaSB, tudiadiem = c.TuDiaDiem, dendiadiem = c.DenDiaDiem, ngaydon = c.NgayDon, giodon = c.GioDoan, makh = c.MaKH, tenkh = c.KHACH_HANG.TenKH, tongtien = c.tongtien };
                dtgv_datxe.DataSource = result.ToList();
            }
            else
            {
                var result = from c in db.DUA_DOAN_SAN_BAY
                             orderby c.tongtien
                             select new { masb = c.MaSB, tudiadiem = c.TuDiaDiem, dendiadiem = c.DenDiaDiem, ngaydon = c.NgayDon, giodon = c.GioDoan, makh = c.MaKH, tenkh = c.KHACH_HANG.TenKH, tongtien = c.tongtien };
                dtgv_datxe.DataSource = result.ToList();
            }
        }
    }
}
