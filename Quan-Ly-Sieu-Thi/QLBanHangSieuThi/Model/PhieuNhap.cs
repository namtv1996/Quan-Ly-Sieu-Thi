namespace QLBanHangSieuThi.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhap")]
    public partial class PhieuNhap
    {
        [Key]
        public int maphieu { get; set; }

        public int? mancc { get; set; }

        public int? mahh { get; set; }

        public int? soluong { get; set; }

        public DateTime? ngaynhap { get; set; }

        [StringLength(100)]
        public string diadiem { get; set; }

        public double? tonggia { get; set; }

        public virtual HangHoa HangHoa { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
