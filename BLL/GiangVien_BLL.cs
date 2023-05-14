using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class GiangVien_BLL
    {
        private static GiangVien_BLL _Instance;
        public static GiangVien_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new GiangVien_BLL();
                return _Instance;
            }
        }
        public GiangVien_DTO GetGiangVienById(string id)
        {
            GIANG_VIEN gv = GiangVien_DAL.Instance.GetGiangVienByID(id);
            if (gv != null)
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
            foreach (var i in GiangVien_DAL.Instance.GetGiangVienWithNumberLHP())
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
            GiangVien_DAL.Instance.SendNoticeToLHP(MaGV, MaLHP, TieuDe, NoiDung, NgayTao);
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
        public bool CreateExam(string TenBKT, string LoaiBaiKiemTra, byte ThoiGianLamBai, DateTime NgayKiemTra,
                               byte SoCauHoi, string MaLHP, string MaGV, string MatKhauLamBai, bool ChoPhepQuayLai)
        {
            if (GiangVien_DAL.Instance.CheckExamGKOrCKExist(MaLHP, LoaiBaiKiemTra))
                return false;
            else
            {
                GiangVien_DAL.Instance.CreateExam(TenBKT, LoaiBaiKiemTra, ThoiGianLamBai, NgayKiemTra, SoCauHoi, MaLHP,
                                              MaGV, MatKhauLamBai, ChoPhepQuayLai);
                return true;
            }
        }

        public bool CheckScheduleExamConflict(DateTime TimeExam, byte ThoiGianLamBai, string MaLHP)
        {
            return GiangVien_DAL.Instance.CheckScheduleExamConflict(TimeExam, ThoiGianLamBai, MaLHP);
        }

        public void CreateQuestion(string TenCauHoi, string DapAnA, string DapAnB, string DapAnC, string DapAnD, string DapAnDung, string MaMonHoc, string PhanLoai)
        {
            GiangVien_DAL.Instance.CreateQuestion(TenCauHoi, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung, MaMonHoc, PhanLoai);
        }

        public List<CBBItem> GetMonHocInKhoaForGV(string MaGV)
        {
            return GiangVien_DAL.Instance.GetMonHocInKhoaForGV(MaGV);
        }

        public List<CBBItem> GetTeacherByFaculuty(string idFaculuty, string nameFaculuty)
        {
            return GiangVien_DAL.Instance.GetTeacherByFaculuty(idFaculuty, nameFaculuty);

        }
        public ThoiKhoaBieu_DTO GetScheduleForTKB(string MaLHP)
        {
            return GiangVien_DAL.Instance.GetScheduleForTKB(MaLHP);
        }
        public List<string> GetMaLSHForGiangVien(string MaGiangVien)
        {
            return GiangVien_DAL.Instance.GetMaLSHForGiangVien(MaGiangVien);
        }
        public bool UpdateTeacherInfo(GiangVien_DTO gv)
        {
            return GiangVien_DAL.Instance.UpdateTeacherInfo(gv);
        }
        #region Get List GV Suitable To Assign
        public List<AssignTeacher> GetGiangVienWithNumberLHPPhuHop(string MaLHP, string Thu, int? TietBD, int? TietKT)
        {
            List<AssignTeacher> li = new List<AssignTeacher>();
            int stt = 1;
            var li1 = GiangVien_DAL.Instance.GetGVPhuHopTKB(MaLHP, Thu, TietBD, TietKT);
            foreach (var i in GiangVien_DAL.Instance.GetGVPhuHopTKB(MaLHP, Thu, TietBD, TietKT))
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

        #region Xem lịch dạy của giảng viên
        public List<LopHocPhan_DTO> GetWorkScheduleInWeek(string MaGV, int NamHoc, bool IsKiChan)
        {
            List<LopHocPhan_DTO> li = GiangVien_DAL.Instance.GetWorkScheduleInWeek(MaGV, NamHoc, IsKiChan);
            int STT = 1;
            foreach (LopHocPhan_DTO hp in li)
                hp.STT = STT++;
            return li;
        }

        public List<LopHocPhan_DTO> GetWorkScheduleByDateOfWeek(string MaGV, int NamHoc, string Thu, bool IsKiChan)
        {
            List<LopHocPhan_DTO> li = GiangVien_DAL.Instance.GetWorkScheduleInWeek(MaGV, NamHoc, IsKiChan);
            List<LopHocPhan_DTO> res = new List<LopHocPhan_DTO>();
            int STT = 1;
            foreach (LopHocPhan_DTO hp in li)
            {
                if (hp.tkb.Thu == Thu)
                {
                    hp.STT = STT++;
                    res.Add(hp);
                }
            }
            return res;
        }

        public List<KeyValuePair<int, int>> GetAllKiHocNamHocGVDay(string MaGV)
        {
            return GiangVien_DAL.Instance.GetAllKiHocNamHocGVDay(MaGV);
        }
        #endregion
    }
}
