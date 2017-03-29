using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Return : MonoBehaviour {
  public Rect windowRect = new Rect(20, 20, 120, 50);
  public bool upgradeActive = false;
  public UnityEngine.UI.Image image;

  public void Button(int scene)
  {
    SceneManager.LoadScene("MainMenu");
  }
}
