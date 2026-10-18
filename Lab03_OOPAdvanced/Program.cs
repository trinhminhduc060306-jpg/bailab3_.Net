namespace Lab03_OOPAdvanced
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            /* SinhVien sv = new SinhVien(
                 "Nguyen Van An",
                 new DateTime(2005, 5, 15),
                 "SV001",
                 8.5
             );

             Console.WriteLine(sv.HoTen);
             Console.WriteLine(sv.NgaySinh);
             Console.WriteLine(sv.MaSV);
             Console.WriteLine(sv.DiemTB);*/

            /*SinhVienChinhQuy sv1 = new SinhVienChinhQuy();
            sv1.HoTen = "Nguyen Van An";
            sv1.SoTinChi = 15;

            SinhVienLienThong sv2 = new SinhVienLienThong();
            sv2.HoTen = "Tran Van Binh";
            sv2.SoTinChi = 15;

            Console.WriteLine("Sinh vien: " + sv1.HoTen);
            Console.WriteLine("Hoc phi: " + sv1.TinhHocPhi().ToString("N0") + " VND");

            Console.WriteLine("Sinh vien: " + sv2.HoTen);
            Console.WriteLine("Hoc phi: " + sv2.TinhHocPhi().ToString("N0") + " VND");*/

            /*SinhVienBai4.SinhVien sv = new SinhVienBai4.SinhVien
            {
                MaSV = "SV001",
                HoTen = "Nguyen Van An",
                DiemTB = 11
            };

            if (sv.IsValid(out string message))
            {
                Console.WriteLine(sv.ToDisplayText());
                
            }
            else
            {
                Console.WriteLine(message);
                Console.WriteLine("Du lieu hop le");
            }*/
            List<NguoiHoc> ds = new List<NguoiHoc>();

            ds.Add(new SinhVienChinhQuy
            {
                HoTen = "An",
                SoTinChi = 18
            });

            ds.Add(new SinhVienLienThong
            {
                HoTen = "Binh",
                SoTinChi = 15
            });

            decimal tong = 0;

            foreach (NguoiHoc item in ds)
            {
                decimal hocPhi = item.TinhHocPhi();

                tong += hocPhi;

                Console.WriteLine("{0}: {1:N0}",
                    item.HoTen, hocPhi);
            }

            Console.WriteLine("Tong hoc phi: {0:N0}", tong);

        }
    }
}
