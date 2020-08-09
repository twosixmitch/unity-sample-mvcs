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

    // Use a service to retrieve the models.
    var productModels = ProductService.Instance.GetAllProducts();

    foreach (var product in productModels)
    {
      // Create a new instance of the view.
      var itemGO = Instantiate(ProductViewPrefab, Vector3.zero, Quaternion.identity);
      itemGO.transform.SetParent(ProductViewContainer.transform, false);
      itemGO.transform.SetAsLastSibling();

      // Get the view script.
      var itemView = itemGO.GetComponent<ProductView>();

      // Hold onto the view for further updates.
      _productViews.Add(itemView);

      // The controller passes the model to the view.
      itemView.Populate(product.Name, product.CostDescription());
    }
  }
}