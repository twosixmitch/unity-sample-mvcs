using UnityEngine;
using UnityEngine.UI;

public class ProductView : MonoBehaviour
{
  public Text NameText;
  public Text CostText;

  // Present the information to the user.
  public void Populate(string name, string cost)
  {
    NameText.text = name;
    CostText.text = cost;
  }
}
