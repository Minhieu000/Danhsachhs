using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)

        {

            // Tao danh sach học sinh
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "An", Age = 16 },
                new Student { Id = 2, Name = "Binh", Age = 14 },
                new Student { Id = 3, Name = "Cuong", Age = 18 },
                new Student { Id = 4, Name = "Dung", Age = 15 },
                new Student { Id = 5, Name = "Anh", Age = 17 }
            };

            // a. In danh sách toan bo học sinh
            Console.WriteLine("Danh sach toan bo hoc sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            Console.WriteLine();

            // b. Tim học sinh co tuoi từ 15 đến 18
            Console.WriteLine("hoc sinh co tuoi tu 15 đen 18:");
            var ageRange = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var student in ageRange)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            Console.WriteLine();

            // c. Tim học sinh có tên bat đau bằng chu "A"
            Console.WriteLine("hoc sinh có ten bat đau bang chu'A':");
            var nameStartsWithA = students.Where(s => s.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
            foreach (var student in nameStartsWithA)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            Console.WriteLine();

            // d. Tinh tong tuoi của tat ca học sinh
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"tong tuoi cua tat ca hoc sinh: {totalAge}");
            Console.WriteLine();

            // e. Tim học sinh có tuoi nhỏ nhất
            int minAge = students.Min(s => s.Age);
            var youngestStudent = students.Where(s => s.Age == minAge).FirstOrDefault();
            Console.WriteLine("Tim hoc sinh có tuoi nho nhat:");
            Console.WriteLine($"ID: {youngestStudent.Id}, Name: {youngestStudent.Name}, Age: {youngestStudent.Age}");
            Console.WriteLine();

            // f. Sap xep danh sach hoc sinh theo tuổi tăng dần
            Console.WriteLine("danh sach hoc sinh theo tuoi tang dan:");
            var sortedStudents = students.OrderBy(s => s.Age);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

        }
    }
}
