using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarypzlab002.Models
{
    public abstract class Document
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public int NumbersOfPages { get; set; }

        public Document()
        {

        }
        public Document(int ISBN, string Title, int PublicationYear, int NumbersOfPages)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.PublicationYear = PublicationYear;
            this.NumbersOfPages = NumbersOfPages;
        }

        public abstract string Print();

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
            return $"ISBN: {ISBN}; Title: {Title}; PublicationYer: {PublicationYear}; NumbersOfPages: {NumbersOfPages}";
        }

        public static bool operator ==(Document left, Document right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if (left is null || right is null)
                return false;

            return left.Equals(right);
        }
        public static bool operator !=(Document left, Document right)
        {
            return !(left == right);
        }
    }
}
