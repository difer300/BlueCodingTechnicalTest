using BillApp.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BillApp.Domain.Interfaces.Services
{
    public interface IBillService
    {
        IEnumerable<Bill> ListAll();
        Bill Add(Bill bill);
    }
}
