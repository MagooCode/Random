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
        public static int _id;
        public string Name { get; set;}
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
