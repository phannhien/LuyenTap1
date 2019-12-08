using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG12019.DAL.Entity
{
    public class QuaTrinhHocTap
    {
        [Key]
        public string MaQuaTrinhHocTap { get; set; }
        public int TuNam { get; set; }
        public int DenNam { get; set; }
        public string ThoiGianHoc
        {
            get
            {
                return string.Format("{0} -> {1}", TuNam, DenNam);
            }
        }
        public string HocTai { get; set; }
        public string MaSinhVien { get; set; }
        [ForeignKey("MaSinhVien")]
        public virtual SinhVien SinhVien { get; set; }

        /// <summary>
        /// Lấy danh sách quá trình học tập của 1 SINH VIÊN từ MockData     
        /// </summary>
        /// <param name="maSinhVien">Mã sinh viên của sinh viên cần lấy</param>
        /// <returns>Danh sách quá trình học tập</returns>
        public static List<QuaTrinhHocTap> GetList(string maSinhVien)
        {
            List<QuaTrinhHocTap> listQuaTrinhHocTap = new List<QuaTrinhHocTap>();
            for(int i = 0; i < 5; i++)
            {
                QuaTrinhHocTap quaTrinhHocTap = new QuaTrinhHocTap
                {
                    MaQuaTrinhHocTap = i.ToString(),
                    TuNam = 1990 + i,
                    DenNam = 1990 + i + 1,
                    HocTai = "Phan Bội Châu",
                    MaSinhVien = maSinhVien
                };
                listQuaTrinhHocTap.Add(quaTrinhHocTap);
            }
            return listQuaTrinhHocTap;
        }

        /// <summary>
        /// Lấy danh sách quá trình học tập của sinh viên từ File
        /// </summary>
        /// <param name="pathData">Đường dẫn file chứa dữ liệu</param>
        /// <param name="maSinhVien">Mã sinh viên cần lấy dữ liệu</param>
        /// <returns>Danh sách quá trình học tập của sinh viên có mã là maSinhVien</returns>
        public static List<QuaTrinhHocTap> GetListFromFile(string pathData, string maSinhVien)
        {
            var arrayLines = File.ReadAllLines(pathData);
            List<QuaTrinhHocTap> ketQua = new List<QuaTrinhHocTap>();
            foreach(var line in arrayLines)
            {
                var lsValue = line.Split(new char[] { '#' });
                var quaTrinhHocTap = new QuaTrinhHocTap
                {
                    MaSinhVien = lsValue[0],
                    MaQuaTrinhHocTap = lsValue[1],
                    TuNam = Convert.ToInt32(lsValue[2]),
                    DenNam = Int32.Parse(lsValue[3]),
                    HocTai = lsValue[4]
                };
                if (quaTrinhHocTap.MaSinhVien == maSinhVien)
                    ketQua.Add(quaTrinhHocTap);
            }
            return ketQua;
        }
        public static int getMaqTHTFinal(string pathDataLearningHistory, string maSinhVien)
        {
            List<QuaTrinhHocTap> list = QuaTrinhHocTap.GetListFromFile(pathDataLearningHistory, maSinhVien);
            return Int32.Parse(list[list.Count - 1].MaQuaTrinhHocTap);
        }
        public static void Remove(string pathDataLearningHistory, string maQuaTrinhHocTap)
        {
            string[] lines = File.ReadAllLines(pathDataLearningHistory);

            // Xóa hết
            File.WriteAllText(pathDataLearningHistory, "");

            // Ghi lại nếu không trùng mã 
            using (StreamWriter writer = new StreamWriter(pathDataLearningHistory))
            {
                foreach (string line in lines)
                {
                    var lsValue = line.Split('#');
                    string maQTHT = lsValue[1];
                    if (!maQTHT.Contains(maQuaTrinhHocTap))
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }

        public static void updateQTHT(string pathDataLearningHistory, string maSV, string maQTHT, int tuNam, int denNam, string hocTai)
        {
            // Lấy dữ liệu
            string[] data = File.ReadAllLines(pathDataLearningHistory);
            // Xóa hết
            File.WriteAllText(pathDataLearningHistory, "");

            using (StreamWriter writer = new StreamWriter(pathDataLearningHistory))
            {
                foreach (string line in data)
                {
                    // Kiểm tra nếu trung mã QTHT 
                    if (line.Contains(maQTHT))
                    {
                        writer.WriteLine(maSV + "#" + maQTHT + "#" + tuNam + "#" + denNam + "#" + hocTai);
                    }
                    else
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }

        public static void addQTHT(string pathDataLearningHistory, string maSV, int tuNam, int denNam, string hocTai)
        {
            int maQTHT = getMaqTHTFinal(pathDataLearningHistory, maSV) + 1;
            using (StreamWriter writer = new StreamWriter(pathDataLearningHistory, true))
            {
                writer.WriteLine(maSV + "#" + maQTHT + "#" + tuNam + "#" + denNam + "#" + hocTai);
                writer.Flush();
                writer.Close();
            }
        }

        internal static void Remove(string v1, object pathDatalearningHistory, string v2, string maQuaTrinhHocTap)
        {
            throw new NotImplementedException();
        }
    }
}