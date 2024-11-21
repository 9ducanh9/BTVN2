using System;
using System.Collections.Generic;
using System.Linq;

namespace BTVN2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tạo danh sách học sinh
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Lam Chi Tai", Age = 20 },
                new Student { Id = 2, Name = "Nguyen Ngoc Nhu Quynh", Age = 18 },
                new Student { Id = 3, Name = "Lam Thanh Quang", Age = 17 },
                new Student { Id = 4, Name = "Cao Thi My Nhan", Age = 21 },
                new Student { Id = 5, Name = "Lucas Lewis", Age = 16 }
            };

            // a. In danh sách toàn bộ học sinh
            Console.WriteLine("Danh sach toan bo hoc sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            // b. Tìm và in danh sách học sinh có tuổi từ 15 đến 18
            var ageRangeStudent = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            Console.WriteLine("\nHoc sinh co tuoi tu 15 den 18:");
            foreach (var student in ageRangeStudent)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            // c. Tìm và in danh sách học sinh có tên bắt đầu bằng chữ "A"
            var nameStartWithA = students.Where(s => s.Name.StartsWith("A")).ToList();
            Console.WriteLine("\nHoc sinh co ten bat dau bang chu 'A':");
            foreach (var student in nameStartWithA)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            // d. Tính tổng tuổi của tất cả học sinh
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

            // e. Tìm và in học sinh có tuổi lớn nhất
            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            Console.WriteLine("\nHoc sinh co tuoi lon nhat:");
            Console.WriteLine($"ID: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

            // f. Sắp xếp danh sách theo tuổi tăng dần
            var sortedByAge = students.OrderBy(s => s.Age).ToList();
            Console.WriteLine("\nDanh sach hoc sinh sau khi sap xep tuoi tang dan:");
            foreach (var student in sortedByAge)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}
