using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ExpenseTrackerAPI.Models
{
    public class ExpenseDbContext : DbContext
    {
        public ExpenseDbContext() : base("ExpenseDB") { }

        public DbSet<Expense> Expenses { get; set; }
    }
}