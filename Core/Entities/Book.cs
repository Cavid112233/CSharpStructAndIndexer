using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Book
    {
        private static int _no;
        public int No { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        private int _pageCount { get; set; }
        public int PageCount
        {
            get
            {
                return _pageCount;
            }
            set
            {
                if (value > 0)
                {
                    _pageCount = value;
                }
            }
        }
        public Book(string name, string authorName, int pageCount)
        {
            _no++;
            No = _no;
            Name = name;
            AuthorName = authorName;
            _pageCount = pageCount;
        }
        public override string ToString()
        {
            return $" No:{No}\n Name:{Name}\n Author name:{AuthorName}\n Page count:{PageCount}";

        }
    }
}
