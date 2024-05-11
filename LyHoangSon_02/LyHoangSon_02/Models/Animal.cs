namespace LyHoangSon_02.Models
{
    public abstract class  Animal
    {
        public abstract int Id { get; set; }
        public abstract string  Name { get; set; }
        public abstract E_Gender Gender { get; set; }
        public abstract double Weight { get; set; }
    }

    public enum E_Gender
    {
        Male,
        Female
    }
}