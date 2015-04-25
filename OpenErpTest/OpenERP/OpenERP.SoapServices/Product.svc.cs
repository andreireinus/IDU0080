namespace OpenERP.SoapServices
{
    using System.Linq;

    using OpenERP.Library;

    public class Product : ServiceBase, IProduct
    {
        public ProductProduct SearchById(int id)
        {
            return this.Run(
                () =>
                {
                    var products = OpenErpWrapper.GetService().GetEntities<ProductProduct>(c => c.Id == id).ToArray();

                    if (!products.Any())
                    {
                        throw new BusinessLogicException(BusinessLogicCodes.ProductNotFound, "Toodet ei leitud");
                    }

                    return products.First();
                });
        }

        public ProductProduct[] SearchByName(string name)
        {
            return this.Run(
                () =>
                {
                    var products = OpenErpWrapper.GetService()
                        .GetEntities<ProductProduct>(c => c.NameTemplate.Contains(name))
                        .ToArray();

                    if (!products.Any())
                    {
                        throw new BusinessLogicException(BusinessLogicCodes.ProductNotFound, "Toodet ei leitud");
                    }

                    return products;
                });
        }
    }
}
