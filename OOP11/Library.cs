using System;
using System.Collections.Generic;

namespace OOP11
{
    public class Library : Book
    {
        private int numberOfBooks;
        private int numberOfStudents;
        private List<string> studentsList;
        private List<Book> booksList;

        public int NumberOfBooks
        {
            get => numberOfBooks;
            set => numberOfBooks = value;
        }

        public int NumberOfStudents
        {
            get => numberOfStudents;
            set => numberOfStudents = value;
        }

        public List<string> StudentsList
        {
            get => studentsList;
            set => studentsList = value;
        }

        public List<Book> BooksList
        {
            get => booksList;
            set => booksList = value;
        }

        public void Show()
        {
            //base.Show();
            Console.WriteLine("Number of students: " + numberOfStudents);
            Console.WriteLine("Number of books: " + numberOfBooks);
            Console.Write("Students: ");
            foreach (var student in studentsList)
            {
                Console.Write(student + " ");
            }
            Console.WriteLine("Books: ");
            foreach (var book in booksList)
            {
                book.Show();
            }
        }
    }
}