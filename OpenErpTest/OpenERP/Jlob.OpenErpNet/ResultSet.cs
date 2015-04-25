using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jlob.OpenErpNet
{
    public class ResultSet
    {
        public object[] Data { get; set; }

        public ResultSet(Object[] data)
        {
            this.Data = data;
        }
    }
}
