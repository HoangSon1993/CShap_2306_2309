namespace Bai_04;

public class CongTy
{
    public List<KhachHang> DS { get; set; } = new List<KhachHang>();

    public CongTy()
    {
        DS.Add(new KhachHangVN()
        {
            MaSo = 1,
            HoTen = "Nguyễn Văn An",
            Loai = 1,
            NgayLapHD = new DateTime(2024,4,19),
            TieuThu = 100,
            DinhMuc = 200,
            DonGia = 3000
        });
        DS.Add(new KhachHangNN()
        {
            MaSo = 2,
            HoTen = "Mbabe",
            NgayLapHD = new DateTime(2024,4,20),
            TieuThu = 220,
            DonGia = 3000
        });
        DS.Add(new KhachHangNN()
        {
            MaSo = 3,
            HoTen = "Messi",
            NgayLapHD = new DateTime(2024,4,24),
            TieuThu = 210,
            DonGia = 3000
        });
        DS.Add(new KhachHangVN()
        {
            MaSo = 1,
            HoTen = "Nguyễn Thị Định",
            Loai = 1,
            NgayLapHD = new DateTime(2024,4,19),
            TieuThu = 78,
            DinhMuc = 200,
            DonGia = 3000
        });
    }

    public void Xuat()
    {
        foreach (var item in DS)
        {
            Console.WriteLine(item);
        }
    }

    public int TongTienDien
    {
        get
        {
            int tong = 0;
            foreach (var item in DS)
            {
                tong += item.TienDien;
            }
            return tong;
        }
    }

    public KhachHang TieuThuItNhat()
    {
        KhachHang min = DS[0];
        foreach (var item in DS)
        {
            if (item.TienDien < min.TienDien)
            {
                min = item;
            }

        }
            return min;
    }
}