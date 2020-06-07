using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class ProductAsset : ScriptableObject
{
    public string Name;
    public float Cost;
    
    #if UNITY_EDITOR
	[MenuItem("Assets/Create/UnitySampleMVCS/Product")]
    public static void CreateAsset()
    {
        ScriptableObjectUtility.CreateAsset<ProductAsset>();
    }
    #endif
}
