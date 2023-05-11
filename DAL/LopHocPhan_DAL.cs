using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class LopHocPhan_DAL
    {
        private PBL3Entities db;
        private static LopHocPhan_DAL _Instance;
        public static LopHocPhan_DAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new LopHocPhan_DAL();
                return _Instance;
            }
        }
        private LopHocPhan_DAL()
        {
            db = new PBL3Entities();
        }

        #region Thêm, xoá lớp học phần
        public bool InsertModuleClass(LOP_HOC_PHAN lhp)
        {
            using (var context = new PBL3Entities())
            {
                context.LOP_HOC_PHAN.Add(lhp);
                return context.SaveChanges() > 0;
            }
        }

        public bool DeleteModuleClass(string idMoudleClass)
        {
            bool success = false;
            using (var context = new PBL3Entities())
            {
                var moudleClassInfo = context.LOP_HOC_PHAN.FirstOrDefault(l => l.MaLopHP == idMoudleClass);
                if (moudleClassInfo != null)
                {
                    try
                    {
                        context.LOP_HOC_PHAN.Remove(moudleClassInfo);
                        context.SaveChanges();
                        success = true;
                    }
                    catch
                    {
                        success = false;
                    }
                }
            }
            return success;
        }
        #endregion
        public int GetNumberOfStudentInClass(string MaLopHP)
        {
            return db.LOP_HOC_PHAN.Where(lhp => lhp.MaLopHP == MaLopHP).Select(lsh => lsh.SINHVIEN_LOPHOCPHAN.Count).FirstOrDefault();
        }

        public LopHocPhan_AdminEdit GetHocPhanByMaHP(string MaHP)
        {
            //Trả về các thông tin cần như: mã HP, tênHP,SoTC,MaGV,HoGV,KiHoc,NamHoc,Thu,TietBD,TietKT
            //Trả về các thông tin cần thiết trong giao diện frmViewDetailModuleClass
            return db.LOP_HOC_PHAN.Where(i => i.MaLopHP == MaHP)
                .GroupJoin(db.GIANG_VIEN, hp => hp.MaGV, gv => gv.MaGV, (hp, gv) => new
                {
                    LopHP_tmp = hp,
                    GiangVien_tmp = gv.DefaultIfEmpty()
                })
                .SelectMany(i1 => i1.GiangVien_tmp.Select(i2 => new
                {
                    i1.LopHP_tmp.MaLopHP,
                    TenHP = i1.LopHP_tmp.MON_HOC.TenMH,
                    i1.LopHP_tmp.MON_HOC.SoTC,
                    i1.LopHP_tmp.KiHoc,
                    i1.LopHP_tmp.NamHoc,
                    i1.LopHP_tmp.SoLuongToiDa,
                    i2.MaGV,
                    HoGV = i2.NGUOI_DUNG.Ho,
                    TenGV = i2.NGUOI_DUNG.Ten
                }))
                .GroupJoin(db.THOI_KHOA_BIEU, hp => hp.MaLopHP, tkb => tkb.MaLopHP, (hp, tkb) => new
                {
                    LopHP_tmp = hp,
                    TKB_tmp = tkb.DefaultIfEmpty()
                })
                .SelectMany(i1 => i1.TKB_tmp.Select(i2 => new LopHocPhan_AdminEdit
                {
                    MaHP = i1.LopHP_tmp.MaLopHP,
                    TenHP = i1.LopHP_tmp.TenHP,
                    SoTc = i1.LopHP_tmp.SoTC,
                    MaGV = i1.LopHP_tmp.MaGV,
                    KiHoc = i1.LopHP_tmp.KiHoc,
                    NamHoc = i1.LopHP_tmp.NamHoc,
                    HoTenGV = i1.LopHP_tmp.HoGV + " " + i1.LopHP_tmp.TenGV,
                    SoLuongMax = (int)i1.LopHP_tmp.SoLuongToiDa,
                    Thu = i2.Thu,
                    TietBD = i2.TietBD,
                    TietKT = i2.TietKetThuc,
                    MaPhong = i2.MaPhongHoc
                })).FirstOrDefault();
        }

        public List<SinhVienLHP_View> GetSinhVienInLHP(string MaHP)
        {
            /*Trả về danh sách sinh viên hiển thị lên dtgv của frmViewDetailModuleClass
            Danh sách này cũng được dùng để hiển thị danh sách sinh viên khi GV bấm vào xem danh
            sách lớp ở giao diện GV
            */
            var li = db.LOP_HOC_PHAN.Where(p => p.MaLopHP == MaHP)
                .Join(db.SINHVIEN_LOPHOCPHAN, hp => hp.MaLopHP, sv => sv.MaLopHP, (hp, sv) => new
                {
                    sv.MaSV
                })
                .Join(db.SINH_VIEN, svhp => svhp.MaSV, sv => sv.MaSV, (svhp, sv) => new SinhVienLHP_View
                {
                    MSSV = svhp.MaSV,
                    HoTenSV = sv.NGUOI_DUNG.Ho + " " + sv.NGUOI_DUNG.Ten,
                    SDT = sv.NGUOI_DUNG.Sdt,
                    LopSH = sv.LOP_SINH_HOAT.MaLopSH
                }).ToList();
            return li;
        }

        public bool UpdateSoTC(string MaHP, int SoTC)
        {
            string MaMH = db.LOP_HOC_PHAN.Where(p => p.MaLopHP == MaHP).Select(p => p.MaMH).FirstOrDefault();

            //Nếu GetMonHocById từ MonHoc_DAL rồi cập nhật SoTC rồi lấy db.SaveChanges() ở đây thì sẽ không
            //thực hiện bất kì việc cập nhật nào vì 2 đối tượng db ở 2 lớp DAL là khác nhau
            return MonHoc_DAL.Instance.UpdateSoTC(MaMH, SoTC);
        }

        /// <summary>
        /// Hàm này phục vụ cho việc add sinh viên vào lớp học phần
        /// </summary>
        /// <param name="MaSV"></param>
        /// <param name="KiHoc"></param>
        /// <returns></returns>
        public List<LopHocPhan_AdminEdit> GetListHocPhanOfStudent_AddSV(string MaSV, int KiHoc)
        {
            //Lấy thông tin của các lớp học phần của sinh viên có MaSV ở kì học nào đó
            return db.SINHVIEN_LOPHOCPHAN.Where(p => p.MaSV == MaSV)
                .Join(db.LOP_HOC_PHAN, svhp => svhp.MaLopHP, hp => hp.MaLopHP, (svhp, hp) => new
                {
                    svhp.MaLopHP,
                    hp.MON_HOC.TenMH,
                    hp.KiHoc
                }).Where(p => p.KiHoc == KiHoc)
                .Join(db.THOI_KHOA_BIEU, hp => hp.MaLopHP, tkb => tkb.MaLopHP, (hp, tkb) => new LopHocPhan_AdminEdit()
                {
                    MaHP = hp.MaLopHP,
                    TenHP = hp.TenMH,
                    Thu = tkb.Thu,
                    TietBD = tkb.TietBD,
                    TietKT = tkb.TietKetThuc
                }).ToList();
        }

        public void AddStudentIntoClass(string MaHP, string MaSV)
        {
            //Hàm này dùng để thêm 1 sinh viên vào lớp học phần
            SINHVIEN_LOPHOCPHAN svhp = new SINHVIEN_LOPHOCPHAN()
            {
                MaSV = MaSV,
                MaLopHP = MaHP
            };
            db.SINHVIEN_LOPHOCPHAN.Add(svhp);
            db.SaveChanges();
        }

        public string GetMaKhoaOfLHP(string MaHP)
        {
            return db.LOP_HOC_PHAN.Where(p => p.MaLopHP == MaHP).Select(hp => hp.MON_HOC.MaKhoa).FirstOrDefault();
        }

        public bool DeleteStudent(string MaHP, List<string> liMSSV)
        {
            List<SINHVIEN_LOPHOCPHAN> li = new List<SINHVIEN_LOPHOCPHAN>();
            foreach (string mssv in liMSSV)
            {
                var svhp = db.SINHVIEN_LOPHOCPHAN.Where(i => i.MaLopHP == MaHP && i.MaSV == mssv).FirstOrDefault();
                if (svhp != null)
                    li.Add(svhp);
            }
            db.SINHVIEN_LOPHOCPHAN.RemoveRange(li);
            return db.SaveChanges() > 0;
        }

        public List<InformationClass_DTO> GetInformationClasses()
        {
            var result = from lhp in db.LOP_HOC_PHAN
                         join mh in db.MON_HOC on lhp.MaMH equals mh.MaMH
                         join kh in db.KHOAs on mh.MaKhoa equals kh.MaKhoa
                         join sv_lhp in db.SINHVIEN_LOPHOCPHAN on lhp.MaLopHP equals sv_lhp.MaLopHP into sv_lhps
                         from sv_lhp in sv_lhps.DefaultIfEmpty()
                         join nd in db.NGUOI_DUNG on lhp.MaGV equals nd.MaNguoiDung into nds
                         from nd in nds.DefaultIfEmpty()
                         group sv_lhp by new { lhp.MaLopHP, mh.TenMH, kh.TenKhoa, lhp.MaGV, nd.Ho, nd.Ten, lhp.SoLuongToiDa } into g
                         orderby g.Key.TenKhoa
                         select new InformationClass_DTO
                         {
                             maLop = g.Key.MaLopHP,
                             tenLop = g.Key.TenMH,
                             tenKhoa = g.Key.TenKhoa,
                             maGV = g.Key.MaGV ?? "Empty",
                             hoTenGV = (g.Key.Ho ?? "Empty") + " " + g.Key.Ten,
                             soLuongSV = g.Count(x => x.MaSV != null),
                             soLuongToiDa = g.Key.SoLuongToiDa ?? 0
                         };
            return result.ToList();
        }

        public int CountModuleClass()
        {
            return db.LOP_HOC_PHAN.Count();
        }

        public List<ThongBao_DTO> GetNotificationsInSpecificBound(string MaSV, DateTime StartDateFilter)
        {
            //Nếu so sánh trực tiếp thì có thể không ra kết quả như mong đợi vì toán tử >=,.. của DateTime
            //so sánh cả phần giờ, phút, giây
            StartDateFilter = new DateTime(StartDateFilter.Year, StartDateFilter.Month, StartDateFilter.Day);
            return db.SINHVIEN_LOPHOCPHAN.Where(sv => sv.MaSV == MaSV)
                .Join(db.LOP_HOC_PHAN, sv => sv.MaLopHP, hp => hp.MaLopHP, (sv, hp) => new
                {
                    hp.MaLopHP,
                    hp.MON_HOC.TenMH
                })
                .Join(db.THONGBAO_LOPHOCPHAN, hp => hp.MaLopHP, tb_lhp => tb_lhp.MaLopHP, (hp, tb_lhp) => new
                {
                    hp.MaLopHP,
                    hp.TenMH,
                    tb_lhp.MaTB
                })
                .Join(db.THONG_BAO, tb_lhp => tb_lhp.MaTB, tb => tb.MaTB, (tb_lhp, tb) => new
                {
                    tb_lhp.MaLopHP,
                    tb_lhp.TenMH,
                    tb.NgayTao,
                    tb.TieuDe,
                    tb.NDThongBao,
                    tb.MaGVThongBao
                })
                .Where(p => p.NgayTao >= StartDateFilter)
                .Join(db.NGUOI_DUNG, tb => tb.MaGVThongBao, nd => nd.MaNguoiDung, (tb, nd) => new ThongBao_DTO
                {
                    MaLopHP = tb.MaLopHP,
                    TenMonHoc = tb.TenMH,
                    NgayTao = (DateTime)tb.NgayTao,
                    TieuDe = tb.TieuDe,
                    NoiDung = tb.NDThongBao,
                    TenGV = nd.Ho + " " + nd.Ten,
                    CheckGender = nd.GioiTinh ? "Thầy" : "Cô"
                }).ToList();
        }

        public List<InformationSubject_DTO> getListSubjects()
        {
            var result = db.MON_HOC
                .Join(db.KHOAs, mh => mh.MaKhoa, kh => kh.MaKhoa, (mh, kh) => new { MH = mh, KH = kh })
                .OrderBy(x => x.KH.TenKhoa)
                .Select(x => new InformationSubject_DTO
                {
                    MaMh = x.MH.MaMH,
                    TenMh = x.MH.TenMH,
                    SoTC = x.MH.SoTC,
                    TenKhoa = x.KH.TenKhoa
                })
                .ToList();
            return result;
        }
    }
}
