
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
  public UnityEngine.UI.Image image;
  public SoundManager soundManager;
  public AudioClip gameOverSound;
  public float timer;
    public UnityEngine.UI.Text text;
    string stringString = "Time";
    public TimeSpan time;
    public String currentLevel = "1";
    public PlayerHealth health;


    // Use this for initialization
    void Start()
    {
        text = GetComponent<UnityEngine.UI.Text>();
    }

    // Update is called once per frame
    void Update()
    {

    timer = timer - Time.deltaTime;
        time = TimeSpan.FromSeconds(timer);
    }
    void OnGUI()
    {
    Rect windowRect = new Rect(20, 20, 120, 50);
    if (health.health <= 0 || timer<=0f)
    {
      
      text.text = "Game Over";
      Time.timeScale = 0;
      if (image.gameObject.activeInHierarchy == false)
      {
        image.gameObject.SetActive(true);
      }
    }

    else

    {
      text.text = string.Format("{0:D2}m:{1:D2}s \n Level: {2} \n,{3}", time.Minutes, time.Seconds, currentLevel, "Health: "+health.health.ToString());
    }
    }


}

