using System;
using System.Collections.Generic;

namespace booksea.Models
{
    public partial class TheOrder
    {
        public int Id { get; set; }
        public int? Customer { get; set; }
        public DateTime? OrderTime { get; set; }
        public int? TheBook { get; set; }
        public double? Amt { get; set; }
        public int? ThePayment { get; set; }
        public int? TheConsignee { get; set; }
        public int? Theclerk { get; set; }
        public int? TheDeliverer { get; set; }
        public int? OrderState { get; set; }
    }
}
