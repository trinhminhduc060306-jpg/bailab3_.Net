using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03_OOPAdvanced
{

    using System;

    public class Nguoi
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public Nguoi(string hoTen, DateTime ngaySinh)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }
        public virtual string MoTa()
        {
            return HoTen + " - "
                + NgaySinh.ToString("dd/MM/yyyy");
        }
    }
    public class SinhVien : Nguoi
    {
        public string MaSV { get; set; }
        public double DiemTB { get; set; }
        public SinhVien(string hoTen, DateTime ngaySinh,
                        string ma, double diem)
            : base(hoTen, ngaySinh)
        {
            MaSV = ma;
            DiemTB = diem;
        }
        public override string MoTa()
        {
            return base.MoTa()
                + " - Ma SV: " + MaSV
                + " - Diem TB: " + DiemTB.ToString("N2");
        }
    }

}
