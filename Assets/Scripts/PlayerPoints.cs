using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPoints : MonoBehaviour
{
  
  public bool guiYes = false;
  public bool guiYes2 = false;
  public bool guiYes3 = false;
  public bool guiYes4 = false;
  public Texture2D sprite;
  public Texture2D disabledSprite;
  public Texture2D sprite2;
  public Texture2D disabledSprite2;
  public Texture2D sprite3;
  public Texture2D disabledSprite3;
  public Texture2D sprite4;
  public Texture2D disabledSprite4;
  public SoundManager soundManager;
  public AudioClip keySound;
  public AudioClip unlockSound;
  public AudioClip heartSound;
  public AudioClip coinSound;
  public int keyNum;
  public GameObject key;
  public GameObject lockBox;
  public GameObject lockBox2;
  public GameObject lockBox3;
  public GameObject lockBox4;
  public int playerPoints=10;
  bool hasKey;
  public int buildIndex=2;

  void Start()
  {

    SingletonCoin.instance.playerPoints = PlayerPrefs.GetInt("playerPoints", SingletonCoin.instance.playerPoints);
    if
      (keyNum > 0)
    {
      hasKey = true;     
    }
  }
  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.R))
    {
      SingletonCoin.instance.playerPoints = 0;
    }
  }
  void OnTriggerEnter(Collider other)
  {
    if(other.gameObject.CompareTag("Respawn"))
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     
    }

    if (other.gameObject.CompareTag("Coin"))
    {
      
      SoundManager.instance.PlaySFX(coinSound);
      SingletonCoin.instance.playerPoints = SingletonCoin.instance.playerPoints + 10;
      Debug.Log(SingletonCoin.instance.playerPoints);
      PlayerPrefs.SetInt("playerPoints", SingletonCoin.instance.playerPoints);


    }

    if (other.gameObject.CompareTag("Key"))
    {
      guiYes = true;
      SoundManager.instance.PlaySFX(keySound);
      lockBox.gameObject.GetComponent<BoxCollider>().isTrigger = enabled;
      keyNum += 1;
      Destroy(other.gameObject);
      hasKey = true;
    }
    if (other.gameObject.CompareTag("Key2"))
    {
      guiYes2 = true;
      SoundManager.instance.PlaySFX(keySound);
      lockBox2.gameObject.GetComponent<BoxCollider>().isTrigger = enabled;
      keyNum += 1;
      Destroy(other.gameObject);
      hasKey = true;
    }
    if (other.gameObject.CompareTag("Key3"))
    {
      guiYes3 = true;
      SoundManager.instance.PlaySFX(keySound);
      lockBox3.gameObject.GetComponent<BoxCollider>().isTrigger = enabled;
      keyNum += 1;
      Destroy(other.gameObject);
      hasKey = true;
    }
    if (other.gameObject.CompareTag("Key4"))
    {
      guiYes4 = true;
      SoundManager.instance.PlaySFX(keySound);
      lockBox4.gameObject.GetComponent<BoxCollider>().isTrigger = enabled;
      keyNum += 1;
      Destroy(other.gameObject);
      hasKey = true;
    }
    if (other.gameObject.CompareTag("Lock") && hasKey == true)
    {
      guiYes = false;
      guiYes3 = false;
      guiYes2 = false;
      guiYes4 = false;
      SoundManager.instance.PlaySFX(unlockSound);
      keyNum = keyNum - 1;
      hasKey = false;
      Destroy(other.gameObject);
    }
    if (other.gameObject.CompareTag("Finish"))
    {
      SoundManager.instance.PlaySFX(heartSound);
      Destroy(other.gameObject);
      SceneManager.LoadScene("Main 1");
    }
    if (other.gameObject.CompareTag("Finish2"))
    {
      SoundManager.instance.PlaySFX(heartSound);
      Destroy(other.gameObject);
      SceneManager.LoadScene("Main 2");
    }
    if (other.gameObject.CompareTag("Finish3"))
    {
      SoundManager.instance.PlaySFX(heartSound);
      Destroy(other.gameObject);
      SceneManager.LoadScene("Credits");
    }
  }
  public void OnGUI()
  {
    //GUI.TextField((new Rect(350, 20, 50, 50)), ( gameObject.GetComponent<PlayerCoin>().playerPoints).ToString());
    if (guiYes == true)
    {
      GUI.DrawTexture((new Rect(10, 20, 50, 50)), sprite);
    }
    else if (guiYes == false)
    {
      GUI.DrawTexture((new Rect(10, 20, 50, 50)), disabledSprite);
    }

      if (guiYes2 == true)
      {
        GUI.DrawTexture((new Rect(80, 20, 50, 50)), sprite2);
      }
      else if (guiYes2 == false)
      {
        GUI.DrawTexture((new Rect(80, 20, 50, 50)), disabledSprite2);
      }

    if (guiYes3 == true)
    {
      GUI.DrawTexture((new Rect(320, 20, 50, 50)), sprite3);
    }
    else if (guiYes3 == false)
    {
      GUI.DrawTexture((new Rect(320, 20, 50, 50)), disabledSprite3);
    }

    if (guiYes4 == true)
    {
      GUI.DrawTexture((new Rect(400, 20, 50, 50)), sprite4);
    }
    else if (guiYes4 == false)
    {
      GUI.DrawTexture((new Rect(400, 20, 50, 50)), disabledSprite4);
    }
  }

}


  

  

