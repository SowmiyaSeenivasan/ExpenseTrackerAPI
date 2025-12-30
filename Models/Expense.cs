using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpenseTrackerAPI.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }

        
    }

}