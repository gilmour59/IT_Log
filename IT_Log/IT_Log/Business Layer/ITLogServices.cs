using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using FastMember;
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

        public static List<it_log_all> Search(string text) {

            return repository.Search(text);
        }

        public static List<it_log_all> SearchByDate(DateTime from, DateTime to) {

            return repository.SearchByDate(from, to);
        }

        public static List<it_log_all> GetAll() {

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

        public static void Delete(int id) {

            repository.Delete(id);
        }
    }
}
