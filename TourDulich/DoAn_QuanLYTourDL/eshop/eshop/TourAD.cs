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
    public partial class TourAD : Form
    {
        public TourAD()
        {
            InitializeComponent();
        }
        TOUR_DULICHEntities2 db = new TOUR_DULICHEntities2();
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
        public void loaddata()
        {
            var result = from c in db.DATTOURs
                         select new { mavt = c.MAVET, tent = c.TENT, tient = c.TIENT, makh = c.MaKH };
            dtgv_tour.DataSource = result.ToList();

        }
        public void loadcombo()
        {
            var result = from c in db.TOURs
                         select c.TENT;
            cb_tentour.DataSource = result.ToList();
        }
        public void binding()
        {
            string mavt = dtgv_tour.SelectedCells[0].OwningRow.Cells["mavt"].Value.ToString();
            string tent = dtgv_tour.SelectedCells[0].OwningRow.Cells["tent"].Value.ToString();
            string tient = dtgv_tour.SelectedCells[0].OwningRow.Cells["tient"].Value.ToString();
            string makh = dtgv_tour.SelectedCells[0].OwningRow.Cells["makh"].Value.ToString();
            txt_mavt.Text = mavt;
            txt_tient.Text = tient;
            cb_tentour.SelectedItem = tent;
            txt_makh.Text = makh;
        }
        public void remove()
        {
            string mavt = dtgv_tour.SelectedCells[0].OwningRow.Cells["mavt"].Value.ToString();
            DATTOUR dt = db.DATTOURs.Where(ma => ma.MAVET == mavt).SingleOrDefault();
            db.DATTOURs.Remove(dt);
            db.SaveChanges();
            MessageBox.Show("Đã xóa");
            loaddata();
            tongsove();
        }
        public void update()
        {
                string mavt = dtgv_tour.SelectedCells[0].OwningRow.Cells["mavt"].Value.ToString();
                DATTOUR ve = db.DATTOURs.Find(mavt);
                ve.MAVET = txt_mavt.Text;
                ve.TENT = cb_tentour.SelectedItem.ToString();
                ve.TIENT = int.Parse(txt_tient.Text);
                ve.MaKH = txt_makh.Text;
                db.SaveChanges();
                MessageBox.Show("Đã Sửa");
                loaddata();
        }
        public void tongsove()
        {
            int cout = db.DATTOURs.Count();
            lb_tongve.Text = cout.ToString();
        }
        private void TourAD_Load(object sender, EventArgs e)
        {
            loaddata();
            loadcombo();
            tongsove();
        }

        private void dtgv_tour_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            var result = from c in db.DATTOURs
                         where c.TENT.Contains(txt_ten_tour.Text)
                         select new { mavt = c.MAVET, tent = c.TENT, tient = c.TIENT, makh = c.MaKH };
            dtgv_tour.DataSource = result.ToList();
            if (dtgv_tour.RowCount == 0)
            {
                MessageBox.Show("không tìm thấy tour");
            }
        }

        private void txt_ten_tour_TextChanged(object sender, EventArgs e)
        {
            if (txt_ten_tour.Text.Equals(""))
            {
                loaddata();
            }
        }
    }
}
