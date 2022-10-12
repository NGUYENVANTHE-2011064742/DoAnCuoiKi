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
    public partial class QuanLiMon : Form
    {
        public QuanLiMon()
        {
            InitializeComponent();
        }
        Model1 kn = new Model1();
        List<SanPham> listSanPhams;
        private void QuanLiMon_Load(object sender, EventArgs e)
        {
            try
            {
                Model1 kn = new Model1();
                List<SanPham> listSanPhams = kn.SanPhams.ToList();
                List<LoaiSanPham> listLoaiSanPhams = kn.LoaiSanPhams.ToList();
                dsLoaiSanPham(listLoaiSanPhams);
                BinGird(listSanPhams);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dsLoaiSanPham(List<LoaiSanPham> loaiSanPhams)
        {
            this.cmbLoaiSP.DataSource = loaiSanPhams;
            this.cmbLoaiSP.DisplayMember = "TenLSP";
            this.cmbLoaiSP.ValueMember = "MaLSP";
        }
        private void BinGird(List<SanPham> listSanPhams)
        {
            dgvMon.Rows.Clear();
            foreach (var item in listSanPhams)
            {
                int index = dgvMon.Rows.Add();
                dgvMon.Rows[index].Cells[0].Value = item.MaSP;
                dgvMon.Rows[index].Cells[1].Value = item.MaLSP;
                dgvMon.Rows[index].Cells[2].Value = item.TenSP;
                dgvMon.Rows[index].Cells[3].Value = item.DonViTinh;
                dgvMon.Rows[index].Cells[4].Value = item.GiaBan;
                dgvMon.Rows[index].Cells[5].Value = item.GhiChu;
            }
        }

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMon.SelectedCells.Count > 0)
            {
                int selectRowindex = dgvMon.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvMon.Rows[selectRowindex];
                this.txtMaSP.Text = selectedRow.Cells[0].Value.ToString();
                this.cmbLoaiSP.Text = selectedRow.Cells[1].Value.ToString();
                this.txtTenSP.Text = selectedRow.Cells[2].Value.ToString();
                this.txtDVT.Text = selectedRow.Cells[3].Value.ToString();
                this.txtGiaBan.Text = selectedRow.Cells[4].Value.ToString();
                this.txtGhiChu.Text = selectedRow.Cells[5].Value?.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = txtMaSP.Text;
            sp.MaLSP = cmbLoaiSP.SelectedValue.ToString();
            sp.TenSP = txtTenSP.Text;
            sp.DonViTinh = txtDVT.Text;
            sp.GiaBan = int.Parse(txtGiaBan.Text);
            sp.GhiChu = txtGhiChu.Text;
            kn.SanPhams.Add(sp);
            kn.SaveChanges();
            listSanPhams = kn.SanPhams.ToList();
            BinGird(listSanPhams);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SanPham sp = kn.SanPhams.FirstOrDefault(z => z.MaSP == this.txtMaSP.Text);
            sp.MaSP = txtMaSP.Text;
            sp.MaLSP = cmbLoaiSP.SelectedValue.ToString();
            sp.TenSP = txtTenSP.Text;
            sp.DonViTinh = txtDVT.Text;
            sp.GiaBan = int.Parse(txtGiaBan.Text);
            sp.GhiChu = txtGhiChu.Text;
            kn.SaveChanges();
            listSanPhams = kn.SanPhams.ToList();
            BinGird(listSanPhams);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SanPham sp = kn.SanPhams.FirstOrDefault(z => z.MaSP == this.txtMaSP.Text);
            kn.SanPhams.Remove(sp);
            kn.SaveChanges();
            listSanPhams = kn.SanPhams.ToList();
            BinGird(listSanPhams);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
