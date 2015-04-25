using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jlob.OpenErpNet
{
    public class CommandArgument
    {
        public string Property { get; set; }
        public string Operation { get; set; }

        private object _value;

        public object Value
        {
            get 
            { 
                if (this.ArgumentType != OpenErpType.Undefined)
                {
                    switch (this.ArgumentType)
                    {
                        case OpenErpType.Undefined:
                            break;
                        case OpenErpType.Boolean:
                            break;
                        case OpenErpType.Integer:
                            break;
                        case OpenErpType.Float:
                            break;
                        case OpenErpType.Char:
                            if (this._value is DateTime)
                            {
                                return ((DateTime)this._value).ToString("yyyy-MM-dd HH:mm:ss");
                            }
                            break;
                        case OpenErpType.Text:
                            break;
                        case OpenErpType.Date:
                            if (this._value is DateTime)
                            {
                                return ((DateTime)this._value).ToString("yyyy-MM-dd HH:mm:ss");
                            }
                            break;
                        case OpenErpType.Datetime:
                            if (this._value is DateTime)
                            {
                                return ((DateTime)this._value).ToString("yyyy-MM-dd HH:mm:ss");
                            }
                            break;
                        case OpenErpType.Binary:
                            break;
                        case OpenErpType.Selection:
                            break;
                        default:
                            break;
                    }
                }
                return this._value; 
            }
            set { _value = value; }
        }
        
        public OpenErpType ArgumentType { get; set; }
    }
}