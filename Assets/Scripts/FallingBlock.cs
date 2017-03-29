using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour
{
  public SoundManager soundManager;
  public AudioClip fallingSound;
  PlayerMove myObj;
  public GameObject player;
  private Vector3 offset;
  public GameObject block;
  GameObject newObj;


  // Use this for initialization
  void Start()
  {
    InvokeRepeating("Spawner", 5, 5);

  }

  // Update is called once per frame
   public void Spawner()
   {
  Vector3 newPos = player.transform.position;
       newPos.y = player.transform.position.y + 20; ;
       GameObject  newObj = Instantiate(block, newPos, Quaternion.identity);
    Destroy(newObj, 2f);
    if (newObj.transform.position.y < 0)
    {
      Destroy(newObj);
    }
   }
  public void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      SoundManager.instance.PlaySFX(fallingSound);
      //other.gameObject.GetComponent<PlayerHealth>().health -=1;
      Destroy(newObj);


    }
  }
}


