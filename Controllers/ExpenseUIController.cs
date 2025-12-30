/*using ExpenseTrackerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ExpenseTrackerAPI.Controllers
{
    public class ExpenseUIController : Controller
    {
        // GET: ExpenseUI
        public ActionResult Index()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44320/");

            var response = client.GetAsync("api/expense").Result;
            var data = response.Content.ReadAsAsync<List<Expense>>().Result;

            return View(data);
        }
    }
}*/