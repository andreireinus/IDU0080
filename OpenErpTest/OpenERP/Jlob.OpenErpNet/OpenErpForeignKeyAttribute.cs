using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jlob.OpenErpNet
{
    [System.AttributeUsage(AttributeTargets.Property)]
    public class OpenErpForeignKeyAttribute:System.Attribute
    {
        public String PropertyName { get; set; }

        public OpenErpForeignKeyAttribute(string propertyName)
        {
            this.PropertyName = propertyName;
        }
    }
}
