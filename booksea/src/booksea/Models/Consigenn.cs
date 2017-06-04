using System;
using System.Collections.Generic;

namespace booksea.Models
{
    public partial class Consigenn
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? AreaName { get; set; }
        public string StreetName { get; set; }
        public string RoadName { get; set; }
        public string DoorNumber { get; set; }
        public int? ZipCode { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string OfficePhone { get; set; }
        public string HomePhone { get; set; }
        public string Qqnumber { get; set; }
    }
}
