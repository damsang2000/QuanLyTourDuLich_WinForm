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
    public partial class HoaDonAD : Form
    {
        public HoaDonAD()
        {
            InitializeComponent();
        }
        TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
        public void loaddata()
        {
            var result = from c in db.HOA_DON
                         select new { mahd = c.MaHD, makh = c.MaKH,loaive=c.Loaive, soluongve=c.SoLuongVe, tongtien=c.TongTien};
            dtgv_hoadon.DataSource = result.ToList();

        }
        private void HoaDonAD_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void remove()
        {
            string mahd = dtgv_hoadon.SelectedCells[0].OwningRow.Cells["mahd"].Value.ToString();
            HOA_DON h = db.HOA_DON.Where(p =>p.MaHD==mahd).SingleOrDefault();
            db.HOA_DON.Remove(h);
            db.SaveChanges();
            MessageBox.Show("Đã xóa");
            loaddata();
        }
        public void update()
        {
            string mahd= dtgv_hoadon.SelectedCells[0].OwningRow.Cells["mahd"].Value.ToString();
            HOA_DON hd = db.HOA_DON.Find(mahd);
            if (int.Parse(FrTrangChuAD.sodem) <= 3)
                hd.TongTien = int.Parse(FrTrangChuAD.sokp) * 700000;
            else
                hd.TongTien = int.Parse(FrTrangChuAD.sokp) * 1000000;
            db.SaveChanges();
            MessageBox.Show("Đã Sửa");
            loaddata();
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            remove();
        }

        private void dtgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update();
        }

        private void btn_inhoadon_Click(object sender, EventArgs e)
        {
            frReport rp = new frReport();
            rp.Show();
        }
    }
}
