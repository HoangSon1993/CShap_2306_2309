using System;

namespace Bai_05_Game_RPG
{
    public class NhanVat
    {
        public int SucManh { get; set; }
        public int NhanhNhen { get; set; }
        public int BenBi { get; set; }
        public int ThongThai { get; set; }
        
        //--------------------------------
        public virtual int MIN_SatThuongVatLy { get;}
        public virtual int MAX_SatThuongVatLy { get; }
        public virtual int TyLeChiMang { get; }
        public virtual int Giap => Convert.ToInt32(BenBi * 1.5);
        public virtual int KhangPhep => (ThongThai + 1) * BenBi;
        public virtual int Mau { get; }
        public virtual int MIN_XacThuongPhep { get; }
        public virtual int MAX_XacThuongPhep { get; }
        
    }
}