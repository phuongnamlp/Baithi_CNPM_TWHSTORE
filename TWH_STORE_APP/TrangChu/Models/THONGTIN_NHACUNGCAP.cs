namespace TrangChu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class THONGTIN_NHACUNGCAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THONGTIN_NHACUNGCAP()
        {
            DANHSACHCANNHAP_NVL = new HashSet<DANHSACHCANNHAP_NVL>();
        }

        [Key]
        [StringLength(10)]
        public string MANCC { get; set; }

        [StringLength(50)]
        public string TENNCC { get; set; }

        [StringLength(13)]
        public string SDT { get; set; }

        [StringLength(30)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        [StringLength(50)]
        public string LOAIHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHCANNHAP_NVL> DANHSACHCANNHAP_NVL { get; set; }
    }
}
