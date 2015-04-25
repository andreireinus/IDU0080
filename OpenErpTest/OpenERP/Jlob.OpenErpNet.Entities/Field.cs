using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jlob.OpenErpNet.Entities
{
    [OpenErpMap("ir.model.fields")]
    public class Field
    {
        [OpenErpMap("name")]
        public string Name { get; set; }
        
        [OpenErpMap("field_description")]
        public string Description { get; set; }
        
        [OpenErpMap("ttype")]
        public string Type { get; set; }

        [OpenErpMap("relation")]
        public string ObjectRelation { get; set; }

        [OpenErpMap("relation_field")]
        public string FieldRelation { get; set; }

        [OpenErpMap("readonly")]
        public bool ReadOnly { get; set; }

        [OpenErpMap("required")]
        public bool Required { get; set; }
    }
}
