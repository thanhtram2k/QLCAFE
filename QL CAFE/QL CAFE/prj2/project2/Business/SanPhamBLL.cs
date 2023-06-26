﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using project2.Entities;
using project2.DataAccess;

namespace project2.Business
{
    class SanPhamBLL
    {
        //DataAccessHelper dah = new DataAccessHelper();
        SanPhamDAL bll = new SanPhamDAL();
        public DataTable LoadSP()
        {
            return bll.LoadSP();
        }
    
        public void ThemSP(string masp, string tensp, double dongia, string donvitinh,string loaisp)
        {
            bll.Them(new SanPham(masp,tensp,dongia,donvitinh,loaisp));
        }
        public void SuaSP(string masp, string tensp, double dongia, string donvitinh, string loaisp)
        {
            bll.Sua(new SanPham(masp,tensp,dongia,donvitinh,loaisp));
        }
        public void XoaSP(string masp, string tensp, double dongia, string donvitinh, string loaisp)
        {
            bll.Xoa(new SanPham(masp, tensp, dongia, donvitinh, loaisp));
        }
      
        public DataTable Listsp(string msp)
        {
            return bll.List1(msp);
        }
        public DataTable ListTensp(string tsp)
        {
            return bll.List2(tsp);
        }
        //public DataTable pxb(string sp)
        //{
        //    return bll.px(sp);
        //}
        public DataTable laygiaban(string gb)
        {
            return bll.laygia(gb);
        }
        public int tongbanghi(string masp)
        {
            return bll.DemBanGhi(masp);
        }
    }
}
