
public class ProductBuilder
{
  public static ProductModel Build(ProductAsset asset)
  {
    return new ProductModel()
    {
      Name = asset.Name,
      Cost = asset.Cost
    };
  }
}
