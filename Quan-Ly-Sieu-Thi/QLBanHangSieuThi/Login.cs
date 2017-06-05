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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        // tạo watermarked (hình mờ)
        private void txt_tk_Enter(object sender, EventArgs e)
        {
            if(txt_tk.Text== "Nhập tài khoản")
            {
                txt_tk.Text = "";
                txt_tk.ForeColor = Color.Black;
            }
        }

        private void txt_tk_Leave(object sender, EventArgs e)
        {
            if (txt_tk.Text == "")
            {
                txt_tk.Text = "Nhập tài khoản";
                txt_tk.ForeColor = Color.DarkSlateGray;
            }
        }

        private void txt_mk_Enter(object sender, EventArgs e)
        {
            if (txt_mk.Text == "Nhập mật khẩu")
            {
                txt_mk.Text = "";
                txt_mk.PasswordChar = '*';
                txt_mk.ForeColor = Color.Black;
            }
        }

        private void txt_mk_Leave(object sender, EventArgs e)
        {
            if (txt_mk.Text == "")
            {
                txt_mk.Text = "Nhập mật khẩu";
                txt_mk.PasswordChar = '\0';
                txt_mk.ForeColor = Color.DarkSlateGray;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_tk.Text=="Nhập tài khoản" || txt_tk.Text == "")
            {
                MessageBox.Show("Nhập vào thông tin tài khoản");
            }
            if(txt_mk.Text=="Nhập mật khẩu" || txt_mk.Text == "")
            {
                MessageBox.Show("Nhập vào thông tin mật khẩu");
            }
            if (txt_tk.Text == "admin" && txt_mk.Text == "admin")
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
        }
    }
}
