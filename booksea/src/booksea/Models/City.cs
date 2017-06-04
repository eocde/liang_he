using System;
using System.Collections.Generic;

namespace booksea.Models
{
    public partial class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Province { get; set; }
    }
}
