using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonCoin : MonoBehaviour
{
  public static SingletonCoin instance = null;
  public int playerPoints = 0;

  private void Awake()
  {
    if (instance == null)
    {
      instance = this;
    }
    else if (instance != this)
    {
      Destroy(this.gameObject);
    }
    DontDestroyOnLoad(this.gameObject);
  }
}
