using System.Diagnostics.SymbolStore;

namespace OOP_LyHoangSon.Models
{
    public interface IProduct
    {
        string TenSanPham { get; set; }
        double GiaBan { get; set; }
        int SoluongTonKho { get; set; }
        string Cpu { get; set; } 
        string Ram { get; set; } //xoa
        double KTManHinh { get; set; } //xoa
        int TrongLuong { get; set; } //xoa
        string HeDieuHanh { get; set; } // xoa
        int BoNhoTrong { get; set; } // xoa
        string HangSanXuat { get; set; } // xoa
        string BangTan { get; set; }  //xoa
        int DungTich { get; set; } //xoa
        int CongSuat { get; set; }
        int TheTichLamLanh { get; set; } //xoa
        int NHietDoToiDa { get; set; } //xoa
        int NhietDoToiThieu { get; set; } //xoa
        
        
    }
}