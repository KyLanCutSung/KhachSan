﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class taikhoan
    {
        private string tentaikhoan;
        private string matkhau;

        public taikhoan()
        {

        }
        public taikhoan(string tentaikhoan, string matkhau)
        {
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
        }
        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}