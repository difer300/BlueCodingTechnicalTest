using BillApp.Domain.Interfaces.Services;
using BillApp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BillApp.Web.Controllers
{
    public class BillController : Controller
    {
        private readonly IBillService billService;

        
        public BillController(IBillService billService)
        {
            this.billService = billService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listBills = billService.ListAll();
            return View(listBills);
        }

        [HttpPost]
        public IActionResult Create(Bill bill)
        {
            var newBill = billService.Add(bill);
            return View(newBill);
        }
    }
}
