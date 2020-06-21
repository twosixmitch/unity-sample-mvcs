using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class ProductDatabase : ScriptableObject
{
  public List<ProductAsset> ProductAssets;

#if UNITY_EDITOR
  [MenuItem("Assets/Create/UnitySampleMVCS/ProductDatabase")]
  public static void CreateAsset()
  {
    ScriptableObjectUtility.CreateAsset<ProductDatabase>();
  }
#endif
}