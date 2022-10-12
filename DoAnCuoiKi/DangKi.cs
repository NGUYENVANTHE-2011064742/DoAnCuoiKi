using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace DoAnCuoiKi
{
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }
        public bool checkTK(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-z0-9]{3,24}$");
        }
        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox1TenDN.Text;
            string matkhau = textBox2MK.Text;
            string xnMK = textBox3MK.Text;
            string email = textBox4Email.Text;
            if(!checkTK(tentk)) { MessageBox.Show("VUI LÒNG NHẬP TÊN TK TỪ 3-24 KÝ TỰ,BAO GỒM CHỮ VÀ SỐ, CHỮ HOA VÀ CHỮ THƯỜNG!");return; }
            if (!checkTK(matkhau)) { MessageBox.Show("VUI LÒNG NHẬP MẬT KHẨU TỪ 3-24 KÝ TỰ,BAO GỒM CHỮ VÀ SỐ, CHỮ HOA VÀ CHỮ THƯỜNG!"); return; }
            if(xnMK != matkhau) { MessageBox.Show("MẬT KHẨU XÁC NHẬN CHƯA ĐÚNG!");return; }
            if(!checkEmail(email)) { MessageBox.Show("VUI LÒNG NHẬP EMAIL ĐÚNG ĐỊNH DẠNG!"); return; }
            if(modify.TaiKhoans("Select * from DsTaiKhoan where Email = '"+email+"' ").Count != 0) { MessageBox.Show("EMAIL NÀY ĐÃ ĐƯỢC ĐĂNG KÍ");return; }
            try
            {
                string query = "Insert into DsTaiKhoan values('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);
                if (MessageBox.Show("ĐĂNG KÍ THÀNH CÔNG, BẠN CÓ MUỐN ĐĂNG NHẬP NGAY BÂY GIỜ KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("TÊN TÀI KHOẢN NÀY ĐÃ ĐƯỢC ĐĂNG KÍ!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}