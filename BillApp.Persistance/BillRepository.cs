using BillApp.Domain.Interfaces.Repositories;
using BillApp.Domain.Models;
using System.Collections.Generic;

namespace BillApp.Persistance
{
    public class BillRepository : IBillRepository
    {
        public Bill Add(Bill bill)
        {
            return new Bill()
            {
                Name = bill.Name,
                Total = bill.Total
            };
        }

        public IEnumerable<Bill> ListAll()
        {
            var lstBills = new List<Bill>
            {
                new Bill()
                {
                    Name = "Bill 1",
                    Total = 100
                },
                new Bill()
                {
                    Name = "Bill 2",
                    Total = 400
                },
                new Bill()
                {
                    Name = "Bill 3",
                    Total = 400
                },
            };

            return lstBills;
        }

    }
}
