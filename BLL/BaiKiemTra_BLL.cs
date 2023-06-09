using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BaiKiemTra_BLL
    {
        private static BaiKiemTra_BLL _Instance;
        public static BaiKiemTra_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BaiKiemTra_BLL();
                return _Instance;
            }
        }

        private BaiKiemTra_BLL() { }

        public List<CauHoi_DTO> GetListQuestionInExam(int MaBaiKiemTra, int TongSoCau)
        {
            //Lấy ra danh sách câu hỏi của bài kiểm tra
            return BaiKiemTra_DAL.Instance.GetListQuestionInExam(MaBaiKiemTra, TongSoCau);
        }

        /// <summary>
        /// Lấy ra thông tin của tất cả các bài kiểm tra mà sinh viên đó có thể làm
        /// Hiển thị ở datagridview UC_DoExam
        /// </summary>
        /// <param name="MaSV"></param>
        /// <returns></returns>
        public List<BaiKiemTra_DTO> GetAllExamOfStudent(string MaSV)
        {
            return BaiKiemTra_DAL.Instance.GetAllExamOfStudent(MaSV);
        }

        /// <summary>
        /// Trả về kết quả làm bài của tất cả bài kiểm tra mà sinh viên
        /// đã làm để hiển thị lên dtgv của UC_ViewHistoryDoExam
        /// </summary>
        /// <param name="MaSV"></param>
        /// <param name="KiHoc"></param>
        /// <param name="TenHP"></param>
        /// <returns></returns>
        public List<KetQuaLamKiemTra> GetAllKetQuaLamBai(string MaSV)
        {
            return BaiKiemTra_DAL.Instance.GetAllKetQuaLamBai(MaSV);
        }

        /// <summary>
        /// Đây là chức năng của giáo viên, xem kết quả làm bài của sinh viên tại bài kiểm tra nào đó do mình tạo
        /// </summary>
        /// <param name="MaBaiKiemTra"></param>
        /// <returns></returns>
        public List<KetQuaLamKiemTra_SVLHP> GetKetQuaKiemTra_LHP(int MaBaiKiemTra)
        {
            return BaiKiemTra_DAL.Instance.GetKetQuaKiemTra_LHP(MaBaiKiemTra);
        }

        /// <summary>
        /// Trả về List bài kiểm tra trong tháng để hiển thị lên Calendar
        /// </summary>
        /// <param name="MaSV"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public List<BaiKiemTra_DTO> GetListExamInMonth(string MaSV, int month, int year)
        {
            DateTime startDate = new DateTime(year, month, 1);
            int maxDay = UtilityClass.GetNumberOfDayInMonth(month, year);
            DateTime endDate = new DateTime(year, month, maxDay);
            return BaiKiemTra_DAL.Instance.GetListExamInMonth(MaSV, startDate, endDate);
        }

        public void SaveResultOfDoExam(KetQuaLamKiemTra kq)
        {
            LAM_BAI_KIEM_TRA lambkt = new LAM_BAI_KIEM_TRA()
            {
                MaSV = kq.MaSV,
                MaBaiKiemTra = kq.MaBaiKiemTra,
                SoCauDung = (byte)kq.SoCauDung,
                SoLanViPham = (byte)kq.SoLanViPham,
                ThoiGianLamBai = kq.ThoiGianLamBai,
                ThoiGianNopBai = kq.ThoiGianNopBai,
                Diem = kq.Diem
            };
            BaiKiemTra_DAL.Instance.SaveResultOfDoExam(lambkt);
        }

        /// <summary>
        /// Lưu kết quả phúc khảo khi nhấn nút nộp bài ở frmQuiz 
        /// </summary>
        /// <param name="maSV"></param>
        /// <param name="maBaiKiemTra"></param>
        /// <param name="listCauHoi"></param>
        public void SaveKetQuaPhucKhao(string maSV, int maBaiKiemTra, List<CauHoi_DTO> listCauHoi)
        {
            List<KET_QUA_PHUC_KHAO> listKetQuaPhucKhao = new List<KET_QUA_PHUC_KHAO>();
            int i = 1;
            foreach(var cauHoi in listCauHoi)
            {
                listKetQuaPhucKhao.Add(new KET_QUA_PHUC_KHAO
                {
                    maSV = maSV,
                    maBaiKiemTra = maBaiKiemTra,
                    thuTuCauHoi = i,
                    tenCauHoi = cauHoi.TenCauHoi,
                    dapAnA = cauHoi.DapAnHienThi[0],
                    dapAnB = cauHoi.DapAnHienThi[1],
                    dapAnC = cauHoi.DapAnHienThi[2],
                    dapAnD = cauHoi.DapAnHienThi[3],
                    dapAnChon = cauHoi.maDapAnChon,
                    dapAnDung = cauHoi.maDapAnDung
                });
                i++;
            }
            BaiKiemTra_DAL.Instance.SaveKetQuaPhucKhao(listKetQuaPhucKhao);
        }

        /// <summary>
        /// Trả về danh sách các bài kiểm tra của 1 lớp học phần
        /// </summary>
        /// <param name="moduleClass"></param>
        /// <returns></returns>
        public List<CBBItem> GetAllExamsInSpecificModuleClass(string moduleClass)
        {
            return BaiKiemTra_DAL.Instance.GetAllExamsInSpecificModuleClass(moduleClass);
        }

        /// <summary>
        /// Sẽ được gọi mỗi khi được nhập password thành công
        /// </summary>
        /// <param name="MSV"></param>
        /// <param name="maBaiKT"></param>
        public void IsDoingExam(string MSV, int maBaiKT)
        {
             BaiKiemTra_DAL.Instance.IsDoingExam(MSV, maBaiKT);
        }

        public double? IsExsitExam(string MSV, int maBaiKT)
        {
            return BaiKiemTra_DAL.Instance.IsExsitExam(MSV, maBaiKT);
        }

        public List<CauHoi_DTO> GetCauHoiPhucKhao(string MaSV, int MaBaiKiemTra)
        {
            return BaiKiemTra_DAL.Instance.GetCauHoiPhucKhao(MaSV, MaBaiKiemTra);
        }
    }
}
