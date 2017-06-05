using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangSieuThi.UC
{
    public partial class ucHuongDan : UserControl
    {
        public ucHuongDan()
        {
            InitializeComponent();
            webBrowser2.Navigate(@"C:\Users\namtv1996\Desktop\GITHUB-PROJECT\Quan  Ly Sieu Thi\Quan-Ly-Sieu-Thi\Quan-Ly-Sieu-Thi\QLBanHangSieuThi\File\huong-dan-Ql-sieu-thi.htm");
        }
    }
}
