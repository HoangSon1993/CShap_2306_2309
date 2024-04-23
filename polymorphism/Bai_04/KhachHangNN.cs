namespace Bai_04;

public class KhachHangNN: KhachHang
{
    public string QuocTich { get; set; }

    public override int TienDien => Convert.ToInt32(TieuThu * DonGia * 2.5);
    public override string ToString() => $"Họ tên: {HoTen}, Quốc tịch: {QuocTich}, Tiền điện: {TienDien}";

}