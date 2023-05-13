using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class PhuHuynh_DAL
    {
        private PBL3Entities db;
        private static PhuHuynh_DAL _Instance;

        public static PhuHuynh_DAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new PhuHuynh_DAL();
                return _Instance;
            }
        }

        private PhuHuynh_DAL()
        {
            db = new PBL3Entities();
        }
        public List<PHU_HUYNH> GetPhuHuynhByIdStudent(string mssv)
        {
            //Sắp xếp theo MoiQuanHe để Cha - Con trả về trước Mẹ - Con
            return db.PHU_HUYNH.Where(ph => ph.MaSV == mssv).OrderBy(ph => ph.MoiQuanHe).ToList();
        }


        public bool UpdateParentInfo(PhuHuynh_DTO phuHuynhOld, string oldName)
        {
            PHU_HUYNH phuHuynh = db.PHU_HUYNH.Where(p => p.MaSV == phuHuynhOld.MaSV && p.TenPH == oldName)
                .FirstOrDefault();
            if (phuHuynh == null)
            {
                //null tức là chưa có thông tin cha/mẹ của sinh viên này trong CSDL
                phuHuynh = new PHU_HUYNH();
                //(MaSV,TenPH) là khoá chính nên không thể thiếu việc gán MaSV qua cho phuHuynh mới tạo ra
                phuHuynh.MaSV = phuHuynhOld.MaSV;
                db.PHU_HUYNH.Add(phuHuynh);
            }

            /*Tên phụ huynh đã bị thay đổi và phụ huynh này trước đó ĐÃ CÓ trong CSDL(oldName != "")
            Việc thêm đk oldName != "" rất quan trọng vì nếu thiếu đk này thì ta sẽ xoá đi phuHuynh vừa thêm
            tại lần thêm ở if trước đó nếu phụ huynh này chưa có trong CSDL*/
            if (phuHuynhOld.TenPH != oldName && oldName != "")
            {
                //Xoá bản ghi cũ rồi thêm mới vì TenPH là 1 phần của khoá chính 
                db.PHU_HUYNH.Remove(phuHuynh);
                db.SaveChanges();
                phuHuynh.TenPH = phuHuynhOld.TenPH;
                db.PHU_HUYNH.Add(phuHuynh);
            }
            if (phuHuynhOld.Sdt != "")
                phuHuynh.Sdt = phuHuynhOld.Sdt;
            if (phuHuynhOld.DiaChi != "")
                phuHuynh.DiaChi = phuHuynhOld.DiaChi;

            phuHuynh.NgaySinh = phuHuynhOld.NgaySinh;
            phuHuynh.GioiTinh = phuHuynhOld.GioiTinh;
            phuHuynh.MoiQuanHe = phuHuynhOld.MoiQuanHe;
            return db.SaveChanges() > 0;
        }
    }
}
