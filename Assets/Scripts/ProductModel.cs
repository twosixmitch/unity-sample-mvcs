
public class ProductModel
{
    public string Name { get; set; }
    public float Cost { get; set; }

    public ProductModel(string name, float cost)
    {
        Name = name;
        Cost = cost;
    }
}
