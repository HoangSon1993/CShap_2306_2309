using System;

namespace Bai_05_Game_RPG
{
    public class DoDon:NhanVat
    {
        public override int MIN_SatThuongVatLy => SucManh;
        public override int MAX_SatThuongVatLy => Convert.ToInt32(SucManh * 1.5);
        public override int TyLeChiMang => 0;
        public override int Giap { get; }
        public override int KhangPhep { get; }
        public override int Mau { get; }

    }
}