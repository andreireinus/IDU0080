using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace Jlob.OpenErpNet.EFProvider
{
    public sealed class OpenErpDataSourceEnumerator:DbDataSourceEnumerator
    {
        public override System.Data.DataTable GetDataSources()
        {
            throw new NotImplementedException();
        }
    }
}
