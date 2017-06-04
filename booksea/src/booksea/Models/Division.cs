using System;
using System.Collections.Generic;

namespace booksea.Models
{
    public partial class Division
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Area { get; set; }
        public string StreetName { get; set; }
        public string RodaName { get; set; }
        public string DoorName { get; set; }
        public int? ZipCode { get; set; }
    }
}
