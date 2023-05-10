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

        public List<CauHoi_DTO> GetListQuestionInExam(int MaBaiKiemTra, int TongSoCau)
        {
            string LoaiBaiKiemTra = GetLoaiBaiKiemTra(MaBaiKiemTra);
            var li = db.BAIKIEMTRA_CAUHOI.Where(i => i.MaBaiKiemTra == MaBaiKiemTra)
            .Join(db.CAU_HOI, bkt => bkt.MaCauHoi, ch => ch.MaCauHoi, (bkt, ch) => new
            {
                MaPhanLoaiCauHoi = ch.PhanLoai,
                ch.TenCauHoi,
                ch.DapAnA,
                ch.DapAnB,
                ch.DapAnC,
                ch.DapAnD,
                ch.DapAnDung
            })
            //Nếu là bài Test thì chỉ lấy các bài thuộc phạm vi Test
            //Nếu là GK thì lấy các câu hỏi của Test và GK
            //Còn nếu là CK thì lấy câu nào cũng được
            .Where(p => (LoaiBaiKiemTra == "Test" && p.MaPhanLoaiCauHoi == "Test") ||
                        (LoaiBaiKiemTra == "GK" && p.MaPhanLoaiCauHoi != "CK") ||
                        LoaiBaiKiemTra == "CK")
            .OrderBy(ch => Guid.NewGuid()).Take(TongSoCau).ToList();

            List<CauHoi_DTO> res = new List<CauHoi_DTO>();
            foreach (var p in li)
                res.Add(new CauHoi_DTO(p.TenCauHoi, p.DapAnA, p.DapAnB, p.DapAnC, p.DapAnD, p.DapAnDung));
            return res;
        }

        public string GetLoaiBaiKiemTra(int MaBaiKiemTra)
        {
            //Lấy ra loại bài kiểm tra (Test,Giữa kỳ,Cuối kỳ) 
            string tmp = db.BAI_KIEM_TRA.Where(bkt => bkt.MaBaiKiemTra == MaBaiKiemTra)
                   .Select(p => p.TenBaiKiemTra).FirstOrDefault();
            if (tmp == "Giữa kỳ")
                return "GK";
            else if (tmp == "Cuối kỳ")
                return "CK";
            return "Test";
        }

        public List<BaiKiemTra_DTO> GetAllExamOfStudent(string MaSV)
        {
            /*
            lấy ra thông tin của tất cả các bài kiểm tra mà sinh viên đó có thể làm
            var li = db.sinhvien_lophocphan.where(svhp => svhp.masv == masv)
                .join(db.lop_hoc_phan, svhp => svhp.malophp, hp => hp.malophp, (svhp, hp) => new
                {
                    hp.malophp,
                    hp.mon_hoc.tenmh
                })
                .groupjoin(db.bai_kiem_tra, hp => hp.malophp, bkt => bkt.malophp, (hp, bkt) => new
                {
                    lophp_tmp = hp,
                    baikiemtra_tmp = bkt.defaultifempty()
                })
                .selectmany(i1 => i1.baikiemtra_tmp.select(i2 => new baikiemtra_dto
                {
                    mahp = i1.lophp_tmp.malophp,
                    tenmh = i1.lophp_tmp.tenmh,
                    tieudebaikiemtra = i2.tieudebaikiemtra,
                    //socauhoi = i2.socauhoi,
                    //thoigianlambai = i2.thoigianlambai,
                    //thoigianbatdau = i2.ngaykiemtra,
                    //mkbaikiemtra = i2.mkbaikiemtra,
                    chophepquaylai = i2.chophepquaylai != null && (bool)i2.chophepquaylai
                })).tolist();
            */
            var li = db.SINHVIEN_LOPHOCPHAN.Where(svhp => svhp.MaSV == MaSV)
                .Join(db.LOP_HOC_PHAN, svhp => svhp.MaLopHP, hp => hp.MaLopHP, (svhp, hp) => new
                {
                    hp.MaLopHP,
                    hp.MON_HOC.TenMH
                })
                .Join(db.BAI_KIEM_TRA, hp => hp.MaLopHP, bkt => bkt.MaLopHP, (hp, bkt) => new BaiKiemTra_DTO
                {
                    MaHP = hp.MaLopHP,
                    TenMH = hp.TenMH,
                    MaBaiKiemTra = bkt.MaBaiKiemTra,
                    TieuDeBaiKiemTra = bkt.TieuDeBaiKiemTra,
                    SoCauHoi = bkt.SoCauHoi,
                    ThoiGianLamBai = bkt.ThoiGianLamBai,
                    ThoiGianBatDau = bkt.NgayKiemTra,
                    MkBaiKiemTra = bkt.MkBaiKiemTra,
                    ChoPhepQuayLai = bkt.ChoPhepQuayLai != null && (bool)bkt.ChoPhepQuayLai
                })
                .ToList();
            List<BaiKiemTra_DTO> res = new List<BaiKiemTra_DTO>();
            foreach (BaiKiemTra_DTO bkt in li)
            {
                if (db.LAM_BAI_KIEM_TRA.Find(MaSV, bkt.MaBaiKiemTra) == null)
                    res.Add(bkt);
            }
            return res;
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

        public List<BaiKiemTra_DTO> GetListExamInMonth(string MaSV, DateTime startDate, DateTime endDate)
        {
            //Lấy ra tất cả lịch kiểm tra của các lớp HP mà sinh viên này đang theo học trong phạm vi 1 tháng
            var li = db.SINHVIEN_LOPHOCPHAN.Where(sv => sv.MaSV == MaSV)
                .Join(db.LOP_HOC_PHAN, svhp => svhp.MaLopHP, lhp => lhp.MaLopHP, (svhp, lhp) => new
                {
                    lhp.MaLopHP,
                    lhp.MON_HOC.TenMH
                })
                .Join(db.BAI_KIEM_TRA, lhp => lhp.MaLopHP, bkt => bkt.MaLopHP, (lhp, bkt) => new BaiKiemTra_DTO
                {
                    //MaLoaiKiemTra: GK,CK,Test
                    MaLoaiKiemTra = bkt.TenBaiKiemTra,

                    //TieuDeBaiKiemTra: kiểm tra giữa kì OOP
                    TieuDeBaiKiemTra = bkt.TieuDeBaiKiemTra,
                    MaHP = bkt.MaLopHP,
                    TenMH = lhp.TenMH,
                    SoCauHoi = bkt.SoCauHoi,

                    //ThoiGianLamBai là khoảng thời gian tối đa để làm đề này, đơn vị tính (phút)
                    ThoiGianLamBai = bkt.ThoiGianLamBai,

                    //ThoiGianBatDau là thời gian bắt đầu mở đề này
                    ThoiGianBatDau = bkt.NgayKiemTra
                })
                .Where(bkt => startDate <= bkt.ThoiGianBatDau && bkt.ThoiGianBatDau <= endDate).ToList();
            return li;
        }

        public void SaveResultOfDoExam(LAM_BAI_KIEM_TRA lambkt)
        {
            db.LAM_BAI_KIEM_TRA.Add(lambkt);
            db.SaveChanges();
        }
    }
}
