namespace LyHoangSon_02.Models
{
    public class Pig:Animal
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override E_Gender Gender { get; set; }
        public override double Weight { get; set; }
        
        public override string ToString()
        {
            return $"Mã sô: {Id} - Tên: {Name} - Giới tính: {Gender} - Cân năng: {Weight} (kg)";
        }
    }
}