using ExpenseTracker.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.DAL
{
    public class ExpenseTrackerContext: DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}