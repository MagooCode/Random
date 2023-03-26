using Core.Entities;
using Utils.Exceptions;

Book newbook1 = new Book("book1", "Muhammad Ali", 90);
Book newbook2 = new Book("book2", "Mike Tyson", 80);
Book newbook3 = new Book("book3", "Alexander Usik", 60);
Book newbook4 = new Book("book2", "Petr Yan", 50);

Library newlibrary1 = new Library(2);

newlibrary1.AddBook(newbook1);
newlibrary1.AddBook(newbook2);
//try
//{
//    newlibrary1.DeleteBookById(5);
//}
//catch (AlreadyExsistsException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (NotFoundException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (CapacityLimitException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    newlibrary1.BookById(5);
//}
//catch (AlreadyExsistsException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (NotFoundException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (CapacityLimitException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    //newlibrary1.AddBook(newbook4);
//}
//catch (AlreadyExsistsException ex)
//{ 
//	Console.WriteLine(ex.Message);
//}
//catch (NotFoundException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (CapacityLimitException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex)
//{
//	Console.WriteLine(ex.Message);
//}







