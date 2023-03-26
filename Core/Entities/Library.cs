using Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Exceptions;

namespace Core.Entities
{
    public class Library : IEntity
    {
        public int Id { get; set; }
        public int BookLimit { get; set; }
        private Book[] _books;
        public Book this[int index]
        {
            get => _books[index];
            set
            {
                if (value == null)
                    throw new ArgumentNullException("book", "book can't be null");
                _books[index] = value;
            }
        }

        public Library(int bookLimit)
        {
            BookLimit = bookLimit;
            _books = new Book[bookLimit];
        }

        //public void AddBook(Book book)
        //{
        //    foreach (var item in _books)  //?
        //    {
        //        if (book.IsDeleted)
        //        {
        //            continue;
        //        }
        //        if (book.IsDeleted)
        //        {
        //            if (book.Name == item.Name)
        //            {
        //                throw new AlreadyExsistsException("Book by this name already exsists, try up with another name");
        //            }
        //            else
        //            {
        //                if (_books.Length < BookLimit)
        //                {
        //                    Array.Resize(ref _books, _books.Length + 1);
        //                    _books[_books.Length - 1] = book;
        //                }
        //                else
        //                {
        //                    throw new CapacityLimitException("Library is full of books");
        //                }
        //            }
        //        }
        //    }
        //}

        //public void AddBook(Book book)
        //{
        //    foreach (var item in _books)  //?
        //    {
        //        //if (!book.IsDeleted)
        //        //{
        //        //    continue;
        //        //}
        //        if (book.IsDeleted == false)
        //        {
        //            if (book is not null && book.Name == item.Name)
        //            {
        //                throw new AlreadyExsistsException("Book by this name already exsists, try up with another name");
        //            }
        //            else
        //            {
        //                if (Book._bookCount < _books.Length)
        //                {
        //                    _books[_books.Length - Book._bookCount] = book;
        //                    ++Book._bookCount;
        //                }
        //                else
        //                {
        //                    throw new CapacityLimitException("Library is full of books");
        //                }
        //            }
        //        }
        //        else
        //        {
        //            continue;
        //        }
        //    }
        //}

        //public void AddBook(Book book)
        //{
        //    foreach (var item in _books)  //?
        //    {
        //        if (book.IsDeleted == false)
        //        {
        //            if (_books[0] is null)
        //            {
        //                _books[0] = book;
        //                Book._bookCount++;
        //                break;
        //            }
        //            else
        //            {
        //                if (book is not null)
        //                {
        //                    if (item.Name == book.Name)
        //                    {
        //                        throw new AlreadyExsistsException("Book by this name already exsists, try up with another name");
        //                    }
        //                    else if (Book._bookCount < _books.Length)
        //                    {
        //                        _books[_books.Length - Book._bookCount] = book;
        //                        ++Book._bookCount;
        //                    }
        //                    else
        //                    {
        //                        throw new CapacityLimitException("Library is full of books");
        //                    }
        //                }
        //                else
        //                {
        //                    throw new ArgumentNullException("given value can't be null");
        //                }
        //            }
        //        }
        //        else
        //        {
        //            continue;
        //        }
        //    }
        //}

        public void AddBook(Book book)
        {
            if (_books[0] is null)
            {
                _books[0] = book;
                Book._bookCount++;
            }
            else
            {
                foreach (var item in _books)  //?
                {
                    if (book.IsDeleted == false)
                    {
                        if (book is not null)
                        {
                            if (item.Name == book.Name)
                            {
                                throw new AlreadyExsistsException("Book by this name already exsists, try up with another name");
                            }
                            else if (Book._bookCount < _books.Length)
                            {
                                _books[_books.Length - Book._bookCount] = book;
                                ++Book._bookCount;
                            }
                            else
                            {
                                throw new CapacityLimitException("Library is full of books");
                            }
                        }
                        else
                        {
                            throw new ArgumentNullException("given value can't be null");
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        //public void AddBook(Book book)
        //{
        //    for (int i = 0; i < _books.Length; i++)
        //    {
        //        if (book.IsDeleted == false)
        //        {
        //            if (_books[i] is null)
        //            {
        //                _books[i] = book;
        //                Book._bookCount++;
        //                break;
        //            }
        //            else
        //            {
        //                if (book is not null)
        //                {
        //                    if (_books[i].Name == book.Name)
        //                    {
        //                        throw new AlreadyExsistsException("Book by this name already exsists, try up with another name");
        //                    }
        //                    else if (Book._bookCount < _books.Length)
        //                    {
        //                        _books[_books.Length - Book._bookCount] = book;
        //                        ++Book._bookCount;
        //                    }
        //                    else
        //                    {
        //                        throw new CapacityLimitException("Library is full of books");
        //                    }
        //                }
        //                else
        //                {
        //                    throw new ArgumentNullException("given value can't be null");
        //                }
        //            }
        //        }
        //        else
        //        {
        //            continue;
        //        }
        //    }
        //}

        //public void AddBook(Book book)
        //{
        //    foreach (var item in Books)
        //    {
        //        //if (!item.IsDeleted)
        //        //{
        //        //    continue;
        //        //}
        //        if (item.IsDeleted && item.Name == book.Name)
        //        {
        //            throw new AlreadyExsistsException("Book by this name already exsists, try up with another name");
        //        }
        //        else
        //        {
        //            if (Books.Length < BookLimit)
        //            {
        //                Array.Resize(ref Books, Books.Length + 1);
        //                Books[Books.Length - 1] = book;
        //            }
        //            else
        //            {
        //                throw new CapacityLimitException("Library is full of books");
        //            }
        //        }
        //    }
        //}

        public Book BookById(int id)
        {
            foreach (var Book in _books)
            {
                if (Book.IsDeleted == false && Book.Id == id)
                {
                    return Book;
                }
            }
            throw new NotFoundException("There isn't such book by given id in Library");
        }

        public Book[] GetAllBooks()
        {
            Book[] newBooks = new Book[_books.Length];
            _books.CopyTo(newBooks, 0);
            return newBooks;
        }

        public void DeleteBookById(int id)
        {
            foreach (var Book in _books)
            {
                if (Book.Id == id)
                { 
                    Book.IsDeleted = true;
                }
            }
            throw new NotFoundException("There isn't such book in Library");
        }

        public void Sort()
        {
            int currentMinimum = Int32.MaxValue;
            for (int i = 0; i < _books.Length; i++)
            {
                for (int iCompare = i + 1; iCompare < _books.Length; iCompare++)
                {
                    if (_books[i].PageCount > _books[iCompare].PageCount)
                    {  
                        currentMinimum = _books[iCompare].PageCount;
                        _books[iCompare].PageCount = _books[i].PageCount;
                        _books[i].PageCount = currentMinimum;
                    }
                }
                Console.WriteLine(_books[i]);
            }
        }

        
    }
}
