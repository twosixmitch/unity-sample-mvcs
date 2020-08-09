using System.Collections.Generic;

public class ProductService : SingletonBehaviour<ProductService>
{
  private ProductFactory _factory;
  private List<ProductModel> _products;

  public override void Init()
  {
    _factory = new ProductFactory();
    _factory.LoadDatabase(); // from disk

    // Convert the raw data into useable models.
    _products = _factory.GetProducts();
  }

  public List<ProductModel> GetAllProducts()
  {
    return _products;
  }
}
