namespace OOP_LyHoangSon.Models
{
    public class SmartFridge:ElectronicDevice
    {
            public override string Cpu => "";
            public override string Ram => "";
            public override double KTManHinh => 0;
            public override string HeDieuHanh => "";
            public override int BoNhoTrong => 0;
            public override string BangTan => "";
            public override int TheTichLamLanh => 0;
            public override int NHietDoToiDa => 0;
            public override int NhietDoToiThieu => 0;

            public override string ToString()
            {
                //Tủ lạnh thông minh có các thông tin:
                // − Dung tích (lít)
                // − Trọng lượng (kg)
                // − Hãng sản xuất
                return $"Ten: {TenSanPham} - Gia ban: {GiaBan} - So luong ton: {SoluongTonKho} - Trong luong: {TrongLuong} - Hang San Xuat: {HangSanXuat} - Dung tich: {DungTich}";

            }

            public SmartFridge()
        {
            Type = TypeDevice.SmartFridge;
        }
    }
}