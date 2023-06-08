using DTO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class SinhVien_DAL
    {

        public static bool CheckIdStudentExist(string MSSV)
        {
            using (var db = new PBL3Entities())
            {
                return db.THONG_TIN_DANG_NHAP.Where(p => p.TaiKhoan == MSSV
                                          && p.VaiTro == "Sinh Viên").FirstOrDefault() != null;
            }
        }

        public static string GetNameOfHomeroomClass(string MSSV)
        {
            using (var db = new PBL3Entities())
            {
                return db.SINH_VIEN.Where(sv => sv.MaSV == MSSV).Select(sv => sv.MaLopSH).FirstOrDefault();
            }
        }
        public static SINH_VIEN GetSinhVienById(string id)
        {
            #region Trước đó
            //return db.SINH_VIEN.Where(p => p.MaSV == id).Include(sv => sv.NGUOI_DUNG).
            //    Include(sv => sv.CHUONG_TRINH_DAO_TAO).Include(sv => sv.CHUONG_TRINH_DAO_TAO.KHOA).SingleOrDefault();
            #endregion
            using (var db = new PBL3Entities())
            {
                //Do hầu như lấy hết tất cả cột của bảng NguoiDung và Khoa nên mới dùng Include trong trường hợp này
                //Ko cần phải Include(sv => sv.CHUONG_TRINH_DAO_TAO) vì đã có trong
                //Include(sv => sv.CHUONG_TRINH_DAO_TAO.KHOA)
                return db.SINH_VIEN.Where(p => p.MaSV == id).Include(sv => sv.NGUOI_DUNG)
                .Include(sv => sv.CHUONG_TRINH_DAO_TAO.KHOA).SingleOrDefault();
            }
        }

        public static List<SINH_VIEN> GetSinhVienInLopSH(string MaLopSH)
        {
            using (var db = new PBL3Entities())
            {
                return db.SINH_VIEN.Where(p => p.MaLopSH == MaLopSH).Include(sv => sv.PHU_HUYNH).
                OrderBy(sv => sv.MaSV).ToList();
            }
        }

        public static bool UpdateStudentInfo(SinhVien_DTO sv)
        {
            using (var db = new PBL3Entities())
            {
                //Hàm này dùng trong frmStudent để cập nhật thông tin cá nhân
                NGUOI_DUNG nd = db.NGUOI_DUNG.Where(p => p.MaNguoiDung == sv.MaNguoiDung).FirstOrDefault();
                if (nd != null)
                {
                    if (sv.DiaChi != "")
                        nd.DiaChi = sv.DiaChi;
                    if (sv.EmailCaNhan != "")
                        nd.EmailCaNhan = sv.EmailCaNhan;
                    if (sv.Sdt != "")
                        nd.Sdt = sv.Sdt;
                    if (sv.NoiSinh != "")
                        nd.NoiSinh = sv.NoiSinh;
                    if (sv.DanToc != "")
                        nd.DanToc = sv.DanToc;
                    if (sv.QuocTich != "")
                        nd.QuocTich = sv.QuocTich;
                    if (sv.AnhCaNhan != null)
                        nd.AnhCaNhan = sv.AnhCaNhan;
                    return db.SaveChanges() > 0;
                }
                return false;
            }
        }

        #region Các hàm xử lí chức năng xem lịch học trong ngày, trong tuần
        public static int GetKiHocHienTai(string MaSV)
        {
            using (var db = new PBL3Entities())
            {
                //Kì học đếm như sau: 1,2,3,4,5,6,7,8|,9,10
                int KiHocHienTai = db.SINHVIEN_LOPHOCPHAN.Where(p => p.MaSV == MaSV)
                .GroupJoin(db.LOP_HOC_PHAN, svhp => svhp.MaLopHP, hp => hp.MaLopHP, (svhp, hp) => new
                {
                    Hocphan_tmp = hp.DefaultIfEmpty()
                })
                .SelectMany(i1 => i1.Hocphan_tmp.Select(i2 => new
                {
                    i2.KiHoc
                })).OrderByDescending(i => i.KiHoc).Select(i => i.KiHoc).FirstOrDefault();
                return KiHocHienTai;
            }
        }

        public static List<LopHocPhan_DTO> GetLichHocTrongTuan(string MaSV, int KiHoc)
        {
            using (var db = new PBL3Entities())
            {
                //Một khi đã thêm được sv vào lớp học phần thì lúc này chắc chắn đã phân công GV rồi
                //nên không sợ chưa có GiangVien, đỡ phải GroupJoin với GIANG_VIEN. Và một khi phân công được
                //giảng viên thì chứng tỏ đã có dữ liệu về TKB rồi
                var li = db.SINHVIEN_LOPHOCPHAN.Where(i => i.MaSV == MaSV)
                .GroupJoin(db.LOP_HOC_PHAN, svhp => svhp.MaLopHP, hp => hp.MaLopHP, (svhp, hp) => new
                {
                    Hocphan_tmp = hp.DefaultIfEmpty()
                })
                .SelectMany(i1 => i1.Hocphan_tmp.Select(i2 => new
                {
                    i2.MaLopHP,
                    i2.MON_HOC.TenMH,
                    i2.MON_HOC.SoTC,
                    i2.KiHoc,
                    HoTenGV = i2.GIANG_VIEN.NGUOI_DUNG.Ho + " " + i2.GIANG_VIEN.NGUOI_DUNG.Ten
                }))
                .Where(i => i.KiHoc == KiHoc)
                .Join(db.THOI_KHOA_BIEU, hp => hp.MaLopHP, tkb => tkb.MaLopHP, (hp, tkb) => new LopHocPhan_DTO()
                {
                    MaHP = hp.MaLopHP,
                    TenHP = hp.TenMH,
                    TenGV = hp.HoTenGV,
                    SoTC = hp.SoTC,
                    KiHoc = hp.KiHoc,
                    tkb = new ThoiKhoaBieu_DTO()
                    { Thu = tkb.Thu, TietBD = tkb.TietBD, TietKT = tkb.TietKetThuc, Phong = tkb.MaPhongHoc }
                }).ToList();
                return li;
            }
        }
        #endregion

        /// <summary>
        /// Dùng để trả về kết quả học tập của sinh viên
        /// </summary>
        /// <param name="MaSV"></param>
        /// <returns></returns>
        public static List<KetQuaHocTap> GetKetQuaHocTap(string MaSV)
        {
            using (var db = new PBL3Entities())
            {
                var li = db.SINHVIEN_LOPHOCPHAN.Where(sv => sv.MaSV == MaSV)
                .Join(db.LOP_HOC_PHAN, sv => sv.MaLopHP, hp => hp.MaLopHP, (sv, hp) => new
                {
                    //Lấy ra các lớp học phần mà sinh viên này học
                    hp.MaLopHP,
                    hp.MON_HOC.TenMH,
                    hp.KiHoc,
                    hp.NamHoc,
                    hp.MON_HOC.SoTC,
                    hp.MON_HOC.CtTinhDiem
                })
                .GroupJoin(db.BAI_KIEM_TRA, hp => hp.MaLopHP, bkt => bkt.MaLopHP, (hp, bkt) => new
                {
                    //Do cũng có thể 1 lớp học phần chưa có bài kiểm tra nào nên phải dùng Left join
                    LopHP_tmp = hp,
                    BaiKiemTra_tmp = bkt.DefaultIfEmpty()
                })
                .SelectMany(i1 => i1.BaiKiemTra_tmp.Select(i2 => new
                {
                    i1.LopHP_tmp.MaLopHP,
                    i1.LopHP_tmp.TenMH,
                    i1.LopHP_tmp.KiHoc,
                    i1.LopHP_tmp.NamHoc,
                    i1.LopHP_tmp.SoTC,
                    i1.LopHP_tmp.CtTinhDiem,
                    i2.MaBaiKiemTra,
                    //LoaiBaiKiemTra (Test, Giữa kì, Cuối kì)
                    LoaiBaiKiemTra = i2.TenBaiKiemTra
                }))
                .GroupJoin(db.LAM_BAI_KIEM_TRA, bkt => bkt.MaBaiKiemTra, lambkt => lambkt.MaBaiKiemTra, (bkt, lambkt) => new
                {
                    //Cũng có thể có bài kiểm tra rồi nhưng sinh viên này chưa làm thì cũng chưa có điểm
                    BaiKiemTra_tmp = bkt,

                    /*Đang thực hiện truy vấn theo chiều từ BaiKiemTra->LamBaiKiemTra
                    Do đó sẽ lấy ra tất cả lịch sử làm bài của CÁC SINH VIÊN làm bài kiểm tra đó
                    => Cần phải thêm một bước Where ở đây và dùng DefaultIfEmpty() để nếu sinh viên này
                    chưa làm bài kiểm tra đó thì vẫn hiển thị thông tin của lớp học phần đó
                    */
                    LamBaiKiemTra_tmp = lambkt.Where(p => p.MaSV == MaSV).DefaultIfEmpty()
                })
                .SelectMany(i1 => i1.LamBaiKiemTra_tmp.Select(i2 => new
                {
                    i2.MaSV,
                    i1.BaiKiemTra_tmp.MaLopHP,
                    i1.BaiKiemTra_tmp.TenMH,
                    i1.BaiKiemTra_tmp.KiHoc,
                    i1.BaiKiemTra_tmp.NamHoc,
                    i1.BaiKiemTra_tmp.SoTC,
                    i1.BaiKiemTra_tmp.CtTinhDiem,
                    i1.BaiKiemTra_tmp.LoaiBaiKiemTra,
                    Diem = (double?)i2.Diem
                    //Nếu để Where(p => p.MaSV == MaSV) ngay sau SelectMany này thì kết quả
                    //trả về chỉ các bản ghi nào mà sinh viên có làm bài kiểm tra của lớp học phần đó 
                })).OrderBy(p => p.KiHoc).ToList();

                //Dùng Dictionary ở đây để lấy ra KetQuaHocTap của 1 lớp HP nào đó một cách nhanh chóng
                Dictionary<string, KetQuaHocTap> dict = new Dictionary<string, KetQuaHocTap>();

                //Gộp kết quả làm bài của các bài kiểm tra vào theo từng lớp học phần
                List<KetQuaHocTap> res = new List<KetQuaHocTap>();
                int STT = 1;
                foreach (var item in li)
                {
                    KetQuaHocTap kq;
                    bool checkIsExist = false;
                    if (dict.ContainsKey(item.MaLopHP))
                    {
                        kq = dict[item.MaLopHP];
                        checkIsExist = true;
                    }
                    else
                    {
                        kq = new KetQuaHocTap()
                        {
                            MaLopHP = item.MaLopHP,
                            TenMH = item.TenMH,
                            SoTC = item.SoTC,
                            KiHoc = item.KiHoc,
                            NamHoc = item.NamHoc + " - " + (item.NamHoc + 1),
                            CtTinhDiem = item.CtTinhDiem
                        };
                    }
                    if (item.LoaiBaiKiemTra == "Test" && item.Diem != null)
                        kq.DiemBTs.Add((double)item.Diem);
                    else if (item.LoaiBaiKiemTra == "Giữa kỳ")
                        kq.GK = item.Diem;
                    else if (item.LoaiBaiKiemTra == "Cuối kỳ")
                        kq.CK = item.Diem;
                    else if (item.LoaiBaiKiemTra == "Quá trình")
                        kq.QT = item.Diem;
                    else kq.DA = item.Diem;
                    if (!checkIsExist)
                    {
                        kq.STT = STT++;
                        res.Add(kq);
                        dict.Add(item.MaLopHP, kq);
                    }
                }
                return res;
            }
        }
    }
}
