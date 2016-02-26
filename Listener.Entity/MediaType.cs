using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Listener.Entity
{
    public class MediaType
    {
        ///<summary>
        ///Id
        ///</summary>
        [AutoIncrement]
        public int Id { set; get; }
        ///<summary>
        ///名称
        ///</summary>
        public string Name { set; get; }
        ///<summary>
        ///类型Id
        ///</summary>
        public int TypeId { set; get; }
        ///<summary>
        ///排序
        ///</summary>
        public int Sort { set; get; }
        ///<summary>
        ///添加时间
        ///</summary>
        public DateTime? AddTime { set; get; }
        ///<summary>
        ///添加人
        ///</summary>
        public string AddUser { set; get; }
    }
}
