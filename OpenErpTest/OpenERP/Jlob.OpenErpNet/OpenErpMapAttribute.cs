using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jlob.OpenErpNet
{

    public enum OpenErpType
    {
        Undefined,
        Boolean,
        Integer,
        Float,
        Char,
        Text,
        Date,
        Datetime,
        Binary,
        Selection
    }

    [System.AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class OpenErpMapAttribute:System.Attribute
    {
        public string OpenErpName { get; set; }

        public OpenErpType OpenErpType { get; set; }

        public OpenErpMapAttribute(string name)
        {
            OpenErpName = name;
            OpenErpType = OpenErpType.Undefined;
        }

        public OpenErpMapAttribute(string name, OpenErpType type)
            :this(name)
        {
            OpenErpType = type;
        }

        public OpenErpMapAttribute(OpenErpType type)
        {
            OpenErpName = string.Empty;
            OpenErpType = type;
        }
        
    }
}
