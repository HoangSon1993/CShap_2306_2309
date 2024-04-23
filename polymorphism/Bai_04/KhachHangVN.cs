namespace Bai_04;

public class KhachHangVN: KhachHang
{
    public int Loai { get; set; }
    public int DinhMuc { get; set; }
    public override int TienDien {
        get
        {
            if (TieuThu <= DinhMuc)
            {
                return TieuThu * DonGia;
            }
            else
            {
                return Convert.ToInt32(DinhMuc + (TieuThu - DinhMuc) * 2.5) * DonGia;
            }
        }
    }

   public override string ToString() => $"Họ tên: {HoTen}, Quốc tịch: Việt Nam, Tiền điện: {TienDien}";
}