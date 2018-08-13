using System;
using System.Collections;
using System.Collections.Generic;
using IT_Log.Model;

namespace IT_Log.Data_Layer
{
    interface IITLogRepository
    {
        List<it_log_all> GetAll();
        it_log GetById(int id);
        it_log Insert(it_log obj);
        void Update(it_log obj);
        void Delete(int id);
        List<it_log_all> SearchByDate(DateTime from, DateTime to);
        List<it_log_all> Search(string text);
    }
}
