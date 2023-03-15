using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarypzlab002.Models
{
    public class Book : Document
    {
        public string Author { get; set; }

        public Book()
        {

        }
        public Book(int ISBN, string Title, int PublicationYear, int NumbersOfPages, string Author)
            : base(ISBN, Title, PublicationYear, NumbersOfPages)
        {
            this.Author = Author;
        }

        public override bool Equals(object obj)
        {
            return ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}; Title: {Title}; PublicationYer: {PublicationYear}; NumbersOfPages: {NumbersOfPages}; Author:{Author}";
        }

        public override string Print()
        {
            return "Drukowanie ksiązki";
        }
    }
}
