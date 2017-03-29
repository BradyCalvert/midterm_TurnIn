using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlockDisabled : MonoBehaviour {

	public void Button () {
		if(SingletonCoin.instance.playerPoints>=10)
    {
      GameObject.FindWithTag("Falling").SetActive(false);
      SingletonCoin.instance.playerPoints = SingletonCoin.instance.playerPoints - 10;
    }
	}
}
