using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai04
{
    public class Classroom
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public void Output()
        {
            foreach (var item in Students)
            {
                item.Output();
            }

            Console.WriteLine($"Số học sinh trong lớp là: {Students.Count}");
        }

        public Student FindYoungest()
        {
            // Student min = Students[0];
            // foreach (var student in Students)
            // {
            //     if (student.Age < min.Age)
            //     {
            //         min = student;
            //     }
            // }
            //
            // return min;

            return Students.OrderBy(s => s.Age).First();
        }

        public double Avg_Match()
        {
            // double sum = 0;
            // foreach (var item in Students)
            // {
            //     sum += item.MathGrade;
            // }
            //
            // return sum / Students.Count;
            return Students.Average(s => s.MathGrade);
        }
        
        public double Avg_Physic()
        {
            // double sum = 0;
            // foreach (var item in Students)
            // {
            //     sum += item.PhysicsGrade;
            // }
            //
            // return sum / Students.Count;
            
            return Students.Average(s => s.PhysicsGrade);
        }
        
        public double Avg_Chemis()
        {
            // double sum = 0;
            // foreach (var item in Students)
            // {
            //     sum += item.ChemistryGrade;
            // }
            //
            // return sum / Students.Count;

            return Students.Average(s => s.ChemistryGrade);
        }

        public int Cout_Passed()
        {
            // int count = 0;
            // foreach (var item in Students)
            // {
            //     if (item.IsPassed)
            //     {
            //         count++;
            //     }
            // }
            //
            // return count;

            return Students.Count(s => s.IsPassed);
        }
    }
    
}