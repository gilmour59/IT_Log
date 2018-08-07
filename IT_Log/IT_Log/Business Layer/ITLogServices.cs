using System.Collections.Generic;
using IT_Log.Data_Layer;
using IT_Log.Model;

namespace IT_Log.Business_Layer
{
    public static class ITLogServices
    {
        static IITLogRepository repository;

        static ITLogServices() {

            repository = new ITLogRepository();
        }

        public static IList<it_log> GetAll() {

            return repository.GetAll();
        }

        public static it_log GetById(int id) {

            return repository.GetById(id);
        }

        public static it_log Insert(it_log obj) {

            return repository.Insert(obj);
        }

        public static void Update(it_log obj) {

            repository.Update(obj);
        }

        public static void Delete(it_log obj) {

            repository.Delete(obj);
        }
    }
}
