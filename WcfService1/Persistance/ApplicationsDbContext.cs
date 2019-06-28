using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WcfService1.Models;

namespace WcfService1.Persistance
{
    public class ApplicationsDbContext:DbContext
    {
        public DbSet<Application> Applications { get; set; }
    }
}