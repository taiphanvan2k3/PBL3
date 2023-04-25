using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GiangVien_BLL
    {
        private static GiangVien_BLL _Instance;
        public static GiangVien_BLL Instance
        {
            get
            {
                if(_Instance == null)
                    _Instance = new GiangVien_BLL();
                return _Instance;
            }
        }
        public GiangVien_DTO GetGiangVienById(string id)
        {
            GIANG_VIEN gv = GiangVien_DAL.Instance.GetGiangVienByID(id);
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
                    MaKhoa = k.TenKhoa
                };
            }
            return null;
        }
        public List<string> GetClassSectionByID(string id)
        {
            return GiangVien_DAL.Instance.GetMaLopHPByID(id);
        }
        public List<AssignTeacher> GetGiangVienWithNumberLHP()
        {
            List<AssignTeacher> li = new List<AssignTeacher>();
            int stt = 1;
            foreach(var i in GiangVien_DAL.Instance.GetGiangVienWithNumberLHP())
            {
                li.Add(new AssignTeacher
                {
                    STT = stt,
                    MaGV = i.MaGV,
                    TenGV = i.TenGV,
                    SDT = i.SDT,
                    SoLuongHPPhuTrach = i.SoLuongHPPhuTrach
                });
                stt++;
            }
            return li;
        }
        public bool CheckTKBGiangVienConflict(string id, string thu, int TietBD, int TietKT)
        {
            return GiangVien_DAL.Instance.CheckTKBGiangVienConflict(id, thu, TietBD, TietKT);
        }
        public void AssignTeacherToSectionClass(string id, string thu, int TietBD, int TietKT, string phong, string MaLHP)
        {
            GiangVien_DAL.Instance.AssignTeacherToSectionClass(id, thu, TietBD, TietKT, phong, MaLHP);
        }
        public void AssignTeacherNoChangeSchedule(string id, string MaLHP)
        {
            GiangVien_DAL.Instance.AssignTeacherNoChangeSchedule(id, MaLHP);
        }
        #region Get List GV Suitable To Assign
        public List<AssignTeacher> GetGiangVienWithNumberLHPPhuHop(string MaLHP, string Thu, int? TietBD, int? TietKT)
        {
            List<AssignTeacher> li = new List<AssignTeacher>();
            int stt = 1;
            foreach (var i in GiangVien_DAL.Instance.GetGVPhuHopTKB(MaLHP,Thu,TietBD,TietKT))
            {
                li.Add(new AssignTeacher
                {
                    STT = stt,
                    MaGV = i.MaGV,
                    TenGV = i.TenGV,
                    SDT = i.SDT,
                    SoLuongHPPhuTrach = i.SoLuongHPPhuTrach
                });
                stt++;
            }
            return li;
        }
        #endregion
    }
}
