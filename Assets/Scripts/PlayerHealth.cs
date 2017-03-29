using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
  public int health;
  public void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Falling"))
    {
      health -= 1;
    }
  }
  }
