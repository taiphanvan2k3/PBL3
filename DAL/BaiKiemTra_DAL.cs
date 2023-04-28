using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class BaiKiemTra_DAL
    {
        private static BaiKiemTra_DAL _Instance;
        private PBL3Entities db;
        public static BaiKiemTra_DAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BaiKiemTra_DAL();
                return _Instance;
            }
        }

        private BaiKiemTra_DAL()
        {
            db = new PBL3Entities();
        }

        public List<CauHoi_DTO> GetListQuestionInExam(int MaBaiKiemTra)
        {
            var li = db.BAIKIEMTRA_CAUHOI.Where(i => i.MaBaiKiemTra == MaBaiKiemTra)
            .Join(db.CAU_HOI, bkt => bkt.MaCauHoi, ch => ch.MaCauHoi, (bkt, ch) => new
            {
                ch.TenCauHoi,
                ch.DapAnA,
                ch.DapAnB,
                ch.DapAnC,
                ch.DapAnD,
                ch.DapAnDung
            }).ToList();

            List<CauHoi_DTO> res = new List<CauHoi_DTO>();
            foreach (var p in li)
                res.Add(new CauHoi_DTO(p.TenCauHoi, p.DapAnA, p.DapAnB, p.DapAnC, p.DapAnD, p.DapAnDung));
            return res;
        }

        public List<BaiKiemTra_DTO> GetAllExamOfStudent(string MaSV)
        {
            // Lấy ra thông tin của tất cả các bài kiểm tra mà sinh viên đó có thể làm
            //var li = db.SINHVIEN_LOPHOCPHAN.Where(svhp => svhp.MaSV == MaSV)
            //    .Join(db.LOP_HOC_PHAN, svhp => svhp.MaLopHP, hp => hp.MaLopHP, (svhp, hp) => new
            //    {
            //        hp.MaLopHP,
            //        hp.MON_HOC.TenMH
            //    })
            //    .GroupJoin(db.BAI_KIEM_TRA, hp => hp.MaLopHP, bkt => bkt.MaLopHP, (hp, bkt) => new
            //    {
            //        LopHP_tmp = hp,
            //        BaiKiemTra_tmp = bkt.DefaultIfEmpty()
            //    })
            //    .SelectMany(i1 => i1.BaiKiemTra_tmp.Select(i2 => new BaiKiemTra_DTO
            //    {
            //        MaHP = i1.LopHP_tmp.MaLopHP,
            //        TenMH = i1.LopHP_tmp.TenMH,
            //        TieuDeBaiKiemTra = i2.TieuDeBaiKiemTra,
            //        //SoCauHoi = i2.SoCauHoi,
            //        //ThoiGianLamBai = i2.ThoiGianLamBai,
            //        //ThoiGianBatDau = i2.NgayKiemTra,
            //        //MkBaiKiemTra = i2.MkBaiKiemTra,
            //        ChoPhepQuayLai = i2.ChoPhepQuayLai != null && (bool)i2.ChoPhepQuayLai
            //    })).ToList();
            
            var li2 = db.SINHVIEN_LOPHOCPHAN.Where(svhp => svhp.MaSV == MaSV)
                .Join(db.LOP_HOC_PHAN, svhp => svhp.MaLopHP, hp => hp.MaLopHP, (svhp, hp) => new
                {
                    hp.MaLopHP,
                    hp.MON_HOC.TenMH
                })
                .Join(db.BAI_KIEM_TRA, hp => hp.MaLopHP, bkt => bkt.MaLopHP, (hp, bkt) => new BaiKiemTra_DTO
                {
                    MaHP = hp.MaLopHP,
                    TenMH = hp.TenMH,
                    TieuDeBaiKiemTra = bkt.TieuDeBaiKiemTra,
                    SoCauHoi = bkt.SoCauHoi,
                    ThoiGianLamBai = bkt.ThoiGianLamBai,
                    ThoiGianBatDau = bkt.NgayKiemTra,
                    MkBaiKiemTra = bkt.MkBaiKiemTra,
                    ChoPhepQuayLai = bkt.ChoPhepQuayLai != null && (bool)bkt.ChoPhepQuayLai
                }).ToList();
            return li2;
        }


        public List<KetQuaLamKiemTra> GetKetQuaLambaiTheoKi(string MaSV, int KiHoc)
        {
            // Trả về kết quả làm bài kiểm tra của sinh viên theo kì
            return db.LAM_BAI_KIEM_TRA.Where(sv => sv.MaSV == MaSV)
                .Join(db.BAI_KIEM_TRA, lamkt => lamkt.MaBaiKiemTra, baikt => baikt.MaBaiKiemTra, (lamkt, baikt) => new
                {
                    baikt.MaLopHP,
                    baikt.TenBaiKiemTra,
                    lamkt.ThoiGianLamBai,
                    lamkt.ThoiGianNopBai,
                    TongSocau = baikt.SoCauHoi,
                    lamkt.SoCauDung,
                    lamkt.SoLanViPham,
                    lamkt.Diem
                })
                .Join(db.LOP_HOC_PHAN, bkt => bkt.MaLopHP, lhp => lhp.MaLopHP, (bkt, lhp) => new KetQuaLamKiemTra
                {
                    MaHP = lhp.MaLopHP,
                    TenMH = lhp.MON_HOC.TenMH,
                    TenBaiKiemTra = bkt.TenBaiKiemTra,
                    KiHoc = lhp.KiHoc,
                    NamHoc = lhp.NamHoc + " - " + lhp.NamHoc,
                    ThoiGianLamBai = (DateTime)bkt.ThoiGianLamBai,
                    ThoiGianNopBai = (DateTime)bkt.ThoiGianNopBai,
                    TongSoCau = bkt.TongSocau,
                    SoCauDung = bkt.SoCauDung,
                    Diem = bkt.Diem,
                    SoLanViPham = bkt.SoLanViPham,
                }).Where(p => p.KiHoc == KiHoc).ToList();
        }

        public List<KetQuaLamKiemTra_SVLHP> GetKetQuaKiemTra_LHP(int MaBaiKiemTra)
        {
            //Phương thức này lấy ra kết quả làm bài của sinh viên ở bài kiểm tra nào đó
            //Đây là chức năng của giáo viên, xem kết quả làm bài của sinh viên tại bài kiểm tra nào đó do mình tạo
            var li = db.BAI_KIEM_TRA.Where(bkt => bkt.MaBaiKiemTra == MaBaiKiemTra)
                .Join(db.LAM_BAI_KIEM_TRA, bkt => bkt.MaBaiKiemTra, lambkt => lambkt.MaBaiKiemTra, (bkt, lambkt) => new
                {
                    lambkt.MaSV,
                    lambkt.ThoiGianLamBai,
                    lambkt.ThoiGianNopBai,
                    lambkt.SoCauDung,
                    lambkt.SoLanViPham,
                    lambkt.Diem
                })
                .Join(db.SINH_VIEN, lambkt => lambkt.MaSV, sv => sv.MaSV, (lambkt, sv) => new
                {
                    lambkt.MaSV,
                    sv.NGUOI_DUNG.Ho,
                    sv.NGUOI_DUNG.Ten,
                    sv.MaLopSH,
                    lambkt.ThoiGianLamBai,
                    lambkt.ThoiGianNopBai,
                    lambkt.SoCauDung,
                    lambkt.SoLanViPham,
                    lambkt.Diem
                })
                .Select(p => new KetQuaLamKiemTra_SVLHP()
                {
                    MaSV = p.MaSV,
                    HoTenSV = p.Ho + " " + p.Ten,
                    LopSH = p.MaLopSH,
                    ThoiGianLamBai = (DateTime)p.ThoiGianLamBai,
                    ThoiGianNopBai = (DateTime)p.ThoiGianNopBai,
                    SoCauDung = p.SoCauDung,
                    SoLanViPham = p.SoLanViPham,
                    Diem = p.Diem
                }).ToList();
            return li;
        }

        public List<BaiKiemTra_DTO> GetListExamInMonth(DateTime startDate, DateTime endDate)
        {
            var li = db.BAI_KIEM_TRA.Where(bkt => startDate <= bkt.NgayKiemTra
                                           && bkt.NgayKiemTra <= endDate)
            .Select(p => new BaiKiemTra_DTO()
            {
                //MaLoaiKiemTra: GK,CK,Test
                MaLoaiKiemTra = p.TenBaiKiemTra,

                //TieuDeBaiKiemTra: kiểm tra giữa kì OOP
                TieuDeBaiKiemTra = p.TieuDeBaiKiemTra,
                MaHP = p.MaLopHP,
                TenMH = p.LOP_HOC_PHAN.MON_HOC.TenMH,
                SoCauHoi = p.SoCauHoi,
                ThoiGianLamBai = p.ThoiGianLamBai,
                ThoiGianBatDau = p.NgayKiemTra
            }).ToList();
            return li;
        }
    }
}
