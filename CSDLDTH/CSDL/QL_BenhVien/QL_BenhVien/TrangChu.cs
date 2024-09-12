using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BenhVien
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btn_BS_Click(object sender, EventArgs e)
        {
            FrmBacSiDangNhap frBS = new FrmBacSiDangNhap();
            frBS.Show();
            this.Hide();
        }

        private void btn_ad_Click(object sender, EventArgs e)
        {
            FrmAdminDangNhap frAd = new FrmAdminDangNhap();
            frAd.Show();
            this.Hide();
        }

        private void btn_BN_Click(object sender, EventArgs e)
        {
            FrmBenhNhanDangNhap frBN = new FrmBenhNhanDangNhap();
            frBN.Show();
            this.Hide();
        }
    }
}
