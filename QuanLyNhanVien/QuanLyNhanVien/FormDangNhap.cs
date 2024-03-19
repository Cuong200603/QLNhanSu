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

namespace QuanLyNhanVien
{
    public partial class FormDangNhap : Form
    {
        SqlConnection connection;
        string connectstring = @"Data Source=CUONGYOUNG\CHUMINHCUONG;Initial Catalog=QLNHANSU;Integrated Security=True";
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectstring);
            connection.Open();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string username = tbTaiKhoan.Text;
            string password = tbMatKhau.Text;

            string query = "SELECT COUNT(*) FROM Account WHERE username = @username AND password = @password";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    // Đăng nhập thành công, chuyển sang Form1
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                }
            }
        }
    }
}
