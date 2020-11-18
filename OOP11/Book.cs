using System;
using System.Collections.Generic;
using System.Reflection;

namespace OOP10
{
    public class Book
    {
        /// <summary>
        /// sci-fi
        /// detske
        /// romanticke
        /// naucne
        /// dobrodruzne
        /// </summary>
        public static List<string> categoryList = new List<string>(){"detské", "romantické", "náučné", "sci-fi", "dobrodružné"};
        
        private string title;
        private string author;
        private string category;
        private int releaseDate;
        private int pages;

        public string Title
        {
            get => title;
            set => title = value;
        }
        public string Author 
        { 
            get => author;
            set => author = value;
        }
        public string Category 
        {
            set => category = value;
        }
        public int ReleaseDate 
        { 
            get => releaseDate;
            set
            {
                if (value > 2021 || value < 1450)
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }
            }
        }
        public int Pages 
        { 
            get => pages;
            set
            {
                if (value < 0)
                {
                    pages = 1;
                }
                else
                {
                    pages = value;
                }
            }
        }

        //public Book(string title, int pages, int releaseDate = -1, string category = "-1", string author = "-1")

        public Book() : this("-1", -1, -1, "-1", "-1")
        {
            
        }

        public Book(string title, int pages) : this(title, pages, -1, "-1", "-1")
        {
            
        }

        public Book(string title, int pages, int releaseDate, string category, string author)
        {
            this.title = title;
            this.pages = pages;
            this.releaseDate = releaseDate;
            this.category = category;
            this.author = author;
        }

        public void Show()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Pages: " + pages);
            Console.WriteLine("Release date: " + releaseDate);
        }
    }
}