namespace DoAnCuoiKi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLap { get; set; }

        [Required]
        [StringLength(50)]
        public string TenMon { get; set; }

        [Required]
        [StringLength(10)]
        public string SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaTien { get; set; }

        [Column(TypeName = "money")]
        public decimal Tong { get; set; }
    }
}
