using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listener.Entity;
using ServiceStack.OrmLite;
using ServiceStack.Text;

namespace Dapper.Pack
{
    public class Curd
    {
        public readonly string ConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
    
        public int Add()
        {
            
            using (IDbConnection db = dbFactory.Open())
            {
                db.DropAndCreateTable<SoulTraveller>();
                var todo = new SoulTraveller
                {
                    Id=1,
                    Title = "Learn OrmLite",
                    Description = "Hello Title",
                    Views = 23,Up = 43,Down = 54,Img = "imgurl",Media = "mediaurl",
                    AddTime = DateTime.Now,AddUser = "jerry"
                };

                db.Save(todo);
                todo.Id = 2;
                db.Save(todo);

                var savedTodo = db.SingleById<Listener.Entity.Listener>(todo.Id);
                savedTodo.Description = "Updated";
                db.Save(savedTodo);

                "Updated Todo:".Print();
                db.Select<Listener.Entity.Listener>(q => q.Description == "Updated").PrintDump();

                db.DeleteById<Listener.Entity.Listener>(savedTodo.Id);

                "No more Todos:".Print();
                db.Select<Listener.Entity.Listener>().PrintDump();
            }

            return 1;
        }


    }
}
