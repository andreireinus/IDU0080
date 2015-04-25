using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jlob.OpenErpNet
{
    public class CommandContext
    {
        public string EntityName { get; set; }
        public Type EntityType { get; set; }
        public string ParameterName { get; set; }
        public List<CommandArgument> Arguments { get; set; }

        public CommandContext()
        {
            this.Arguments = new List<CommandArgument>();
        }

        public object[] GetArguments()
        {
            List<object[]> objectList = new List<object[]>();
            foreach (CommandArgument argument in Arguments)
            {
                objectList.Add(new Object[] {argument.Property, argument.Operation, argument.Value });
            }
            return objectList.ToArray();
        }

        public void ClearArguments()
        {
            this.Arguments.Clear();
        }
    }
}
