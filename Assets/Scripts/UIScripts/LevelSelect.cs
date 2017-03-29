using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelSelect : MonoBehaviour {

	// Use this for initialization
	public void Button(int scene)
  {
    SceneManager.LoadScene("LevelSelect");
  }
}
