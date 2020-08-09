
public class ProductModel
{
  public string Name { get; set; }
  public float Cost { get; set; }

  // Light logic that cuts down duplicated code. 
  public string CostDescription()
  {
    return $"The cost is ${Cost}";
  }
}
