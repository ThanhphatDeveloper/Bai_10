using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        string connet = @"Data Source=NGUYEN-THANH-PH\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True";

        SqlDataAdapter dataAdapter = new SqlDataAdapter();

        DataSet dsSinhvien = new DataSet();// chứa dữ liệu
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSinhVienDataSet.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.qLSinhVienDataSet.Lop);
            // TODO: This line of code loads data into the 'qLSinhVienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLSinhVienDataSet.SinhVien);

            dataAdapter = new SqlDataAdapter("SELECT * FROM LOP", connet);// lấy dữ liệu

            dataAdapter.Fill(dsSinhvien, "tableLop");// đỗ dữ liệu vào dataset

            cbo_lop.DataSource = dsSinhvien.Tables["tableLop"].Copy();// tạo 1 đối tượng bản sao

            cbo_lop.DisplayMember = "TenLop";
            cbo_lop.ValueMember = "MaLop";


            


        }
    }
}
