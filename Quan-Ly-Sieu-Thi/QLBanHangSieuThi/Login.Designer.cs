namespace QLBanHangSieuThi
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.ckb_nho = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_tk
            // 
            this.txt_tk.ForeColor = System.Drawing.Color.DimGray;
            this.txt_tk.Location = new System.Drawing.Point(60, 48);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(215, 20);
            this.txt_tk.TabIndex = 1;
            this.txt_tk.Text = "Nhập tài khoản";
            this.txt_tk.Enter += new System.EventHandler(this.txt_tk_Enter);
            this.txt_tk.Leave += new System.EventHandler(this.txt_tk_Leave);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(200, 125);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // txt_mk
            // 
            this.txt_mk.ForeColor = System.Drawing.Color.DimGray;
            this.txt_mk.Location = new System.Drawing.Point(60, 86);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(215, 20);
            this.txt_mk.TabIndex = 2;
            this.txt_mk.Text = "Nhập mật khẩu";
            this.txt_mk.Enter += new System.EventHandler(this.txt_mk_Enter);
            this.txt_mk.Leave += new System.EventHandler(this.txt_mk_Leave);
            // 
            // ckb_nho
            // 
            this.ckb_nho.AutoSize = true;
            this.ckb_nho.Location = new System.Drawing.Point(60, 129);
            this.ckb_nho.Name = "ckb_nho";
            this.ckb_nho.Size = new System.Drawing.Size(46, 17);
            this.ckb_nho.TabIndex = 3;
            this.ckb_nho.Text = "Nhớ";
            this.ckb_nho.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 196);
            this.Controls.Add(this.ckb_nho);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_tk);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.CheckBox ckb_nho;
    }
}