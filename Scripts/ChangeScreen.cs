using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScreen : MonoBehaviour
{

  public Dropdown list;

  public void ChangeScreenS()
  {
    if(list.value == 0)
    {
      Screen.SetResolution(1600, 900, true);
    }
    if(list.value == 1)
    {
      Screen.SetResolution(1920, 1080, true);
    }
    if(list.value == 2)
    {
      Screen.SetResolution(3840, 2160, true);
    }
  }
}
