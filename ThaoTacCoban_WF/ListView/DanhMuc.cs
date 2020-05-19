using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView
{
   public class DanhMuc
    {
        public string masp { get;set; }
        public string tensp { get; set; }
        public List<SanPham> Sanphams { get; set; }

        public DanhMuc() {

            Sanphams = new List<SanPham>();
        }
        public void themsp(SanPham sp)
        {
            Sanphams.Add(sp);
            sp.Nhom = this;
        }
    }
}
