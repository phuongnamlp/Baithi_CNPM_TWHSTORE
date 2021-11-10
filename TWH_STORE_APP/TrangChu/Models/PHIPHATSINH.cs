namespace TrangChu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIPHATSINH")]
    public partial class PHIPHATSINH
    {
        [Key]
        [StringLength(10)]
        public string MAPHIEU { get; set; }

        [StringLength(50)]
        public string NOIDUNG { get; set; }

        public int? CHIPHI { get; set; }
    }
}
