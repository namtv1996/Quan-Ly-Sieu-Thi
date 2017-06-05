namespace QLBanHangSieuThi.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        public int manv { get; set; }

        [StringLength(50)]
        public string hoten { get; set; }

        [StringLength(10)]
        public string gioitinh { get; set; }

        public DateTime? ngaysinh { get; set; }

        [StringLength(100)]
        public string diachi { get; set; }

        [StringLength(20)]
        public string lienhe { get; set; }

        public double? luong { get; set; }

        public int? machucvu { get; set; }

        public int? makho { get; set; }

        public virtual ChucVu ChucVu { get; set; }

        public virtual Kho Kho { get; set; }
    }
}
