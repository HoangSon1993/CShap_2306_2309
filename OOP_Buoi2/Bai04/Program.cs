using System;

namespace Bai04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Classroom classroom = new Classroom();
            classroom.Students.Add(new Student()
            {
                LastName = "Nguyen Thanh",
                FirstName = "Binh",
                Age = 22,
                MathGrade = 6.5,
                ChemistryGrade = 4.9,
                PhysicsGrade = 7.2
            });
            classroom.Students.Add(new Student()
            {
                LastName = "Tran Van",
                FirstName = "Chien",
                Age = 19,
                MathGrade = 8.5,
                ChemistryGrade = 6.7,
                PhysicsGrade = 5.4
            });
            classroom.Students.Add(new Student()
            {
                LastName = "Nguyen Van",
                FirstName = "An",
                Age = 18,
                MathGrade = 5.5,
                ChemistryGrade = 5.6,
                PhysicsGrade = 2.2
            });
            classroom.Output();
            Console.WriteLine($"Sinh viên nhỏ tuổi nhất: ");
            classroom.FindYoungest().Output();
            Console.WriteLine();

            Console.WriteLine($"DTB Toán của cả lớp: {classroom.Avg_Match()}");
            Console.WriteLine();
            
            Console.WriteLine($"DTB Lý của cả lớp: {classroom.Avg_Physic()}");
            Console.WriteLine();
            
            Console.WriteLine($"DTB Hoá của cả lớp: {classroom.Avg_Chemis()}");
            Console.WriteLine();

            Console.WriteLine($"Số học sinh qua môn: {classroom.Cout_Passed()}");
        }
    }
}