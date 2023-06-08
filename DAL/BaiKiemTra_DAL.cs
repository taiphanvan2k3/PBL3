using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DAL
{
    public class BaiKiemTra_DAL
    {
        private static BaiKiemTra_DAL _Instance;
        public static BaiKiemTra_DAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BaiKiemTra_DAL();
                return _Instance;
            }
        }



        /// <summary>
        /// Lấy ra danh sách câu hỏi để load vào 1 bài kiểm tra nào đó
        /// </summary>
        /// <param name="MaBaiKiemTra"></param>
        /// <param name="TongSoCau"></param>
        /// <returns></returns>
        public List<CauHoi_DTO> GetListQuestionInExam(int MaBaiKiemTra, int TongSoCau)
        {
            using (var db = new PBL3Entities())
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
        }

        public string GetLoaiBaiKiemTra(int MaBaiKiemTra)
        {
            using (var db = new PBL3Entities())
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
        }

        /// <summary>
        /// Lấy ra thông tin của tất cả các bài kiểm tra mà sinh viên đó có thể làm
        /// Hiển thị ở datagridview UC_DoExam
        /// </summary>
        /// <param name="MaSV"></param>
        /// <returns></returns>
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
            using (var db = new PBL3Entities())
            {
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
                    TieuDeBaiKiemTra = bkt.TenBaiKiemTra,
                    SoCauHoi = bkt.SoCauHoi,
                    ThoiGianLamBai = bkt.ThoiGianLamBai,
                    ThoiGianBatDau = bkt.NgayKiemTra,
                    MkBaiKiemTra = bkt.MkBaiKiemTra,
                    ChoPhepQuayLai = bkt.ChoPhepQuayLai != null && (bool)bkt.ChoPhepQuayLai
                })
                .ToList();

                //Sau khi trả về các bài kiểm tra có ở các lớp HP mà sinh viên đang học thì lọc ra
                //các bài kiểm tra sv chưa làm để hiển thị trên giao diện thôi
                List<BaiKiemTra_DTO> res = new List<BaiKiemTra_DTO>();
                foreach (BaiKiemTra_DTO bkt in li)
                {
                    //Kiểm tra sinh viên có MaSV này đã làm bài kiểm tra có MaBaiKiemTra này chưa
                    LAM_BAI_KIEM_TRA temp = db.LAM_BAI_KIEM_TRA.Find(MaSV, bkt.MaBaiKiemTra);
                    if (temp == null || temp.Diem == -1)
                        res.Add(bkt);
                }
                return res;
            }
        }


        public List<KetQuaLamKiemTra> GetAllKetQuaLamBai(string MaSV)
        {
            using (var db = new PBL3Entities())
            {
                // Trả về kết quả làm bài kiểm tra của sinh viên
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
                    NamHoc = lhp.NamHoc + " - " + (lhp.NamHoc + 1),
                    ThoiGianLamBai = (DateTime)bkt.ThoiGianLamBai,
                    ThoiGianNopBai = (DateTime)bkt.ThoiGianNopBai,
                    TongSoCau = bkt.TongSocau,
                    SoCauDung = bkt.SoCauDung,
                    Diem = bkt.Diem,
                    SoLanViPham = bkt.SoLanViPham,
                }).ToList();
            }
        }

        public List<KetQuaLamKiemTra_SVLHP> GetKetQuaKiemTra_LHP(int MaBaiKiemTra)
        {
            using (var db = new PBL3Entities())
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
                    lambkt.Diem,
                    bkt.SoCauHoi
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
                    lambkt.Diem,
                    lambkt.SoCauHoi
                })
                .Select(p => new KetQuaLamKiemTra_SVLHP()
                {
                    MaSV = p.MaSV,
                    HoTenSV = p.Ho + " " + p.Ten,
                    LopSH = p.MaLopSH,
                    ThoiGianLamBai = (DateTime)p.ThoiGianLamBai,
                    ThoiGianNopBai = (DateTime)p.ThoiGianNopBai,
                    SoCauDung = p.SoCauDung + "/" + p.SoCauHoi,
                    SoLanViPham = p.SoLanViPham,
                    Diem = p.Diem
                }).ToList();
                return li;
            }
        }

        public List<BaiKiemTra_DTO> GetListExamInMonth(string MaSV, DateTime startDate, DateTime endDate)
        {
            using (var db = new PBL3Entities())
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
        }

        public void SaveResultOfDoExam(LAM_BAI_KIEM_TRA lambkt)
        {
            using (var db = new PBL3Entities())
            {
                LAM_BAI_KIEM_TRA oldResult = db.LAM_BAI_KIEM_TRA.Where(p => p.MaSV == lambkt.MaSV && p.MaBaiKiemTra == lambkt.MaBaiKiemTra).FirstOrDefault();
                if (oldResult != null)
                {
                    oldResult.SoCauDung = lambkt.SoCauDung;
                    oldResult.SoLanViPham = lambkt.SoLanViPham;
                    oldResult.Diem = lambkt.Diem;
                    oldResult.ThoiGianLamBai = lambkt.ThoiGianLamBai;
                    oldResult.ThoiGianNopBai = lambkt.ThoiGianNopBai;
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        public List<CBBItem> GetAllExamsInSpecificModuleClass(string moduleClass)
        {
            using (var db = new PBL3Entities())
            {
                var li = db.BAI_KIEM_TRA.Where(bkt => bkt.MaLopHP == moduleClass)
                .Select(p => new
                {
                    p.MaBaiKiemTra,
                    p.TenBaiKiemTra,
                    p.TieuDeBaiKiemTra
                }).ToList();
                List<CBBItem> res = new List<CBBItem>();
                foreach (var item in li)
                {
                    res.Add(new CBBItem()
                    {
                        Id = item.MaBaiKiemTra.ToString(),
                        Value = item.TenBaiKiemTra + " - " + item.TieuDeBaiKiemTra
                    });
                }
                return res;
            }
        }

        public void IsDoingExam(string MSV, int maBaiKT)
        {
            using (var db = new PBL3Entities())
            {
                LAM_BAI_KIEM_TRA lbkt = new LAM_BAI_KIEM_TRA
                {
                    MaSV = MSV,
                    MaBaiKiemTra = maBaiKT,
                    Diem = -1,
                    ThoiGianLamBai = DateTime.Now,
                    ThoiGianNopBai = DateTime.Now,
                };
                db.LAM_BAI_KIEM_TRA.Add(lbkt);  
                db.SaveChanges();
            }
        }
        
        public double? IsExsitExam(string MSV, int maBaiKT)
        {
            using (var db = new PBL3Entities())
            {
                LAM_BAI_KIEM_TRA lbkt = db.LAM_BAI_KIEM_TRA.Where(p => p.MaSV == MSV && p.MaBaiKiemTra ==  maBaiKT).FirstOrDefault();  
                if (lbkt != null)
                {
                    return lbkt.Diem;
                }
                return null;
            }
        }
    }
}
