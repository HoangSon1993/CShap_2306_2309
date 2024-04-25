using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int> { 3, -2, 9, 4, -6, 2, 0, 7 };

            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Andy", Age = 18, GPA = 5.9 },
                new Student { Id = 2, Name = "Brent", Age = 19, GPA = 3.5 },
                new Student { Id = 3, Name = "Cody", Age = 18, GPA = 2.7 },
                new Student { Id = 4, Name = "David", Age = 20, GPA = 9.8 },
                new Student { Id = 5, Name = "Eric", Age = 22, GPA = 7.3 },
                new Student { Id = 6, Name = "Frank", Age = 20, GPA = 8.2 }
            };

            // Loc danh sach so duong
            var lsSoDuong = list.Where(x => x > 0);

            // Loc danh sach so duong chan
            var lsSoDuongChan = list.Where(x => x > 0 && x % 2 == 0);
            // list.Where(x => x > 0).Where(x =>x % 2 == 0)

            // Danh sach sinh vien lon hon 20 tuoi va GPA > 5
            var lsSvAge20 = students.Where(sv => sv.Age > 20 && sv.GPA > 5);

            // Sap xep danh sach so nguyen giam dan
            list.OrderByDescending(x => x);
            // Sắp xếp danh sách sinh viên theo số tuổi tăng dần
            students.OrderBy(sv => sv.Age);
            
            // Sắp xếp danh sách sinh viên theo số tuổi tăng dần. Nếu tuổi bằng nhau thì sắp xếp
            // theo điểm trung bình giảm dần:
            students.OrderBy(sv => sv.Age)
                .ThenByDescending(sv => sv.GPA);
            
            // Sinh viên có tuổi cao nhất
            var maxAgeSv = students.Max(s=>s.Age);
            
            // Đếm số lượng sinh viên đậu (có điểm trung bình ≥ 5):
            var slSvDau = students.Count(sv => sv.GPA >= 5);
            
            //Trong ví dụ trên, phương thức Max() chỉ cho biết giá trị tuổi cao nhất. Muốn lọc ra
            // danh sách sinh viên lớn tuổi nhất, cần phải truy vấn như sau:
             int maxAge = students.Max(s => s.Age);
             students.Where(s => s.Age == maxAge);
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
    }
}