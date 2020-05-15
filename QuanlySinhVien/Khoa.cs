using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlySinhVien
{
    [Serializable]
    public class Khoa
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public Dictionary<string,LopHoc> Lops
        {
            get; set;
        }
        public Khoa()
        {
           Lops = new Dictionary<string, LopHoc>();
        }
        public override string ToString()
        {
            return TenKhoa;
        }
    }
}
