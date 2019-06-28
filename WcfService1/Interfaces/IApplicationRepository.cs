using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService1.Models;

namespace WcfService1.Interfaces
{
    interface IApplicationRepository
    {
        Task<List<Application>> GetItems();
        Task<Application> GetItem(int id);
        void Add(Application app);
        void Remove(Application app);
    }
}
