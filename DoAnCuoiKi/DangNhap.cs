using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1DangKi_Click(object sender, EventArgs e)
        {
            DangKi dangKi = new DangKi();
            dangKi.Show();
        }

        private void button4QuenMK_Click(object sender, EventArgs e)
        {
            QuenMK quenMK = new QuenMK();
            quenMK.Show();
        }

        Modify modify = new Modify();
        private void button2DangNhap_Click(object sender, EventArgs e)
        {
            string tentk = textBox1DangNhap.Text;
            string matkhau = textBox2MK.Text;
            if(tentk.Trim()=="") { MessageBox.Show("VUI LÒNG NHẬP TK!");}
            else if (matkhau.Trim() == "") { MessageBox.Show("VUI LÒNG NHẬP MK!"); }
            else
            {
                string query = "Select * from DsTaiKhoan where TenDN = '" + tentk + "' and Pass = '"+matkhau+"'";
                if(modify.TaiKhoans(query).Count!=0)
                {
                    MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG!","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    GiaoDienChinh giaoDienChinh = new GiaoDienChinh();
                    giaoDienChinh.Show();
                }
                else
                {
                    MessageBox.Show("TÀI KHOẢN HOẶC MẬT KHẨU KHÔNG CHÍNH XÁC!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void button3Thoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN THOÁT KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
