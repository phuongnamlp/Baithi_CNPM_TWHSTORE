namespace TrangChu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANHSACHCANNHAP_NVL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDLOAI { get; set; }

        [Required]
        [StringLength(10)]
        public string MANVL { get; set; }

        [Required]
        [StringLength(50)]
        public string LOAIHANG { get; set; }

        public int? SOLUONG { get; set; }

        [Required]
        [StringLength(10)]
        public string MANCC { get; set; }

        public virtual DANHSACH_NVL DANHSACH_NVL { get; set; }

        public virtual THONGTIN_NHACUNGCAP THONGTIN_NHACUNGCAP { get; set; }
    }
}
