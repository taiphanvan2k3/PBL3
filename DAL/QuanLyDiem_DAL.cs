namespace DAL
{
    /// <summary>
    /// Lớp này hiện tại chưa dùng vào mục đích gì ????
    /// </summary>
    public class QuanLyDiem_DAL
    {
        private PBL3Entities db;
        private QuanLyDiem_DAL _Instance;
        public QuanLyDiem_DAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QuanLyDiem_DAL();
                return _Instance;
            }
        }

        private QuanLyDiem_DAL()
        {
            db = new PBL3Entities();
        }
        //public List<KetQuaLamKiemTra>GetKetQuaHocTap(string MSSV,int KiHoc,int NamHoc)
        //{
        //    var li=db.SINHVIEN_LOPHOCPHAN.
        //}
    }
}
