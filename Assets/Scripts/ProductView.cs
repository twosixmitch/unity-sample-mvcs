using UnityEngine;
using UnityEngine.UI;

public class ProductView : MonoBehaviour
{
  public Text NameText;
  public Text CostText;

  public void Populate(string name, float cost)
  {
    NameText.text = name;
    CostText.text = $"${cost}";
  }
}
