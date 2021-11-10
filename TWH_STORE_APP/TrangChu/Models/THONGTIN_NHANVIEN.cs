namespace TrangChu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class THONGTIN_NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THONGTIN_NHANVIEN()
        {
            BANGLUONGs = new HashSet<BANGLUONG>();
            USERS = new HashSet<USER>();
        }

        [Key]
        [StringLength(10)]
        public string MANV { get; set; }

        [StringLength(50)]
        public string TENNV { get; set; }

        [StringLength(10)]
        public string GIOITINH { get; set; }

        public DateTime? NGAYSINH { get; set; }

        [StringLength(13)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        [StringLength(20)]
        public string CHUCVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANGLUONG> BANGLUONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER> USERS { get; set; }
    }
}
