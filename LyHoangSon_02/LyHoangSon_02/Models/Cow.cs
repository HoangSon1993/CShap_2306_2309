namespace LyHoangSon_02.Models
{
    public class Cow:Animal
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override E_Gender Gender { get; set; }
        public override double Weight { get; set; }

        public int SanLuongSua
        {
            get => SanLuongSua;
            set
            {
                if(Gender == E_Gender.Male)
                {
                    SanLuongSua = 0;
                }
                else
                {
                    SanLuongSua = value;
                };
            }
        }

        public override string ToString()
        {
            return $"Mã sô: {Id} - Tên: {Name} - Giới tính: {Gender} - Cân năng: {Weight} (kg)- Sản lượng sữa: {SanLuongSua} (lit)";
        }
    }
}