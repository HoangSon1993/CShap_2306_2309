using System;

namespace Bai04
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double MathGrade { get; set; }
        public double PhysicsGrade { get; set; }
        public double ChemistryGrade { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public double GPA => (MathGrade + ChemistryGrade + PhysicsGrade) / 3;
        public bool IsPassed => GPA >= 5;

        public void Output()
        {
            Console.WriteLine($"Họ tên: {FullName}");
            Console.WriteLine($"Tuổi: {Age}");
            Console.WriteLine($"Điểm trung bình: {GPA}");
            Console.WriteLine($"Kết quả: {(IsPassed?"Đậu":"Thi lại")}");
        }
    }
}