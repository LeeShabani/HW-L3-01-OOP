using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_oop_library;


namespace HomeWork3_Task1
{
    public class Bookcs
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Isbn { get; set; }
        public bool IsAvailable;

        public Bookcs(string title, string author, int isbn)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            IsAvailable = true;
        }
    }
}
