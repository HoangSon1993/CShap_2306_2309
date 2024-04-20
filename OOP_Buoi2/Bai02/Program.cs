namespace Bai02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student()
            {
                FirstName = "Ly Hoang",
                LastName = "Son",
                Age = 22,
                ChemistryGrade = 10,
                MathGrade = 9.5,
                PhysicsGrade = 5.6
            };
            s.Output();
        }
    }
}