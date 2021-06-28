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
    public partial class frReport : Form
    {
        public frReport()
        {
            InitializeComponent();
        }

        private void frReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportHD.HOA_DON' table. You can move, or remove it, as needed.
            this.HOA_DONTableAdapter.Fill(this.ReportHD.HOA_DON);

            this.reportViewer1.RefreshReport();
        }
    }
}
