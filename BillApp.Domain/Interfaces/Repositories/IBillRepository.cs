using BillApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillApp.Domain.Interfaces.Repositories
{
    public interface IBillRepository
    {
        IEnumerable<Bill> ListAll();
        Bill Add(Bill bill);
    }
}
