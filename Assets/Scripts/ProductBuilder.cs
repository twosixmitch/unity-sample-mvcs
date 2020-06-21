
public class ProductBuilder
{
  public static ProductModel Build(ProductAsset asset)
  {
    return new ProductModel(asset.Name, asset.Cost);
  }
}
