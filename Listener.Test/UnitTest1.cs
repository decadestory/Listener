using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrmLite.Pack;
using Listener.Entity;

namespace Listener.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var list =  new List<SoulTraveller>();

            Parallel.For(0, 1000, t =>
            {
                var todo = new SoulTraveller
                {
                    Title = "为你唱的一首歌",
                    Description = "Hello Title",
                    Sort = 0,
                    TypeId = 1,
                    Views = 23,
                    Up = 43,
                    Down = 54,
                    Img = "imgurl",
                    Media = "mediaurl",
                    AddTime = DateTime.Now,
                    AddUser = "jerry"
                };
                lock (list)
                {
                    list.Add(todo);
                }
                
            });
            Curd<SoulTraveller>.AddRange(list);
        }

        [TestMethod]
        public void TestMethod2()
        {

            var todo = new MediaType
            {
                Name = "音乐",
                TypeId = 2,
                Sort = 0,
                AddTime = DateTime.Now,
                AddUser = "jerry"
            };

            var ss = Curd<MediaType>.Add(todo);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var obj = new Listener.DB.SoulTravellerDb();
            var list = obj.PageList(1, 20);
        }


    }
}
