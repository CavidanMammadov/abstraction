using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.cs
{
    internal class Group
    {
        public string GroupNo { get; set; }
        public int StudentLimit { get; set; }
        private Student[] Students { get; set; }
        private int _studentCount;

        public Group(string groupNo, int studentLimit)
        {
            if (studentLimit < 5 || studentLimit > 18)
                Console.WriteLine("sagird sayi 5  ve 18 arasinda olmalidir");

            if (!CheckGroupNo(groupNo))
                Console.WriteLine("Qrup adini duzgun daxil edin");

            GroupNo = groupNo;
            StudentLimit = studentLimit;
            Students = new Student[studentLimit];
            _studentCount = 0;
        }

        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length == 5 &&
                char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) &&
                char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
            {
                return true;
            }
            return false;
        }

        public void AddStudent(Student student)
        {
            if (_studentCount < StudentLimit)
            {
                Students[_studentCount++] = student;
            }
            else
            {
                Console.WriteLine("limit kecildi");
            }
        }

        public Student GetStudent(int? id)
        {
            if (id == null)
                return null;

            foreach (var student in Students)
            {
                if (student != null && student.Id == id)
                    return student;
            }
            return null;
        }

        public Student[] GetAllStudents()
        {
            return Students;
        }
    }
}
