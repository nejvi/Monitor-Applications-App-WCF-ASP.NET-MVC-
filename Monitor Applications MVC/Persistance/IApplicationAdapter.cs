using MonitorApplicationsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorApplicationsMVC.Persistance
{
    interface IApplicationAdapter
    {
        List<Application> AdaptListOfApplications(ServiceReference2.Application[] wcfApplications);
        Application AdaptApplication(ServiceReference2.Application wcfApplication);
    }
}
