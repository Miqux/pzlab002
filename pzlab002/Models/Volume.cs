using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarypzlab002.Models
{
    public class Volume : Book
    {
        public int NumbersOfVolume { get; set; }
        public int NumbersOfAllVolume { get; set; }

        public Volume()
        {

        }
        public Volume(int ISBN, string Title, int PublicationYear, int NumbersOfPages, string Author, int NumbersOfVolume, int NumbersOfAllVolume)
                    : base(ISBN, Title, PublicationYear, NumbersOfPages, Author)
        {
            this.NumbersOfVolume = NumbersOfVolume;
            this.NumbersOfAllVolume = NumbersOfAllVolume;
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
            return $"ISBN: {ISBN}; Title: {Title}; PublicationYer: {PublicationYear}; NumbersOfPages: {NumbersOfPages}; Author: {Author}; NumbersOfVolume:{NumbersOfVolume}; NumbersOfAllVolume:{NumbersOfAllVolume}";
        }
        public override string Print()
        {
            return "Drukowanie tomu";
        }
    }
}
