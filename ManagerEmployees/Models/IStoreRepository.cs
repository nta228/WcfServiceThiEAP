using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerEmployees.Models
{
    public interface IStoreRepository
    {
        IQueryable<Employees> Employees { get; }
    }
}
