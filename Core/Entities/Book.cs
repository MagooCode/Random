using Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Book : IEntity
    {
        public static int _bookCount;
        public static int _id;
        public string _name;
        public string Name
        {
            get
            { 
                return _name;
            }
            set
            {
                if (value is null)
                    throw new ArgumentNullException("given value can't be null");
                _name = value;
            }
        }
        public string AuthorName { get; set;}
        public int PageCount { get; set;}
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public Book(string name, string authorName, int pageCount)
        {
            Id = ++_id;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            IsDeleted = false;
        }

        public static bool operator >(Book book1, Book book2)
        {
            return book1.PageCount > book2.PageCount;
        }

        public static bool operator <(Book book1, Book book2)
        {
            return book1.PageCount < book2.PageCount;
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"{Name}-{AuthorName}-{PageCount}");
        }

        public override string ToString()
        {
            return ($"{Name}-{AuthorName}-{PageCount}");
        }
    }
}
