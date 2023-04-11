namespace DTO
{
    public class ThoiKhoaBieu_DTO
    {


        public string Thu { get; set; }
        public int TietBD { get; set; }
        public int TietKT { get; set; }
        public string Phong { get; set; }
        public ThoiKhoaBieu_DTO(string thu, int tietBD, int tietKT, string phong)
        {
            Thu = thu;
            TietBD = tietBD;
            TietKT = tietKT;
            Phong = phong;
        }
        public ThoiKhoaBieu_DTO() { }
        public override string ToString()
        {
            return Thu + "," + TietBD + "-" + TietKT + "," + Phong;
        }
    }
}
