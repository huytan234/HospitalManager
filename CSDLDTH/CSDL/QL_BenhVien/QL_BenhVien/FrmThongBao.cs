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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QL_BenhVien
{
    public partial class FrmThongBao : Form
    {
        public FrmThongBao()
        {
            InitializeComponent();
        }

        DBConnect _conn = new DBConnect();
        public int thongBaoSelectedID;
        public string idTaikhoan, hoten;
        private void FrmThongBao_Load(object sender, EventArgs e)
        {
            lbIdTK.Text = idTaikhoan;
            lbtenAdmin.Text = hoten;

            SqlCommand cmd1 = new SqlCommand("SELECT ThongBao.id,noidung,(Admin.ho + ' ' + Admin.ten) FROM ThongBao " +
                "JOIN Admin ON ThongBao.id_admin = Admin.id", _conn.connection());

            DataTable dtThongBao = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            da.Fill(dtThongBao);
            dgvThongBao.DataSource = dtThongBao;


            dgvThongBao.Columns[0].HeaderText = "ID";
            dgvThongBao.Columns[1].HeaderText = "Nội dung";
            dgvThongBao.Columns[2].HeaderText = "Họ Tên Người Đăng";



            SqlDataReader dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                thongBaoSelectedID = Convert.ToInt16(dr[0]);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (HOSPITALDBEntities1 context = new HOSPITALDBEntities1())
            {
                ThongBao thongBao = context.ThongBaos.Find(thongBaoSelectedID);
                context.ThongBaos.Remove(thongBao);
                context.SaveChanges();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }

        private void dgvThongBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvThongBao.SelectedCells[0].RowIndex;
            thongBaoSelectedID = Convert.ToInt32(dgvThongBao.Rows[secilen].Cells[0].Value);

            label2.Text = thongBaoSelectedID.ToString();
        }

        private void btnRF_Click(object sender, EventArgs e)
        {
            dgvThongBao.Refresh();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FrmThemThongBao fr = new FrmThemThongBao();
            fr.getTaiKhoan = lbIdTK.Text;
            fr.getHoTen = lbtenAdmin.Text;
            fr.Show();
            this.Hide();
        }
    }
}
