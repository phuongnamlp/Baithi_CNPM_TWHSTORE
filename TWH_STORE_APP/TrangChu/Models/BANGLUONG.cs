namespace TrangChu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANGLUONG")]
    public partial class BANGLUONG
    {
        [Key]
        [StringLength(10)]
        public string MABANGLUONG { get; set; }

        [Required]
        [StringLength(10)]
        public string MANV { get; set; }

        [StringLength(50)]
        public string TENNV { get; set; }

        public int? TongNgayLam { get; set; }

        public int? TongNgayVang { get; set; }

        [Column(TypeName = "money")]
        public decimal? TIENLUONG { get; set; }

        [Column(TypeName = "money")]
        public decimal? LUONGTHUONG { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONGLUONG { get; set; }

        public virtual THONGTIN_NHANVIEN THONGTIN_NHANVIEN { get; set; }
    }
}
