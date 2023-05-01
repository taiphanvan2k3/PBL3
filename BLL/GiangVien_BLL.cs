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
                    QuocTich = nd.QuocTich,
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
        public List<string> GetListLHPByIDTeacher(string id)
        {
            return GiangVien_DAL.Instance.GetMaLopHPByID(id);
        }
        public void SendNoticeToLHP(string MaGV, string MaLHP, string TieuDe, string NoiDung, DateTime NgayTao)
        {
            GiangVien_DAL.Instance.SendNoticeToLHP(MaGV,MaLHP,TieuDe, NoiDung, NgayTao);
        }
        public bool CheckNoticeRedundanṭ̣̣̣(string MaGV, DateTime NgayTao, string MaLHP)
        {
            return GiangVien_DAL.Instance.CheckNoticeRedundanṭ̣̣̣(MaGV, NgayTao, MaLHP);
        }
        public void ReplaceNotice(string MaGV, DateTime NgayTao, string MaLHP, string TieuDe, string NoiDung)
        {
            GiangVien_DAL.Instance.ReplaceNotice(MaGV, NgayTao, MaLHP, TieuDe, NoiDung);
        }
        public int GetNumberQuestionForMonHoc(string MaLHP)
        {
            return GiangVien_DAL.Instance.GetNumberQuestionForMonHoc(MaLHP);
        }
        public void CreateExam(string TenBKT, string LoaiBaiKiemTra, byte ThoiGianLamBai, DateTime NgayKiemTra,
                               byte SoCauHoi, string MaLHP, string MaGV, string MatKhauLamBai, bool ChoPhepQuayLai)
        {
            GiangVien_DAL.Instance.CreateExam(TenBKT, LoaiBaiKiemTra, ThoiGianLamBai, NgayKiemTra, SoCauHoi, MaLHP, 
                                              MaGV, MatKhauLamBai, ChoPhepQuayLai);
        }
        public bool CheckScheduleExamConflict(DateTime TimeExam, byte ThoiGianLamBai, string MaLHPForAll)
        {
            return GiangVien_DAL.Instance.CheckScheduleExamConflict(TimeExam, ThoiGianLamBai, MaLHPForAll);
        }
        public void CreateQuestion(string TenCauHoi, string DapAnA, string DapAnB, string DapAnC, string DapAnD, string DapAnDung, string MaMonHoc, string PhanLoai)
        {
            GiangVien_DAL.Instance.CreateQuestion(TenCauHoi,DapAnA,DapAnB,DapAnC,DapAnD,DapAnDung, MaMonHoc, PhanLoai);
        }
        public List<CBBItem> GetMonHocInKhoaForGV(string MaGV)
        {
            return GiangVien_DAL.Instance.GetMonHocInKhoaForGV(MaGV);
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
