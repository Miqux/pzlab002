using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarypzlab002.Models
{
    public class Magazine : Document
    {
        public int Number { get; set; }
        public FrequencyEnum Frequency { get; set; }

        public Magazine()
        {

        }

        public Magazine(int ISBN, string Title, int PublicationYear, int NumbersOfPages, int Number, FrequencyEnum Frequency)
            : base(ISBN, Title, PublicationYear, NumbersOfPages)
        {
            this.Number = Number;
            this.Frequency = Frequency;
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
            return $"ISBN: {ISBN}; Title: {Title}; PublicationYer: {PublicationYear}; NumbersOfPages: {NumbersOfPages}; Numer:{Number}; Frequency:{Frequency}";
        }

        public override string Print()
        {
            return "Drukowanie magazynu";
        }
    }
}
