using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03_OOPAdvanced
{
    internal class SinhVienBai4
    {
        public interface IValidatable
        {
            bool IsValid(out string message);
        }
        public interface IPrintable
        {
            string ToDisplayText();
        }
        public class SinhVien : IValidatable, IPrintable
        {
            public string MaSV { get; set; }
            public string HoTen { get; set; }
            public double DiemTB { get; set; }
            public bool IsValid(out string message)
            {
                if (string.IsNullOrWhiteSpace(MaSV)) { message = "Thiếu mã"; return false; }
                if (DiemTB < 0 || DiemTB > 10) { message = "Điểm sai"; return false; }
                message = ""; return true;
            }
            public string ToDisplayText() { return MaSV + " - " + HoTen+ " - " + DiemTB.ToString("N2"); }
        }
    }
}
