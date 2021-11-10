namespace TrangChu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USERS")]
    public partial class USER
    {
        [Key]
        [StringLength(10)]
        public string TAIKHOAN { get; set; }

        [Required]
        [StringLength(10)]
        public string MATKHAU { get; set; }

        [Required]
        [StringLength(10)]
        public string MANV { get; set; }

        public int IDQUYEN { get; set; }

        public virtual QUYEN QUYEN { get; set; }

        public virtual THONGTIN_NHANVIEN THONGTIN_NHANVIEN { get; set; }
    }
}
