using BillApp.Domain.Interfaces.Services;
using BillApp.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillApp.Controllers
{
    [Route("/api/bills")]
    [Produces("application/json")]
    [ApiController]
    public class BillController
    {
        private readonly IBillService billService;

        public BillController(IBillService billService)
        {
            this.billService = billService;
        }

        /// <summary>
        /// Get all the bills 
        /// </summary>
        /// <returns>The list of the bills</returns>
        [HttpGet]
        public IEnumerable<Bill> ListAll()
        {
            return billService.ListAll();
        }

        /// <summary>
        /// Add a new bill
        /// </summary>
        /// <param name="bill">The new bill</param>
        /// <returns>The created bill</returns>
        /// <summary>
        [HttpPost]
        public Bill Add(Bill bill)
        {
            return billService.Add(bill);
        }
    }
}
