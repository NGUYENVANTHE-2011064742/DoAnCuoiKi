namespace DoAnCuoiKi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLSP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSP { get; set; }

        [Required]
        [StringLength(50)]
        public string DonViTinh { get; set; }

        public int GiaBan { get; set; }

        public string GhiChu { get; set; }

        public bool Xoa { get; set; }
    }
}
