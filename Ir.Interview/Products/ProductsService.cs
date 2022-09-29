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
      foreach (var product in _products)
      {
        var newPrice = newPrices.SingleOrDefault(productWithPrice => productWithPrice.ProductId == product.Id);
        if (newPrice != null)
        {
          product.Price = newPrice.Price;
        }
      }
      return _products;
    }
  }
}
