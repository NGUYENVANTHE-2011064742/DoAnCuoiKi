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
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
        }
        Model1 kn = new Model1();
        List<NhanVien> listNhanViens;
        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                Model1 kn = new Model1();
                List<NhanVien> listNhanViens = kn.NhanViens.ToList();
                List<ChucVu> listChucVus = kn.ChucVus.ToList();
                dsChucVu(listChucVus);
                BinGird(listNhanViens);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dsChucVu(List<ChucVu> listChucVus)
        {
            this.cmbCV.DataSource = listChucVus;
            this.cmbCV.DisplayMember = "TenCV";
            this.cmbCV.ValueMember = "MaCV";
        }
        private void BinGird(List<NhanVien> listNhanViens)
        {
            dgvNhanVien.Rows.Clear();
            foreach (var item in listNhanViens)
            {
                int index = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[index].Cells[0].Value = item.MaNV;
                dgvNhanVien.Rows[index].Cells[1].Value = item.TenNV;
                dgvNhanVien.Rows[index].Cells[2].Value = item.MaCV;
                dgvNhanVien.Rows[index].Cells[3].Value = item.GioiTinh;
                dgvNhanVien.Rows[index].Cells[4].Value = item.DiaChi;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = txtMaNV.Text;
            nv.TenNV = txtTenNV.Text;
            nv.MaCV = cmbCV.SelectedValue.ToString();
            nv.GioiTinh = boy.Checked ? "Nam" : "Nu";
            nv.DiaChi = txtDiaChi.Text;
            kn.NhanViens.Add(nv);
            kn.SaveChanges();
            listNhanViens = kn.NhanViens.ToList();
            BinGird(listNhanViens);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.SelectedCells.Count > 0)
            {
                int selectRowindex = dgvNhanVien.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvNhanVien.Rows[selectRowindex];
                this.txtMaNV.Text = selectedRow.Cells[0].Value.ToString();
                this.txtTenNV.Text = selectedRow.Cells[1].Value.ToString();
                this.cmbCV.Text = selectedRow.Cells[2].Value.ToString();
                if (dgvNhanVien.Rows[e.RowIndex].Cells[3].FormattedValue.ToString() == "Nam")
                {
                    boy.Checked = true;
                }
                else
                    girl.Checked = true;
                this.txtDiaChi.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NhanVien nv = kn.NhanViens.FirstOrDefault(z => z.MaNV == txtMaNV.Text);
            nv.MaNV = txtMaNV.Text;
            nv.TenNV = txtTenNV.Text;
            nv.MaCV = cmbCV.SelectedValue.ToString();
            nv.GioiTinh = boy.Checked ? "Nam" : "Nu";
            nv.DiaChi = txtDiaChi.Text;
            kn.SaveChanges();
            listNhanViens = kn.NhanViens.ToList();
            BinGird(listNhanViens);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NhanVien nv = kn.NhanViens.FirstOrDefault(z => z.MaNV == txtMaNV.Text);
            kn.NhanViens.Remove(nv);
            kn.SaveChanges();
            listNhanViens = kn.NhanViens.ToList();
            BinGird(listNhanViens);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
