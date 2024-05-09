namespace OOP_LyHoangSon.Models
{
    public class SmartPhone:ElectronicDevice
    {
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public double KTManHinh { get; set; }
        public int TrongLuong { get; set; }
        public string HeDieuHanh { get; set; }
        public int BoNhoTrong => 0;
        public override int CongSuat => 0;
        
        public override string HangSanXuat => "";
        public override string BangTan => "";
        public override int DungTich => 0;
        public override int TheTichLamLanh => 0;
        public override int NHietDoToiDa => 0;
        public override int NhietDoToiThieu => 0;

        public override string ToString()
        {
            // Thông tin CPU
            // − Dung lượng RAM (GB)
            // − Kích thước màn hình (inch)
            // − Trọng lượng (gram)
            // − Hệ điều hành
            return $"Ten: {TenSanPham} - Gia ban: {GiaBan} - So luong ton: {SoluongTonKho} - Cpu: {Cpu} - Ram: {Ram} - KT Man hinh: {KTManHinh} - Trong luong: {TrongLuong} - He dieu hanh: {HeDieuHanh}";
        }

        public SmartPhone()
        {
            Type = TypeDevice.SmartPhone;
        }
    }
}