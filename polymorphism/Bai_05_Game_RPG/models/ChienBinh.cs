using System;

namespace Bai_05_Game_RPG
{
    public class ChienBinh:NhanVat
    {
        public override int MIN_SatThuongVatLy => SucManh;
        public override int MAX_SatThuongVatLy => Convert.ToInt32(SucManh * 1.5);
        public override int TyLeChiMang => Convert.ToInt32((SucManh * 0.5) + (NhanhNhen * 0.1));
        public override int Giap => Convert.ToInt32(BenBi * 1.5);
        public override int KhangPhep => (ThongThai + 1) * BenBi;
        public override int Mau => 300 + (10 * SucManh) + (15 * BenBi);
        public override int MIN_XacThuongPhep => 0;
        public override int MAX_XacThuongPhep => 0;
    }
}