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
    public partial class KhachSanAD : Form
    {
        public KhachSanAD()
        {
            InitializeComponent();
        }
        TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
        public static string sokp = "";
        public static string sodem = "";
        public void loaddata()
        {
            var result = from c in db.KHACH_SAN
                         select new { maks = c.MaKS, tenks = c.TenKS, ngaynp = c.NgayNhanPhong, ngaytp = c.NgayTraPhong, sophong = c.SoPhong, Songay = c.SoNgayO, khtrenphong = c.KhachTrenMotPhong, tenkh = c.KHACH_HANG.TenKH, tongtien = c.tongtien };
            dtgv_phong.DataSource = result.ToList();

        }
        public void loaddata1()
        {
            cbViTri.Items.Clear();
            cbSoDem.Items.Clear();
            cb_khachtrenphong.Items.Clear();
            cb_sophong.Items.Clear();
            string[] sx = { "Sắp xếp theo tên", "Sắp xếp theo giá" };
            for (int i = 1; i <= 30; i++)
            {
                cbSoDem.Items.Add(i);
            }
            for (int i = 1; i <= 4; i++)
            {
                cb_khachtrenphong.Items.Add(i);
            }
            for (int i = 1000; i <= 1050; i++)
            {
                cb_sophong.Items.Add(i);
            }
            foreach (string s in sx)
            {
                cb_sapxep.Items.Add(s);
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
        public void binding()
        {
            string maks = dtgv_phong.SelectedCells[0].OwningRow.Cells["maks"].Value.ToString();
            string tenks = dtgv_phong.SelectedCells[0].OwningRow.Cells["tenks"].Value.ToString();
            string ngaynp = dtgv_phong.SelectedCells[0].OwningRow.Cells["ngaynp"].Value.ToString();
            string ngaytp = dtgv_phong.SelectedCells[0].OwningRow.Cells["ngaytp"].Value.ToString();
            string sodem = dtgv_phong.SelectedCells[0].OwningRow.Cells["Songay"].Value.ToString();
            string sophong = dtgv_phong.SelectedCells[0].OwningRow.Cells["sophong"].Value.ToString();
            string khachtrenphong = dtgv_phong.SelectedCells[0].OwningRow.Cells["khtrenphong"].Value.ToString();
            cbViTri.SelectedValue= tenks;
            dt_nhanphong.Value = Convert.ToDateTime(ngaynp);
            dt_traphong.Value = Convert.ToDateTime(ngaytp);
            cbSoDem.SelectedItem=int.Parse(sodem);
            cb_sophong.SelectedItem=int.Parse(sophong);
            cb_khachtrenphong.SelectedItem =int.Parse(khachtrenphong);
        }
        public void remove()
        {
            string maks = dtgv_phong.SelectedCells[0].OwningRow.Cells["maks"].Value.ToString();
            KHACH_SAN h = db.KHACH_SAN.Where(p => p.MaKS == maks).SingleOrDefault();
            db.KHACH_SAN.Remove(h);
            db.SaveChanges();
            MessageBox.Show("Đã xóa");
            loaddata();
            tongsove();
        }
        public void tongsove()
        {
            int cout = db.KHACH_SAN.Count();
            lb_tongve.Text = cout.ToString();
        }
        private void KhachSanAD_Load(object sender, EventArgs e)
        {
            loaddata();
            loaddata1();
            loadcombo();
            tongsove();
        }
        public void update()
        {
                string maks = dtgv_phong.SelectedCells[0].OwningRow.Cells["maks"].Value.ToString();
                KHACH_SAN ks = db.KHACH_SAN.Find(maks);
                ks.TenKS = cbViTri.SelectedValue.ToString();
                ks.NgayNhanPhong = dt_nhanphong.Value.Date;
                ks.NgayTraPhong = dt_traphong.Value.Date;
                ks.SoNgayO = int.Parse(cbSoDem.SelectedItem.ToString());
                if (ks.SoNgayO <= 3)
                {
                    ks.tongtien = int.Parse(cb_khachtrenphong.SelectedItem.ToString()) * 700000;
                }
                else
                {
                    ks.tongtien = int.Parse(cb_khachtrenphong.SelectedItem.ToString()) * 1000000;
                }
                ks.KhachTrenMotPhong = int.Parse(cb_khachtrenphong.SelectedItem.ToString());
                ks.SoPhong = int.Parse(cb_sophong.SelectedItem.ToString());
                sodem = cbSoDem.SelectedItem.ToString();
                sokp = cb_khachtrenphong.SelectedItem.ToString();
                db.SaveChanges();
                MessageBox.Show("Đã Sửa");
                loaddata();
            
        }
        private void dtgv_phong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            binding();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            remove();
        }

        private void cbSoDem_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt_traphong.Value = dt_nhanphong.Value.AddDays(int.Parse(cbSoDem.SelectedItem.ToString()));
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            var result = from c in db.KHACH_SAN
                         where c.KHACH_HANG.TenKH.Contains(txt_ten_kh.Text)
                         select new { maks = c.MaKS, tenks = c.TenKS, ngaynp = c.NgayNhanPhong, ngaytp = c.NgayTraPhong, sophong = c.SoPhong, Songay = c.SoNgayO, khtrenphong = c.KhachTrenMotPhong, tenkh = c.KHACH_HANG.TenKH, tongtien = c.tongtien };
            dtgv_phong.DataSource = result.ToList();
            if (dtgv_phong.RowCount == 0)
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
                var result = from c in db.KHACH_SAN
                             orderby c.KHACH_HANG.TenKH
                             select new { maks = c.MaKS, tenks = c.TenKS, ngaynp = c.NgayNhanPhong, ngaytp = c.NgayTraPhong, sophong = c.SoPhong, Songay = c.SoNgayO, khtrenphong = c.KhachTrenMotPhong, tenkh = c.KHACH_HANG.TenKH, tongtien = c.tongtien };
                dtgv_phong.DataSource = result.ToList();
            }
            else
            {
                var result = from c in db.KHACH_SAN
                             orderby c.tongtien
                             select new { maks = c.MaKS, tenks = c.TenKS, ngaynp = c.NgayNhanPhong, ngaytp = c.NgayTraPhong, sophong = c.SoPhong, Songay = c.SoNgayO, khtrenphong = c.KhachTrenMotPhong, tenkh = c.KHACH_HANG.TenKH, tongtien = c.tongtien };
                dtgv_phong.DataSource = result.ToList();
            }
        }
    }
}
