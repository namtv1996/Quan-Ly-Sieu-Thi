using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHangSieuThi.Model;
using QLBanHangSieuThi.Object;

namespace QLBanHangSieuThi.UC
{
    public partial class ucThongKe : UserControl
    {
        public ucThongKe()
        {
            InitializeComponent();
            Load += UcThongKe_Load;
        }

        private void LoadData()
        {
            using (var db = new MyContext())
            {
                foreach (var item in db.Database.SqlQuery<ThongKe>("sp_hh_thongkenhap", new object[] { }))
                {
                    chart1.Series["Nhap"].Points.AddXY(item.ngay.Day,
                        new object[] { item.soluong });
                }
                foreach (var item in db.Database.SqlQuery<ThongKe>("sp_hh_thongkexuat", new object[] { }))
                {
                    chart1.Series["Ban"].Points.AddXY(item.ngay.Day,
                        new object[] { item.soluong });
                }
            }
        }

        private void UcThongKe_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
