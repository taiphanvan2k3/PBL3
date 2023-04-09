using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class PhuHuynh_BLL
    {
        private static PhuHuynh_DTO ConvertToPhuHuynhDTO(PHU_HUYNH ph)
        {
            return new PhuHuynh_DTO()
            {
                MaSV = ph.MaSV,
                TenPH = ph.TenPH,
                GioiTinh = ph.GioiTinh,
                Sdt = ph.Sdt,
                DiaChi = ph.DiaChi,
                NgaySinh = ph.NgaySinh,
                MoiQuanHe = ph.MoiQuanHe
            };
        }
        public static List<PhuHuynh_DTO> GetPhuHuynhByIdStudent(string mssv)
        {
            List<PHU_HUYNH> li = PhuHuynh_DAL.GetPhuHuynhByIdStudent(mssv);
            if (li == null)
                return null;
            List<PhuHuynh_DTO> res = new List<PhuHuynh_DTO>();
            foreach (PHU_HUYNH ph in li)
            {
                res.Add(ConvertToPhuHuynhDTO(ph));
            }
            return res;
        }
    }
}
