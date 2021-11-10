namespace TrangChu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANHSACH_NVL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANHSACH_NVL()
        {
            DANHSACHCANNHAP_NVL = new HashSet<DANHSACHCANNHAP_NVL>();
        }

        [Key]
        [StringLength(10)]
        public string MANVL { get; set; }

        [StringLength(50)]
        public string TENNVL { get; set; }

        [StringLength(10)]
        public string LOAI { get; set; }

        public DateTime? NGAYSX { get; set; }

        public DateTime? NGAYHH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHCANNHAP_NVL> DANHSACHCANNHAP_NVL { get; set; }
    }
}
