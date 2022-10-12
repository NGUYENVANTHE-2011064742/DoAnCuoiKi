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
    public partial class GiaoDienChinh : Form
    {
        public GiaoDienChinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN ĐĂNG XUẤT KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) ;
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLNhanVien qLNhanVien = new QLNhanVien();
            qLNhanVien.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuanLiMon quanLiMon = new QuanLiMon();
            quanLiMon.Show();
        }
    }
}
