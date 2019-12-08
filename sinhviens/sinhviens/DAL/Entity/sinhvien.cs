using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinhviens.DAL.Entity
{
    public class sinhvien
    {
        [Key]
        public string MSV { get; set; }
        public string HoTen { get; set; }
        public Boolean GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string TenKhoa { get; set; }
        public string  Diem1 { get; set; }
        public string Diem2 { get; set; }

        public static List<sinhvien> GetSinhVien()
        {
            return new SinhVienDBContext().SinhVienDbSet.Select(p=>p).ToList();
        }
        public static void Add(sinhvien sv)
        {
            var db = new SinhVienDBContext();
            db.SinhVienDbSet.Add(sv);
            db.SaveChanges();
        }
        public static void Remove(sinhvien sv)
        {
            var db = new SinhVienDBContext();
            var objSV = db.SinhVienDbSet.Where(e => e.MSV == sv.MSV).FirstOrDefault();
            if (objSV != null)
                db.SinhVienDbSet.Remove(objSV);
            db.SaveChanges();
        }
        public static void Edit(sinhvien sv)
        {
            var db = new SinhVienDBContext();
            var objSV = db.SinhVienDbSet.Where(e => e.MSV == sv.MSV).FirstOrDefault();
            if (objSV != null)
            {
                objSV.HoTen = sv.HoTen;
                //objSV.NgaySinh = sv.NgaySinh;

            }
            db.SaveChanges();
        }
    }
}
