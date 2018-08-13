using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Log.Model
{
    public class it_log_all
    {
        public int id { get; internal set;}
        public string Name { get; internal set; }
        public string Office { get; internal set; }
        public DateTime? Date { get; internal set; }
        public TimeSpan? Time { get; internal set; }
        public string Service_Request { get; internal set; }
        public string IT_Personnel { get; internal set; }
    }
}
