using System.Collections;
using System.Collections.Generic;
using IT_Log.Model;

namespace IT_Log.Data_Layer
{
    interface IITLogRepository
    {
        IList GetAll();
        it_log GetById(int id);
        it_log Insert(it_log obj);
        void Update(it_log obj);
        void Delete(int id);
    }
}
