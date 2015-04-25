namespace OpenERP.Web.Models
{
    using System.Text;
    using System.Web.Mvc;

    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString WriteErrors(this HtmlHelper helper)
        {
            if (helper.ViewBag.Errors == null || !(helper.ViewBag.Errors is ErrorsList))
            {
                return MvcHtmlString.Create("&nbsp;");
            }

            var sb =new StringBuilder();
            var errors = (ErrorsList)helper.ViewBag.Errors;
            foreach (var message in errors.Messages)
            {
                sb.AppendFormat("<div class=\"alert alert-danger\">{0}</div>", message);
            }

            return MvcHtmlString.Create(sb.ToString());
        }
    }
}