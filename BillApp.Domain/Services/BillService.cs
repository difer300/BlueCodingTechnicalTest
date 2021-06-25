using BillApp.Domain.Interfaces.Repositories;
using BillApp.Domain.Interfaces.Services;
using BillApp.Domain.Models;
using System.Collections.Generic;

namespace BillApp.Domain.Services
{
    public class BillService : IBillService
    {
        private readonly IBillRepository billRepository;
        public BillService(IBillRepository billRepository)
        {
            this.billRepository = billRepository;
        }

        public Bill Add(Bill bill)
        {
            return billRepository.Add(bill);
        }

        public IEnumerable<Bill> ListAll()
        {
            return billRepository.ListAll();
        }
    }
}
