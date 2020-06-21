using UnityEngine;
using System.Collections.Generic;

public class StoreController : MonoBehaviour
{
  public GameObject ProductViewPrefab;
  public GameObject ProductViewContainer;

  private List<ProductView> _productViews;

  void Start()
  {
    _productViews = new List<ProductView>();

    var products = ProductService.Instance.GetAllProducts();

    foreach (var product in products)
    {
      // Create the view item.
      var itemGO = Instantiate(ProductViewPrefab, Vector3.zero, Quaternion.identity);
      itemGO.transform.SetParent(ProductViewContainer.transform, false);
      itemGO.transform.SetAsLastSibling();

      // Get the view script.
      var itemView = itemGO.GetComponent<ProductView>();
      _productViews.Add(itemView);

      // Populate it with the product information.
      itemView.Populate(product.Name, product.Cost);
    }
  }
}