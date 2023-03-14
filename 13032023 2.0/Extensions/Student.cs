using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13032023_2._0.Extensions
{
    public class Student
    {
        private static int _id;
        public int Id { get; }
        public string _fullname { get; set; }
        public byte _point { get; set; }

        public Student(string Fullname, byte Point)
        {
            _fullname = Fullname;
            _point = Point;
            _id++;
            Id = _id;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nid:{this.Id} \nFullname:{this._fullname} \nPoint:{this._point }");
        }
    }
}
