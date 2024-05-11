namespace LyHoangSon_02.Models
{
    public class Chicken:Animal
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override E_Gender Gender { get; set; }
        public override double Weight { get; set; }
        
        public int SanLuongTrungGa
        {
            get => SanLuongTrungGa;
            set
            {
                if (Gender == E_Gender.Male)
                {
                    SanLuongTrungGa = 0;
                }
                else
                {
                    SanLuongTrungGa = value;
                }
            } }

        public override string ToString()
        {
            return $"Mã sô: {Id} - Tên: {Name} - Giới tính: {Gender} - Cân năng: {Weight} (kg)- Sản lượng trứng gà: {SanLuongTrungGa} (trứng)";
        }
    }
}