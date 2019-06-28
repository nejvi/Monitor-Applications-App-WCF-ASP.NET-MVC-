using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using WcfService1.Models;

namespace WcfService1
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IService1” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface    IService1
    {

        [OperationContract]
        Task<List<Application>> GetAllAplications();

        [OperationContract]
        Task<Application> GetApplication(int id);

        [OperationContract]
        void AddApplication();

        [OperationContract]
        void RemoveApplication(int id);

        // TODO: dodaj tutaj operacje usługi
    }
}
