using System.Collections.Generic;
using System.Linq;
using IT_Log.Model;

namespace IT_Log.Data_Layer
{
    class ITLogRepository : IITLogRepository
    {
        public void Delete(it_log obj)
        {
            using (ittransactionlogEntities db = new ittransactionlogEntities())
            {

                db.it_log.Attach(obj);
                db.it_log.Remove(obj);
                db.SaveChanges();
            }
        }

        public IList<it_log> GetAll()
        {
            using (ittransactionlogEntities db = new ittransactionlogEntities())
            {

                return db.it_log.ToList();
            }
        }

        public it_log GetById(int id)
        {
            using (ittransactionlogEntities db = new ittransactionlogEntities())
            {

                return db.it_log.Find(id);
            }
        }

        public it_log Insert(it_log obj)
        {
            using (ittransactionlogEntities db = new ittransactionlogEntities())
            {

                db.it_log.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(it_log obj)
        {
            using (ittransactionlogEntities db = new ittransactionlogEntities())
            {

                db.it_log.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
