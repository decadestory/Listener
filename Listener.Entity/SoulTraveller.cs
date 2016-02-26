using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Listener.Entity
{
    public class SoulTraveller
    {
        ///<summary>
        ///Id
        ///</summary>
        [AutoIncrement]
        public int Id { set; get; }
        ///<summary>
        ///标题
        ///</summary>
        public string Title { set; get; }
        ///<summary>
        ///描述
        ///</summary>
        public string Description { set; get; }
        ///<summary>
        ///类型
        ///</summary>
        public int? TypeId { set; get; }
        ///<summary>
        ///查看次数
        ///</summary>
        public int? Views { set; get; }
        ///<summary>
        ///赞
        ///</summary>
        public int? Up { set; get; }
        ///<summary>
        ///踩
        ///</summary>
        public int? Down { set; get; }
        ///<summary>
        ///图片url
        ///</summary>
        public string Img { set; get; }
        ///<summary>
        ///音频地址
        ///</summary>
        public string Media { set; get; }
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
