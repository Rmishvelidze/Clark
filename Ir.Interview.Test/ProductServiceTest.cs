using System;
using System.Collections.Generic;
using Xunit;

namespace Ir.Interview.Test
{
  public class ProductServiceTest
  {
    [Fact]
    public void UpdatePrices_GivenNewPricesForAllProducts_ExpectedAllProductsPriceUpdatedInLessThanOneHundredMilliseconds()
    {
      var productService = new ProductsService();
      var products = productService.Products;
      var newPrices = new List<ProductPrice>();
      var priceGenerator = new Random(3);

      for (int i = 0; i < products.Count; i++)
      {
        var product = products[i];
        newPrices.Add(new ProductPrice
        {
          ProductId = product.Id,
          Price = priceGenerator.Next(300)
        });
      }
      var stopwatch = new System.Diagnostics.Stopwatch();
      stopwatch.Start();


      productService.UpdatePrices(newPrices);


      stopwatch.Stop();
      Assert.DoesNotContain(products, product => product.Price == -1);
      Assert.True(stopwatch.ElapsedMilliseconds < 100);
    }
  }
}