using DTO;
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

        public List<LopHocPhan_DTO> GetListHocPhanOfStudent(string MSSV, int KiHoc, int NamHoc)
        {
            //Lấy ra các môn học của sinh viên có MSSV ở KiHoc,NamHoc nào đó, rồi mới đi Join bảng
            var li = db.SINHVIEN_LOPHOCPHAN.Where(i => i.MaSV == MSSV && i.KiHoc == KiHoc && i.NamHoc == NamHoc)
                .Join(db.LOP_HOC_PHAN, svhp => svhp.MaLopHP, lhp => lhp.MaLopHP, (svhp, lhp) => new
                {
                    svhp.MaLopHP,
                    lhp.MON_HOC.SoTC,
                    TenHP = lhp.MON_HOC.TenMH,
                    lhp.MaGV
                })
                .Join(db.GIANG_VIEN, hp => hp.MaGV, gv => gv.MaGV, (hp, gv) => new
                {
                    hp.MaLopHP,
                    hp.TenHP,
                    hp.SoTC,
                    HoGV = gv.NGUOI_DUNG.Ho,
                    TenGV = gv.NGUOI_DUNG.Ten
                })
                .Join(db.THOI_KHOA_BIEU, hp => hp.MaLopHP, tkb => tkb.MaLopHP, (hp, tkb) => new
                {
                    hp.MaLopHP,
                    hp.TenHP,
                    hp.SoTC,
                    hp.HoGV,
                    hp.TenGV,
                    tkb.Thu,
                    tkb.TietBD,
                    tkb.TietKetThuc,
                    tkb.MaPhongHoc
                });
            List<LopHocPhan_DTO> res = new List<LopHocPhan_DTO>();

            int stt = 0;
            foreach (var i in li)
            {
                stt++;
                res.Add(new LopHocPhan_DTO()
                {
                    STT = stt,
                    MaHP = i.MaLopHP,
                    TenHP = i.TenHP,
                    SoTC = i.SoTC,
                    TenGV = i.HoGV + " " + i.TenGV,
                    tkb = new ThoiKhoaBieu_DTO(i.Thu, i.TietBD, i.TietBD, i.MaLopHP)
                });
            }
            return res;
        }

        public int GetKiHocHienTai(string MSSV)
        {
            return db.SINHVIEN_LOPHOCPHAN.Where(p => p.MaSV == MSSV).OrderByDescending(p => p.KiHoc)
                .Select(p => p.KiHoc).FirstOrDefault();
        }
    }
}
