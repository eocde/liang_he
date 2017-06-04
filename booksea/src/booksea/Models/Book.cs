using System;
using System.Collections.Generic;

namespace booksea.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string BookId { get; set; }
        public string BookName { get; set; }
        public string BookFeature { get; set; }
        public string BookDescription { get; set; }
        public string Bookmeaning { get; set; }
        public double? Price { get; set; }
        public string SmallImg { get; set; }
        public string BigImg { get; set; }
        public int? BookState { get; set; }
    }
}
