using System;
using System.Collections.Generic;

namespace booksea.Models
{
    public partial class CustomerType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public double? MinSpending { get; set; }
    }
}
