namespace Bai_04;

public class KhachHang
{
    public int MaSo { get; set; }
    public string HoTen { get; set; }
    public DateTime NgayLapHD { get; set; }
    public int TieuThu { get; set; }
    public int DonGia { get; set; }
    public virtual int TienDien => 0;
}