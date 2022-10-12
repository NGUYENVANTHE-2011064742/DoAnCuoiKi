using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi
{
    class TaiKhoan
    {
        private string tentk;
        private string matkhau;

        public TaiKhoan()
        {
        }

        public TaiKhoan(string tentk, string matkhau)
        {
            this.tentk = tentk;
            this.matkhau = matkhau;
        }

        public string Tentk { get => tentk; set => tentk = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}
