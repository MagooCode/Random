using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13032023_2._0.Extensions
{
    public class Group
    {
        public string GroupNo { get; set; }
        public byte _studentLimit;
        public byte StudentLimit
        {
            get => _studentLimit;
            set
            { 
                if (value > 5 && value <18)
                    _studentLimit = value;
            }
        }

        private Student[] students;

        public void AddStudent(Student student)
        {
            if (students.Length < StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }

        }

        public  Student GetStudent(int id)
        {
            foreach (var student in Student)
            { 
            if (student.Id == id)
                { return student; }
            }
            return null;
        }
        public Student[] GetAllStudents()
        { 
            return students;
        }
    }
}
