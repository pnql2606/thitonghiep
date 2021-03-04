using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using QLBD.Class;

namespace QLBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            Loadbang();
        }
        DataTable tblCL;
        private void Loadbang()
        {
            string sql;
            sql = "SELECT * FROM BangDia";
            tblCL = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dataGridView1.DataSource = tblCL; //Nguồn dữ liệu            
            dataGridView1.Columns[0].HeaderText = "Mã Băng Đĩa";
            dataGridView1.Columns[1].HeaderText = "Tên Băng Đĩa";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Băng Đĩa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                return;
            }
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên Băng Đĩa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return;
            }
            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Số Lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn Thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=PC-26\\SQLEXPRESS;Initial Catalog=QuanLyBangDia;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("insert into BangDia(MaBD,Tenbangdia,Soluong) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "' )", con);
                con.Open(); // mo ket noi
                cmd.ExecuteNonQuery(); // thuc thi
                con.Close();
                Loadbang();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                this.Close();//thoát Form
                Application.Exit();//Thoát ứng dụng
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Băng Đĩa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                return;
            }
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên Băng Đĩa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return;
            }
            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Số Lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=PC-26\\SQLEXPRESS;Initial Catalog=QuanLyBangDia;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("update BangDia set MaBD='" + textBox1.Text + "',Tenbangdia='" + textBox2.Text + "',Soluong='" + textBox3.Text + "' where MaBD='" + textBox1.Text + "'", con);
                con.Open(); // mo ket noi
                cmd.ExecuteNonQuery(); // thuc thi
                con.Close();
                Loadbang();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Băng Đĩa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                return;
            }
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên Băng Đĩa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return;
            }
            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Số Lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=PC-26\\SQLEXPRESS;Initial Catalog=QuanLyBangDia;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("delete from BangDia  where MaBD='" + textBox1.Text + "'", con);
                con.Open(); // mo ket noi
                cmd.ExecuteNonQuery(); // thuc thi
                con.Close();
                Loadbang();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["MaBD"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Tenbangdia"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Soluong"].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
