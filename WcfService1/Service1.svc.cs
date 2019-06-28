using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using WcfService1.Models;
using WcfService1.Persistance;

namespace WcfService1
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie, usłudze i pliku konfiguracji.
    // UWAGA: aby uruchomić klienta testowego WCF w celu przetestowania tej usługi, wybierz plik Service1.svc lub Service1.svc.cs w eksploratorze rozwiązań i rozpocznij debugowanie.
    public class Service1 : IService1
    {
        ApplicationRepository _repository;
        public Service1()
        {
            _repository = new ApplicationRepository();
        }

        public void AddApplication()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Application>> GetAllAplications()
        {
            var items = await _repository.GetItems();

            if (items == null)
            {

            }

            return items;
        }

        public async Task<Application> GetApplication(int id)
        {
            var item = await _repository.GetItem(id);

            if (item == null)
            {

            }

            return item;
        }

        public void RemoveApplication(int id)
        {
            var item = _repository.GetItem(id);

            if (item == null)
            {

            }
            
            throw new NotImplementedException();
        }
    }
}
