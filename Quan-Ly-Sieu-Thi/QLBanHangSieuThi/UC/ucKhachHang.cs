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
using System.Data.SqlClient;

namespace QLBanHangSieuThi.UC
{
    public partial class ucKhachHang : UserControl
    {
        public ucKhachHang()
        {
            InitializeComponent();
            Load += UcKhachHang_Load;
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            dgvList.DataError += DgvList_DataError;
            btnSearch.Click += BtnSearch_Click;
            dgvList.CellClick += DgvList_CellClick;
            btnReload.Click += BtnReload_Click;

            LockControl();
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            RefreshControl();
            LockControl();
        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LockControl();

            using (var row = dgvList.CurrentRow)
            {
                txtCustomerID.Text = row.Cells["makh"].Value.ToString();
                txtCustomerName.Text = row.Cells["hoten"].Value.ToString();
                txtContact.Text = row.Cells["lienhe"].Value.ToString();
                txtAddress.Text = row.Cells["diachi"].Value.ToString();
                dtpDoB.Value = (DateTime)row.Cells["ngaysinh"].Value;
                rbnMale.Checked = row.Cells["gioitinh"].Value.ToString().Equals("Nam") ? true : false;
            }

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private bool edit;

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchBox.Text != string.Empty)
            {
                using (var db = new MyContext())
                {
                    dgvList.DataSource = db.Database.SqlQuery<KhachHang>("sp_kh_timkiem " +
                        "@value", new object[]
                        {
                            new SqlParameter("@value", txtSearchBox.Text)
                        }).ToList();
                }
            }
        }

        private void DgvList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // DO NOTHING HERE
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == string.Empty)
            {
                MessageBox.Show("Chọn thông tin để xóa!");
                return;
            }
            using (var db = new MyContext())
            {
                try
                {
                    var id = int.Parse(txtCustomerID.Text);
                    var cus = db.KhachHangs.Find(id);
                    if (cus != null && MessageBox.Show("Xóa thông tin?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.KhachHangs.Remove(cus);
                        int res = db.SaveChanges();
                        if (res > 0)
                        {
                            MessageBox.Show("Đã xóa!");
                            LoadData();
                            LockControl();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == string.Empty || (edit && txtCustomerID.Text == string.Empty))
            {
                MessageBox.Show("Nhập thông tin!");
                return;
            }

            using (var db = new MyContext())
            {
                try
                {
                    int res = 0;
                    if (edit)
                    {
                        var id = int.Parse(txtCustomerID.Text);
                        var customer = db.KhachHangs.Find(id);
                        if (customer != null)
                        {
                            customer.hoten = txtCustomerName.Text;
                            customer.lienhe = txtContact.Text;
                            customer.gioitinh = rbnFemale.Checked ? "Nữ" : "Nam";
                            customer.diachi = txtAddress.Text;
                            customer.ngaysinh = dtpDoB.Value;

                            res = db.SaveChanges();
                        }
                    }
                    else
                    {
                        var customer = new KhachHang()
                        {
                            hoten = txtCustomerName.Text,
                            lienhe = txtContact.Text,
                            gioitinh = rbnFemale.Checked ? "Nữ" : "Nam",
                            diachi = txtAddress.Text,
                            ngaysinh = dtpDoB.Value
                        };
                        db.KhachHangs.Add(customer);
                        res = db.SaveChanges();
                    }
                    if (res > 0)
                    {
                        MessageBox.Show("Đã cập nhật");
                        LoadData();
                        LockControl();
                        RefreshControl();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            UnlockControl();
            edit = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LockControl();
            UnlockControl();
            edit = false;
            RefreshControl();
        }

        private void LoadData()
        {
            using (var db = new MyContext())
            {
                dgvList.DataSource = db.KhachHangs.ToList();
            }
            dgvList.Columns[0].HeaderText = "Mã";
            dgvList.Columns[1].HeaderText = "Tên";
            dgvList.Columns[2].HeaderText = "Ngày sinh";
            dgvList.Columns[3].HeaderText = "Giới tính";
            dgvList.Columns[4].HeaderText = "Địa chỉ";
            dgvList.Columns[5].HeaderText = "Liên hệ";
            dgvList.Columns[6].HeaderText = "Hóa đơn";
        }

        private void UcKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LockControl()
        {
            txtCustomerID.Enabled = false;
            txtCustomerName.Enabled = false;
            txtAddress.Enabled = false;
            txtContact.Enabled = false;
            dtpDoB.Enabled = false;
            rbnFemale.Enabled = false;
            rbnMale.Enabled = false;

            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void UnlockControl()
        {
            txtCustomerName.Enabled = true;
            txtAddress.Enabled = true;
            txtContact.Enabled = true;
            dtpDoB.Enabled = true;
            rbnFemale.Enabled = true;
            rbnMale.Enabled = true;

            btnSave.Enabled = true;
        }

        private void RefreshControl()
        {
            txtCustomerID.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtContact.Text = string.Empty;
            dtpDoB.Value = DateTime.Now;
        }
    }
}
