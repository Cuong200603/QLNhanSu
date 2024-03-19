using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using Microsoft.VisualBasic;


namespace QuanLyNhanVien
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string sex;
        string connectstring = @"Data Source=CUONGYOUNG\CHUMINHCUONG;Initial Catalog=QLNHANSU;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();
        DataTable table3 = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Employees";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgVNhanSu.DataSource = table;
            dgVThongKe.DataSource = table;
        }
        void loaddata1()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Departments";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dgVPhongBan.DataSource = table1;
        }
        void loaddata2()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from JobTitles";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            dgVChucVu.DataSource = table2;
        }

        public Form1()
        {
            InitializeComponent();
            //Kết nối Combobox MaPhong
            SqlDataAdapter da = new SqlDataAdapter("select * from Departments", connectstring);
            DataTable ba = new DataTable();
            da.Fill(ba);
            cbbMaPhong.DataSource = ba;
            cbbMaPhong.DisplayMember = "department_id";
            cbbMaPhong.ValueMember = "department_id";
            cbbSreachMaPhong.DataSource = ba;
            cbbSreachMaPhong.DisplayMember = "department_id";
            cbbSreachMaPhong.ValueMember = "department_id";
            //Kết nối Combobox MaChucVu
            SqlDataAdapter tg = new SqlDataAdapter("select * from JobTitles", connectstring);
            DataTable bb = new DataTable();
            tg.Fill(bb);
            cbbChucVu.DataSource = bb;
            cbbChucVu.DisplayMember = "job_title_id";
            cbbChucVu.ValueMember = "job_title_id";
            cbbSreachChucVu.DataSource = bb;
            cbbSreachChucVu.DisplayMember = "job_title_id";
            cbbSreachChucVu.ValueMember = "job_title_id";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectstring);
            connection.Open();
            loaddata();
            loaddata1();
            loaddata2();
        }

        private void btThemNS_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Employees values (N'" + tbMaNV.Text + "',N'" + tbTenNV.Text + "',N'" + dtNgaySinh.Text + "',N'" + sex + "',N'" + tbDiaChi.Text + "',N'" + tbGmail.Text + "',N'" + tbSDT.Text + "',N'" + cbbMaPhong.Text + "',N'" + cbbChucVu.Text + "',N'" + tbLuong.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            sex = "Nam";
        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {
            sex = "Nữ";
        }

        private void btSuaNS_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Employees set employee_id =N'" + tbMaNV.Text + "',name =N'" + tbTenNV.Text + "',date_of_birth=N'" + dtNgaySinh.Text + "',gender =N'" + sex + "',address =N'" + tbDiaChi.Text + "',email =N'" + tbGmail.Text + "',phone_number =N'" + tbSDT.Text + "',department_id =N'" + cbbMaPhong.Text + "',job_title_id = N'" + cbbChucVu.Text + "',salary = N'" + tbLuong.Text + "' where employee_id =N'" + tbMaNV.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btXoaNS_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Employees where  employee_id =N'" + tbMaNV.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void dgVNhanSu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaNV.ReadOnly = true;
            int i;
            i = dgVNhanSu.CurrentRow.Index;
            tbMaNV.Text = dgVNhanSu.Rows[i].Cells[0].Value.ToString();
            tbTenNV.Text = dgVNhanSu.Rows[i].Cells[1].Value.ToString();
            dtNgaySinh.Text = dgVNhanSu.Rows[i].Cells[2].Value.ToString();
            sex = dgVNhanSu.Rows[i].Cells[3].Value.ToString();
            tbDiaChi.Text = dgVNhanSu.Rows[i].Cells[4].Value.ToString();
            tbGmail.Text = dgVNhanSu.Rows[i].Cells[5].Value.ToString();
            tbSDT.Text = dgVNhanSu.Rows[i].Cells[6].Value.ToString();
            cbbMaPhong.Text = dgVNhanSu.Rows[i].Cells[7].Value.ToString();
            cbbChucVu.Text = dgVNhanSu.Rows[i].Cells[8].Value.ToString();
            tbLuong.Text = dgVNhanSu.Rows[i].Cells[9].Value.ToString();
        }

        private void btThemPB_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Departments values (N'" + tbMaPhong.Text + "',N'" + tbTenPhong.Text + "')";
            command.ExecuteNonQuery();
            loaddata1();
            loaddata();
        }

        private void btSuaPB_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE Departments SET department_id = N'" + tbMaPhong.Text + "', department_name = N'" + tbTenPhong.Text + "' WHERE department_id = N'" + tbMaPhong.Text + "'";
            command.ExecuteNonQuery();
            loaddata1();
            loaddata();
        }

        private void btXoaPB_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Departments where  department_id =N'" + tbMaPhong.Text + "'";
            command.ExecuteNonQuery();
            loaddata1();
            loaddata();
        }

        private void dgVPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgVPhongBan.CurrentRow.Index;
            tbMaPhong.Text = dgVPhongBan.Rows[i].Cells[0].Value.ToString();
            tbTenPhong.Text = dgVPhongBan.Rows[i].Cells[1].Value.ToString();
        }

        private void btThemCV_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into JobTitles values (N'" + tbMaCV.Text + "',N'" + tbTenCV.Text + "')";
            command.ExecuteNonQuery();
            loaddata2();
            loaddata();
        }

        private void btSuaCV_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE JobTitles SET job_title_id = N'" + tbMaCV.Text + "',title_name = N'" + tbTenCV.Text + "' WHERE job_title_id = N'" + tbMaCV.Text + "'";
            command.ExecuteNonQuery();
            loaddata2();
            loaddata();
        }

        private void btXoaCV_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from JobTitles where  job_title_id = N'" + tbMaCV.Text + "'";
            command.ExecuteNonQuery();
            loaddata2();
            loaddata();
        }

        private void dgVChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgVChucVu.CurrentRow.Index;
            tbMaCV.Text = dgVChucVu.Rows[i].Cells[0].Value.ToString();
            tbTenCV.Text = dgVChucVu.Rows[i].Cells[1].Value.ToString();
        }

        private void btSreachTK_Click(object sender, EventArgs e)
        {
            string employeeID = tbSreachMaNV.Text;
            string employeeName = tbSreachTen.Text;
            string departmentID = cbbSreachMaPhong.Text;
            string jobTitle = cbbSreachChucVu.Text;

            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Employees WHERE " +
                "(employee_id = N'" + employeeID + "' OR N'" + employeeID + "' IS NULL) AND " +
               // "(name = N'" + employeeName + "' OR N'" + employeeName + "' IS NULL) AND " +
                "(department_id = N'" + departmentID + "' OR N'" + departmentID + "' IS NULL) AND " +
                "(job_title_id = N'" + jobTitle + "' OR N'" + jobTitle + "' IS NULL)";
            adapter.SelectCommand = command;
            table3.Clear();
            adapter.Fill(table3);
            if (table3.Rows.Count == 0)
            {
                MessageBox.Show("Không có nhân viên nào");
                dgVThongKe.DataSource = new DataTable();
            }
            else
            {
                dgVThongKe.DataSource = table3;
            }
        }

        private void btXoaTK_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Employees where  employee_id =N'" + tbMaNV.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}