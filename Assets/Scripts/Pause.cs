using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
  public static Pause instance = null;
  public UnityEngine.UI.Image image;
  bool isPaused = false;
  public Rect windowRect = new Rect(20, 20, 120, 50);
  public void Start()
  {
    Time.timeScale = 1;
  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Tab))
    {
      PauseButton();
    }
  }
  void PauseButton()
  {
    if (image.gameObject.activeInHierarchy == false)
    {
      image.gameObject.SetActive(true);
      Time.timeScale = 0;
      isPaused = true;
    }
    else if(image.gameObject.activeInHierarchy == true)
    {
      image.gameObject.SetActive(false);
      Time.timeScale = 1;
      isPaused = false;
    }
  }
  public void OnGUI()
  {
    GUI.enabled = false;
    if (isPaused = true)
    {
      GUI.enabled = true;
      //GUI.Window(0, windowRect, DoMyWindow, "Paused");
    }
    
  }
  void DoMyWindow(int windowID)
  {
    if (GUI.Button(new Rect(10, 20, 100, 20), "Hello World"))
      print("Paused");
  }
}

