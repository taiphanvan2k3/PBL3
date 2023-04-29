﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public List<CauHoi_DTO> GetListQuestionInExam(int MaBaiKiemTra)
        {
            //Lấy ra danh sách câu hỏi của bài kiểm tra
            return BaiKiemTra_DAL.Instance.GetListQuestionInExam(MaBaiKiemTra);
        }


        /// <summary>
        /// Lấy ra thông tin của tất cả các bài kiểm tra mà sinh viên đó có thể làm
        /// </summary>
        /// <param name="MaSV"></param>
        /// <returns></returns>
        public List<BaiKiemTra_DTO> GetAllExamOfStudent(string MaSV)
        {
            return BaiKiemTra_DAL.Instance.GetAllExamOfStudent(MaSV);
        }

        /// <summary>
        /// Trả về kết quả làm bài kiểm tra của sinh viên theo kì
        /// </summary>
        /// <param name="MaSV"></param>
        /// <param name="KiHoc"></param>
        /// <param name="TenHP"></param>
        /// <returns></returns>
        public List<KetQuaLamKiemTra> GetKetQuaLambaiTheoDieuKien(string MaSV, int KiHoc, string TenHP = null)
        {
            var li = BaiKiemTra_DAL.Instance.GetKetQuaLambaiTheoKi(MaSV, KiHoc);
            if (TenHP == null)
                return li;
            return li.Where(p => p.TenMH == TenHP).ToList();
        }

        public List<KetQuaLamKiemTra_SVLHP> GetKetQuaKiemTra_LHP(int MaBaiKiemTra)
        {
            return BaiKiemTra_DAL.Instance.GetKetQuaKiemTra_LHP(MaBaiKiemTra);
        }

        public List<BaiKiemTra_DTO> GetListExamInMonth(int month, int year)
        {
            DateTime startDate = new DateTime(year, month, 1);
            int maxDay = UtilityClass.GetNumberOfDayInMonth(month, year);
            DateTime endDate = new DateTime(year, month, maxDay);
            return BaiKiemTra_DAL.Instance.GetListExamInMonth(startDate, endDate);
        }
    }
}