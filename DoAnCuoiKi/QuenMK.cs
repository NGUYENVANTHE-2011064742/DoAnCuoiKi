﻿using System;
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
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
            label2.Text = "";
        }
        Modify modify = new Modify();
        private void button1LayLaiMK_Click(object sender, EventArgs e)
        {
            string email = textBox1Email.Text;
            if (email.Trim() == "") { MessageBox.Show("VVUI LÒNG NHẬP EMAIL ĐÃ ĐĂNG KÍ!"); }
            else
            {
                string query = "Select * from DsTaiKhoan where Email = '" + email + "'";
                if(modify.TaiKhoans(query).Count!=0)
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text = "MẬT KHẨU:" + modify.TaiKhoans(query)[0].Matkhau;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "EMAIL NÀY CHƯA ĐƯỢC ĐĂNG KÍ!";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
