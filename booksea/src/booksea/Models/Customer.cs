using System;
using System.Collections.Generic;

namespace booksea.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public int? CustomerType { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string OfficePhone { get; set; }
        public string HomePhone { get; set; }
        public string QqNumber { get; set; }
        public DateTime? RegistDate { get; set; }
    }
}
