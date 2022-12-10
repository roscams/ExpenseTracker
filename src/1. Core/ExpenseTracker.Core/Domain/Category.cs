using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Core.Domain
{
    public class Category: DataObject
    {
        public ICollection<Expense> Expenses { get; set; }
        public string Name { get; set; }
        //public string Color { get; set; }
    }
}
