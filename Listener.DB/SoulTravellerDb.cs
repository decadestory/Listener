using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listener.Entity;
using OrmLite.Pack;
using OrmLite.Pack.DTO;
using ServiceStack.OrmLite;

namespace Listener.DB
{
    public class SoulTravellerDb
    {
        public  PageResult<SoulTraveller> PageList(int page, int size, string title = "")
        {
            using (var db = Curd<SoulTraveller>.Current.Open())
            {
                var cnt = db.Count<SoulTraveller>(q => q.Where(t => t.Title.Contains(title)));

                var result = db.Select<SoulTraveller>(q => q.Where(t => t.Title.Contains(title))
                    .OrderByDescending(t => t.AddTime).Limit(skip: page, rows: size));
                return new PageResult<SoulTraveller> { Total = cnt, Data = result };
            }
        }
    }
}
