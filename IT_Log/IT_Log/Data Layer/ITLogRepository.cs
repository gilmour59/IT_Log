using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using IT_Log.Model;

namespace IT_Log.Data_Layer
{
    class ITLogRepository : IITLogRepository
    {

        public void Delete(int id)
        {
            using (ittransactionlogEntities db = new ittransactionlogEntities())
            {
                //using (dbemployeeEntities db = new dbemployeeEntities())
                //{
                //    db.Database.ExecuteSqlCommand("UPDATE employee_info SET lastname = 'SQLTEST' WHERE empID = 19");
                //}

                var delete = (from l in db.it_log
                              where l.it_log_id.Equals(id)
                              select l).FirstOrDefault();

                db.it_log.Attach(delete);
                db.it_log.Remove(delete);
                db.SaveChanges();
            }
        }

        public IList GetAll()
        {
            using (ittransactionlogEntities db = new ittransactionlogEntities())
            {
                var itlog = (from l in db.it_log
                             join p in db.it_personnel
                             on l.it_personnel_id equals p.it_personnel_id
                             select new
                             {
                                 id = l.it_log_id,
                                 Name = l.name,
                                 Office = l.office,
                                 Date = l.date,
                                 Time = l.time,
                                 Service_Request = l.service_request,
                                 IT_Personnel = p.it_personnel_name
                                
                             }).ToList();

                return itlog;
            }
        }

        public IList Search(string text)
        {
            using (ittransactionlogEntities db = new ittransactionlogEntities())
            {
                var result = (from l in db.it_log
                              join p in db.it_personnel
                              on l.it_personnel_id equals p.it_personnel_id
                              where(l.name.Contains(text) || l.office.Contains(text) || 
                              l.service_request.Contains(text) || p.it_personnel_name.Contains(text))
                              select new
                              {
                                  id = l.it_log_id,
                                  Name = l.name,
                                  Office = l.office,
                                  Date = l.date,
                                  Time = l.time,
                                  Service_Request = l.service_request,
                                  IT_Personnel = p.it_personnel_name

                              }).ToList();

                return result;
            }
        }

        public IList SearchByDate(DateTime from, DateTime to)
        {
            using (ittransactionlogEntities db = new ittransactionlogEntities())
            {
                /*var result = db.Database.SqlQuery<IList>("SELECT l.it_log_id, l.name, " +
                    "l.office, l.date, l.time, l.service_request, p.it_personnel_name " +
                    "FROM it_log AS l INNER JOIN it_personnel AS p ON l.it_personnel_id = p.it_personnel_id" +
                    "WHERE l.date BETWEEN DATE(@from) AND DATE(@to)", 
                    new SqlParameter("@from", from), 
                    new SqlParameter("@to", to)).ToList();
                    */

                var result = (from l in db.it_log
                              join p in db.it_personnel
                              on l.it_personnel_id equals p.it_personnel_id
                              where (l.date >= @from.Date && l.date <= @to.Date)
                              select new
                              {
                                  id = l.it_log_id,
                                  Name = l.name,
                                  Office = l.office,
                                  Date = l.date,
                                  Time = l.time,
                                  Service_Request = l.service_request,
                                  IT_Personnel = p.it_personnel_name

                              }).ToList();

                return result;
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
