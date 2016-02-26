using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listener.Entity;
using ServiceStack.OrmLite;

namespace OrmLite.Pack
{
    public class TablesCreator
    {
        public int Id { get; set; }
        public static void Create(OrmLiteConnectionFactory fact)
        {
            using (var db = fact.Open())
            {
                db.CreateTableIfNotExists<SoulTraveller>();
                db.CreateTableIfNotExists<MediaType>();
            }
        }
    }
}
