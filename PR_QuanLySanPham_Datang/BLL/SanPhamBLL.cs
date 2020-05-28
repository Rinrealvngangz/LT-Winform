using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;
namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamAccess spa = new SanPhamAccess();
        public List<SanPham> LayToanBoSanPham()
        {
          
           return  spa.LayToanBoSanPham();
        }
        public bool XoaSp(int ma)
        {
            return spa.XoaSp(ma);
        }

        public bool ThemSanPham(SanPham sp)
        {
            if (sp.TenSp.Length == 0) return false;
            return spa.ThemSP(sp);
        }
    }
}
