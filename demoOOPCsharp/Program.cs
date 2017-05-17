using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demoOOPCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SinhVien sv1 = new SinhVien();
            sv1.ten = "Lam";
            sv1.maSinhVien = "A321";
            SinhVien sv2 = new SinhVien("A123", "Khoa học", "Hoang123@gmail.com");
            sv2.ten = "Hoàng";

            List<SinhVien> listSV = new List<SinhVien>();
            listSV.Add(sv1);
            listSV.Add(sv2);

            for (int i = 0; i < listSV.Count; i++)
            {
                listSV[i].gioithieu();
                listSV[i].hoctap();
                listSV[i].nghenhac();
                listSV[i].luyentapThethao();
                listSV[i].uongCapheSang();
                listSV[i].docsach();
                listSV[i].sudungMayTinh();
            }

            NhanVien nv1 = new NhanVien();
            nv1.ten = "Mai";
            nv1.phongBan = "Khoa giáo";
            nv1.maNhanVien = "I001";
            NhanVien nv2 = new NhanVien("I100", "Giám khảo", 10000000);
            nv2.ten = "Đông";

            List<NhanVien> listNV = new List<NhanVien>();
            listNV.Add(nv1);
            listNV.Add(nv2);

            for(int j = 0; j < listNV.Count; j++)
            {
                listNV[j].gioithieu();
                listNV[j].sudungMayTinh();
                listNV[j].choiCobac();
                listNV[j].uongRuou();
                listNV[j].hutThuoc();
            }

            Console.ReadKey();
        }
    }

    public class SinhVien : ConNguoi, HoatDongTichCuc
    {
        public string maSinhVien { get; set; }
        public string lop { get; set; }
        public string email { get; set; }

        public SinhVien()
        {

        }

        public SinhVien(string maSinhVien, string lop, string email)
        {
            this.maSinhVien = maSinhVien;
            this.lop = lop;
            this.email = email;
        }

        public new void gioithieu()
        { 
            Console.WriteLine("Tôi là " + ten + ", tôi là sinh viên với mã số là " + maSinhVien);
        }

        public void docsach()
        {
            Console.WriteLine("Sinh viên " + ten + " đọc sách");
        }

        public void hoctap()
        {
            Console.WriteLine("Sinh viên " + ten + " học tập");
        }

        public void luyentapThethao()
        {
            Console.WriteLine("Sinh viên " + ten + " luyện tập thể thao");
        }

        public void nghenhac()
        {
            Console.WriteLine("Sinh viên " + ten + " nghe nhạc");
        }

        public void uongCapheSang()
        {
            Console.WriteLine("Sinh viên " + ten + " uống cà phê sáng");
        }

        public override void sudungMayTinh()
        {
            Console.WriteLine("Sinh viên " + ten + " sử dụng máy tính");
        }
    }

    public class NhanVien : ConNguoi, HoatDongTieuCuc
    {
        public string maNhanVien { get; set; }
        public string phongBan { get; set; }
        public double mucluong { get; set; }

        public NhanVien()
        {

        }

        public NhanVien(string maNhanVien, string phongBan, double mucluong)
        {
            this.maNhanVien = maNhanVien;
            this.phongBan = phongBan;
            this.mucluong = mucluong;
        }

        public new void gioithieu()
        {
            Console.WriteLine("Tôi là " + ten + ", tôi là nhân viên phòng " + phongBan + " với mã số là " + maNhanVien);
        }

        public override void sudungMayTinh()
        {
            Console.WriteLine("Nhân viên " + ten + " sử dụng máy tính");
        }

        public void choiCobac()
        {
            Console.WriteLine("Nhân viên " + ten + " chơi cờ bạc");
        }

        public void uongRuou()
        {
            Console.WriteLine("Nhân viên " + ten + " uống rượu");
        }

        public void hutThuoc()
        {
            Console.WriteLine("Nhân viên " + ten + " hút thuốc");
        }
    }
}