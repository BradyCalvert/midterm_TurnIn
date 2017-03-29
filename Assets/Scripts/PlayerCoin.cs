using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCoin : MonoBehaviour
{
  public void OnTriggerEnter(Collider other)
  {
    if(other.gameObject.CompareTag("Player"))
    {
      Destroy(this.gameObject);
    }
  }
}
