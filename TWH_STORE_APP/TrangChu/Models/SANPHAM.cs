namespace TrangChu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [Key]
        [StringLength(10)]
        public string MAMON { get; set; }

        [Required]
        [StringLength(100)]
        public string NAME { get; set; }

        public int GIA { get; set; }
    }
}
