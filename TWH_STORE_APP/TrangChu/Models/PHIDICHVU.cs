namespace TrangChu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIDICHVU")]
    public partial class PHIDICHVU
    {
        [Key]
        [StringLength(10)]
        public string MAPHIEUDV { get; set; }

        [Required]
        [StringLength(100)]
        public string NOIDUNG { get; set; }

        public int CHIPHI { get; set; }
    }
}
