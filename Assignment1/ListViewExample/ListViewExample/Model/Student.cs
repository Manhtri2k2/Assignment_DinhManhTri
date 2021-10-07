using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewExample.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string YearOfBirth { get; set; }
        public string Image { get; set; }
    }

    public class StudentManager
    {
        public static List<Student> GetStudents()
        {
            var students = new List<Student>();

            students.Add(new Student { StudentId = 1, Name = "Nguyễn Công Phượng", YearOfBirth = "2002", Image = "Assets/1.png" });
            students.Add(new Student { StudentId = 2, Name = "Nguyễn Tiến Linh", YearOfBirth = "2003", Image = "Assets/2.png" });
            students.Add(new Student { StudentId = 3, Name = "Đỗ Duy Mạnh", YearOfBirth = "2002", Image = "Assets/3.png" });
            students.Add(new Student { StudentId = 5, Name = "Đỗ Hùng Dũng", YearOfBirth = "1992", Image = "Assets/5.png" });
            students.Add(new Student { StudentId = 6, Name = "Vũ Văn Thanh", YearOfBirth = "1993", Image = "Assets/6.png" });
            students.Add(new Student { StudentId = 7, Name = "Đặng Văn Lâm", YearOfBirth = "1992", Image = "Assets/7.png" });
            students.Add(new Student { StudentId = 8, Name = "Hà Đức Chinh", YearOfBirth = "1998", Image = "Assets/8.png" });
            students.Add(new Student { StudentId = 9, Name = "Đoàn Văn Hậu", YearOfBirth = "1890", Image = "Assets/9.png" });
            students.Add(new Student { StudentId = 10, Name = "Nguyễn Tuấn Anh", YearOfBirth = "1990", Image = "Assets/10.png" });
            students.Add(new Student { StudentId = 11, Name = "Nguyễn Tấn Trường", YearOfBirth = "1991", Image = "Assets/11.png" });
            students.Add(new Student { StudentId = 12, Name = "Quế Ngọc Hải", YearOfBirth = "1995", Image = "Assets/12.png" });
            students.Add(new Student { StudentId = 13, Name = "Bùi Tiến Dũng", YearOfBirth = "1997", Image = "Assets/13.png" });

            return students;
        }
    }
}

