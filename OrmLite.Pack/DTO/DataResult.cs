using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmLite.Pack.DTO
{
    public class DataResult<T>
    {
        public int Code { get; set; }
        public T Data { get; set; }
        public string ErrMsg { get; set; }
        public object ExtData { get; set; }
    }
}
