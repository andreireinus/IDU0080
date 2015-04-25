namespace OpenERP.Web
{
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using AutoMapper;

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            Mapper.CreateMap<WCF.Customer.Customer, WCF.Invoice.Customer>();
            Mapper.CreateMap<WCF.Product.ProductProduct, WCF.Invoice.ProductProduct>();
        }
    }
}
