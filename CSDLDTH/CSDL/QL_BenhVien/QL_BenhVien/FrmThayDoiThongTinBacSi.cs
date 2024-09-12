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
    public partial class FrmThayDoiThongTinBacSi : Form
    {
        public FrmThayDoiThongTinBacSi()
        {
            InitializeComponent();
        }

        public string getTen, getHo;
        public int BacSiSlectedID;
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            using (HOSPITALDBEntities1 context = new HOSPITALDBEntities1())
            {
                BacSi bacSi = context.BacSis.Find(BacSiSlectedID);

                if (bacSi != null)
                {
                    if (txtHo.Text == "" || txtTen.Text == "" || txtMK.Text == "")
                    {

                        MessageBox.Show("Sửa thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh nhân này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            bacSi.ho = txtHo.Text;
                            bacSi.ten = txtTen.Text;
                            bacSi.matkhau = txtMK.Text;
                            context.SaveChanges();
                            MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Đã hủy sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmThayDoiThongTinBacSi_Load(object sender, EventArgs e)
        {

        }
    }
}
