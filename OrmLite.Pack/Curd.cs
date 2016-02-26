using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Listener.Entity;
using OrmLite.Pack.DTO;
using ServiceStack;
using ServiceStack.OrmLite;

namespace OrmLite.Pack
{
    public class Curd<T>
    {
        private static readonly string ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        static Curd()
        {
            TablesCreator.Create(Current);
        }

        public static OrmLiteConnectionFactory Current
        {
            get
            {
                var db = (OrmLiteConnectionFactory)CallContext.GetData("DbFactory");
                if (db != null) return db;
                db = new OrmLiteConnectionFactory(ConnStr, SqlServerDialect.Provider);
                CallContext.SetData("DbFactory", db);
                return db;
            }
        }

        public static long Add(T obj)
        {
            using (var db = Current.Open())
            {
                return db.Insert(obj);
            }
        }

        public static void AddRange(List<T> list)
        {
            using (var db = Current.Open())
            {
                db.InsertAll(list);
            }
        }

        public static int Del(string id)
        {
            using (var db = Current.Open())
            {
                return db.DeleteById<T>(id);
            }
        }

        public static int Dels(List<string> ids)
        {
            using (var db = Current.Open())
            {
                return db.DeleteByIds<T>(ids);
            }
        }

        public static int DelFunc(Func<T, bool> func)
        {
            using (var db = Current.Open())
            {
                return db.Delete(func);
            }
        }

        public static int Edit(T obj)
        {
            using (var db = Current.Open())
            {
                return db.Update(obj);
            }
        }

        public static T Get(string id)
        {
            using (var db = Current.Open())
            {
                return db.SingleById<T>(id);
            }
        }

     

    }
}
