using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GiangVienBLL
    {
        private static GiangVienBLL _Instance;
        public static GiangVienBLL Instance
        {
            get
            {
                if(_Instance == null)
                    _Instance = new GiangVienBLL();
                return _Instance;
            }
        }
        public GiangVien_DTO GetGiangVienById(string id)
        {
            GIANG_VIEN gv = GiangVien_DAL.GetGiangVienByID(id);
            if(gv != null)
            {
                NGUOI_DUNG nd = gv.NGUOI_DUNG;
                KHOA k = gv.KHOA;
                return new GiangVien_DTO()
                {
                    MaNguoiDung = nd.MaNguoiDung,
                    MaCCCD = nd.MaCCCD,
                    Ho = nd.Ho,
                    Ten = nd.Ten,
                    AnhCaNhan = nd.AnhCaNhan,
                    NgaySinh = nd.NgaySinh,
                    GioiTinh = nd.GioiTinh,
                    DanToc = nd.DanToc,
                    QuocTinh = nd.QuocTich,
                    NoiSinh = nd.NoiSinh,
                    DiaChi = nd.DiaChi,
                    Sdt = nd.Sdt,
                    EmailCaNhan = nd.EmailCaNhan,
                    EmailTruongCap = nd.EmailTruongCap,
                    TrinhDo = gv.TrinhDo,
                    Luong = gv.Luong,
                    Khoa = k.TenKhoa
                };
            }
            return null;
        }
    }
}
