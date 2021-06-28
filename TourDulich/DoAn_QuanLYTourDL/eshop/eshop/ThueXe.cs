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
    public partial class ThueXe : Form
    {
        public ThueXe()
        {
            InitializeComponent();
        }

        private void cbTuChon_Click(object sender, EventArgs e)
        {
            string[] hg = { "có tài xế", "tự lái"};
            foreach (string s in hg)
            {
                cbTuChon.Items.Add(s);
            }
        }

        private void ThueXe_Load(object sender, EventArgs e)
        {
            cbViTriTraXe.Hide();
            btViTriTraXe.Hide();
        }

        private void cbViTriThue_Click(object sender, EventArgs e)
        {
            string[] dt = { "Hồ Chí Minh", "Hà Nội", "Đà Lạt", "Hà Giang", "Khác" };
            foreach (string s in dt)
            {
                cbViTriThue.Items.Add(s);
            }
        }

        private void ckViTriTraXe_CheckedChanged(object sender, EventArgs e)
        {
            btViTriTraXe.Show();
            if (ckViTriTraXe.Checked)
                cbViTriTraXe.Show();
            else
                cbViTriTraXe.Hide();

        }    
    }
}
