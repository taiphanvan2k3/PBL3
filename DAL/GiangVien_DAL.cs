using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class GiangVien_DAL
    {
        private PBL3Entities db;
        private static GiangVien_DAL _Instance;
        public static GiangVien_DAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new GiangVien_DAL();
                return _Instance;
            }
        }

        private GiangVien_DAL()
        {
            db = new PBL3Entities();
        }

        public string GetMaKhoaOfGV(string MaGVCN)
        {
            return db.GIANG_VIEN.Where(gv => gv.MaGV == MaGVCN).Select(p => p.MaKhoa).FirstOrDefault();
        }
        public List<string> GetAllTinhThanh()
        {
            return db.cities.Select(p => p.tinhThanhPho).ToList();
        }
        public GIANG_VIEN GetGiangVienByID(string id)
        {
            return db.GIANG_VIEN.Where(p => p.MaGV == id).Include(gv => gv.NGUOI_DUNG).
                Include(gv => gv.KHOA).SingleOrDefault();
        }
        public List<string> GetMaLopHPByID(string id)
        {
            return db.LOP_HOC_PHAN.
                      Join(
                            db.GIANG_VIEN,
                            lhp => lhp.MaGV,
                            gv => gv.MaGV,
                            (lhp, gv) => new { lhp, gv }
                      ).Where(x => x.gv.MaGV == id)
                      .Select(x => x.lhp.MaLopHP).ToList();
        }
        public List<AssignTeacher> GetGiangVienWithNumberLHP()
        {
            var li = db.GIANG_VIEN
                     .Join(db.NGUOI_DUNG, gv => gv.MaGV, nd => nd.MaNguoiDung, (gv, nd) => new { GiangVien = gv, NguoiDung = nd })
                     .Join(db.LOP_HOC_PHAN, j => j.GiangVien.MaGV, lhp => lhp.MaGV, (j, lhp) => new { GiangVien = j.GiangVien, NguoiDung = j.NguoiDung, LopHocPhan = lhp })
                     .GroupBy(j => new { j.GiangVien.MaGV, HoTen = j.NguoiDung.Ho + " " + j.NguoiDung.Ten, j.NguoiDung.Sdt })
                     .Select(g => new AssignTeacher { MaGV = g.Key.MaGV, TenGV = g.Key.HoTen, SDT = g.Key.Sdt, SoLuongHPPhuTrach = g.Count() })
                     .ToList();
            return li;
        }
        public bool CheckTKBGiangVienConflict(string id, string thu, int TietBD, int TietKT)
        {
            var li = db.THOI_KHOA_BIEU
                     .Join(db.LOP_HOC_PHAN, tkb => tkb.MaLopHP, lhp => lhp.MaLopHP, (tkb, lhp) => new { TKB = tkb, LHP = lhp })
                     .Join(db.GIANG_VIEN, x => x.LHP.MaGV, gv => gv.MaGV, (x, gv) => new { x.TKB, x.LHP, GV = gv })
                     .Where(x => x.GV.MaGV == id && x.TKB.Thu == thu && ((x.TKB.TietBD >= TietBD && x.TKB.TietBD <= TietKT) || (x.TKB.TietKetThuc >= TietBD && x.TKB.TietKetThuc <= TietKT)))
                     .Select(x => x.TKB).ToList();
            //Nếu list rỗng thì không có xung đột trả về true
            return (li.Count == 0 ? true : false);
        }
        public void AssignTeacherToSectionClass(string id, string thu, int TietBD, int TietKT, string phong, string maLHP)
        {
            var query = db.LOP_HOC_PHAN.Where(lhp => lhp.MaLopHP == maLHP).FirstOrDefault();
            query.MaGV = id;
            var RecordToDelete = db.THOI_KHOA_BIEU.FirstOrDefault(x => x.LOP_HOC_PHAN.MaLopHP == maLHP);
            if (RecordToDelete != null)
            {
                db.THOI_KHOA_BIEU.Remove(RecordToDelete);
                db.SaveChanges();
            }
            var NewRecord = new THOI_KHOA_BIEU
            {
                MaLopHP = maLHP,
                MaPhongHoc = phong,
                Thu = thu,
                TietBD = Convert.ToByte(TietBD),
                TietKetThuc = Convert.ToByte(TietKT)
            };
            db.THOI_KHOA_BIEU.Add(NewRecord);
            db.SaveChanges();
        }
        public void AssignTeacherNoChangeSchedule(string id, string maLHP)
        {
            var query = db.LOP_HOC_PHAN.Where(lhp => lhp.MaLopHP == maLHP).FirstOrDefault();
            query.MaGV = id;
            db.SaveChanges();
        }
        public string GetMaKhoaByMaLHP(string maLHP)
        {
            return db.LOP_HOC_PHAN
                   .Join(db.MON_HOC, lhp => lhp.MaMH, mh => mh.MaMH, (lhp, mh) => new
                   {
                       lhp.MaLopHP,
                       mh.MaMH,
                       mh.MaKhoa
                   }).Where(p => p.MaLopHP == maLHP).Select(p => p.MaKhoa).FirstOrDefault();
        }
        public void SendNoticeToLHP(string MaGV, string MaLHP, string TieuDe, string NoiDung, DateTime NgayTao)
        {
            THONG_BAO NewThongBao = new THONG_BAO
            {
                TieuDe = TieuDe,
                NDThongBao = NoiDung,
                NgayTao = NgayTao,
                MaGVThongBao = MaGV
            };
            db.THONG_BAO.Add(NewThongBao);
            db.SaveChanges();
            //Sort r lấy cái đầu tiên là ra mã lớn nhất vừa thêm 
            int matb = db.THONG_BAO.OrderByDescending(p => p.MaTB).Select(p => p.MaTB).FirstOrDefault();
            THONGBAO_LOPHOCPHAN NewTBLHP = new THONGBAO_LOPHOCPHAN
            {
                MaLopHP = MaLHP,
                MaTB = matb
            };
            db.THONGBAO_LOPHOCPHAN.Add(NewTBLHP);
            db.SaveChanges();
        }
        //Kiểm tra nếu trong ngày đã gửi thông báo cho 1 lớp học phần đó rồi thì
        //thay thế thông báo hoặc không gửi nữa 
        public bool CheckNoticeRedundanṭ̣̣̣(string MaGV, DateTime NgayTao, string MaLHP)
        {
            var query = db.THONG_BAO
                .Join(db.THONGBAO_LOPHOCPHAN, tb => tb.MaTB, tblhp => tblhp.MaTB, (tb, tblhp) => new
                {
                    tb.MaTB,
                    tblhp.MaLopHP,
                    tb.MaGVThongBao,
                    tb.NgayTao
                }).Where(p => p.MaGVThongBao == MaGV && p.MaLopHP == MaLHP && DbFunctions.TruncateTime(p.NgayTao) == NgayTao.Date)
                .ToList();
            //Bởi vì LinQ to entities k hỗ trợ lấy ra Date từ datetime trong Database nên phải dùng
            //DbFunctions.TruncateTime(Datetime) để lấy ra phần ngày không chứa giờ

            //Nếu tồn tại thông báo trong ngày thì trả về true
            return query.Count != 0;
        }
        //Thay thế thông báo 
        public void ReplaceNotice(string MaGV, DateTime NgayTao, string MaLHP, string TieuDe, string NoiDung)
        {
            var query = db.THONG_BAO
                .Join(db.THONGBAO_LOPHOCPHAN, tb => tb.MaTB, tblhp => tblhp.MaTB, (tb, tblhp) => new
                {
                    ThongBao = tb,
                    tblhp.MaLopHP
                })
                .FirstOrDefault(p => p.ThongBao.MaGVThongBao == MaGV && p.MaLopHP == MaLHP && DbFunctions.TruncateTime(p.ThongBao.NgayTao) == NgayTao.Date);

            if (query != null)
            {
                query.ThongBao.NgayTao = NgayTao;
                query.ThongBao.TieuDe = TieuDe;
                query.ThongBao.NDThongBao = NoiDung;
                db.SaveChanges();
            }
        }
        /*public bool CheckTimeExamConflict(string MaGV, string MaLHP, DateTime TimeExam)
        {
            var query = db.BAI_KIEM_TRA.
        }*/
        public int GetNumberQuestionForMonHoc(string MaLHP)
        {
            string MaMH = db.LOP_HOC_PHAN.Where(p => p.MaLopHP == MaLHP)
                            .Join(db.MON_HOC, lhp => lhp.MaMH, mh => mh.MaMH, (lhp, mh) => new
                            {
                                lhp.MaMH,
                                mh.TenMH
                            }).Select(p => p.MaMH).FirstOrDefault();
            return db.CAU_HOI.Where(p => p.MaMH == MaMH).Count();
        }
        public bool CheckExamGKOrCKExist(string MaLHP, string LoaiBaiKiemTra)
        {
            var query = db.BAI_KIEM_TRA.Where(x => x.MaLopHP == MaLHP && x.TenBaiKiemTra == LoaiBaiKiemTra).ToList();
            return query.Count > 0;
        }
        public void CreateExam(string TenBKT, string LoaiBaiKiemTra, byte ThoiGianLamBai, DateTime NgayKiemTra,
                               byte SoCauHoi, string MaLHP, string MaGV, string MatKhauLamBai, bool ChoPhepQuayLai)
        {
            BAI_KIEM_TRA NewBKT = new BAI_KIEM_TRA
            {
                TenBaiKiemTra = LoaiBaiKiemTra,
                TieuDeBaiKiemTra = TenBKT,
                NgayKiemTra = NgayKiemTra,
                ThoiGianLamBai = ThoiGianLamBai,
                SoCauHoi = SoCauHoi,
                MkBaiKiemTra = MatKhauLamBai,
                ChoPhepQuayLai = ChoPhepQuayLai,
                MaGV = MaGV,
                MaLopHP = MaLHP
            };
            db.BAI_KIEM_TRA.Add(NewBKT);
            db.SaveChanges();

            //Sort r lấy cái đầu tiên là ra mã lớn nhất vừa thêm 
            int MaBKT = db.BAI_KIEM_TRA.OrderByDescending(p => p.MaBaiKiemTra).Select(p => p.MaBaiKiemTra).FirstOrDefault();
            int SoLuongCauHoi = GetNumberQuestionForMonHoc(MaLHP);

            //Nếu số câu hỏi có trong CSDL phù hợp nhiều hơn 2 lần số câu hỏi cần làm thì sẽ lấy ở mức gấp đôi số câu hỏi cần làm để random 
            if (SoLuongCauHoi > SoCauHoi * 2)
                SoLuongCauHoi = SoCauHoi * 2;
            string PhanLoai;
            if (LoaiBaiKiemTra == "Cuối kỳ")
                PhanLoai = "CK";
            else if (LoaiBaiKiemTra == "Giữa kỳ")
                PhanLoai = "GK";
            else
                PhanLoai = LoaiBaiKiemTra;
            //x => Guid.NewGuid() là phương thức lấy ngẫu nhiên record trong database theo method syntax in LinQ to entities 
            List<CAU_HOI> li = db.CAU_HOI.OrderBy(x => Guid.NewGuid()).Take(SoLuongCauHoi).Where(x => x.PhanLoai == PhanLoai).ToList();
            foreach (var i in li)
            {
                BAIKIEMTRA_CAUHOI NewBKT_CH = new BAIKIEMTRA_CAUHOI
                {
                    MaBaiKiemTra = MaBKT,
                    MaCauHoi = i.MaCauHoi
                };
                db.BAIKIEMTRA_CAUHOI.Add(NewBKT_CH);
            }
            db.SaveChanges();
        }
        public ThoiKhoaBieu_DTO GetScheduleForTKB(string MaLHP)
        {
            var query = db.THOI_KHOA_BIEU.Where(p => p.MaLopHP == MaLHP).Select(p => new ThoiKhoaBieu_DTO
            {
                Thu = p.Thu,
                TietBD = p.TietBD
            }).FirstOrDefault();
            return query;
        }
        public List<string> GetListSVForLHP(string MaLHP)
        {
            return db.SINHVIEN_LOPHOCPHAN.Where(p => p.MaLopHP == MaLHP).Select(p => p.MaSV).Distinct().ToList();
        }
        //Lấy ra các lớp học phần mà sinh viên trong lớp học phần cần tạo bài kiểm tra học và kiểm tra xung đột trên các lớp đó 
        public bool CheckScheduleExamConflict(DateTime TimeExam, byte ThoiGianLamBai, string MaLHP)
        {
            DateTime TimeKetThuc = TimeExam.AddMinutes((double)ThoiGianLamBai);

            //Lấy ra danh sách sinh viên trong lớp học phần muốn tạo bài kiểm tra
            List<string> list = GetListSVForLHP(MaLHP);

            //Lấy ra danh sách các lớp học phần mà mỗi sinh viên trong lớp đó học 
            var ListLHP = db.SINHVIEN_LOPHOCPHAN.Where(x => list.Contains(x.MaSV)).Select(x => x.MaLopHP).Distinct().ToList();

            //Lấy ra các bài kiểm tra thuộc trong danh sách lớp học phần vừa lấy và kiểm tra xung đột thời gian thi 
            /*var query = db.BAI_KIEM_TRA.Where(bkt => ListLHP.Contains(bkt.MaLopHP)
            && ((bkt.NgayKiemTra >= TimeExam && DbFunctions.AddMinutes(bkt.NgayKiemTra, bkt.ThoiGianLamBai) >= TimeKetThuc
                && bkt.NgayKiemTra <= TimeKetThuc)
            || (bkt.NgayKiemTra <= TimeExam && DbFunctions.AddMinutes(bkt.NgayKiemTra, bkt.ThoiGianLamBai) >= TimeKetThuc)
            || (bkt.NgayKiemTra <= TimeExam && DbFunctions.AddMinutes(bkt.NgayKiemTra, bkt.ThoiGianLamBai) <= TimeKetThuc
                && DbFunctions.AddMinutes(bkt.NgayKiemTra, bkt.ThoiGianLamBai) >= TimeExam)
            || (bkt.NgayKiemTra >= TimeExam && DbFunctions.AddMinutes(bkt.NgayKiemTra, bkt.ThoiGianLamBai) <= TimeKetThuc))).ToList();*/
            var query1 = db.BAI_KIEM_TRA.Where(bkt => ListLHP.Contains(bkt.MaLopHP)
                                                && !(DbFunctions.AddMinutes(bkt.NgayKiemTra, bkt.ThoiGianLamBai) < TimeExam 
                                                      || bkt.NgayKiemTra > TimeKetThuc)).ToList();
            return query1.Count > 0;
        }
        public void CreateQuestion(string TenCauHoi, string DapAnA, string DapAnB, string DapAnC, string DapAnD, string DapAnDung, string MaMonHoc, string PhanLoai)
        {
            CAU_HOI NewCauHoi = new CAU_HOI
            {
                TenCauHoi = TenCauHoi,
                DapAnA = DapAnA,
                DapAnB = DapAnB,
                DapAnC = DapAnC,
                DapAnD = DapAnD,
                DapAnDung = DapAnDung,
                MaMH = MaMonHoc,
                PhanLoai = PhanLoai
            };
            db.CAU_HOI.Add(NewCauHoi);
            db.SaveChanges();
        }
        public List<CBBItem> GetMonHocInKhoaForGV(string MaGV)
        {
            return db.GIANG_VIEN.Where(gv => gv.MaGV == MaGV)
                                .Join(db.LOP_HOC_PHAN, gv => gv.MaGV, lhp => lhp.MaGV, (gv, lhp) => new
                                {
                                    gv.MaGV,
                                    lhp.MaLopHP,
                                    lhp.MaMH
                                }).Join(db.MON_HOC, lhp => lhp.MaMH, mh => mh.MaMH, (lhp, mh) => new
                                {
                                    lhp.MaMH,
                                    mh.TenMH
                                }).Select(mh => new CBBItem { Id = mh.MaMH, Value = mh.TenMH }).Distinct().ToList();
        }
        public List<string> GetMaLSHForGiangVien(string MaGiangVien)
        {
            return db.LOP_SINH_HOAT.Where(lsh => lsh.MaGVCN == MaGiangVien).Select(p => p.MaLopSH).ToList();
        }
        public bool UpdateTeacherInfo(GiangVien_DTO gv)
        {
            NGUOI_DUNG nd = db.NGUOI_DUNG.Where(p => p.MaNguoiDung == gv.MaNguoiDung).FirstOrDefault();
            if (nd != null)
            {
                if (gv.DiaChi != "")
                    nd.DiaChi = gv.DiaChi;
                if (gv.EmailCaNhan != "")
                    nd.EmailCaNhan = gv.EmailCaNhan;
                if (gv.Sdt != "")
                    nd.Sdt = gv.Sdt;
                if (gv.NoiSinh != "")
                    nd.NoiSinh = gv.NoiSinh;
                if (gv.DanToc != "")
                    nd.DanToc = gv.DanToc;
                if (gv.QuocTich != "")
                    nd.QuocTich = gv.QuocTich;
                if (gv.AnhCaNhan != null)
                    nd.AnhCaNhan = gv.AnhCaNhan;
                return db.SaveChanges() > 0;
            }
            return false;
        }

        #region Ver2
        public List<AssignTeacher> GetGVPhuHopTKB(string MaLHP, string Thu, int? TietBD, int? TietKT)
        {
            string MaKhoa = GetMaKhoaByMaLHP(MaLHP);
            List<string> li1 = db.GIANG_VIEN.Where(gv => gv.MaKhoa == MaKhoa).Select(p => p.MaGV).ToList();

            List<string> li2 = db.GIANG_VIEN.Where(gv => gv.MaKhoa == MaKhoa)
               .Join(db.LOP_HOC_PHAN, gv => gv.MaGV, lhp => lhp.MaGV, (gv, lhp) => new
               {
                   gv.MaGV,
                   lhp.MaLopHP
               })
               .Join(db.THOI_KHOA_BIEU, gv => gv.MaLopHP, tkb => tkb.MaLopHP, (gv, tkb) => new
               {
                   gv.MaGV,
                   tkb.Thu,
                   tkb.TietBD,
                   tkb.TietKetThuc
               }).Where(p => p.Thu == Thu && !(p.TietBD > TietKT || p.TietKetThuc < TietBD)).Select(p => p.MaGV).ToList();
            List<string> li = li1.Except(li2).ToList();
            return db.GIANG_VIEN
                .Join(db.NGUOI_DUNG, gv => gv.MaGV, nd => nd.MaNguoiDung, (gv, nd) => new
                {
                    GiangVien = gv,
                    NguoiDung = nd
                })
                .GroupJoin(db.LOP_HOC_PHAN, gv => gv.GiangVien.MaGV, lhp => lhp.MaGV, (gv, lhp) => new
                {
                    GiangVien = gv,
                    LopHocPhan = lhp
                })
                .SelectMany(x => x.LopHocPhan.DefaultIfEmpty(), (x, sublhp) => new { x.GiangVien, LopHocPhan = sublhp })
                .Where(p => li.Contains(p.GiangVien.GiangVien.MaGV))
                .GroupBy(x => new { x.GiangVien.GiangVien.MaGV, x.GiangVien.NguoiDung.Ho, x.GiangVien.NguoiDung.Ten, x.GiangVien.NguoiDung.Sdt })
                .Select(grp => new AssignTeacher
                {
                    MaGV = grp.Key.MaGV,
                    TenGV = grp.Key.Ho + " " + grp.Key.Ten,
                    SDT = grp.Key.Sdt,
                    SoLuongHPPhuTrach = grp.Count(x => x.LopHocPhan != null)
                }).ToList();
        }
        #endregion

        public List<CBBItem> GetTeacherByFaculuty(string idFaculuty, string nameFaculuty)
        {
            var result = from nd in db.NGUOI_DUNG
                         join gv in db.GIANG_VIEN on nd.MaNguoiDung equals gv.MaGV
                         where gv.MaKhoa == idFaculuty
                              && !db.LOP_SINH_HOAT.Any(lsh => lsh.MaGVCN == gv.MaGV && lsh.MaLopSH.Contains(nameFaculuty))
                         select new CBBItem
                         {
                             Id = nd.MaNguoiDung,
                             Value = nd.MaNguoiDung + " - " + nd.Ho + " " + nd.Ten
                         };

            return result.ToList();
        }


        #region 2/5/2023 Tài làm xem lịch dạy giảng viên. 
        public List<LopHocPhan_DTO> GetWorkScheduleInWeek(string MaGV, int NamHoc, bool IsKiChan)
        {
            //Với việc xem lịch dạy giảng viên thì xem dựa vào năm học hiện tại + kì chẵn/lẻ
            return db.LOP_HOC_PHAN.Where(hp => hp.MaGV == MaGV)
                .Join(db.THOI_KHOA_BIEU, hp => hp.MaLopHP, tkb => tkb.MaLopHP, (hp, tkb) => new LopHocPhan_DTO
                {
                    MaHP = hp.MaLopHP,
                    TenHP = hp.MON_HOC.TenMH,
                    KiHoc = hp.KiHoc,
                    NamHoc = hp.NamHoc,
                    tkb = new ThoiKhoaBieu_DTO()
                    {
                        Phong = tkb.MaPhongHoc,
                        Thu = tkb.Thu,
                        TietBD = tkb.TietBD,
                        TietKT = tkb.TietKetThuc
                    }
                }).Where(p => p.NamHoc == NamHoc && (IsKiChan ? p.KiHoc % 2 == 0 : p.KiHoc % 2 == 1)).ToList();
        }

        public List<KeyValuePair<int, int>> GetAllKiHocNamHocGVDay(string MaGV)
        {
            var li = db.LOP_HOC_PHAN.Where(hp => hp.MaGV == MaGV)
                .Select(p => new
                {
                    p.NamHoc,
                    KiHoc = p.KiHoc % 2 == 0 ? 2 : 1
                }).OrderBy(p => p.NamHoc).ThenBy(p => p.KiHoc).Distinct();
            List<KeyValuePair<int, int>> res = new List<KeyValuePair<int, int>>();
            foreach (var item in li)
                res.Add(new KeyValuePair<int, int>(item.KiHoc, item.NamHoc));
            return res;
        }
        #endregion
    }
}
