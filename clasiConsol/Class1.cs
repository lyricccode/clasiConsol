using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasiConsol
{
    public class Book
    {
        string Author { get; set; }
        string Name { get; set; }
        int Year { get; set; }

        

        public Book(string author, string name, int year)
        {
            Author = author;
            Name = name;
            Year = year;
        }

        public void DisplayInfo()
        {
            int IsOld = 2026 - Year;
            if (IsOld >= 20)
            {
                Console.WriteLine($" '{Name}' - {Author}, {Year} [Старая]");
            }
            else
            {
                Console.WriteLine($" '{Name}' - {Author}, {Year}");
            }
        }
    }
}
