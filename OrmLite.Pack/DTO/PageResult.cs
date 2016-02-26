using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLite.Pack.DTO
{
    public class PageResult<T>
    {
        public long Total { get; set; }
        public List<T> Data { get; set; }
    }
}
