using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jlob.OpenErpNet.Entities
{
    [OpenErpMap("ir.model")]
    public class Model
    {

        [OpenErpMap("id")]
        public int Id { get; set; }
        [OpenErpMap("osv_memory")]
        public Boolean Osv_Memory { get; set; }
        [OpenErpMap("name")]
        public string Name { get; set; }
        [OpenErpMap("model")]
        public string Class { get; set; }
        [OpenErpMap("state")]
        public string State { get; set; }
        [OpenErpMap("modules")]
        public string Modules { get; set; }

        [OpenErpMap("field_id")]
        public ICollection<Field> Fields { get; set; }
    }
}
