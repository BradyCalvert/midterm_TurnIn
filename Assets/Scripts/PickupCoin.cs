using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCoin : MonoBehaviour {
  public static PickupCoin instance = null;
  public int playerPoints = 0;

  // Use this for initialization
  void Awake()
  {
    if (instance == null)
    {
      instance = this;
    }
    else if (instance != this)
      Destroy(gameObject);

    DontDestroyOnLoad(gameObject);
}
  }
