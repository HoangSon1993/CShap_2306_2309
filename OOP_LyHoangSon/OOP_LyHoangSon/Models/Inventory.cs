using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Policy;

namespace OOP_LyHoangSon.Models
{
    public class Inventory
    {
        public List<ElectronicDevice> Devices { get; set; } = new List<ElectronicDevice>();
        public double Money { get; set; } = 1000000000;

        public Inventory()
        {
            Devices.Add(new SmartPhone()
            {
                TenSanPham = "Iphone 13pro",
                GiaBan = 17500000,
                SoluongTonKho = 4,
                Cpu = "M1 Max",
                Ram = "16Gb",
                KTManHinh = 5.2,
                TrongLuong = 245,
                HeDieuHanh = "IOS"
            });
            Devices.Add(new SmartPhone()
            {
                TenSanPham = "Iphone 14pro Max",
                GiaBan = 32200000,
                SoluongTonKho = 12,
                Cpu = "M2 Max",
                Ram = "32Gb",
                KTManHinh = 6.8,
                TrongLuong = 322,
                HeDieuHanh = "IOS"
            });
            Devices.Add(new SmartPhone()
            {
                TenSanPham = "SamSung Galaxy S22 Ultra",
                GiaBan = 22700000,
                SoluongTonKho = 5,
                Cpu = "Snapdragon 8 Gen 2 for Galaxy",
                Ram = "8Gb",
                KTManHinh = 6.8,
                TrongLuong = 223,
                HeDieuHanh = "Android 13"
            });
            Devices.Add(new SmartPhone()
            {
                TenSanPham = "Iphone 12",
                GiaBan = 13200000,
                SoluongTonKho = 1,
                Cpu = "M1 Pro",
                Ram = "16Gb",
                KTManHinh = 4.8,
                TrongLuong = 218,
                HeDieuHanh = "IOS"
            });
            Devices.Add(new Tablet()
            {
                TenSanPham = "Ipad pro 10.5",
                GiaBan = 25100000,
                SoluongTonKho = 3,
                Cpu = "Apple A13 Bionic",
                Ram = "32Gb",
                KTManHinh = 10.2,
                BoNhoTrong = 64,
                HeDieuHanh = "iPadOS 15"
            });
            Devices.Add(new Tablet()
            {
                TenSanPham = "SamSung Galaxy Tab s10",
                GiaBan = 15600000,
                SoluongTonKho = 7,
                Cpu = "Exynos 1280 8 nhân",
                Ram = "8Gb",
                KTManHinh = 10.4,
                BoNhoTrong = 64,
                HeDieuHanh = "Android 14"
            });
            Devices.Add(new Tablet()
            {
                TenSanPham = "SamSung GalaXy tab s9",
                GiaBan = 12500000,
                SoluongTonKho = 2,
                Cpu = "Snapdragon 685 8 nhân",
                Ram = "16Gb",
                KTManHinh = 11.5,
                BoNhoTrong = 128,
                HeDieuHanh = "Android 13"
            });
            Devices.Add(new SmartTV()
            {
                TenSanPham = "Samsung Oled abc",
                GiaBan = 32000000,
                SoluongTonKho = 7,
                KTManHinh = 55,
                HeDieuHanh = "Tizen",
                HangSanXuat = "SamSung",
                BangTan = "5.0GHz"
            });
            Devices.Add(new SmartTV()
            {
                TenSanPham = "Vidaa Oleb 43inch",
                GiaBan = 29200000,
                SoluongTonKho = 3,
                KTManHinh = 43,
                HeDieuHanh = "Vidaa U7",
                HangSanXuat = "Toshiba",
                BangTan = "2.4GHz"
            });
            Devices.Add(new SmartFridge()
            {
                TenSanPham = "Nagakawa inventor 12",
                GiaBan = 12000000,
                SoluongTonKho = 12,
                DungTich = 404,
                TrongLuong = 86,
                HangSanXuat = "Sharp"
            });
            Devices.Add(new SmartFridge()
            {
                TenSanPham = "TCL Inventor 1HP",
                GiaBan = 9200000,
                SoluongTonKho = 3,
                DungTich = 407,
                TrongLuong = 77,
                HangSanXuat = "LG"
            });
            Devices.Add(new AirConditioner()
            {
                TenSanPham = "Casper Inventor 1Hp",
                GiaBan = 4990000,
                SoluongTonKho = 15,
                CongSuat = 45,
                TheTichLamLanh = 15,
                NHietDoToiDa = 28,
                NhietDoToiThieu = 16
            });
            Devices.Add(new AirConditioner()
            {
                TenSanPham = "Nagakawa inventor 1.5Hp",
                GiaBan = 7590000,
                SoluongTonKho = 6,
                CongSuat = 55,
                TheTichLamLanh = 20,
                NHietDoToiDa = 27,
                NhietDoToiThieu = 15
            });
        }

        //− Đếm số sản phẩm có trong kho đồ.
        public int Count()
        {
            return Devices.Count;
        }

        // − Đếm số sản phẩm theo mỗi loại.
        public int CountByItem(TypeDevice type)
        {
            return Devices.Count(e => e.Type == type);
        }

        // − Liệt kê danh sách sản phẩm sắp hết hàng (tồn kho < 5), sắp xếp theo số lượng tồn
        public List<ElectronicDevice> SanPhamSapHetHang()
        {
            return Devices.Where(e => e.SoluongTonKho < 5).ToList();
        }

        // kho tăng dần, giá tiền giảm dần.
        public List<ElectronicDevice> SapXepTheoKhoGia()
        {
            return Devices
                .OrderBy(e => e.SoluongTonKho)
                .ThenByDescending(e => e.GiaBan)
                .ToList();
        }

        // − Tổng lượng tiền còn tồn trong kho (gồm tiền của các sản phẩm và tiền mặt).
        public double TongTienTonKho()
        {
            return Devices.Sum(e => e.GiaBan * e.SoluongTonKho) + Money;
        }

        // − Liệt kê danh sách các điện thoại chạy hệ điều hành Android.
        public List<ElectronicDevice> DtAndroid()
        {
            return Devices
                .Where(e => e.HeDieuHanh == "Android")
                .ToList();
        }

        // − Cho biết máy tính bảng có dung lượng RAM cao nhất.
        public List<ElectronicDevice> TableMaxRam(TypeDevice type)
        {
            var maxRam = Devices.Max(E => E.Ram);
            return Devices
                .Where(e => e.Type == type && e.Ram == maxRam)
                .ToList();
        }

        // − Cho biết sản phẩm có giá bán cao nhất.
        public List<ElectronicDevice> SanPhamGiaCaoNhat()
        {
            var maxGiaBan = Devices.Max(e => e.GiaBan);
            return Devices
                .Where(e => e.GiaBan == maxGiaBan)
                .ToList();
        }

        // − Cho biết top 3 sản phẩm có kích thước màn hình lớn nhất.
        public List<ElectronicDevice> Top3KichThuocManHinh_Max()
        {
            return Devices
                .OrderByDescending(e => e.KTManHinh)
                .Take(3)
                .ToList();
        }

        // − Tính công suất làm lạnh trung bình của tất cả máy lạnh.
        public double CongSuatLamLanhTrungBinh()
        {
            return Devices.Average(e => e.CongSuat);
        }

        // − Tính tổng dung tích của tất cả tủ lạnh thuộc hãng LG.
        public int TongDungTichTuLanhLG ()
        {
            return (Devices
                    .Where(e => e.HangSanXuat == "LG"))
                .Sum(e => e.CongSuat);
        }
    }
}