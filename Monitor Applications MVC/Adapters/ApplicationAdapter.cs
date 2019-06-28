using MonitorApplicationsMVC.Models;
using MonitorApplicationsMVC.Persistance;
using ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorApplicationsMVC.Adapters
{
    public class ApplicationAdapter : IApplicationAdapter
    {
        public Models.Application AdaptApplication(ServiceReference2.Application wcfApplication)
        {
            Models.Application app = new Models.Application();
            app.Id = wcfApplication.id;
            app.name = wcfApplication.name;
            app.surname = wcfApplication.surname;
            app.monitorModel = wcfApplication.monitorModel;
            app.price = wcfApplication.price;

            return app;
        }

        public List<Models.Application> AdaptListOfApplications(ServiceReference2.Application[] wcfApplications)
        {
            List<Models.Application> applications = new List<Models.Application>();
            foreach(var item in wcfApplications)
            {
                applications.Add(AdaptApplication(item));
            }
            return applications;
        }
    }
}
