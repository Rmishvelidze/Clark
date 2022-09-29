namespace Ir.Interview
{
    public class ProductsService
    {
        #region Do Not Change

        private readonly List<Product> _products;

        public ProductsService()
        {
            _products = new List<Product>();
            for (int i = 0; i < 40000; i++)
            {
                var id = i;
                _products.Add(new Product
                {
                    Id = id,
                    Name = $"Shoe {id}"
                });
            }
            _products.Shuffle();
        }

        public IReadOnlyList<Product> Products
        {
            get { return _products.AsReadOnly(); }
        }
        #endregion

        public IEnumerable<Product> UpdatePrices(IEnumerable<ProductPrice> newPrices)
        {
            var orderedNewPrices =  newPrices.OrderBy(x => x.ProductId).ToList();
            var orderedProducts = _products.OrderBy(x => x.Id).ToList();

            for (int i = 0; i < orderedProducts.Count; i++)
            {
                if(orderedProducts[i].Id  == orderedNewPrices[i].ProductId)
                {
                    orderedProducts[i].Price = orderedNewPrices[i].Price;
                }
            }

            return orderedProducts;
        }
    }
}
