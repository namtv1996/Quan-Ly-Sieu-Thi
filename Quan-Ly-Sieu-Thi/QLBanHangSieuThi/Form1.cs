using QLBanHangSieuThi.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangSieuThi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabPage1.Controls.Add(new ucHome());
            tabPage2.Controls.Add(new ucNhapHangHoa());
            tabPage3.Controls.Add(new ucXuatHangHoa());
            tabPage4.Controls.Add(new ucKhachHang());
            tabPage5.Controls.Add(new ucNhanSu());
            tabPage6.Controls.Add(new ucThongKe());
            tabPage7.Controls.Add(new ucHuongDan());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login l = new Login();
            l.Visible = true;
        }
    }
}
