using System;
using System.Collections.Generic;

namespace OOP11
{
    class Program
    {
        static void Main(string[] args)
        {
           var schoolLibrary = new Library();
           
           schoolLibrary.NumberOfBooks = 4;
           schoolLibrary.NumberOfStudents = 2;
           schoolLibrary.StudentsList = new List<string>() {"John", "Poul"};
           schoolLibrary.BooksList = new List<Book>(){
               new Book("Matika", 150, 1985, Book.categoryList[2], "Peter Druska"),
               new Book("Cirkus romána", 80, 2019, Book.categoryList[0], "Zuzana Haasová"),
               new Book("Kámasútra pre milencov 21.storočia", 160, 2011, Book.categoryList[1], "Katarina Jassova"),
               new Book("Zlo nema na kuzlo", 144, 2015, Book.categoryList[4], "Roman Brat")
           };
           
           schoolLibrary.Show();
        }
    }
}