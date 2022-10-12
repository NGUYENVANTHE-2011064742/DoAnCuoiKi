namespace DoAnCuoiKi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DsTaiKhoan")]
    public partial class DsTaiKhoan
    {
        [Key]
        [StringLength(50)]
        public string TenDN { get; set; }

        [Required]
        [StringLength(50)]
        public string Pass { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }
    }
}
