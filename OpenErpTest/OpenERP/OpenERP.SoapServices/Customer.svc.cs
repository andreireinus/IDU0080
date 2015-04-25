namespace OpenERP.SoapServices
{
    using System.Linq;

    using OpenERP.Library;

    public class Customer : ServiceBase, ICustomer
    {
        public Library.Entities.Customer[] Search(string name)
        {
            return this.Run(() => OpenErpWrapper.SearchCustomer(name));
        }

        public Library.Entities.Customer SearchById(int id)
        {
            return this.Run(() => OpenErpWrapper.SearchCustomer(id));
        }
    }
}
