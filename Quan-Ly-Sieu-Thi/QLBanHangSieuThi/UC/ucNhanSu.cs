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
using System.Data.SqlClient;

namespace QLBanHangSieuThi.UC
{
    public partial class ucNhanSu : UserControl
    {
        public ucNhanSu()
        {
            InitializeComponent();
            Load += UcNhanSu_Load;
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnSave.Click += BtnSave_Click;
            btnReload.Click += BtnReload_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSearch.Click += BtnSearch_Click;
            dgvList.CellClick += DgvList_CellClick;
            dgvList.DataError += DgvList_DataError;

            LockControl();
        }

        private bool edit;

        private void DgvList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // DO NOTHING HERE
        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var row = dgvList.CurrentRow)
            {
                txtEmployeeID.Text = row.Cells["manv"].Value.ToString();
                txtEmployeeName.Text = row.Cells["hoten"].Value.ToString();
                txtSalary.Text = row.Cells["luong"].Value.ToString();
                txtContact.Text = row.Cells["lienhe"].Value.ToString();
                txtAddress.Text = row.Cells["diachi"].Value.ToString();
                dtpDoB.Value = (DateTime)row.Cells["ngaysinh"].Value;
                cmbOffice.SelectedValue = row.Cells["machucvu"].Value;
                cmbStorage.SelectedValue = row.Cells["makho"].Value;
                rbnMale.Checked = row.Cells["gioitinh"].Value.ToString().Equals("Nam") ? true : false;
            }

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchBox.Text != string.Empty)
            {
                using (var db = new MyContext())
                {
                    dgvList.DataSource = db.Database.SqlQuery<NhanVien>("sp_nv_timkiem @value",
                        new object[]
                        {
                        new SqlParameter("@value", txtSearchBox.Text)
                        }).ToList();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == string.Empty)
            {
                MessageBox.Show("Chọn thông tin để xóa!");
                return;
            }
            using (var db = new MyContext())
            {
                try
                {
                    int res = 0;
                    var id = int.Parse(txtEmployeeID.Text);
                    var emp = db.NhanViens.Find(id);
                    if (emp != null && MessageBox.Show("Xóa thông tin", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.NhanViens.Remove(emp);
                        res = db.SaveChanges();
                    }

                    if (res > 0)
                    {
                        MessageBox.Show("Đã xóa!");
                        LoadData();
                        RefreshControl();
                        LockControl();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            RefreshControl();
            LockControl();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text == string.Empty || (edit && txtEmployeeID.Text == string.Empty))
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
                        var id = int.Parse(txtEmployeeID.Text);
                        var emp = db.NhanViens.Find(id);
                        if (emp != null)
                        {
                            emp.hoten = txtEmployeeName.Text;
                            emp.lienhe = txtContact.Text;
                            emp.diachi = txtAddress.Text;
                            emp.gioitinh = rbnFemale.Checked ? "Nữ" : "Nam";
                            emp.luong = double.Parse(txtSalary.Text);
                            emp.ngaysinh = (DateTime)dtpDoB.Value;
                            emp.makho = (int)cmbStorage.SelectedValue;
                            emp.machucvu = (int)cmbOffice.SelectedValue;

                            res = db.SaveChanges();
                        }
                    }
                    else
                    {
                        db.NhanViens.Add(new NhanVien()
                        {
                            hoten = txtEmployeeName.Text,
                            lienhe = txtContact.Text,
                            diachi = txtAddress.Text,
                            gioitinh = rbnFemale.Checked ? "Nữ" : "Nam",
                            luong = double.Parse(txtSalary.Text),
                            ngaysinh = (DateTime)dtpDoB.Value,
                            makho = (int)cmbStorage.SelectedValue,
                            machucvu = (int)cmbOffice.SelectedValue
                        });
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
            btnDelete.Enabled = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LockControl();
            UnlockControl();
            RefreshControl();
            edit = false;
        }

        private void LoadData()
        {
            using (var db = new MyContext())
            {
                dgvList.DataSource = db.NhanViens.ToList();
            }
        }

        private void UcNhanSu_Load(object sender, EventArgs e)
        {
            LoadData();
            using (var db = new MyContext())
            {
                cmbStorage.DataSource = db.Khoes.ToList();
                cmbStorage.DisplayMember = "tenkho";
                cmbStorage.ValueMember = "makho";

                cmbOffice.DataSource = db.ChucVus.ToList();
                cmbOffice.ValueMember = "machucvu";
                cmbOffice.DisplayMember = "tenchucvu";
            }
        }

        private void LockControl()
        {
            txtEmployeeID.Enabled = false;
            txtEmployeeName.Enabled = false;
            txtAddress.Enabled = false;
            txtContact.Enabled = false;
            txtSalary.Enabled = false;
            dtpDoB.Enabled = false;
            cmbOffice.Enabled = false;
            cmbStorage.Enabled = false;
            rbnFemale.Enabled = false;
            rbnMale.Enabled = false;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }

        private void UnlockControl()
        {
            txtEmployeeName.Enabled = true;
            txtAddress.Enabled = true;
            txtContact.Enabled = true;
            txtSalary.Enabled = true;
            dtpDoB.Enabled = true;
            cmbOffice.Enabled = true;
            cmbStorage.Enabled = true;
            rbnFemale.Enabled = true;
            rbnMale.Enabled = true;

            btnSave.Enabled = true;
        }

        private void RefreshControl()
        {
            txtEmployeeID.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtSalary.Text = string.Empty;
            dtpDoB.Value = DateTime.Now;
        }
    }
}
