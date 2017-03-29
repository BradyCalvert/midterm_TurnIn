using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

  public AudioSource soundSFX;
  public AudioSource soundBackGround;
  public static SoundManager instance = null;

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

    //play background music

  }
  public void PlayBackground(AudioClip soundToPlay)
  {
    soundBackGround.clip = soundToPlay;
    soundBackGround.Play();
  }
  public void PlaySFX(AudioClip soundToPlay)
  {
    //Assign soundFX audio source to the clip
    soundSFX.clip = soundToPlay;

    //play the clip
    soundSFX.Play();



  }
}