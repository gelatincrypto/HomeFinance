using System;

namespace HomeFinance.Domain.Core
{
    public class Operation
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public long Amount { get; set; }
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
