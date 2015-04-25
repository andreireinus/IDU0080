namespace OpenERP.GenerateEntities
{
    using System;
    using System.IO;
    using System.Linq;

    using Jlob.OpenErpNet;
    using Jlob.OpenErpNet.Entities;

    using OpenERP.Library;

    public class Program
    {
        public static void Main(string[] args)
        {
            var openErpService = OpenErpWrapper.GetService();
            var models = openErpService.GetEntities<Model>(e => e.Osv_Memory == false).Include(i => i.Fields);

            using (var sw = new StreamWriter(@"C:\1_Devel\00_Kool\IDU0080\OpenErpTest\OpenERP\OpenERP.Library\GeneratedEntities.cs"))
            {
                sw.WriteHeader();
                foreach (var model in models)
                {
                    sw.WriteModel(model);
                    
                }

                sw.WriteLine("}");
            }
        }
    }

    public static class StreamWriterExtensions
    {
        public static void WriteHeader(this StreamWriter sw)
        {
            sw.WriteLine("namespace OpenERP.Library");
            sw.WriteLine("{");
            sw.WriteLine("\tusing System;");
            sw.WriteLine("\tusing Jlob.OpenErpNet;");
            sw.WriteLine();
        }
        public static void WriteModel(this StreamWriter sw, Model model)
        {

            sw.WriteLine("\t[OpenErpMap(\"{0}\")]", model.Class);
            sw.WriteLine("\tpublic class {0} : OpenErpEntityBase {{", model.Class.ToErpClassName());
            foreach (var f in model.Fields)
            {
                sw.WriteField(f);
            }
            sw.WriteLine("\t}");
            sw.WriteLine();
        }

        private static void WriteField(this StreamWriter sw, Field field)
        {
            if (field.Name == "id")
            {
                return;
            }
            var clrType = "object";
            var erpType = OpenErpType.Undefined;

            switch (field.Type)
            {
                case "char":
                case "text":
                    clrType = "string";
                    erpType = OpenErpType.Char;
                    break;
                case "selection":
                    clrType = "string";
                    erpType = OpenErpType.Selection;
                    break;

                case "boolean":
                    clrType = "bool";
                    erpType = OpenErpType.Boolean;
                    break;
                case "many2one":
                case "integer":
                    erpType = OpenErpType.Integer;
                    clrType = "int?";
                    if (field.Required)
                    {
                        clrType = "int";
                    }
                    break;
                case "float":
                    erpType = OpenErpType.Float;
                    clrType = "double?";
                    if (field.Required)
                    {
                        clrType = "double";
                    }
                    break;
                case "date":
                case "datetime":
                    erpType = field.Type == "date" ? OpenErpType.Date : OpenErpType.Datetime;
                    clrType = "DateTime?";
                    if (field.Required)
                    {
                        clrType = "DateTime";
                    }
                    break;
                default:
                    return;
            }

            sw.WriteLine("\t\t[OpenErpMap(\"{0}\", OpenErpType.{1})]", field.Name, erpType);
            sw.WriteLine("\t\tpublic {0} {1} {{ get; set; }}", clrType, field.Name.ToErpFieldName());

        }
    }

    public static class StringExtensions
    {
        public static string ToErpClassName(this string s)
        {
            return string.Join("", s.Split('.').Select(a => a.Substring(0, 1).ToUpperInvariant() + a.Substring(1)));
        }

        public static string ToErpFieldName(this string s)
        {
            return string.Join("", s.Split('_').Select(a => a.Substring(0, 1).ToUpperInvariant() + a.Substring(1)));
        }
    }
}
