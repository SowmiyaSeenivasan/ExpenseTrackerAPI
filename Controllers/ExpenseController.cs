using ExpenseTrackerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExpenseTrackerAPI.Controllers
{
    [RoutePrefix("api/expense")]
    public class ExpenseController : ApiController
    {
        ExpenseDbContext db = new ExpenseDbContext();

        // GET: api/expense/getall
        [HttpGet]
        [Route("getall")]
        public IHttpActionResult GetAll()
        {
            return Ok(db.Expenses.ToList());
        }

        // GET: api/expense/total
        [HttpGet]
        [Route("total")]
        public IHttpActionResult Total()
        {
            return Ok(db.Expenses.Sum(e => e.Amount));
        }

        // GET: api/expense/average
        [HttpGet]
        [Route("average")]
        public IHttpActionResult Average()
        {
            return Ok(db.Expenses.Any() ? db.Expenses.Average(e => e.Amount) : 0);
        }

        // POST: api/expense/add-multiple
        [HttpPost]
        [Route("add-multiple")]
        public IHttpActionResult AddMultiple(List<Expense> list)
        {
            db.Expenses.AddRange(list);
            db.SaveChanges();
            return Ok("Added successfully");
        }

        // DELETE: api/expense/delete/1
        [HttpDelete]
        [Route("delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var expense = db.Expenses.Find(id);
            if (expense == null)
                return NotFound();

            db.Expenses.Remove(expense);
            db.SaveChanges();

            return Ok("Expense deleted");
        }
    }

}