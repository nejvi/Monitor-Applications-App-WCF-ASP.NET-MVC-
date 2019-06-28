using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WcfService1.Interfaces;
using WcfService1.Models;

namespace WcfService1.Persistance
{
    public class ApplicationRepository : IApplicationRepository
    {
        ApplicationsDbContext _context;
        public ApplicationRepository()
        {
            _context = new ApplicationsDbContext();
        }

        public void Add(Application app)
        {
            _context.Applications.Add(app);
            _context.SaveChanges();
        }

        public async Task<Application> GetItem(int id)
        {
            return await _context.Applications.FindAsync(id);
        }

        public async Task<List<Application>> GetItems()
        {
            return await _context.Applications.ToListAsync();
        }

        public void Remove(Application app)
        {
            _context.Applications.Remove(app);
            _context.SaveChanges();
        }
    }
}