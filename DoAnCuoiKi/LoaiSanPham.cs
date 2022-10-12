namespace DoAnCuoiKi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiSanPham")]
    public partial class LoaiSanPham
    {
        [Key]
        [StringLength(10)]
        public string MaLSP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLSP { get; set; }

        public string GhiChu { get; set; }

        public bool Xoa { get; set; }
    }
}
