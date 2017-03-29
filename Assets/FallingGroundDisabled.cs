using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingGroundDisabled : MonoBehaviour {

	// Use this for initialization
	public void Button ()
  { 
    if(SingletonCoin.instance.playerPoints>=20)
    {
      GameObject.FindWithTag("Danger").SetActive(false);
      SingletonCoin.instance.playerPoints = SingletonCoin.instance.playerPoints - 20;
    }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
