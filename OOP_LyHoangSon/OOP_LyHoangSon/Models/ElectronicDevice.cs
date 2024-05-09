namespace OOP_LyHoangSon.Models
{
    public class ElectronicDevice : IProduct
    {
        public string TenSanPham { get; set; }
        public double GiaBan { get; set; }
        public int SoluongTonKho { get; set; }
        public virtual string Cpu { get; set; }
        public virtual string Ram { get; set; }
        public virtual double KTManHinh { get; set; }
        public virtual int TrongLuong { get; set; }
        public virtual string HeDieuHanh { get; set; }
        public virtual int BoNhoTrong { get; set; }
        public virtual string HangSanXuat { get; set; }
        public virtual string BangTan { get; set; }
        public virtual int DungTich { get; set; }
        public virtual int CongSuat { get; set; }
        public virtual int TheTichLamLanh { get; set; }
        public virtual int NHietDoToiDa { get; set; }
        public virtual int NhietDoToiThieu { get; set; }
        public TypeDevice Type { get; set; }

        public override string ToString()
        {
            return
                $"Cpu: {Cpu} - Ram: {Ram} - KT Man hinh: {KTManHinh} - Trong luong: {TrongLuong} - He dieu hanh: {HeDieuHanh} - Bo nho trong: {BoNhoTrong} - Hang San Xuat: {HangSanXuat} - Bang Tan: {BangTan} - Dung tich: {DungTich} - The tich lam lanh: {TheTichLamLanh} - Nhiet do toi da: {NHietDoToiDa} - Nhiet do toi thieu: {NhietDoToiThieu}";
        }
    }

    public enum TypeDevice
    {
        SmartPhone,
        Tablet,
        SmartTV,
        SmartFridge,
        AirConditioner
    }
}