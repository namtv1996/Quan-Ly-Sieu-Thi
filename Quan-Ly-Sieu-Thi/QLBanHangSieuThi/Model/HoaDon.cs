namespace QLBanHangSieuThi.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        public int mahoadon { get; set; }

        public int? makh { get; set; }

        public int? mahh { get; set; }

        public int? soluong { get; set; }

        public DateTime? ngayxuat { get; set; }

        public double? tongtien { get; set; }

        public int? dathanhtoan { get; set; }

        public virtual HangHoa HangHoa { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
