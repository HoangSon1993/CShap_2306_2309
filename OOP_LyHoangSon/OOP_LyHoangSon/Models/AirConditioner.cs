namespace OOP_LyHoangSon.Models
{
    public class AirConditioner:ElectronicDevice
    {
        public override string Cpu => "";
        public override string Ram => "";
        public override double KTManHinh => 0;
        public override int TrongLuong => 0;
        public override string HeDieuHanh => "";
        public override int BoNhoTrong => 0;
        public override string HangSanXuat => "";
        public override string BangTan => "";
        public override int DungTich => 0;

        public override string ToString()
        {
            //Máy lạnh có các thông tin:
            // − Công suất (HP)
            // − Thể tích làm lạnh (m3
            // )
            // − Nhiệt độ tối thiểu (oC)
            // − Nhiệt độ tối đa (oC)
            return $"Ten: {TenSanPham} - Gia ban: {GiaBan} - So luong ton: {SoluongTonKho} - Cong suat: {CongSuat} -The tich lam lanh: {TheTichLamLanh} - Nhiet do toi da: {NHietDoToiDa} - Nhiet do toi thieu: {NhietDoToiThieu}";

        }


        public AirConditioner()
        {
            Type = TypeDevice.AirConditioner;
        }
    }
}