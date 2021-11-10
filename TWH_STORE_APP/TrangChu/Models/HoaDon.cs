namespace TrangChu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        public int ID { get; set; }

        [Required]
        [StringLength(5)]
        public string SOBAN { get; set; }

        [Required]
        [StringLength(100)]
        public string TENMON { get; set; }

        public int GIATIEN { get; set; }

        [StringLength(20)]
        public string TRANGTHAI { get; set; }
    }
}
