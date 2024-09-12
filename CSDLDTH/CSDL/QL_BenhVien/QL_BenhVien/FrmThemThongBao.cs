using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BenhVien
{
    public partial class FrmThemThongBao : Form
    {
        private HOSPITALDBEntities1 dbInit;
        public FrmThemThongBao()
        {
            InitializeComponent();
            dbInit = new HOSPITALDBEntities1();

        }

        DBConnect _conn = new DBConnect();
        public string getTaiKhoan,getHoTen;
        public int getIdAdmin;
        private void FrmThemThongBao_Load(object sender, EventArgs e)
        {

            lbIdTK.Text = getTaiKhoan;
            lbtenAdmin.Text = getHoTen;

            SqlCommand cmd = new SqlCommand("SELECT id FROM Admin WHERE taikhoan=@taikhoan", _conn.connection());
            cmd.Parameters.AddWithValue("@taikhoan", lbIdTK.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                getIdAdmin = Convert.ToInt16(dr[0]);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string noiDung = rtxtNoiDung.Text;

            ThongBao thongBao = new ThongBao
            {
                noidung = noiDung,
                id_admin = getIdAdmin
            };
            dbInit.ThongBaos.Add(thongBao);
            dbInit.SaveChanges();
            this.Close();
        }
    }
}
