using sinhviens.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinhviens.DAL
{
    public class SinhVienDBContext:DbContext
    {
        public SinhVienDBContext()
            :base("Data Source=.;Initial Catalog=sinhvien;Persist Security Info=True;User ID=sa;Password=123")
        {

        }
        public DbSet<sinhvien> SinhVienDbSet { get; set; }
    }
}
