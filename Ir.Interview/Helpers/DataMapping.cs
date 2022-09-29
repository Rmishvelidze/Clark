using Ir.Interview.Models;

namespace Ir.Interview.Helpers
{
    public static class DataStructurization
    {
        private static ProductForCsv CreateProductForCsv(Models.Product product, ProductQuantity productQuantity) =>
            new()
            {
                Id = product.Id,
                Name = product.Name,
                Barnd = product.Brand,
                Inventory = productQuantity.Quantity.ToString()
            };

        public static List<ProductForCsv> CreateDataForCsv(List<Models.Product> products, List<ProductQuantity> productQuantities)
        {
            var data = new List<ProductForCsv>();
            foreach (var product in products)
            {
                var productQuantity = productQuantities.FirstOrDefault(p => p.Id == product.Id);
                if (productQuantity != null)
                {
                    data.Add(CreateProductForCsv(product, productQuantity));
                }
                else
                {
                    data.Add(CreateProductForCsv(product, new ProductQuantity()));
                }
            }
            return data;
        }
    }
}
