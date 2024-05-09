namespace OOP_LyHoangSon.Models
{
    public class SmartTV:ElectronicDevice
    {

        public override string Cpu => "";
        public override string Ram => "";
        public override int TrongLuong => 0;
        public override int BoNhoTrong => 0;
        public override int DungTich => 0;
        public override int TheTichLamLanh => 0;
        public override int NHietDoToiDa => 0;
        public override int NhietDoToiThieu => 0;

        public override string ToString()
        {
            //TV thông minh có các thông tin:
            // − Kích thước màn hình (inch)
            // − Hệ điều hành
            // − Hãng sản xuất
            // − Băng tần: 2.4 GHz hoặc 5.0 GHz
            return $"Ten: {TenSanPham} - Gia ban: {GiaBan} - So luong ton: {SoluongTonKho} - KT Man hinh: {KTManHinh} - He dieu hanh: {HeDieuHanh} - Hang San Xuat: {HangSanXuat} - Bang Tan: {BangTan}";

        }

        public SmartTV()
        {
            Type = TypeDevice.SmartTV;
        }
    }
}