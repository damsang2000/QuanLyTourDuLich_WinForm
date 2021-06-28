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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
        public void loaddata()
        {
            var result = from c in db.HOA_DON
                         select new { mahd = c.MaHD, makh = c.MaKH, loaive = c.Loaive, soluongve = c.SoLuongVe, tongtien = c.TongTien };
            dtgv_hoadon.DataSource = result.ToList();
            string sum = db.HOA_DON.Sum(t=>t.TongTien).ToString();
            lb_tongtien.Text = sum;

        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void lb_tiencombo_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
