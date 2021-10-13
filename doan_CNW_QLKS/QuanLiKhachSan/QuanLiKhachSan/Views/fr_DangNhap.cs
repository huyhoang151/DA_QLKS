﻿using QuanLiKhachSan.DAO;
using QuanLiKhachSan.Data;
using QuanLiKhachSan.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan.Views
{
    public partial class fr_DangNhap : Form
    {
        public fr_DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;
            if (DangNhap.Instance.KtDangNhap(username, password) == true)
            {
                TaiKhoan TkDangNhap = TaiKhoanDAO.Instance.LayTKtuTenDN(username);
                fr_Main f = new fr_Main(TkDangNhap);
                this.Hide();
                f.Show();
            }
            else MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fr_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
