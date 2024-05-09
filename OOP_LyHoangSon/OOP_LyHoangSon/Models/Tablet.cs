namespace OOP_LyHoangSon.Models
{
    public class Tablet:ElectronicDevice
    {
        public override string HangSanXuat => "";
        public override string BangTan => "";
        public override int DungTich => 0;
        public override int TheTichLamLanh => 0;
        public override int NHietDoToiDa => 0;
        public override int NhietDoToiThieu => 0;
        public override int CongSuat => 0;

        public override string ToString()
        {
            //Thông tin CPU
            // − Dung lượng RAM (GB)
            // − Kích thước màn hình (inch)
            // − Bộ nhớ trong (GB)
            // − Hệ điều hành
            return $"Ten: {TenSanPham} - Gia ban: {GiaBan} - So luong ton: {SoluongTonKho} - Cpu: {Cpu} - Ram: {Ram} - KT Man hinh: {KTManHinh} - He dieu hanh: {HeDieuHanh} - Bo nho trong: {BoNhoTrong}";

        }

        public Tablet()
        {
            Type = TypeDevice.Tablet;
        }
    }
}