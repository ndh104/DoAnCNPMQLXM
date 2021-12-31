using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace QLXEMAY
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có thật sự muốn thoát ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            SqlConnection cnt = new SqlConnection(@"Data Source=DESKTOP-IB4CE96\BIGBOSS;Initial Catalog=QUANLYXEMAY;Integrated Security=True");
            try
            {
                cnt.Open();
                string tk = txtTK.Text;
                string mk = txtMK.Text;
                string sql = "select * from dbo.NhanVien where USERNAME ='" + tk + "' and PASSWORD ='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql,cnt);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công !","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //vào form main sau khi login
                    frmMain frm = new frmMain();
                    frm.Show();//hiển thị form Main
                    this.Hide();//ẩn form Login
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối !");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(tb == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTK_Click(object sender, EventArgs e)
        {
            txtTK.Text = "";
        }

        private void txtMK_Click(object sender, EventArgs e)
        {
            txtMK.Text = "";
            
        }
    }
}
