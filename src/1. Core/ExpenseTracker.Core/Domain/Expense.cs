using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Core.Domain
{
    public class Expense: DataObject
    {
        public double Amount { get; set; }
        public Category Category { get; set; }
        //public ICollection<Tag> Tags { get; set; }
        public string Title { get; set; }
    }
}
