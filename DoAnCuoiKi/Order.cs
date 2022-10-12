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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        private void LoaiMon(List<LoaiSanPham> listLoaiSanPham)
        {
            this.cmbLoai.DataSource = listLoaiSanPham;
            this.cmbLoai.DisplayMember = "MaLSP";
            this.cmbLoai.ValueMember = "TenLSP";
        }
        private void BindGridMon(List<SanPham> listSanPham)
        {
            dgvMon.Rows.Clear();
            foreach (var item in listSanPham)
            {
                int index = dgvMon.Rows.Add();
                dgvMon.Rows[index].Cells[0].Value = item.MaSP;
                dgvMon.Rows[index].Cells[1].Value = item.TenSP;
                dgvMon.Rows[index].Cells[2].Value = item.MaLSP;
                dgvMon.Rows[index].Cells[3].Value = item.GiaBan;
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            try
            {
                Model1 ct = new Model1();
                List<LoaiSanPham> list = ct.LoaiSanPhams.ToList();
                LoaiMon(list);
                List<SanPham> listSanPham = ct.SanPhams.ToList();
                BindGridMon(listSanPham);
                txtMaHDD.Text = (ct.HoaDons.Max(p => p.MaHD)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Model1 ct = new Model1();
                List<SanPham> listSanPham = (from p in ct.SanPhams
                                             where p.MaLSP == cmbLoai.Text
                                             select p).ToList();
                BindGridMon(listSanPham);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMon.Text = dgvMon.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtGia.Text = dgvMon.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        void clear()
        {
            txtSL.Clear();
            txtSL.Focus();
            txtGia.Clear();
            txtMon.Clear();
        }

        string tinhTongTien()
        {
            int total = 0;
            for (int i = 0; i < dgvMonDaChon.Rows.Count; i++)
            {
                total += Convert.ToInt32(dgvMonDaChon.Rows[i].Cells[3].Value);
            }
            return total.ToString();
        }

        private void btnChonMon_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtMon.Text == "" || txtGia.Text == ""))
                    throw new Exception("MỜI BẠN CHỌN MÓN");
                else
                {
                    for (int i = 0; i < dgvMonDaChon.Rows.Count; i++)
                    {
                        if (dgvMonDaChon.Rows[i].Cells[0].FormattedValue.ToString() == txtMon.Text)
                            throw new Exception("MÓN NÀY ĐÃ CÓ TRONG THỰC ĐƠN \n" +
                                "VUI LÒNG XÓA RỒI THÊM MỚI");
                    }

                    if (txtSL.Text == "" || txtSL.Text == null)
                    {
                        txtSL.Text = "1";
                    }
                    int index = dgvMonDaChon.Rows.Add();
                    dgvMonDaChon.Rows[index].Cells[0].Value = txtMon.Text;
                    dgvMonDaChon.Rows[index].Cells[2].Value = txtGia.Text;
                    dgvMonDaChon.Rows[index].Cells[1].Value = txtSL.Text;
                    dgvMonDaChon.Rows[index].Cells[3].Value = (int.Parse(txtSL.Text) * int.Parse(txtGia.Text)).ToString();
                    clear();
                    txtTongTien.Text = tinhTongTien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "THÔNG BÁO");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMonDaChon.Rows.Count == 0)
                    throw new Exception("BẠN CHƯA CHỌN MÓN \n VUI LÒNG CHỌN MÓN");
                foreach (DataGridViewCell oneCell in dgvMonDaChon.SelectedCells)
                {
                    if (oneCell.Selected)
                        dgvMonDaChon.Rows.RemoveAt(oneCell.RowIndex);
                }
                txtTongTien.Text = tinhTongTien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtTongTien.Text == "")
            {
                MessageBox.Show("BẠN CHƯA CHỌN MÓN, VUI LÒNG CHỌN ÍT NHẤT MỘT MÓN!", "THÔNG BÁO");
            }
            else
            {
                ThanhToanMoMo th = new ThanhToanMoMo();
                th.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MỜI QUÝ THANH TOÁN BẰNG TIỀN MẶT CHO THU NGÂN!", "THÔNG TIN");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTongTien.Text == "")
            {
                MessageBox.Show("BẠN CHƯA CHỌN MÓN, VUI LÒNG CHỌN ÍT NHẤT MỘT MÓN!", "THÔNG BÁO");
            }
            else
            {
                TtATM ttATM = new TtATM();
                ttATM.Show();
            }
        }
    }
}
