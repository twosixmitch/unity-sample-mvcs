using UnityEngine;
using System.Collections.Generic;

public class ProductFactory
{
  private ProductDatabase _productDatabase;

  public void LoadDatabase()
  {
    if (_productDatabase == null)
    {
      Log.Debug("[ProductFactory] Loading database");

      _productDatabase = Resources.Load<ProductDatabase>("ProductDatabase");

      if (_productDatabase == null)
      {
        Log.Error("[ProductFactory] Could not load database");
      }
    }
  }

  public List<ProductModel> GetProducts()
  {
    List<ProductModel> models = new List<ProductModel>();

    foreach (var asset in _productDatabase.ProductAssets)
    {
      models.Add(ProductBuilder.Build(asset));
    }

    return models;
  }
}